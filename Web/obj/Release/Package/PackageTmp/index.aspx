<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Web.index" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="datos">
        <div class="row">

            <div class="col-md-12 col-sm-12 col-xs-12" style="background-color: black; color:gray; font-family:Verdana;">
                <h2 class="text-center">Datos materiales verificados</h2>
            </div>

         <%--   <div class="col-md-3 col-sm-3 col-xs-3">
                <button type="button" id="boton" class="btn btn-success">
                    <span class="glyphicon glyphicon-list" aria-hidden="true"></span>Listar
                </button>
            </div>--%>
        </div>


        <br />
        <div class="row">
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <table id="table-users" class="table table-responsive table-hover">
                    <thead>

                        <th>Id</th>
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

                    </thead>
                </table>
            </div>
        </div>

    </div>






    <%--    <div class="datos">

         <table class="display" id="MyDataTable">
        <thead>
            <tr>
                <th>
                    EmaployeeName
                </th>
                <th>
                    Department
                </th>
                <th>
                    Salary
                </th>
            </tr>
        </thead>

        <tbody>
            <tr>
                <td>John</td>
                <td>CSE</td>
                <td>52000</td>
            </tr>
            <tr>
                <td>Sara</td>
                <td>EC</td>
                <td>52000</td>
            </tr>

         
        </tbody>

    </table>

    </div>
   
    --%>

    <!--Formulario
    
    <div class="container login-container">
        <div class="row justify-content-center">
            <div class="col-md-6 login-form">

                <h2>Bienvenido</h2>
                <div class="form-check">
                    <a><strong>Selecione personal IT:</strong></a>
                </div>


                <br />


                <div class="form-check">
                    <asp:DropDownList ID="SoportistaDropDownList" runat="server" CssClass="form-control selcls"></asp:DropDownList>
                </div>

                <br />
                <br />


                <div class="form-check">

                    <a><strong>Selecione lugares recorridos:</strong></a>
                </div>


                <br />


                <div class="form-check">
                    <%--<asp:Label ID="Label1" runat="server" />--%>
                    <asp:CheckBoxList ID="Salones" runat="server"></asp:CheckBoxList>
                </div>


                <div class="form-check">
                    <asp:TextBox ID="Txtdetalles" runat="server" CssClass="form-control" PlaceHolder="Observaciones opcionales *"></asp:TextBox>
                </div>


                <br />

                <div class="form-group">
                    <asp:Button ID="BtnNuevaRecorrida" runat="server" Text="Ingresar" CssClass="btnSubmit" OnClick="BtnNuevaRecorrida_Click" />
                </div>


            </div>
        </div>
    </div>

    -->

</asp:Content>
