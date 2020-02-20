$(document).ready(function () {
    dtPopulate();
    datePick();
    ultimoSp();
});

function dtPopulate() {
    $('#example').DataTable({
        responsive: "false",
        "paging": true,
         "processing": true,
        language: {
            "lengthMenu": "<p style='color: white'>Mostrar _MENU_ registros</p>",
            "zeroRecords": "<p style='color: black'>No se encontraron resultados</p>",
            "info": "<p style='color: white'>Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros</p>",
            "infoEmpty": "<p style='color: white'>Mostrando registros del 0 al 0 de un total de 0 registros</p>",
            "infoFiltered": "<p style='color: white'>(Filtrado de un total de _MAX_ registros)</p>",
            "sSearch": "<p style='color: white; font-size:13px;'><strong>Buscar por item:</strong>",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior"
            },
            "sProcessing": "<p style='color: black'>BUscando datos, por favor espere</p>",
        },
        //para usar los botones   
        dom: 'Bfrtilp',
        buttons: [
            {
                extend: 'excelHtml5',
                text: '<i class="fas fa-file-excel"></i> ',
                titleAttr: 'Exportar a Excel',
                className: 'btn btn-success'
            },
            //{
            //    extend: 'pdfHtml5',
            //    text: '<i class="fas fa-file-pdf"></i> ',
            //    titleAttr: 'Exportar a PDF',
            //    className: 'btn btn-danger'
            //},
            //{
            //    extend: 'print',
            //    text: '<i class="fa fa-print"></i> ',
            //    titleAttr: 'Imprimir',
            //    className: 'btn btn-info'
            //},
        ],

        //Para traer los datos
        ajax: {
            method: "POST",
            url: "Index.aspx/getMateriales",
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
}

function datePick() {
    $('input[name="lbldate"]').daterangepicker({
        opens: 'left',
        "autoApply": true,
        "locale": {
            "format": "MM/DD/YYYY",
            "separator": " - ",
            "applyLabel": "Aplicar",
            "cancelLabel": "Cancelar",
            "fromLabel": "Desde",
            "toLabel": "Hasta",
            "customRangeLabel": "Custom",
            "weekLabel": "Semana",
            "daysOfWeek": [
                "Dom",
                "Lunes",
                "Mart",
                "Mier",
                "Juev",
                "Viern",
                "Sab"
            ],
            "monthNames": [
                "Enero",
                "Febrero",
                "Marzo",
                "Abril",
                "Mayo",
                "Junio",
                "Julio",
                "Agosto",
                "Septiembre",
                "Octubre",
                "Noviembre",
                "Diciembre"
            ],
            "firstDay": 1
        },
        //"startDate": "01/01/2020",
        //"endDate": "01/12/2020"
        cancelLabel: 'Clear'
    },function (start, end, label) {
            var data = {
                objFechas: {
                    inicio: start.format('YYYY-MM-DD'),
                    fin: end.format('YYYY-MM-DD')
                }
            }
            $.ajax({
                method: "POST",
                url: "Index.aspx/getMaterialesFecha",
                data: JSON.stringify(data),
                contentType: "application/json; charset=utf-8",
                dataType: "json"

            }).done(function (info) {

                //dtPopulate2(info);
                //Respuesta del servidor
                console.log(info.d);
                var table = $('#example').DataTable();
                table.clear()
                table.rows.add(info.d.data).draw();
                $(".mensaje").html(info.d);
            });

            console.log("A new date selection was made: " + start.format('YYYY-MM-DD') + ' to ' + end.format('YYYY-MM-DD'));
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



function ultimoSp() {
    $.ajax({
        type: "POST",
        url: 'Index.aspx/getUltimoJob',
        data: '{ }',
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        success: function (data) {

            console.log(data);
            fechahora = data.d.data;
            console.log(fechahora);
            //alert(msg.d)
            //console.log(fechahora);
            $('#lblName').text("Fecha y hora de los datos: "+fechahora)
            return fechahora;
          
            //return data;
        },
        error: function () {
            alert('Error occured');
        }
    });
}