$(document).ready(function () {
    $('#example').DataTable({



        language: {
            "lengthMenu": "<p style='color: white'>Mostrar _MENU_ registros</p>",
            "zeroRecords": "<p style='color: white'>No se encontraron resultados</p>",
            "info": "<p style='color: white'>Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros</p>",
            "infoEmpty": "<p style='color: white'>Mostrando registros del 0 al 0 de un total de 0 registros</p>",
            "infoFiltered": "<p style='color: white'>(filtrado de un total de _MAX_ registros)</p>",
            "sSearch": "<p style='color: white; font-size:11px '><strong>Buscar:</strong>",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior"
            },
            "sProcessing": "<p style='color: white'>Procesando...</p>",
        },
        //para usar los botones   
        responsive: "true",
        dom: 'Bfrtilp',
        buttons: [
            {
                extend: 'excelHtml5',
                text: '<i class="fas fa-file-excel"></i> ',
                titleAttr: 'Exportar a Excel',
                className: 'btn btn-success'
            },
            {
                extend: 'pdfHtml5',
                text: '<i class="fas fa-file-pdf"></i> ',
                titleAttr: 'Exportar a PDF',
                className: 'btn btn-danger'
            },
            {
                extend: 'print',
                text: '<i class="fa fa-print"></i> ',
                titleAttr: 'Imprimir',
                className: 'btn btn-info'
            },
        ],



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
            //{ "data": "Id" },
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
});
