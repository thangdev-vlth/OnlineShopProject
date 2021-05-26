// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var SiteController = function () {
    this.initialize = function () {
        regsiterEvents();
        loadCart();
    }
    function loadCart() {
        console.log("loading cart....");
        $.ajax({
            type: "GET",
            url: "/Cart/GetListItems",
            success: function (res) {
                console.log("loading cart.... success")
                $('#lbl_number_of_items').text("(" + res.length + ")");
            }
        });
    }
    function regsiterEvents() {
        // Write your JavaScript code.
        console.log("add to cart......checked");
        $('body').on('click', '.btn-add-cart', function (e) {
            e.preventDefault();
            
            const id = $(this).data('id');
            $.ajax({
                type: "POST",
                url: "/Cart/AddToCart",
                data: {
                    id: id
                },
                success: function (res) {
                    $('#lbl_number_of_items').text("(" + res.length + ")");
                    swal({
                        title: "Đã Thêm Vào Giỏ Hàng!",
                        text: "Tiếp Tục Mua Sắm Nào!",
                        icon: "success",
                        button: "Oki!",
                    });
                },
                error: function (err) {
                    console.log(err);
                }
            });
        });
    }
}


function numberWithCommas(x) {
    return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}