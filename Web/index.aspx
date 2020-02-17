<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Web.index1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">


    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />



    <!-- Required meta tags -->
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="shortcut icon" href="#" />
    <title>Bridgestone</title>

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="bootstrap/css/bootstrap.min.css" />
    <!-- CSS personalizado -->
    <link rel="stylesheet" href="main.css" />

    <!--datables CSS básico-->
    <link rel="stylesheet" type="text/css" href="datatables/datatables.min.css" />
    <!--datables estilo bootstrap 4 CSS-->
    <link rel="stylesheet" type="text/css" href="datatables/DataTables-1.10.18/css/dataTables.bootstrap4.min.css" />

    <!--font awesome con CDN-->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.2/css/all.css" integrity="sha384-oS3vJWv+0UjzBfQzYUhtDYW+Pj2yciDJxpsK1OYPAYjqT085Qq/1cq5FLXAZQ7Ay" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">

        <div id="main">
            <div class="dark-overlay">
                <header>
                    <nav class="navbar">
                        <a class="navbar-brand">Bridgestone</a>
                    </nav>
                </header>

                <div>

                </div>


                <br />
                <h3 class="text-center text-light">Seguimiento materiales verificados</h3>
                <br />
                       
                <%--  Datepicker--%>
                <input type="text" name="lbldate" value="" class="form-control" style="max-width: 15%" />

                <!--Ejemplo tabla con DataTables-->
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="table-responsive">
                                <table id="example" class="table table-striped" cellspacing="0" width="100%">
                                    <thead class="thead-dark">
                                        <tr>
                                            <th>BuildingMachine</th>
                                            <th>BuildingSize</th>
                                            <th>VerifyDateTime</th>
                                            <th>BSDateShift</th>
                                            <th>BuildingLotNo</th>
                                            <th>Builder1</th>
                                            <th>MaterialBarcodeNo</th>
                                            <th>PartIID</th>
                                            <th>PartName</th>
                                            <th>PartNumber</th>
                                            <th>DateProduced</th>
                                            <th>Remain</th>
                                            <th>MachineProduced</th>
                                            <th>MachineName</th>
                                        </tr>
                                    </thead>
                                </table>
                            </div>
                        </div>
                    </div>

                </div>

            </div>

        </div>

        <!-- jQuery, Popper.js, Bootstrap JS -->
        <script src="jquery/jquery-3.3.1.min.js"></script>
        <script src="popper/popper.min.js"></script>
        <script src="bootstrap/js/bootstrap.min.js"></script>


        <%--  Para usar datepicker--%>
        <script type="text/javascript" src="https://cdn.jsdelivr.net/jquery/latest/jquery.min.js"></script>
        <script type="text/javascript" src="https://cdn.jsdelivr.net/momentjs/latest/moment.min.js"></script>
        <script type="text/javascript" src="https://cdn.jsdelivr.net/npm/daterangepicker/daterangepicker.min.js"></script>
        <link rel="stylesheet" type="text/css" href="https://cdn.jsdelivr.net/npm/daterangepicker/daterangepicker.css" />

        <!-- datatables JS -->
        <script type="text/javascript" src="datatables/datatables.min.js"></script>

        <!-- para usar botones en datatables JS -->
        <script src="datatables/Buttons-1.5.6/js/dataTables.buttons.min.js"></script>
        <script src="datatables/JSZip-2.5.0/jszip.min.js"></script>
        <script src="datatables/pdfmake-0.1.36/pdfmake.min.js"></script>
        <script src="datatables/pdfmake-0.1.36/vfs_fonts.js"></script>
        <script src="datatables/Buttons-1.5.6/js/buttons.html5.min.js"></script>

        <!-- código JS propìo-->
        <script type="text/javascript" src="main.js"></script>


        <script>

</script>


    </form>
</body>
</html>
