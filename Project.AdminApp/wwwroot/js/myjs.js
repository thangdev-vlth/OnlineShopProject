jQuery(function ($) {
    //$("#btnsubmit").click(function (e) {
        
    //    //Serialize the form datas.   
    //    var valdata = $("#updateProductForm").serialize();
        
    //    //to get alert popup   
    //    $.ajax({
    //        url: "/Products/Update",
    //        data: valdata,
    //        dataType: "json",
    //        type: "POST",
    //        success: function (response) {
    //            alert(1);
    //        }
    //    });
    //});   
    $(document).on("submit", "form", function (event) {
        event.preventDefault();
        var data = new FormData(this);
        $.ajax({
            url: $(this).attr("action"),
            type: $(this).attr("method"),
            dataType: "JSON",
            data: new FormData(this),
            processData: false,
            contentType: false,
            success: function (data, status) {
                console.log("ábdhjabshjbasdhbashjb");
                window.parent.location.reload();
                window.close();
            },
            error: function (xhr, desc, err) {
                console.log("action: " + $(this).attr("action"));
                console.log("type: " + $(this).attr("method"));
                
                alert(data);
            }
        });

    });
});
jQuery(function ($) {
    function adjustIframes() {
        $('iframe').each(function () {
            var
                $this = $(this),
                proportion = $this.data('proportion'),
                w = $this.attr('width'),
                actual_w = $this.width();

            if (!proportion) {
                proportion = $this.attr('height') / w;
                $this.data('proportion', proportion);
            }

            if (actual_w != w) {
                $this.css('height', Math.round(actual_w * proportion) + 'px');
            }
        });
    }
    $(window).on('resize load', adjustIframes);
});