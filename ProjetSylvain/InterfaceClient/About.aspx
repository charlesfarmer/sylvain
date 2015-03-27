<%@ Page Title="Paiement" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="InterfaceClient.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Payez pour le cours.</h2>
    </hgroup>

    <article>
        <p>        
            Montant à payer:
        </p>

        <p>        
            21.90$
        </p>

        <p>        
            Numéro de carte de crédit:&nbsp;
            <asp:TextBox runat="server"></asp:TextBox>
        </p>
    </article>

    <aside>
        <h3>Confirmation</h3>
        <p>        
            Vous vous apprêtez à payer 21.90$. Cliquez 'Confirmer' pour confirmer.
        </p>
        <asp:Button runat="server" Text="Confirmer" />
    </aside>
</asp:Content>