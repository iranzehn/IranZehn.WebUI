<%@ Control Language="VB" AutoEventWireup="false" CodeBehind="SelectFT.ascx.vb" Inherits="IranZehn.Pages.Tests.MBTI.UserControls.SelectFT" %>
<table>
    <tr>
        <td style="width: 100%; direction: rtl; font-family: tahoma; height: 191px">
            لطفا از دو ستون زیر آن موردی را که به شما نزدیک تر است انتخاب نمایید<br />
            <table style="width: 100%">
                <tr>
                    <td style="width: 50%; background-color: #ccff66; text-align: right">
                        - ذهن محکم دارند<br />
                        - مسئله را تحلیل می کنند<br />
                        - ذهنی هستند ، با منطبق مجاب می شوند<br />
                        - رک و صریح هستند<br />
                        - برای صلاحیت و شایستگی ارزش قایل اند<br />
                        - با مغز خود تصمیم می گیرند<br />
                        - در استناد کردن مهارت دارند<br />
                        - به عدالت بها می دهند<br />
                        - ممکن است بی احساس ارزیابی شوند<br />
                        - معمولا موضوعات را شخصی نمی کنند</td>
                    <td style="width: 50%; background-color: #66cc66; text-align: right" dir="rtl">
                        - دل ملایمی دارند ، مهربان هستند<br />
                        - با مسئله همدردی می کنند<br />
                        - عینی هستند<br />
                        - مودب هستند<br />
                        - به روابط بها می دهند<br />
                        - با دل خود تصمیم می گیرند<br />
                        - به هماهنگی بها می دهند<br />
                        - در قدردانی کردن مهارت دارند<br />
                        - ممکن است بیش از اندازه احساسی ارزیابی شوند<br />
                        - معمولا موضوعات را شخصی می کنند</td>
                </tr>
                <tr>
                    <td colspan="1" style="background-color: #ccff66; text-align: center">
                        <asp:RadioButton ID="rbT" runat="server" GroupName="IE" /></td>
                    <td colspan="2" style="background-color: #66cc66; text-align: center">
                        <asp:RadioButton ID="rbF" runat="server" GroupName="IE" /></td>
                </tr>
            </table>
            </td>
    </tr>
</table>
