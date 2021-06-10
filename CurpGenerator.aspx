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
                        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Primer apellido: </asp:TableCell> 
                    <asp:TableCell>
                        <asp:TextBox ID="txtLastName1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Segundo apellido: </asp:TableCell> 
                    <asp:TableCell>
                        <asp:TextBox ID="txtLastName2" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Fecha de nacimiento: </asp:TableCell> 
                    <asp:TableCell>
                        <asp:TextBox ID="txtBirth" runat="server"></asp:TextBox>
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
                        <asp:DropDownList ID="DropDownState" runat="server">
                            <asp:ListItem>Aguascalientes</asp:ListItem>
                            <asp:ListItem>Baja California Norte</asp:ListItem>
                            <asp:ListItem>Baja California Sur</asp:ListItem>
                            <asp:ListItem>Campeche</asp:ListItem>
                            <asp:ListItem>Chiapas</asp:ListItem>
                            <asp:ListItem>Chihuahua</asp:ListItem>
                            <asp:ListItem>Ciudad de México</asp:ListItem>
                            <asp:ListItem>Coahuila</asp:ListItem>
                            <asp:ListItem>Colima</asp:ListItem>
                            <asp:ListItem>Durango</asp:ListItem>
                            <asp:ListItem>Guanajuato</asp:ListItem>
                            <asp:ListItem>Guerrero</asp:ListItem>
                            <asp:ListItem>Hidalgo</asp:ListItem>
                            <asp:ListItem>Jalisco</asp:ListItem>
                            <asp:ListItem>Estado de México</asp:ListItem>
                            <asp:ListItem>Michoacán</asp:ListItem>
                            <asp:ListItem>Morelos</asp:ListItem>
                            <asp:ListItem>Nayarit</asp:ListItem>
                            <asp:ListItem>Nuevo León</asp:ListItem>
                            <asp:ListItem>Oaxaca</asp:ListItem>
                            <asp:ListItem>Puebla</asp:ListItem>
                            <asp:ListItem>Querétaro</asp:ListItem>
                            <asp:ListItem>Quintana Roo</asp:ListItem>
                            <asp:ListItem>San Luis Potosí</asp:ListItem>
                            <asp:ListItem>Sinaloa</asp:ListItem>
                            <asp:ListItem>Sonora</asp:ListItem>
                            <asp:ListItem>Tabasco</asp:ListItem>
                            <asp:ListItem>Tamaulipas</asp:ListItem>
                            <asp:ListItem>Tlaxcala</asp:ListItem>
                            <asp:ListItem>Veracruz</asp:ListItem>
                            <asp:ListItem>Yucatán</asp:ListItem>
                            <asp:ListItem>Zacatecas</asp:ListItem>
                        </asp:DropDownList>           
                    </asp:TableCell>
                </asp:TableRow>
                
            </asp:Table>
        </div>
    </form>
</body>
</html>
