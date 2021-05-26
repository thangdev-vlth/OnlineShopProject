var CartController = function () {
    this.initialize = function () {
        loadData();
        registerEvents();
    }

    function registerEvents() {
        $('body').on('click', '.btn-plus', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            var quantity = parseInt($('#txt_quantity_' + id).val()) + 1;
            console.log(quantity);
            updateCart(id, quantity);
        });

        $('body').on('click', '.btn-minus', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            var quantity = parseInt($('#txt_quantity_' + id).val()) - 1;
            console.log(quantity);
            updateCart(id, quantity);
        });
        $('body').on('click', '.btn-remove', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
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
                        console.log('id :'+id);
                        updateCart(id, 0);
                    } else {
                        swal("Cảm ơn bạn !");
                    }
                });
           
        });
    }

    function updateCart(id, quantity) {
        
        $.ajax({
            type: "POST",
            url: "/Cart/UpdateCart",
            data: {
                id: id,
                quantity: quantity
            },
            success: function (res) {
                $('#lbl_number_of_items').text(res.length);
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
                    html = "<thead class=\"thead-dark\"><tr><th>Sản Phẩm<\/th><th>Giá<\/th><th>Số Lượng<\/th><th>Tổng<\/th><th>Xóa<\/th><\/tr><\/thead><tbody class=\"align-middle\">";
                        
                    $.each(res, function (i, item) {

                        var amount = item.price * item.quantity;
                        html +="<tr>"
                            + "<td><div class=\"img\"><a href=\"#\"><img src=\"" + item.image + "\" alt=\"Image\"><\/a><p>" + item.name + "<\/p><\/div><\/td>"
                            + "<td>" + numberWithCommas(item.price) + "<\/td>"
                            + "<td><div class=\"qty\">"
                            + "<button  data-id=\"" + item.productId + "\" class=\"btn-minus\"><i class=\"fa fa-minus\"><\/i><\/button>"
                            + "<input id=\"txt_quantity_" + item.productId + "\" type=\"text\" value=\"" + item.quantity + "\" disable>"
                            + "<button  data-id=\"" + item.productId + "\" class=\"btn-plus\"><i class=\"fa fa-plus\"><\/i><\/button><\/div><\/td>"
                            + "<td>" + numberWithCommas(amount) + "<\/td>"
                            + "<td><button data-id=\"" + item.productId + "\" class=\"btn-remove\"><i class=\"fa fa-trash\"><\/i><\/button><\/td>"
                            + "<\/tr>"
                            + "<\/tbody>";
                        total += amount;
                    });
                }
                $('#cart').html(html);
                $('#lbl_number_of_items').text(res.length);
                $('#lbl_total').text(numberWithCommas(total));
                $('#lbl_grandTotal').text(numberWithCommas(total));
            }
        });
    }
}