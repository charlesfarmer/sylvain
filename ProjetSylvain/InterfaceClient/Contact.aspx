<%@ Page Title="Profil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="InterfaceClient.Contact" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Visionnez vos informations personnelles.</h2>
    </hgroup>

    <section class="contact">
        <header>
            <h3>Nom</h3>
        </header>
        <p>
            <span class="label">Prénom:</span>
            <span>Istouch</span>
        </p>
        <p>
            <span class="label">Nom de famille:</span>
            <span>Lapoch</span>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3>Coordonnées</h3>
        </header>
        <p>
            <span class="label">Téléphone:</span>
            <span>(514) 444-1919</span>
        </p>
        <p>
            <span class="label">Adresse:</span>
            <span>12345π rue De La Rue, Vienne, Brésil</span>
        </p>
    </section>
</asp:Content>