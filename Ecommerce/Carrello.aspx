<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Carrello.aspx.cs" Inherits="Ecommerce.Carrello" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <div class="container">
            <h2>Il tuo carrello</h2>
            <asp:Literal ID="ltMessaggioCarrelloVuoto" runat="server"></asp:Literal>
           <div class="row">
            <asp:Repeater ID="rptCarrello" runat="server">
                <ItemTemplate>
                   
                    <div class="col-lg-6 col-md-12 mb-4">
                        <div class="card mb-3 h-100">
                            <div class="row g-0">
                                <div class="col-md-4 d-flex align-items-center justify-content-center">
                                    <a href="Dettaglio.aspx?id=<%# Eval("Articolo.Id") %>">
                                        <img src='<%# Eval("Articolo.ImmaginePath") %>' alt='<%# Eval("Articolo.Nome") %>' class="img-fluid rounded-start" />
                                    </a>
                                </div>
                                <div class="col-md-8">
                                    <div class="card-body">
                                        <h5 class="card-title"><%# Eval("Articolo.Nome") %></h5>
                                        <p class="card-text">Quantità: <%# Eval("Quantita") %>x</p>
                                        <p class="card-text">Prezzo: €<%# Eval("PrezzoTotale", "{0:F2}") %></p>
                                        <asp:LinkButton ID="lnkRimuovi" CommandArgument='<%# Eval("Articolo.Id") %>' runat="server" OnCommand="LnkRimuovi_Command" CssClass="btn btn-outline-danger">Rimuovi</asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
           </div>
            <asp:Button ID="btnSvuotaCarrello" runat="server" CssClass="btn btn-danger" OnClick="BtnSvuotaCarrello_Click" Text="Svuota Carrello" />
        </div>
    </main>
</asp:Content>


