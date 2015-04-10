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
                        <%foreach(var cours in listeCours.Where(x=>x.Inscription.All(y=>y.Etudiant.Id!=etudiantCourant.Id) && x.Ouvert)){ %>
                        <li>
                            <h5><%=cours.Sujet.Nom %></h5>
                            <%string h = "";
                              
                              foreach (var jour in cours.Horaire.Where(x=>x.Actif).Select(x => x.Jour).Distinct())
                              {
                                  h += jour.NomLong + ", ";
                                  var heures = cours.Horaire.Where(x => x.Jour.Id == jour.Id && x.Actif).Select(x => x.Heure).Distinct();
                                  h += heures.Min(x => x.Num) + "h-" + (heures.Max(x => x.Num) + 1) + "h ; ";
                              }
                            %>
                            Horaire: <%=h %>
                            <br />
                            Date limite d'inscription: <%=cours.DateLimite.ToShortDateString() %>
                            <br />
                            <a href="Paiement.aspx?type=1&coursId=<%=cours.Id %>">S'inscrire...</a>
                            
                        </li>
                        <%} %>
                    </ol>
                </td>
                <td style="vertical-align:top">
                    <h3>Cours auxquels vous êtes inscrit:</h3>
                    <ol class="round">
                        <%foreach(var cours in listeCours.Where(x=>x.Inscription.Any(y=>y.Etudiant.Id==etudiantCourant.Id))){ %>
                        <li>
                            <h5><%=cours.Sujet.Nom %></h5>
                            <%string h = "";
                              
                              foreach (var jour in cours.Horaire.Where(x=>x.Actif).Select(x => x.Jour).Distinct())
                              {
                                  h += jour.NomLong + ", ";
                                  var heures = cours.Horaire.Where(x => x.Jour.Id == jour.Id && x.Actif).Select(x => x.Heure).Distinct();
                                  h += heures.Min(x => x.Num) + "h-" + (heures.Max(x => x.Num) + 1) + "h ; ";
                              }
                            %>
                            Horaire: <%=h %>
                            <br />
                            <%var totalpaye = cours.Inscription.Single(x=>x.Etudiant.Id==etudiantCourant.Id).Paiement.Where(x=>!x.Rembourse).Sum(x=>x.Montant); %>
                            Solde à payer: <%=Math.Round((cours.Cout - totalpaye),3) %>$ <%if (totalpaye<cours.Cout){%><a href="Paiement.aspx?type=2&coursId=<%=cours.Id %>">-> Payer</a> <%}%>
                            <br />
                            <a href="Paiement.aspx?type=3&coursId=<%=cours.Id %>">Annuler l'inscription...</a>
                        </li>
                        <%} %>
                    </ol>
                </td>
            </tr>
        </tbody>
    </table>

</asp:Content>
