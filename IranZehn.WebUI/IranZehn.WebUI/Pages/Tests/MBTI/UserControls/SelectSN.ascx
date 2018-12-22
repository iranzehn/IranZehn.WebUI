<%@ Control Language="VB" AutoEventWireup="false" CodeBehind="SelectSN.ascx.vb" Inherits="IranZehn.Pages.Tests.MBTI.UserControls.SelectSN" %>
<table>
    <tr>
        <td style="width: 100%; direction: rtl; font-family: tahoma; height: 205px">
            لطفا از دو ستون زیر آن موردی را که به شما نزدیک تر است انتخاب نمایید<br />
            <table style="width: 100%">
                <tr>
                    <td style="width: 50%; background-color: #ccff66; text-align: right">
                        - توجه به حقایق ، اطلاعات موثق<br />
                        - علاقمند به آنچه واقعیت دارد<br />
                        - توجه به جزئیات<br />
                        - واقع بین و عملی<br />
                        - توجه به لحظه اکنون<br />
                        - عمل گرا<br />
                        - اعتماد به تجربه گذشته<br />
                        - توجه به اشیاء و امور به شکلی که وجود دارد</td>
                    <td style="width: 50%; background-color: #66cc66; text-align: right">
                        - توجه به بینش ، فراست و اطلاعات انتزاعی<br />
                        - علاقمند به آنچه امکان پذیر و یحتمل است<br />
                        - توجه به تصویر بزرگ<br />
                        - توجه به الهام و تصور<br />
                        - توجه به آینده<br />
                        - توجه به نوآوری<br />
                        - تعمق کننده<br />
                        - اعتماد به تصور و حرف دل<br />
                        - توجه به تجربه کردن چیزهای نو</td>
                </tr>
                <tr>
                    <td colspan="1" style="background-color: #ccff66; text-align: center">
                        <asp:RadioButton ID="rbS" runat="server" GroupName="IE" /></td>
                    <td colspan="2" style="background-color: #66cc66; text-align: center">
                        <asp:RadioButton ID="rbN" runat="server" GroupName="IE" /></td>
                </tr>
            </table>
            </td>
    </tr>
</table>
