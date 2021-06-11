<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurpGenerator.aspx.cs" Inherits="CurpGenerator.CurpGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="Table1" runat="server" CellPadding="10" GridLines="Both" HorizontalAlign="Center">
                <asp:TableRow>
                    <asp:TableCell>Nombre(s): </asp:TableCell> 
                    <asp:TableCell>
                        <asp:TextBox ID="txtName" runat="server" Text="CONCEPCION"></asp:TextBox>
                        <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
                              ControlToValidate="txtName"
                              ErrorMessage="Este campo es obligatorio!!"
                              ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Primer apellido: </asp:TableCell> 
                    <asp:TableCell>
                        <asp:TextBox ID="txtLastName1" runat="server" Text="SALGADO"></asp:TextBox>
                        <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server"
                              ControlToValidate="txtLastName1"
                              ErrorMessage="Este campo es obligatorio!!"
                              ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Segundo apellido: </asp:TableCell> 
                    <asp:TableCell>
                        <asp:TextBox ID="txtLastName2" runat="server" Text="BRISEÑO"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Fecha de nacimiento: </asp:TableCell> 
                    <asp:TableCell>
                        <asp:TextBox ID="txtBirth" runat="server" Text="26/06/1956"></asp:TextBox>
                        <asp:ImageButton ID="miniCalendar" runat="server" ImageAlign="AbsBottom" OnClick="miniCalendar_Click" ImageUrl='~/calendar.jpg' Height="25px" />
                        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Sexo H/M: </asp:TableCell> 
                    <asp:TableCell>
                        <asp:DropDownList ID="DropDownGender" runat="server">
                            <asp:ListItem>Hombre</asp:ListItem>
                            <asp:ListItem>Mujer</asp:ListItem>
                        </asp:DropDownList>           
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Estado de nacimiento: </asp:TableCell> 
                    <asp:TableCell>
                        <asp:DropDownList ID="DropDownStates" runat="server"></asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2" HorizontalAlign="Center">
                        <asp:Button ID="btnSend" runat="server" Text="Obtener CURP y RFC!!" OnClick="btnSend_click"/>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
        <br />
        <div style="margin-left: auto; margin-right: auto; text-align:center;">
            <asp:Label ID="labelCurp" runat="server" Text="" ></asp:Label>
            <br />
            <asp:Label ID="labelRFC" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
