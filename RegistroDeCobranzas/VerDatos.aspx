<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerDatos.aspx.cs" Inherits="RegistroDeCobranzas.VerDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Volver" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Mensaje" runat="server" Text="Seleccione un elemento de la lista y haga click en el botón Ver Datos."></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="cobros" runat="server" Height="22px" Width="190px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Ver Datos" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Limpiar Campos" OnClick="Button3_Click" />
            <br />
            
            <br />
            <asp:Label ID="persona" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="fecha" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="monto" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
