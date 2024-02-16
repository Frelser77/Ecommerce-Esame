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
                    <img src="Content/assets/images/Logo_BW.png" alt="Logo" class="position-absolute logo-pstn" Height="25" width="25"/>
                    <a href="Dettaglio.aspx?id=<%# Eval("Id") %>">
                        <div class="articolo h-100 d-flex flex-column align-items-center justify-content-between">
                            <img src='<%# Eval("ImmaginePath") %>' alt="Immagine articolo" class="w-100 my-1 producat" />
                            <div>
                                <h3 class="text-start text-black"><%# Eval("Nome") %></h3>
                                <p class="text-center text-black">Prezzo: €<%# Eval("Prezzo") %></p>
                            </div>
                        </div>
                    </a>
                </div>
            </ItemTemplate>
            <FooterTemplate>
                </div>
            </div>
       
            </FooterTemplate>
        </asp:Repeater>
    </main>


</asp:Content>
