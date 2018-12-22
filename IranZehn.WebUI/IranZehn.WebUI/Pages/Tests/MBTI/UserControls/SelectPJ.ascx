<%@ Control Language="VB" AutoEventWireup="false" CodeBehind="SelectPJ.ascx.vb" Inherits="IranZehn.Pages.Tests.MBTI.UserControls.SelectPJ" %>
<table>
    <tr>
        <td style="width: 100%; direction: rtl; font-family: tahoma; height: 210px">
            لطفا از دو ستون زیر آن موردی را که به شما نزدیک تر است انتخاب نمایید<br />
            <table style="width: 100%">
                <tr>
                    <td style="width: 50%; background-color: #ccff66; text-align: right">
                        - توجه به بسته بودن<br />
                        - توجه به ساختار<br />
                        - برنامه ریزی از قبل<br />
                        - علاقه به نظم<br />
                        - اول کار بعد تفریح<br />
                        - تمایل به تمام کردن پروژه<br />
                        - هدف گرا<br />
                        - ساختار زیاد<br />
                        - توجه به تصمیم گیری<br />
                    </td>
                    <td style="width: 50%; background-color: #66cc66; text-align: right" dir="rtl">
                        - توجه به باز بودن<br />
                        - توجه به جریان<br />
                        - سازگار کردن خود با جریان<br />
                        - علاقه به انعطاف پذیری<br />
                        - اول تفریح بعد کار<br />
                        - تمایل به شروع کردن پروژه ها<br />
                        - فرایند گرا<br />
                        - عدم سخت گیری<br />
                        - توجه به خود به خودی</td>
                </tr>
                <tr>
                    <td colspan="1" style="background-color: #ccff66; text-align: center">
                        <asp:RadioButton ID="rbJ" runat="server" GroupName="IE" /></td>
                    <td colspan="2" style="background-color: #66cc66; text-align: center">
                        <asp:RadioButton ID="rbP" runat="server" GroupName="IE" /></td>
                </tr>
            </table>
            </td>
    </tr>
</table>
