<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AppWebZapateria.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="235px" ImageUrl="~/img/pngwing.com.png" Width="284px" />
            <asp:Label ID="lblTituloLog" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Text="Zapateria Online"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblLogin" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="Silver" Text="Login"></asp:Label>
            <asp:Login ID="Login1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" DestinationPageUrl="~/Inicio.aspx" Font-Names="Verdana" Font-Size="10pt" OnAuthenticate="Login1_Authenticate" FailureText="Usuario/Contraseña incorrecto. Inténtelo de nuevo." DisplayRememberMe="False">
                <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
            </asp:Login>
        </div>
    </form>
</body>
</html>
