<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/SiteAdmin.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<AkocadayiCV.Models.makaleHelper>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Makalaler
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<article class="module width_full">
			<header><h3>Makaleler</h3></header>
    <%var makaleler = ViewBag.makeList; %>

    <table>
        <tr>
            <th>Makale ID</th>
            <th>Makale Adı</th>
            <th>Makale Kısa Açıklaması</th>
            <th>Makale </th>
            <th>Keyword</th>
            <th>Description</th>
            <th>Yazar Adı</th>
            <th>Title</th>
            <th colspan="2">Makale Adı</th>
        </tr>
        <%foreach (var item in Model)
          {%>
              <tr>
                  <td><%=Html.DisplayName(item.makaleID.ToString()) %></td>
                  <td><%=Html.DisplayName(item.makaleAdi) %></td>
                  <td><%=Html.DisplayName(item.kategoriAdi) %></td>
                  <td><%=Html.DisplayName(item.makaleKisaAciklama) %></td>
                  <td><%=Html.DisplayName(item.makale) %></td>
                  <td><%=Html.DisplayName(item.makaleKeyword) %></td>
                  <td><%=Html.DisplayName(item.makaleDescription) %></td>
                  <td><%=Html.DisplayName(item.yazarAdi) %></td>
                  <td><%=Html.DisplayName(item.makaleTitle) %></td>
                  <td><%:Html.ActionLink("Düzenle", "makaleduzenle", new {id=item.makaleID })%></td>
                  <td><%:Html.ActionLink("Sil", "makalesil", new {id=item.makaleID })%></td>

              </tr>
          <%} %>
    </table>
    </article>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
