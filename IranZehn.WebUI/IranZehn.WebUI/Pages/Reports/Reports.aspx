<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false"
    CodeBehind="Reports.aspx.vb" Inherits="IranZehn.Reports" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style1
        {
            width: 60%;
        }
        .style2
        {
            text-align: right;
            width: 215px;
            font-size: small;
            color: #000000;
        }
        .style3
        {
            width: 95px;
        }
        .style4
        {
            font-size: small;
            color: #000000;
        }
        .style5
        {
            font-size: small;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <p class="style4">
        به دلیل بالا بودن حجم اطلاعات از این به بعد گزارشات به صورت فایل در اختیار دوستان
        قرار می گیرد.</p>
    <p class="style4">
        تاریخ آخرین به روز رسانی :
        1394/05/14</p>
    <table class="style1">
        <tr>
            <td class="style2" style="border: thin solid #000000">
                &nbsp; گزارش کلیات
            </td>
            <td class="style3" style="border: thin solid #000000">
                <a href="rpTotal.pdf"><span class="style5">PDF</span></a> 
            </td>
            <td style="border: thin solid #000000" class="style5">
                <a href="rpTotal.xlsx">Excel</a>  
            </td>
        </tr>
        <tr>
            <td class="style2" style="border: thin solid #000000">
                &nbsp; گزارش جنسیت
            </td>
            <td class="style3" style="border: thin solid #000000">
                <a href="rpGender.pdf"><span class="style5">PDF</span></a> 
            </td>
            <td style="border: thin solid #000000" class="style5">
                <a href="rpGender.xlsx">Excel</a>  
            </td>
        </tr>
        <tr>
            <td class="style2" style="border: thin solid #000000">
                &nbsp; گزارش تاهل
            </td>
            <td class="style3" style="border: thin solid #000000">
                <a href="rpMarriageStatus.pdf"><span class="style5">PDF</span></a>
            </td>
            <td style="border: thin solid #000000" class="style5">
                <a href="rpMarriageStatus.xlsx">Excel</a>  
            </td>
        </tr>
        <tr>
            <td class="style2" style="border: thin solid #000000; ">
                &nbsp; گزارش سطح تحصیلات
            </td>
            <td class="style3" style="border: thin solid #000000">
                <a href="rpGraduation.pdf"><span class="style5">PDF</span></a> 
            </td>
            <td style="border: thin solid #000000" class="style5">
                <a href="rpGraduation.xlsx">Excel</a>  
            </td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
</asp:Content>
