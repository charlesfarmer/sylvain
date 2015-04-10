<%@ Page Title="Connexion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="InterfaceClient.Account.Login" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
    </hgroup>
        <h2>Utilisez votre code et votre mot de passe.</h2>
        
                <fieldset>
                    <legend>Log in Form</legend>
                    <ol>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="UserName">Code d'identification</asp:Label>
                            <asp:TextBox runat="server" ID="UserName" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="Un code d'identification est requis." />
                        </li>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="Password">Mot de passe</asp:Label>
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="field-validation-error" ErrorMessage="Un mot de passe est requis." />
                        </li>
                    </ol>
                    <asp:Button runat="server" onclick="Login_Click" Text="Me connecter" />
                </fieldset>
          
        <p>
            <asp:HyperLink NavigateUrl="~/Account/Register.aspx" runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled">Créer un nouveau compte</asp:HyperLink>
            puisque je suis nouveau ici.
        </p>
</asp:Content>
