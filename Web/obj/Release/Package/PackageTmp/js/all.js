//function __showUsers() {
//    $("#boton").on("click", function () {
//        alert("El boton funciono");
//        //test();
//        dtUsers();
//    });
//}


function dtUsers() {
    var table = $("#table-users").DataTable({
        destroy: true,
        responsive: true,
        
        ajax: {
            method: "POST",
            url: "Index.aspx/getUsers",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: function (d) {
                return JSON.stringify(d);
            },
            dataSrc: "d.data"
        },
        columns: [
            { "data": "Id" },
            { "data": "BuildingMachine" },
            { "data": "BuildingSize" },
            { "data": "VerifyDateTime" },
            { "data": "BSDateShift" },
            { "data": "BuildingLotNo" },
            { "data": "Builder1" },
            { "data": "MaterialBarcodeNo" },
            { "data": "PartIID" },
            { "data": "PartName" },
            { "data": "PartNumber" },
            { "data": "DateProduced" },
            { "data": "Remain" },
            { "data": "MachineProduced" },
            { "data": "MachineName" }
        ]
    });
}

function test() {
    $.ajax({
        method: "POST",
        url: "Index.aspx/getUsers",
        contentType: "application/json; charset=utf-8",
        dataType: "json"
    }).done(function (info) {
        console.log(JSON.stringify(info));
    });
}