<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Boromir_W.Error" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<Link rel="Stylesheet" type="text/css" href="Style.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Logo.png" />
    </div>
   
    <article>
        <asp:Label ID="Label1" runat="server" Text="USTED NO TIENE LOS PERMISOS SUFICIENTES PARA INGRESAR" CssClass="titulo"></asp:Label>
    </article>
    </form>
</body>
</html>
