<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="uLogin.ascx.vb" Inherits="IranZehn.uLogin" %>
<div style="width: 100%; margin: 5px 5px 5px 5px; direction: rtl; -moz-border-radius: 10px; -webkit-border-radius: 10px; border-radius: 10px; background-color:  #FFFFFF">
    <asp:Table ID="tblLogin" runat="server" style="margin-top: 0px">
        <asp:TableRow>
            <asp:TableCell ColumnSpan="2"><p style="color:black;font-weight:100">ورود به سیستم</p></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>نام کاربری</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            
</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>کلمه عبور</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:TextBox ID="txtPassword" runat="server" Style="margin-bottom: 0px"></asp:TextBox>
            
</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="btnSubmit" runat="server" Text="ورود"></asp:Button>
            
</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow HorizontalAlign="Left">
            <asp:TableCell>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/NewLogin.aspx">ثبت عضو جدید</asp:HyperLink>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <br />
</div>
