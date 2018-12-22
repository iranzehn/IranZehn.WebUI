Imports IranZehn.Classes

Namespace Pages.Tests.MBTI

    Public Class Test
        Inherits Classes.BasePage

        Private cTestGenerator As New Classes.TestGenerator.YangTestGenerator
        Private Sub CheckStepValidaty(ByVal CurrentStep As Integer)
            'Try

            LogManagement.BLL.LogManagement.LogTrace("Step " + CurrentStep.ToString(), Session.SessionID, "Step " + CurrentStep.ToString() + " Started...")
            Dim tp As TypeObject = Session("TestObject")
            If tp Is Nothing Then
                If CurrentStep > 1 Then
                    Wizard1.ActiveStepIndex = 0
                    Exit Sub
                End If
                tp = cTestGenerator.CheckExamResult(Step02_1.Step02Result)
                Session("TestObject") = tp
            End If
            Select Case CurrentStep
                Case 2
                    Select Case SelectIE1.IsIntroverted
                        Case 1
                            tp.I = 1
                            tp.E = 0
                        Case 0
                            tp.E = 1
                            tp.I = 0
                    End Select
                Case 3
                    Select Case SelectSN1.IsSensitive
                        Case 1
                            tp.S = 1
                            tp.N = 0
                        Case 0
                            tp.N = 1
                            tp.S = 0
                    End Select
                Case 4
                    Select Case SelectFT1.IsThinker
                        Case 1
                            tp.T = 1
                            tp.F = 0
                        Case 0
                            tp.F = 1
                            tp.T = 0
                    End Select
                Case 5
                    Select Case SelectPJ1.IsJudger
                        Case 1
                            tp.J = 1
                            tp.P = 0
                        Case 0
                            tp.P = 1
                            tp.J = 0
                    End Select
            End Select
            If Not Step01_1.ValidateControl Then
                Wizard1.ActiveStepIndex = 0
            ElseIf tp.ItemPercent(1) = 0 Then
                Wizard1.ActiveStepIndex = 2
            ElseIf tp.ItemPercent(2) = 0 Then
                Wizard1.ActiveStepIndex = 3
            ElseIf tp.ItemPercent(3) = 0 Then
                Wizard1.ActiveStepIndex = 4
            ElseIf tp.ItemPercent(4) = 0 Then
                Wizard1.ActiveStepIndex = 5
            Else
                PrepareResult()
            End If
            'Catch ex As Exception
            '    MsgBox("Test-CheckStepValidity")
            'End Try
            LogManagement.BLL.LogManagement.LogTrace("Step " + CurrentStep.ToString(), Session.SessionID, "Step " + CurrentStep.ToString() + " Done.")
        End Sub
        Private Sub PrepareResult()

            Dim tp As TypeObject = Session("TestObject")
            If SelectPJ1.IsJudger = 1 Then
                tp.J = 1
                tp.P = 0
            ElseIf SelectPJ1.IsJudger = 0 Then
                tp.P = 1
                tp.J = 0
            End If
            If tp.ItemPercent(4) = 0 Then
                Exit Sub
            End If
            Dim c As New TestGenerator.YangTestGenerator.TestResultObject '=nothing
            With c
                Try
                    .IPAddress = Request.UserHostAddress
                Catch ex As Exception
                    .IPAddress = "N/A"
                End Try

                .BornData = Step01_1.BornDate
                .GraduateID = Step01_1.GraduateID
                .SexID = Step01_1.SexID
                .MarriageStatusID = Step01_1.MarriageStatusID
                .TestDetails = Step02_1.Step02Result
            End With
            cTestGenerator.SaveTestResultDetails(c, tp)
            Dim strURL As String = "../../../MBTITypes.aspx?type=" + tp.ToString
            Response.Redirect(strURL, False)

        End Sub
        Protected Sub Wizard1_NextButtonClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.WizardNavigationEventArgs) Handles Wizard1.NextButtonClick

            Select Case e.CurrentStepIndex
                Case 0 'Validate FirstInformations
                    If Not Step01_1.ValidateControl Then
                        e.Cancel = True
                    End If
                    LogManagement.BLL.LogManagement.LogTrace("Step 0", Session.SessionID, "Step 0 Done")
                Case Else
                    CheckStepValidaty(e.CurrentStepIndex)

            End Select

        End Sub
        Protected Sub Wizard1_FinishButtonClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.WizardNavigationEventArgs) Handles Wizard1.FinishButtonClick
            CheckStepValidaty(e.CurrentStepIndex)
        End Sub
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Not IsPostBack Then
                Session("TestObject") = Nothing
            End If
        End Sub

    End Class

End Namespace