<%@ Page Title="Liste des cours" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InterfaceClient._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2></h2>
            </hgroup>
            <p>
                Inscrivez-vous aux cours qui sont disponibles.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <table>
        <tbody>
            <tr>
                <td style="vertical-align:top">
                    <h3>Cours disponibles:</h3>
                    <ol class="round">
                        <li>
                            <h5>Natation sous-marine</h5>
                            Horaire: Mardi, 21h-23h
                            <br />
                            Date limite d'inscription: 3 Avril 2015
                            <br />
                            <a>S'inscrire…</a>
                        </li>
                        <li>
                            <h5>Histoire de l'Estonie</h5>
                            Horaire: Samedi, 14h-16h
                            <br />
                            Date limite d'inscription: 14 Avril 2015
                            <br />
                            <a>S'inscrire…</a>
                        </li>
                        <li>
                            <h5>Développement... de photos!</h5>
                            Horaire: Dimanche, 9h-12h
                            <br />
                            Date limite d'inscription: 8 Mai 2015
                            <br />
                            <a>S'inscrire…</a>
                        </li>
                    </ol>
                </td>
                <td style="vertical-align:top">
                    <h3>Cours auxquels vous êtes inscrit:</h3>
                    <ol class="round">
                        <li>
                            <h5>Physique quantique avancée</h5>
                            Horaire: Jeudi, 18h-22h
                            <br />
                            Solde à payer: 560.99$
                            <br />
                            <a>Annuler l'inscription…</a>
                        </li>
                    </ol>
                </td>
            </tr>
        </tbody>
    </table>

</asp:Content>
