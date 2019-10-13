$(document).ready(function () {
    LoadFilters();
});

function LoadFilters() {
    $.ajax({
        url: 'Home/LoadFilterData',
        dataType: "Json",
        type: "POST",
        //data: jQuery.param({ txtBusqueda: txtBuscar }),
        success: function (data) {
            
            var objdata = $.parseJSON(data);
            var objlen = Object.keys(objdata).length;
            if (objlen > 0) {
                objdata.forEach(
                    function (i) {
                        alert(i)
                    })
            }
        },

        error: function (data) {
            alert(data)
        }
    });
}