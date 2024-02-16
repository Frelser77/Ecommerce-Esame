<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ecommerce._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <asp:Repeater ID="rptArticoli" runat="server">
            <HeaderTemplate>
                <div class="container">
                    <div class="row">
            </HeaderTemplate>
            <ItemTemplate>
                <div class="col-md-4 mb-5 articoli-container position-relative">
                    <a href="Dettaglio.aspx?id=<%# Eval("Id") %>">
                        <img src="Content/assets/images/Logo_BW.png" alt="Logo" class="position-absolute logo-pstn" height="25" width="25" />
                    
                    <div class="articolo h-100 d-flex flex-column align-items-center justify-content-between my-op">
                        <img src='<%# Eval("ImmaginePath") %>' alt="Immagine articolo" class="w-100 my-1 producat" />
                        <div>
                            <h3 class="text-start text-black"><%# Eval("Nome") %></h3>
                            <p class="text-center text-black">Prezzo: €<%# Eval("Prezzo") %></p>
                        </div>
                        <div class="d-flex align-items-end justify-content-end">
                            <asp:Button ID="btnAggiungiCarrello" runat="server" CommandArgument='<%# Eval("Id") %>' OnCommand="BtnAggiungiCarrello_Command" CssClass="btn btn-outline-secondary" Text="Aggiungi al carrello" />
                        </div>
                    </div>
</a>
                </div>
            </ItemTemplate>

        </asp:Repeater>
    </main>


</asp:Content>
