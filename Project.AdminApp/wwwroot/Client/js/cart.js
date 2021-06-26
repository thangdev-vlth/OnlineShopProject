var CartController = function () {
    this.initialize = function () {
        console.log(1);
        loadData();
        registerEvents();
    }

    function registerEvents() {
        $('body').on('click', '.btn-plus', function (e) {
            e.preventDefault();
            var id = $(this).data('id');
            var size = $(this).data('size');
            var quantity = parseInt($(this).data('quantity')) + 1;
            console.log(quantity+" " + size + " " + id);
            updateCart(id, quantity,size);
        });

        $('body').on('click', '.btn-minus', function (e) {
            e.preventDefault();
            var id = $(this).data('id');
            var size = $(this).data('size');
            var quantity = parseInt($(this).data('quantity')) - 1;
            console.log(quantity + " " + size + " " + id);
            updateCart(id, quantity,size);
        });
        $('body').on('click', '.btn-remove', function (e) {
            e.preventDefault();
            var id = $(this).data('id');
            var size = $(this).data('size');
            swal({
                title: "Bạn Chắc Chứ?",
                text: "Việc này sẽ bỏ sản phẩm này khỏi giỏ hàng của bạn!",
                icon: "warning",
                buttons: true,
                dangerMode: true,
            }).then((willDelete) => {
                    if (willDelete) {
                        swal("Tiếp tục mua sắm thôi!", {
                            icon: "success",
                        });
                        console.log('id :'+id ,size);
                        updateCart(id, 0, size);
                    } else {
                        swal("Cảm ơn bạn !");
                    }
                });
           
        });
    }

    function updateCart(id, quantity,size) {
        
        $.ajax({
            type: "POST",
            url: "/Cart/UpdateCart",
            data: {
                id: id,
                quantity: quantity,
                size:size
            },
            success: function (res) {
                $('#lbl_number_of_items').text("("+res.length+")");
                loadData();
            },
            error: function (err) {
                console.log(err);
            }
        });
    }

    function loadData() {
        $.ajax({
            type: "GET",
            url: "/Cart/GetListItems",
            success: function (res) {
                var html = 'Bạn Chưa Có Sản Phẩm Nào Trong Giỏ Hàng';
                var total = 0;
                if (res.length != 0) {
                    $('body').on('click', '#btn-checkout-drive', function (e) {
                        var locationUrl = '/Cart/Checkout';
                        const isSigned = $("#is-signed-in").data("signed");
                        console.log(isSigned);
                            if (isSigned =="false"||isSigned==false) {
                                locationUrl = "/login";
                            }
                        window.location = locationUrl;
                    });

                    html = "<thead class=\"thead-dark\"><tr><th>Sản Phẩm<\/th><th>Giá<\/th><th>Số Lượng<\/th><th>Tổng<\/th><th>Xóa<\/th><\/tr><\/thead><tbody class=\"align-middle\">";

                    $.each(res, function (i, item) {

                        var amount = item.price * item.quantity;
                        html += "<tr>"
                            + "<td><div class=\"img\"><a href=\"#\"><img src=\"" + item.image + "\" alt=\"Image\"><\/a><p>" + item.name + " - " + item.size + "<\/p><\/div><\/td>"
                            + "<td>" + numberWithCommas(item.price) + "<\/td>"
                            + "<td><div class=\"qty\">"
                            + "<button  data-id=\"" + item.productId + "\" data-size=\"" + item.size + "\" data-quantity=\"" + item.quantity + "\" class=\"btn-minus\"><i class=\"fa fa-minus\"><\/i><\/button>"
                            + "<input class=\"border-0\"  type=\"text\" value=\"" + item.quantity + "\" disabled>"
                            + "<button  data-id=\"" + item.productId + "\" data-quantity=\"" + item.quantity + "\"  data-size=\"" + item.size + "\"   class=\"btn-plus\"><i class=\"fa fa-plus\"><\/i><\/button><\/div><\/td>"
                            + "<td>" + numberWithCommas(amount) + "<\/td>"
                            + "<td><button data-id=\"" + item.productId + "\"  data-size=\"" + item.size + "\"  data-quantity=\"" + item.quantity + "\" class=\"btn-remove\"><i class=\"fa fa-trash\"><\/i><\/button><\/td>"
                            + "<\/tr>"
                            + "<\/tbody>";
                        total += amount;
                    });
                } else {
                    $('body').on('click', '#btn-checkout-drive', function (e) {
                        swal("Không có sản phẩm nào trong giỏ hàng!", {
                            icon: "error",
                        });
                    });
                }
                $('#cart').html(html);
                $('#lbl_number_of_items').text("(" + res.length + ")");
                $('#lbl_total').text(numberWithCommas(total)+" đ");
                $('#lbl_grandTotal').text(numberWithCommas(total) + " đ");
            }
        });
    }
}