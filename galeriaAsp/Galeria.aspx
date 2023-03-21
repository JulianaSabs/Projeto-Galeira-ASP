<%@ Page Title="" Debug="true" Language="C#" AutoEventWireup="true" CodeFile="Galeria.aspx.cs" Inherits="Galeria" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager" runat="server" EnablePartialRendering="true"></asp:ScriptManager>
    <link rel="stylesheet" href="assets/css/gallery.css">
    <link rel="stylesheet" href="assets/css/lightbox.css">

<div class="container-all">
    <div class="button-voltar-div">
      <asp:LinkButton ID="voltarButton" Text="Voltar" CssClass="ver-card-button" runat="server" OnClick="voltarButton_Click" />
      </div>
</div>
    <div class="gallery">
      <div class="gallery-title">
        <asp:label runat="server" id="tituloAlbum" visible="true"></asp:label>
          <div class="gallery-description">
            <asp:label runat="server" id="descricaoAlbum" visible="true"></asp:label>
          </div>
      </div>
        <asp:Repeater ID="galeriaRepeater" runat="server">
          <ItemTemplate>
               <a data-lightbox="img" href="<%# DataBinder.Eval(Container.DataItem, "imagem_galeria") %>"/>
                 <img src="<%# DataBinder.Eval(Container.DataItem, "imagem_galeria") %>"/>
                </a>
          </ItemTemplate>
        </asp:Repeater>
    </div>
    >
    <asp:label runat="server" id="codAlbumLabel" visible="false"></asp:label>
  <script src="assets/js/gallery.js"></script>
</asp:Content>
