<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false"
    CodeBehind="News.aspx.vb" Inherits="IranZehn.News" Title=".: Iran Zehn :. ( Notices )" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="Panel2" runat="server" style="text-align:right;">
        <asp:Label ID="lblTitle" runat="server" Text="  " Font-Bold="True" ForeColor="Red"></asp:Label>
        <br />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <br />
    </asp:Panel>
</asp:Content>
