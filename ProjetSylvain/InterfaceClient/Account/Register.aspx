<%@ Page Title="Inscription" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="InterfaceClient.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Inscrivez-vous au collège Ahuntsic.</h2>
    </hgroup>


    <p class="message-info">
        Votre mot de passe doit être au moins 8 caractères de long, avoir au moins une majuscule, une majuscule, un chiffre, un caractère spécial, et doit contenir votre année de naissance en hexadécimal.
    </p>

    <p class="validation-summary-errors">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <fieldset>
        <legend>Formulaire d'enregistrement</legend>
        <ol>
            <li>
                <asp:Label runat="server" AssociatedControlID="UserName">Code d'identification</asp:Label>
                <asp:TextBox runat="server" ID="UserName" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                    CssClass="field-validation-error" ErrorMessage="Un code est requis." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="Tel">Téléphone</asp:Label>
                <asp:TextBox runat="server" ID="Tel" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Tel"
                    CssClass="field-validation-error" ErrorMessage="Le numéro de téléphone est requis." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="Adresse">Adresse</asp:Label>
                <asp:TextBox runat="server" ID="Adresse" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Adresse"
                    CssClass="field-validation-error" ErrorMessage="L'adresse est requise." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="Password">Mot de passe</asp:Label>
                <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                    CssClass="field-validation-error" ErrorMessage="Un mot de passe est requis." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="ConfirmPassword">Confirmez le mot de passe</asp:Label>
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                    CssClass="field-validation-error" Display="Dynamic" ErrorMessage="La confirmation du mot de passe est requise." />
                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                    CssClass="field-validation-error" Display="Dynamic" ErrorMessage="Les deux mots de passe sont différents." />
            </li>
        </ol>
        <asp:Button runat="server" OnClick="RegisterUser" Text="Enregistrement" />
        <p>
            <asp:HyperLink NavigateUrl="~/Account/Login.aspx" runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled">Déjà inscrit?</asp:HyperLink>
        </p>
    </fieldset>

</asp:Content>
