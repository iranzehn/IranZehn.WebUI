<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PrintPreview.aspx.vb" Inherits="IranZehn.PrintPreview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>پیش نمایش چاپ</title>
</head>
<body>
    <form id="form1" runat="server">
    <div dir="rtl" style="text-align: center">
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/Iranzehn.png" />
            
    </div>
    <div dir="rtl" style="font-family: tahoma" >
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    </div>
    </form>
</body>
</html>
