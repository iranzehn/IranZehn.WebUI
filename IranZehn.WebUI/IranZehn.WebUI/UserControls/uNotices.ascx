<%@ Control Language="VB" AutoEventWireup="false" CodeBehind="uNotices.ascx.vb" Inherits="IranZehn.uNotices" %>
<table dir="rtl" style="width: 100%; vertical-align: middle">
    <tr>
        <td>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                BackColor="White" BorderColor="#E7E7FF" BorderStyle="Solid" BorderWidth="1px"
                Caption="نکات جدید" CellPadding="3" GridLines="Horizontal" Height="16px" PageSize="5"
                Width="100%" AllowSorting="False">
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <Columns>
                    <asp:BoundField DataField="NDate" HeaderText="تاریخ" SortExpression="NDate">
                        <ItemStyle HorizontalAlign="center" />
                    </asp:BoundField>
                    <%--
                    <asp:HyperLinkField DataTextField="NDate" HeaderText="تاریخ" DataNavigateUrlFields="NoticeID"
                        DataNavigateUrlFormatString="..\News.aspx?ID={0}" 
                        SortExpression="NDate" >
                        <ControlStyle Width="75px" />
                    </asp:HyperLinkField>
                    --%>
                    <%--
                    <asp:BoundField DataField="NoticeTitle" HeaderText="عنوان" >
                        <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    --%>
                    <asp:HyperLinkField DataTextField="NoticeTitle" HeaderText="عنوان" DataNavigateUrlFields="NoticeID"
                        DataNavigateUrlFormatString="..\News.aspx?ID={0}" HeaderStyle-HorizontalAlign="Right"
                        SortExpression="NoticeTitle" ControlStyle-Font-Underline="false" ControlStyle-Font-Bold="true" ItemStyle-HorizontalAlign="Right">
                    </asp:HyperLinkField>
                </Columns>
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" Wrap="True" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <HeaderStyle BackColor="#66FF33" Font-Bold="True" ForeColor="#003300" />
                <AlternatingRowStyle BackColor="#F7F7F7" />
            </asp:GridView>
        </td>
    </tr>
</table>
