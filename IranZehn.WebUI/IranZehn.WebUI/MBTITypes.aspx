<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false"
    CodeBehind="MBTITypes.aspx.vb" Inherits="IranZehn.MBTITypes" Title=".: Iran Zehn :. ( Type Description )" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <asp:Panel ID="pnlSend0" runat="server" 
        style='text-align: right; direction: ltr; vertical-align: bottom;font-family:Tahoma;' 
        Visible="False">
        <div >
            <asp:ImageButton ID="btnSendToFacebook0" runat="server" 
                AlternateText="ارسال نتیجه به فیس بوک" Height="38px" 
                ImageUrl="~/images/Facebook.png" ToolTip="ارسال نتیجه به فیس بوک" 
                Width="40px" />
            &nbsp;</div>
    </asp:Panel>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    <br />
    <asp:Panel ID="pnlSend1" runat="server" 
        style='text-align: right; direction: ltr; vertical-align: bottom;font-family:Tahoma;' 
        Visible="False">
        <div >
            <asp:ImageButton ID="btnSendToFacebook1" runat="server" 
                AlternateText="ارسال نتیجه به فیس بوک" Height="38px" 
                ImageUrl="~/images/Facebook.png" ToolTip="ارسال نتیجه به فیس بوک" 
                Width="38px" />
            &nbsp;</div>
    </asp:Panel>
    <br />
    <asp:ImageButton ID="ibPrint" runat="server" ImageUrl="~/images/Printer.png" Style=""
        Visible="False" Width="16px" Height="16px" ToolTip="نسخه قابل چاپ" />
    <br />
</asp:Content>
