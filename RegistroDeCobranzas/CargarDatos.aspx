<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CargarDatos.aspx.cs" Inherits="RegistroDeCobranzas.CargarDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button2" runat="server" Text="Volver" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Cargar cobro"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Fecha de cobro: "></asp:Label>
            <asp:TextBox ID="fecha" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Nombre: "></asp:Label>

            <asp:TextBox ID="nombre" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Apellido: "></asp:Label>
            <asp:TextBox ID="apellido" runat="server"></asp:TextBox>

            <br />

            <br />
            <asp:Label ID="Label5" runat="server" Text="Monto: "></asp:Label>

            <asp:TextBox ID="monto" runat="server"></asp:TextBox>

            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />

            <br />
            <br />
            <asp:Label ID="mensaje1" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="mensaje2" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
