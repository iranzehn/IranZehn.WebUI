<%@ Page Title=".: Iran Zehn :. ( Relationship )" 
         Language="vb" 
         MasterPageFile="~/MasterPage.master" 
         AutoEventWireup="false"
         CodeBehind="CompleteTable.aspx.vb" 
         Inherits ="IranZehn.CompleteTable"  %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">

        function FixNum(num) {
            if (num.toString().length == 1) {
                return "0" + num.toString();
            }
            return num.toString();
        }
        function SetColor(txt, color) {
            var str = txt.id;
            var r = str.substring(3, 5);
            var c = str.substring(5, 7);
            if (r != 0 && c != 0) {
                for (var i = 1; i <= r; i++) {
                    var obj1 = document.getElementById("txt" + FixNum(i) + FixNum(c));
                    obj1.style.background = color;
                }
                for (var j = 1; j <= c; j++) {
                    var obj2 = document.getElementById("txt" + FixNum(r) + FixNum(j));
                    obj2.style.background = color;
                }
            }
        }
        function txt_onmouseover(txt) {
            SetColor(txt, '#CCCCCC');
            //txt.style.Cursor='pointer';
        }
        function txt_onmouseout(txt) {
            SetColor(txt, 'transparent');
            //txt.style.Cursor='default';
        }
        function txt_onmousedown(txt) {
            var str = txt.value.replace("<", "1").replace(">", "2");
            var r = txt.id.substring(3, 5);
            var c = txt.id.substring(5, 7);
            var obj2 = document.getElementById("txt" + FixNum(r) + FixNum(0));
            var obj1 = document.getElementById("txt" + FixNum(0) + FixNum(c));
            //navigate("?rln="+str+"&t1="+obj1.value+"&t2="+obj2.value);
            GotoUrl(str, obj1.value, obj2.value);
        }
        function GotoUrl(rln, t1, t2) {
            navigate("?rln=" + rln + "&t1=" + t1 + "&t2=" + t2);
        }

    </script>

    <table class="">
        <tr>
            <td style="text-align: right; color: #000000">* شما می توانید روابط بین تیپ های مختلف را بر اساس الگوی <a href='../../AboutSocionics.aspx'>سوشینیکس</a>&nbsp;&nbsp; دریابید.<br />
                * کلیه روابط بر اساس نظریه های روانشناسی و ترکیب سیستم میرز - بریگز &nbsp;بوده&nbsp;
                و صد در صد تضمین شده نیستند .
                <br />
                * بهترین روابط برای&nbsp; ازدواج ، همکاری و دوستی طولانی مدت به ترتیب&nbsp; <span
                    style='color: #FF0000'>همزاد</span> ، <span style='color: #FF0000'>همانند</span>
                ، <span style='color: #FF0000'>فعالیت</span> و <span style='color: #FF0000'>آینه</span>
                هستند .&nbsp;
                <br />
                <asp:Label runat="server">تیپ 1</asp:Label>
                <asp:DropDownList ID="ddlType01" runat="server">
                    <asp:ListItem>INTJ</asp:ListItem>
                </asp:DropDownList>
                <asp:Label runat="server">تیپ 2</asp:Label>
                <asp:DropDownList ID="ddlType02" runat="server">
                    <asp:ListItem>INTJ</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnRelation" runat='server' Font-Names="Tahoma" Text="رابطه" Style="height: 26px" />
                <br />
            </td>
        </tr>
        <tr>
            <td>
                <asp:PlaceHolder ID="PlaceHolder1" runat="server" EnableTheming="True"></asp:PlaceHolder>
                <br />
                <asp:ImageButton ID="ibPrint" runat="server" ImageUrl="~/images/Printer.png"
                    Style="" Visible="False" Width="16px" ToolTip="نسخه قابل چاپ" />
            </td>
        </tr>
    </table>

</asp:Content>
