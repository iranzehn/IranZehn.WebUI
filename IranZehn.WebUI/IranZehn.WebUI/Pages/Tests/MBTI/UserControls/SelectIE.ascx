<%@ Control Language="VB" AutoEventWireup="false" CodeBehind="SelectIE.ascx.vb" Inherits="IranZehn.Pages.Tests.MBTI.UserControls.SelectIE" %>
<table>
    <tr>
        <td style="width: 100%; direction: rtl; font-family: tahoma; height: 193px">
            لطفا از دو ستون زیر آن موردی را که به شما نزدیک تر است انتخاب نمایید<br />
            <table style="width: 100%">
                <tr>
                    <td style="width: 50%; background-color: #ccff66; text-align: right">
                        - علاقمند به صحبت و تبادل<br />
                        - لذت بردن از گروه ها<br />
                        - اول حرف می زنم بعد فکر می کنم<br />
                        - گسترش انرژی<br />
                        - توجه به بیرون<br />
                        - اهل صحبت<br />
                        - علاقمند به تنوع و عمل<br />
                        - معاشرتی<br />
                        - فکر کردن به صدای بلند<br />
                        - لذت بردن از بحث</td>
                    <td style="width: 50%; background-color: #66cc66; text-align: right">
                        - علاقمند به تنهایی<br />
                        - لذت بردن از صحبت دو نفری<br />
                        - اول فکر می کنم بعد حرف می زنم<br />
                        - تمرکز انرژی<br />
                        - توجه به درون<br />
                        - ساکت<br />
                        - توجه به یک موضوع در هر زمان<br />
                        - در خود و محطاط<br />
                        - در خود فکر کردن<br />
                        - لذت بردن از فکر کردن</td>
                </tr>
                <tr>
                    <td colspan="1" style="background-color: #ccff66; text-align: center">
                        <asp:RadioButton ID="rbE" runat="server" GroupName="IE" /></td>
                    <td colspan="2" style="background-color: #66cc66; text-align: center">
                        <asp:RadioButton ID="rbI" runat="server" GroupName="IE" /></td>
                </tr>
            </table>
            </td>
    </tr>
</table>
<br />
