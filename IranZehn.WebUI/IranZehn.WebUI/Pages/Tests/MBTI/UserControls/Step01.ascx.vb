Namespace Pages.Tests.MBTI.UserControls
    Partial Class Step01
        Inherits System.Web.UI.UserControl

        Public ReadOnly Property ValidateControl() As Boolean
            Get

                If ddlYear.SelectedValue < 0 Or ddlMonth.SelectedValue < 0 Or ddlDay.SelectedValue < 0 Then
                    lblError.Text = "لطفا تاریخ را صحیح وارد نمایید"
                ElseIf Not (rbMan.Checked Or rbWoman.Checked) Then
                    lblError.Text = "لطفا جنسیت را صحیح وارد نمایید"
                ElseIf Not (rbSingle.Checked Or rbMaried.Checked) Then
                    lblError.Text = "لطفا وضعیت تاهل را صحیح وارد نمایید"
                ElseIf ddlGraduation.SelectedValue < 0 Then
                    lblError.Text = "لطفا میزان تحصیلات را صحیح وارد نمایید"
                ElseIf Not Classes.CommonFunctions.IsValidCaptcha() Then '' Check Captcha
                    lblError.Text = "لطفا کد صحیح را وارد نمایید"
                Else
                    lblError.Text = ""
                    Return True
                End If

                lblError.Visible = True

                Return False

            End Get
        End Property
        'myExam.SaveTestHeader(Me.ddlYear.SelectedValue.ToString + "/" + Format(Val(Me.ddlMonth.SelectedValue), "00") + "/" + Format(Val(Me.ddlDay.SelectedValue), "00"), IIf(rbMan.Checked, 0, 1), IIf(rbSingle.Checked, 0, 1), ddlGraduation.SelectedValue)
        Public ReadOnly Property BornDate() As String
            Get
                Return Me.ddlYear.SelectedValue.ToString + "/" + Format(Val(Me.ddlMonth.SelectedValue), "00") + "/" + Format(Val(Me.ddlDay.SelectedValue), "00")
            End Get
        End Property
        Public ReadOnly Property SexID() As Integer
            Get
                Return IIf(rbMan.Checked, 0, 1)
                Return -1
            End Get
        End Property
        Public ReadOnly Property MarriageStatusID() As Integer
            Get
                Return IIf(rbSingle.Checked, 0, 1)
            End Get
        End Property
        Public ReadOnly Property GraduateID() As Integer
            Get
                Return ddlGraduation.SelectedValue
            End Get
        End Property


    End Class

End Namespace