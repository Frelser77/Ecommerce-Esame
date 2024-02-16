<%@ Page Title="Dettaglio Prodotto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dettaglio.aspx.cs" Inherits="Ecommerce.Dettaglio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-6 offset-3 mt-5">

                <div class="card shadow">
                    <div class="card-body position-relative">
                        <a href="Default.aspx" class="btn btn-sm btn-transparent text-black position-absolute icon-pstn"><i class="fas fa-arrow-left"></i></a>

                    <div class="card h-100 border-0 d-flex align-items-center">
                        <asp:Image ID="imgProdotto" CssClass="card-img-top img-details" runat="server" AlternateText="Immagine del prodotto" />

                    </div>


                    <div class="col ">

                        <div class="card h-100 border-0 shadow p-2  position-relative">
                            <div class="card-body">
                                <asp:Label ID="lblNome" CssClass="card-title fs-3 fw-bold" runat="server"></asp:Label>
                                <br />
                                <asp:Label ID="lblDescrizione" CssClass="card-text fw-semibold" runat="server"></asp:Label>
                                <div class="badge bg-dark position-absolute pstn">
                                <asp:Label ID="lblPrezzo" CssClass="card-text text-light" runat="server"></asp:Label>
                                    </div>

                            </div>
                            <div class="d-flex align-items-end justify-content-end">
                                <asp:Button ID="btnAggiungiCarrello" runat="server" CssClass="btn btn-outline-secondary" Text="Aggiungi al carrello" OnClick="BtnAggiungiCarrello_Click" />
                            </div>
                        </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
