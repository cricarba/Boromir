<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="Boromir_W.Pedido" %>
 <%@ MasterType VirtualPath="~/Home.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <article>
    <asp:Label ID="Lbpedido" runat="server" Text="Pedido" CssClass="titulo"></asp:Label>
     </article>
  <article>
    <asp:GridView ID="DT_Carro" runat="server"  onselectedindexchanged="DT_Carro_SelectedIndexChanged" CssClass="tablePrincipal">
        <Columns>
            <asp:CommandField ButtonType="Image" SelectImageUrl="~/Imagenes/Garbage.png" 
                SelectText="" ShowSelectButton="True"/>
        </Columns>
        <HeaderStyle CssClass="header" />
    </asp:GridView>
    </article>
    <br />
    <section class="menu">
        <asp:ImageButton ID="Confirmar" runat="server" CssClass="buscador" 
            ImageUrl="~/Imagenes/Document Check.png" onclick="Confirmar_Click" />
        <asp:ImageButton ID="Cancelar" runat="server"  CssClass="buscador" 
            ImageUrl="~/Imagenes/Delete.png" />
            <asp:Label ID="Lb" runat="server" Text="" CssClass="titulo"></asp:Label>
    </section>
</asp:Content>
