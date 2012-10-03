<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductoUp.aspx.cs" Inherits="Boromir_W.ProductoUp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script Language="javascript" type="text/javascript" src="js/jquery.js"></script>
<script Language="javascript" type="text/javascript" src="js/popup.js"></script>
<Link href="Style.css" rel="stylesheet" type="text/css" >
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <section class="popup">
        <asp:Image ID="Image1" runat="server" Height="91px" Width="106px" />
    </section>
     <section class="popup">
         <asp:Label ID="Lbnombre" runat="server" Text="nombre"></asp:Label>
         <p></p>
         <asp:Label ID="Lbcodigo" runat="server" Text="nombre"></asp:Label>
         <p></p>
         <asp:Label ID="Lbcategoria" runat="server" Text="nombre"></asp:Label>
         <p></p>
    </section>
    <section class="popup">         
         $ <asp:Label ID="lbprecio" runat="server" Text="precio"></asp:Label>
         <p></p>
         <asp:Label ID="Lbiva" runat="server" Text="nombre"></asp:Label> %
         <p></p>
         <asp:Label ID="Lbdescuento" runat="server" Text="nombre"></asp:Label> %
         <p></p>
     </section>
       <section class="popup">         
         COLOR: <asp:Label ID="Lbcolor" runat="server" Text="precio"></asp:Label>
         <p></p>
         <asp:Label ID="Lbund" runat="server" Text="nombre"></asp:Label>
         <p></p>
         <asp:Label ID="Lbobs" runat="server" Text="nombre"></asp:Label>
       </section>
    </div>
    </form>
</body>
</html>
