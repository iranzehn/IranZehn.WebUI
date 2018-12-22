<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeBehind="Test.aspx.vb" Inherits="IranZehn.Pages.Tests.MBTI.Test" Title=".: Iran Zehn :. ( MBTI Test )" %>

<%@ Register Src="UserControls/SelectIE.ascx" TagName="SelectIE" TagPrefix="uc3" %>
<%@ Register Src="UserControls/SelectSN.ascx" TagName="SelectSN" TagPrefix="uc4" %>
<%@ Register Src="UserControls/SelectFT.ascx" TagName="SelectFT" TagPrefix="uc5" %>
<%@ Register Src="UserControls/SelectPJ.ascx" TagName="SelectPJ" TagPrefix="uc6" %>
<%@ Register Src="UserControls/Step02.ascx" TagName="Step02" TagPrefix="uc2" %>
<%@ Register Src="UserControls/Step01.ascx" TagName="Step01" TagPrefix="uc1" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <!-- Google Invisible Captcha -->
    <script src="https://www.google.com/recaptcha/api.js" async="async" defer="defer"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

   <%-- <div id="googleRecaptchadiv">
        <div id="recaptcha-demo" class="g-recaptcha" data-sitekey="6LficlMUAAAAAMIQjKCzjKOQm5Xf7GBmF9YA0oeF" ></div>
        <br />
        <script type="text/javascript">
            function onSubmit(token) {
                document.getElementById("ContentPlaceHolder1_Wizard1_StartNavigationTemplateContainerID_StartNextButton").click();
            }
        </script>
    </div>--%>

    <div>
        <div style="direction: rtl; text-align: right;">
            <asp:Wizard ID="Wizard1" runat="server"
                ActiveStepIndex="0"
                StartNextButtonText="تایید"
                FinishCompleteButtonText="مشاهده نتیجه آزمون"
                FinishPreviousButtonText="صفحه قبلی"
                StepNextButtonText="صفحه بعدی"
                StepPreviousButtonText="صفحه قبلی" DisplaySideBar='false'
                Style='width: 85%; font-family: tahoma;'>
                <StartNextButtonStyle Font-Names="Tahoma" />
                <WizardSteps>
                    <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1">
                        <uc1:Step01 ID="Step01_1" runat="server" />
                    </asp:WizardStep>
                    <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2">
                        <uc2:Step02 ID="Step02_1" runat="server" />
                    </asp:WizardStep>
                    <asp:WizardStep ID="WizardStep3" runat="server" Title="Step 3-1">
                        <uc3:SelectIE ID="SelectIE1" runat="server" />
                    </asp:WizardStep>
                    <asp:WizardStep ID="WizardStep4" runat="server" Title="Step 3-2">
                        <uc4:SelectSN ID="SelectSN1" runat="server" />
                    </asp:WizardStep>
                    <asp:WizardStep ID="WizardStep5" runat="server" Title="Step 3-3">
                        <uc5:SelectFT ID="SelectFT1" runat="server" />
                    </asp:WizardStep>
                    <asp:WizardStep ID="WizardStep6" runat="server" Title="Step 3-4">
                        <uc6:SelectPJ ID="SelectPJ1" runat="server" />
                    </asp:WizardStep>
                </WizardSteps>
                <FinishCompleteButtonStyle Font-Names="Tahoma" />
                <FinishPreviousButtonStyle Font-Names="Tahoma" />
                <StepNextButtonStyle Font-Names="Tahoma" />
                <StepPreviousButtonStyle Font-Names="Tahoma" />
            </asp:Wizard>
        </div>

    </div>
</asp:Content>


