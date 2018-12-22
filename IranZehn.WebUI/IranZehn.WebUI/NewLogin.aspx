<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="NewLogin.aspx.vb" Inherits="IranZehn.NewLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Table ID="Table1" runat="server">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <input id="rbPersonalAccount" type="radio" value="true" checked="1" onclick="f()" />  حساب شخصی
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <input id="rbBusinessAccount" type="radio" value="false" />  حساب تجاری
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
            <p id="panelPersonal">
                 با افتتاح حساب کاربر شخصی 
            </p>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>

    </div>
</asp:Content>
