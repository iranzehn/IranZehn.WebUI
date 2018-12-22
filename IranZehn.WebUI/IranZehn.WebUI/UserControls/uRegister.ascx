<%@ Control Language="VB" AutoEventWireup="false" CodeBehind="uRegister.ascx.vb" Inherits="IranZehn.uRegister" %>
<table dir="rtl" style="width:100px;text-align:center; vertical-align:middle; font-family:Tahoma; font-size:small">
    <tr>
        <td style="color:#000080; height: auto;">
            پست الکترونیک شما
        </td>
    </tr>
    <tr>
        <td style="direction:ltr;vertical-align:top">
            <asp:TextBox ID="txtEmail" runat="server" Width="91px" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="font-family:Tahoma;font-size:small">
            <asp:Button ID="btnSubmit" runat="server" PostBackUrl="~/Default2.aspx" 
                Text="ثبت نام" Font-Names="Tahoma" />
        </td>
    </tr>
</table>

 

