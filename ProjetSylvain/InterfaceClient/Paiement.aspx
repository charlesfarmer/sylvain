<%@ Page Title="Paiement" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paiement.aspx.cs" Inherits="InterfaceClient.About" %>

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
            <%=prix %>$
        </p>

        <p>        
            Numéro de carte de crédit:&nbsp;
            <asp:TextBox ID="carte" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="carte" Text="Veuillez entrer un numéro de carte de crédit." />
        </p>
    </article>

    <aside>
        <h3>Confirmation</h3>
        <p>        
            Vous vous apprêtez à payer <%=prix %>$. Cliquez 'Confirmer' pour confirmer.
        </p>
        <asp:Button runat="server" Text="Confirmer" OnClick="Pay" />
    </aside>
</asp:Content>