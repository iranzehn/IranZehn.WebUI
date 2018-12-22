<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false"
    CodeFile="Facebook.aspx.vb" Inherits="Facebook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="color: Black; text-align: right;">
        با ارسال نتیجه تست به فیس بوک شما قادر خواهید بود رابطه خود با دوستانتان را در فیس
        بوک به راحتی ببینید .
        <br />
        لطفا برای ارسال نتیجه تست خود به فیس بوک از روش زیر استفاده کنید : برای حفظ امنیت
        اطلاعات شما در فیس بوک این سیستم به صورت دو مرحله نصب و اتصال طراحی شده است .
        <br />
        1- ابتدا بر روی لینک زیر کلیک کرده تا اپلیکیشن ایران ذهن را روی فیس بوک خود نصب
        کنید:<br />
        <a href="http://facebook.iranzehn.com">http://facebook.iranzehn.com</a><br />
        <a href="images/Facebook_Step1.png">
            <asp:Image ID="Image1" runat="server" Height="328px" ImageUrl="~/images/Facebook_Step1.png" />
        </a><a href="images/Facebook_Step2.png">
            <asp:Image ID="Image2" runat="server" Height="328px" ImageUrl="~/images/Facebook_Step2.png" />
        </a>
        <br />
        &nbsp;<br />
        2- بعد از نصب برنامه&nbsp; روی دکمه زیر کلیک کرده تا تیپ شخصیتی خود را به فیس بوک
        ارسال نمایید.<br />
        <asp:Button ID="btnSendToFacebook" runat="server" Font-Names="Tahoma" Text="ارسال به فیس بوک" />
        <br />
        &nbsp;<br />
        &nbsp;<br />
    </div>
</asp:Content>
