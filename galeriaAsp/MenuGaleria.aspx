<%@  Language="C#" AutoEventWireup="true" CodeFile="MenuGaleria.aspx.cs" Inherits="MenuGaleria" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link rel="stylesheet" href="assets/css/menu_gallery.css">
    <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css'>  

     
    
    
    
    <div class="gallery">
        <div class="title">
            <h4>
               Veja aqui os albuns de fotos do evento 
               <i class='fa fa-photo'></i>
            </h4>
        </div>
        <asp:Repeater ID="galeriaRepeater" runat="server">
        <ItemTemplate>
            <div class="galeria" id="<%# DataBinder.Eval(Container.DataItem, "id_album") %>" onclick="RedirecionarParaGaleria(<%# DataBinder.Eval(Container.DataItem, "id_album") %>)">
             <img src="<%# DataBinder.Eval(Container.DataItem, "capa_album") %>"/>
             <div class="album-title">
                <div class="teste">
                    <span><%# DataBinder.Eval(Container.DataItem, "titulo_album") %></span>
                </div>
             </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>

   
    


<script src="assets/js/menu_galeria.js"></script>
</asp:Content>




























