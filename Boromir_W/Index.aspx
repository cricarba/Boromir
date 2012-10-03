<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Boromir_W.Index1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<Link rel="stylesheet" type="text/css" href="Style.css">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
    <section class="logo">
    .
    </section>

     <section class="logo">
      <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Logo.png"   Height="183px"    Width="175px" />
       <br />
        <asp:Label ID="Usuario" runat="server" Text="Usuario"></asp:Label>            
            <asp:TextBox ID="TBuser" runat="server" CssClass="caja"></asp:TextBox>
          <p></p>
            <asp:Label ID="Contraseña" runat="server" Text="Contraseña"></asp:Label>             
            <asp:TextBox ID="TBpass" runat="server" CssClass="caja"  
         TextMode="Password"></asp:TextBox>
         <p></p>
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Ingresar" CssClass="botones" />    
     </section>
     <br />
   
   </form>
</body>
</html>
