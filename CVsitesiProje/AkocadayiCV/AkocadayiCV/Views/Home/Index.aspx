<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

         <%--<%@using (Html.BeginForm(null, null, FormMethod.Post, new { id = "contact-form", action = "/index" }))%>

       <%if(ViewBag.Success != null && ViewBag.Success){%>
        {
        <div id="wrapper">
            <div id="message-sent">
                <div id="close-button">
                    <span>X</span>
                </div>
                <span>Mesajınız başarıyla gönderilmiştir.</span>
            </div>
        </div>
    }       --%>
    
                 <%using(Html.BeginForm()){ %>
        
                    <div class="col_2">
                        <label for="fullname">Adınız:</label>
                      <input name="adi" type="text" class="input_field" id="fullname" maxlength="30" />
                        <div class="clear"></div>
                    </div>
                    <div class="col_2 no_margin_right">
                      <label for="subject">Soyadınız:</label>
                      <input name="soyadi" type="text" class="input_field" id="surname" maxlength="30" />
                        <div class="clear"></div>
                    </div>
                    <div class="col_2">
                      <label for="fullname">Telefon:</label>
                      <input name="telefon" type="text" class="input_field" id="phone" maxlength="20" />
                        <div class="clear"></div>
                    </div>
             <div class="col_2 no_margin_right">
                      <label for="subject">Email:</label>
                      <input name="email" type="text" class="input_field" id="email" maxlength="30" />
                        <div class="clear"></div>
                    </div>
             <div class="col_2">
                      <label for="fullname">Cinisyet:</label>
                      <input name="cins" type="text" class="input_field" id="cinsiyet" maxlength="20" />
                        <div class="clear"></div>
                    </div>
             <div class="col_2 no_margin_right">
                      <label for="subject">Askerlik Durumu:</label>
                      <input name="askerlik" type="text" class="input_field" id="askerlik" maxlength="30" />
                        <div class="clear"></div>
                    </div>
             <div class="col_2">
                      <label for="fullname">Mezun Olunan Okul:</label>
                      <input name="okul" type="text" class="input_field" id="okul" maxlength="20" />
                        <div class="clear"></div>
                    </div>
             <div class="col_2 no_margin_right">
                      <label for="subject">İş Geçmişi:</label>
                      <input name="tecrube" type="text" class="input_field" id="tecrube" maxlength="30" />
                        <div class="clear"></div>
                    </div>
             <div class="col_2">
                      <label for="fullname">Yabancı Diller:</label>
                      <input name="ydil" type="text" class="input_field" id="ydil" maxlength="20" />
                        <div class="clear"></div>
                    </div>
             <div class="col_2 no_margin_right">
                      <label for="subject">Çalışmak İstenen Pozisyon:</label>
                      <input name="pozisyon" type="text" class="input_field" id="pozisyon" maxlength="30" />
                        <div class="clear"></div>
                    </div>
             <div>
             <label for="text">Eklemek İstediğiniz Bir Şey Var Mı?:</label> <textarea id="text" name="text" rows="0" cols="0" class="required"></textarea>
                  </div>
             <div> 
                    <input type="submit" name="Submit" value="Gönder" class="submit_btn left" />
                    <input type="reset" name="Reset" value="Temizle" class="submit_btn right" />
             <% }%>                     
             </div> 

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet" href="<%:Url.Content("~/Content/css/nivo-slider.css")%>" type="text/css" media="screen" />
</asp:Content>
<%--  --%>