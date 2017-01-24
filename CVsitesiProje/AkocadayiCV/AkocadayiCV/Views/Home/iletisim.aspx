<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    iletisim
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

        	
            <h1>İletişim</h1>
            <div class="content_wrapper content_mb_60">
            <div id="contact_form">
                <h3>İletişim Formu</h3>
                <form method="post" name="contact" action="#">
                    <div class="col_2">
                        <label for="fullname">İsminiz:</label>
                      <input name="fullname" type="text" class="input_field" id="fullname" maxlength="30" />
                        <div class="clear"></div>
                    </div>
                    <div class="col_2 no_margin_right">
                      <label for="subject">Email:</label>
                      <input name="email" type="text" class="input_field" id="email" maxlength="30" />
                        <div class="clear"></div>
                    </div>
                    <div class="col_2">
                      <label for="fullname">Telefon:</label>
                      <input name="phone" type="text" class="input_field" id="phone" maxlength="20" />
                        <div class="clear"></div>
                    </div>
                    <div class="col_2 no_margin_right">
                        <label for="subject">Konu:</label>
                      <input name="subject" type="text" class="input_field" id="subject" maxlength="50" />
                        <div class="clear"></div>
                    </div>
                    <label for="text">Mesajınız:</label> <textarea id="text" name="text" rows="0" cols="0" class="required"></textarea>
                    
                    <input type="submit" name="Submit" value="Gönder" class="submit_btn left" />
                    <input type="reset" name="Reset" value="Temizle" class="submit_btn right" />
                </form>
            </div> 
            <div class="clear"></div>
		</div>        
        <div class="content_wrapper content_mb_30">
        	<div class="col_2">
                <h3>1. Şubemiz</h3>
                Mehmet Akif Ersoy Mahallesi<br />
             Atatürk Caddesi NO : 3/8<br />
                 TUZLA/İSTANBUL<br /><br />
                
                 Tel: 0216-458-98-85<br />
                 Fax: 0216-965-85-52<br /><br />
                 
			</div>
            <div class="col_2 no_margin_right">
                <h3>2. Şubemiz</h3>
                Abdurrahman Gazi Mahallesi<br />
                Atayolu Caddesi NO : 15/1<br />
                KADIKÖY/İSTANBUL<br /><br />
                
                Tel: 0216-985-74-12<br />
                Fax: 0216-452-34-85
               
			</div>
		</div>
        <h3>Harita</h3>
        <div class="img_border">
        <iframe width="630" height="150" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="http://maps.google.com/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=new+york+central+park&amp;aq=&amp;sll=37.0625,-95.677068&amp;sspn=60.158465,135.263672&amp;vpsrc=6&amp;ie=UTF8&amp;hq=&amp;hnear=Central+Park,+New+York&amp;t=m&amp;ll=40.769606,-73.973372&amp;spn=0.014284,0.033023&amp;z=14&amp;output=embed"></iframe></div><br />


</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
