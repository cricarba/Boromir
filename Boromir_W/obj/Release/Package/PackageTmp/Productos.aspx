 <%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Boromir_W.Productos" %>
 <%@ MasterType VirtualPath="~/Home.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <article>
     <asp:Label ID="Label1" runat="server" Text="Productos" CssClass="titulo"></asp:Label>
    </article>
    <article>
     <asp:GridView ID="Dt_productos" runat="server" 
        onselectedindexchanged="Dt_productos_SelectedIndexChanged" 
        CssClass="tablePrincipal"  ClientIDMode="Predictable" 
        ClientIDRowSuffix="Codigo" PageSize="5">
        <Columns>
            <asp:TemplateField HeaderText=" ">
                <ItemTemplate>
               
                    <asp:Image ID="Ver" runat="server" Width="25px" class="modal" value="Demo" ImageUrl="~/Imagenes/View.png" data-codigo='<%# Eval("Codigo") %>'  onclick = "rowsindex(this)" > </asp:Image>
                 </ItemTemplate>
            </asp:TemplateField> 
                        <asp:CommandField ButtonType="Image" SelectImageUrl="~/Imagenes/Market.png" SelectText="" ShowSelectButton="True" />     
            
            <asp:TemplateField HeaderText="Ctd">
                <ItemTemplate>
                        <asp:TextBox ID="Ctd" runat="server" Width="40px"></asp:TextBox>
                 </ItemTemplate>
            </asp:TemplateField>                                
        </Columns>
         <HeaderStyle CssClass="titulocolum"/>
         <RowStyle  CssClass="items"/>
     </asp:GridView>
   </article>
    
 </asp:Content>
