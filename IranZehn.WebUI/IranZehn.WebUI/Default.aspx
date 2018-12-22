<%@ Page Language="VB" 
         MasterPageFile="~/MasterPage.master" 
         AutoEventWireup="false"
         CodeBehind="Default.aspx.vb" Inherits="IranZehn.Default2" Title=".: Iran Zehn :." %>

<%@ Register Src="UserControls/uNotices.ascx" TagName="uNotices" TagPrefix="uc1" %>
<%@ Register Src="UserControls/uRegister.ascx" TagName="uRegister" TagPrefix="uc2" %>
<%@ Register Src="UserControls/uVisit.ascx" TagName="uVisit" TagPrefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script language="jscript" src="JScript.js" type="text/javascript"></script>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 21px;
        }
        .style3
        {
            width: 15%;
        }
        .style4
        {
            direction: rtl;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center style="font-size: larger; font-family: tahoma" class="style4">
        <table style="width: 464px; font-family: tahoma">
            <tr>
                <td colspan="3" style="font-size: smaller; color: teal; direction: rtl; font-family: tahoma;
                    height: 20px; text-align: center">
                    &nbsp;سعی نکن چیزی که نیستی باشی ، از توانمندیهایت لذت ببر
                </td>
            </tr>
            <tr>
                <td colspan="3" style="font-weight: bold; font-size: smaller; color: teal; direction: rtl;
                    font-style: italic; font-family: tahoma; height: 21px; text-align: center">
                    کارل گوستاو یونگ
                </td>
            </tr>
        </table>
        <br />
        <span style="font-size: 10pt; color: #0000ff; font-family: tahoma">این سایت سعی دارد
            تا براساس آزمون میرز-بریگز <a href="AboutMBTI.aspx">( MBTI )</a> مشخصات شخصیتی شما
            را اعلام نماید </span><span style="font-size: 10pt; color: #0000ff; font-family: tahoma">
            </span>
        <br />
        <br />
        <table cellpadding="0" cellspacing="0">
            <tbody>
                <tr valign="top">
                    <td align='center'>
                        <input style="font-family: tahoma" type="button" value="شروع آزمون" id="btnStart"
                            onclick="GoUrl('Pages/Tests/MBTI/Test.aspx')" />
                    </td>
                </tr>
            </tbody>
        </table>
        <div class="style4">
            <br />
        </div>
        <table class="style1">
            <tr>
                <td style="font-size: small; text-align: center;" class="style3" rowspan="2" valign="middle">
                    آمار بازدید کل
                    <br />
                    <asp:Label runat='server' ID="lblTotalVisit" Text="12000"></asp:Label>
                </td>
                <td style="width: 50%; font-size: small; height: 60px; direction: ltr;">
                    <uc1:uNotices ID="uNews1" runat="server" EnableViewState="True" />
                </td>
                <td style="font-size: small; text-align: center;" class="style3" rowspan="2">
                    آمار بازدید امروز
                    <br />
                    <asp:Label runat='server' ID="lblTodayVisit" Text="12000"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2" style="text-align: center">
                </td>
            </tr>
        </table>
    </center>
</asp:Content>
