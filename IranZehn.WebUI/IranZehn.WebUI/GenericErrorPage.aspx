<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="GenericErrorPage.aspx.vb" Inherits="IranZehn.GenericErrorPage" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>.: Iran Zehn :.</title>
</head>
<body>

    <form id="form1" runat="server">

        <p dir="rtl" style="font-family: tahoma; text-align: center;">
            <a href="Default.aspx">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Iranzehn.png" />
            </a>
        </p>
        <p dir="rtl" style="font-family: tahoma; text-align: center;">
            متاسفانه خطایی در هنگام اجرا روی داده است.
        </p>
        <p dir="rtl" style="font-family: tahoma; text-align: center;">
            تیم ایران ذهن در حال بررسی و حل مشکل می باشد.
        </p>
        <p dir="rtl" style="font-family: tahoma; text-align: center;">
            لطفا لحظاتی بعد مجددا تلاش نمایید.
        </p>
        <p dir="rtl" style="font-family: tahoma; text-align: center;">
            &nbsp;
        </p>
        <p dir="rtl" style="font-family: tahoma; text-align: center;">
            با تشکر
        </p>
        <p dir="rtl" style="font-family: tahoma; text-align: center;">
            تیم
        پشتیبانی سایت ایران ذهن
        </p>
        <p dir="rtl" style="font-family: tahoma; text-align: center;">
            &nbsp;
        </p>
        <p dir="rtl" style="font-family: tahoma; text-align: center;">
            &nbsp;
        </p>
        <p dir="ltr" style="font-family: tahoma; text-align: center;">
            <asp:Label ID="lblUnexpectedError" runat="server"></asp:Label>
        </p>
        <p dir="rtl" style="font-family: tahoma; text-align: center;">
            <a href="default.aspx">بازگشت به صفحه اصلی</a>
        </p>
    </form>



</body>
</html>
