<%@ Page Title="Profil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profil.aspx.cs" Inherits="InterfaceClient.Contact" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Visionnez vos informations personnelles.</h2>
    </hgroup>
    <% var etu = (Session["login"] as Backend.Login).Etudiant; %>
    <section class="contact">
        
        <header>
            <h3>Nom</h3>
        </header>
        <p>
            <span class="label">Prénom:</span>
            <%=etu.Coordonnees.Prenom %>
        </p>
        <p>
            <span class="label">Nom de famille:</span>
            <%=etu.Coordonnees.Nom %>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3>Coordonnées</h3>
        </header>
        <p>
            <span class="label">Téléphone:</span>
            <%=etu.Coordonnees.Telephone %>
        </p>
        <p>
            <span class="label">Adresse:</span>
            <%=etu.Coordonnees.Adresse %>
        </p>
    </section>
</asp:Content>