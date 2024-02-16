<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Carrello.aspx.cs" Inherits="Ecommerce.Carrello" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <div class="container">
            <h2>Il tuo carrello</h2>
            <asp:Literal ID="ltMessaggioCarrelloVuoto" runat="server"></asp:Literal>
            <asp:Repeater ID="rptCarrello" runat="server">
                <HeaderTemplate>
                    <table class="table">
                        <thead>
                            <tr>
                                <th>Articolo</th>
                                <th>Nome</th>
                                <th>Quantitá</th>
                                <th>Prezzo</th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>

                <ItemTemplate>
                    <tr>
                        <td class="text-center align-middle">
                            <a href="Dettaglio.aspx?id=<%# Eval("Articolo.Id") %>">
                                <img src='<%# Eval("Articolo.ImmaginePath") %>' alt='<%# Eval("Articolo.Nome") %>' class="img-thumbnail border-0" style="height: 80px; width: 80px; object-fit: cover;" />
                            </a>
                        </td>
                        <td class="align-middle"><%# Eval("Articolo.Nome") %></td>
                        <td class="align-middle"><%# Eval("Quantita") %>x</td>
                        <td class="align-middle">€<%# Eval("PrezzoTotale", "{0:F2}") %></td>
                        <td class="text-center align-middle">
                            <asp:LinkButton ID="lnkRimuovi" CommandArgument='<%# Eval("Articolo.Id") %>' runat="server" OnCommand="LnkRimuovi_Command" CssClass="btn btn-outline-danger btn-sm">Rimuovi</asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>



                <FooterTemplate>
                    </tbody>
                        </table>
                        <div class="row">
                            <div class="col-md-12 text-right d-flex align-content-center justify-content-between">
                                <h5>Totale Carrello: </h5>
                                <asp:Literal ID="ltTotaleCarrello" runat="server"></asp:Literal>
                            </div>
                        </div>
                </FooterTemplate>


            </asp:Repeater>
            <asp:Button ID="btnSvuotaCarrello" runat="server" CssClass="btn btn-danger btn-sm" OnClick="BtnSvuotaCarrello_Click" Text="Svuota Carrello" />
        </div>
    </main>
</asp:Content>
