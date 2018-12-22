<%@ Control Language="VB" AutoEventWireup="false" CodeBehind="Step02.ascx.vb" Inherits="IranZehn.Pages.Tests.MBTI.UserControls.Step02" %>
<div dir='rtl'>
    <table style="color: navy; font-family: tahoma" >
        <tr>
            <td colspan="3" style="height: 21px">
                لطفا قبل از شروع تست به نکات زیر توجه فرمایید</td>
        </tr>
        <tr>
            <td colspan="3">
                ---------------------------------------------------------------------------------------------------------</td>
        </tr>
        <tr>
            <td colspan="3">
                1- تعداد سئوالات 80 عدد می باشد</td>
        </tr>
        <tr>
            <td colspan="3" style="height: 22px">
                2- به سئوالات با صداقت کامل جواب بدهید تا نتیجه حاصل به حقیقت نزدیک تر باشد</td>
        </tr>
        <tr>
            <td colspan="3" rowspan="1">
                3- در صورتیکه به سئوالی جواب ندهید بطور خودکار گزینه 1 محاسبه خواهد شد</td>
        </tr>
        <tr>
            <td colspan="3" rowspan="1">
                4- برای چاپ سئوالات می توانید از
                <asp:ImageButton ID="ibPrint" runat="server" ImageUrl="~/images/Printer.png" 
                    style="" Width="16px" Height="16px" 
        ToolTip="نسخه قابل چاپ" />
    &nbsp;استفاده نمایید.</td>
        </tr>
        <tr>
            <td colspan="3" rowspan="5">
            ----------------------------------------موفق باشید---------------------------------------------------
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>

    </table>
</div>
<asp:Repeater ID="Repeater1" runat="server">
    <FooterTemplate>
    </FooterTemplate>
    <HeaderTemplate>
    </HeaderTemplate>
    <ItemTemplate>
        <table>
            <tr>
                <td colspan="3" rowspan="1" style="width: 100%; color: #ff3300;font-size:12pt;color:Black">
                    <%#Container.ItemIndex+1%>
                    -
                    <%#Container.DataItem("QuestionContent")%>
                    <br />
                </td>
            </tr>
            <tr>
                <td colspan="3" rowspan="3" style="width: 100%; color: #0000cc;font-size:12pt">
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName='<%#Container.DataItem("QuestionID")%>'  Text='ابدا اینطور نیستم'/>
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName='<%#Container.DataItem("QuestionID")%>'  Text='تا اندازه ای اینطور هستم '/>
                    <asp:RadioButton ID="RadioButton3" runat="server" GroupName='<%#Container.DataItem("QuestionID")%>'  Text='کاملا اینطور هستم'/>
                    <asp:TextBox     ID="PreferenceID" runat="server" Text='<%#Container.DataItem("PreferenceID")%>' Visible='false' />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>         
        </table>
    </ItemTemplate>
</asp:Repeater>
