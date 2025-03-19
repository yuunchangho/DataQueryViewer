Public Class frm메세지
    Private Sub s화면지우기()

    End Sub

    Public Sub s초기값(ByVal s작업 As String, ByVal s타이틀 As String, ByVal s메세지 As String, ByVal i버튼 As Integer)
        ' 버튼 ------------------------------------------------------------------------------------------------
        b확인.Visible = False
        b예.Visible = False : b아니오.Visible = False

        Select Case i버튼
            Case MessageBoxButtons.YesNo
                b예.Visible = True : b아니오.Visible = True

                b아니오.Focus()

            Case MessageBoxButtons.OK
                b확인.Left = b아니오.Left : b확인.Top = b아니오.Top

                b확인.Visible = True

                b확인.Focus()
        End Select

        ' 메세지 ----------------------------------------------------------------------------------------------
        '<size=12><color=255, 0, 0><b>환경설정정보 등록이 완료되었습니다.</b></color><br><br><size=10><color=0, 0, 0>※ 주의</color>

        s메세지 = Replace(s메세지, "<sz=", "<size=")

        s메세지 = Replace(s메세지, "<br2>", "<br><br>")

        s메세지 = Replace(s메세지, "<red>", "<color=255, 0, 0>")
        s메세지 = Replace(s메세지, "<black>", "<color=0, 0, 0>")
        s메세지 = Replace(s메세지, "<blue>", "<color=0, 84, 255>")
        s메세지 = Replace(s메세지, "<green>", "<color=35, 164, 26>")
        s메세지 = Replace(s메세지, "<yellow>", "<color=255, 228, 0>")
        s메세지 = Replace(s메세지, "<gray>", "<color=140, 140, 140>")

        s메세지 = Replace(s메세지, "</c>", "</color>")

        Me.Text = s타이틀

        l메세지.Text = s메세지
    End Sub

    Private Sub frm메세지_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 화면 지우기
        Call s화면지우기()

        Select Case 메세지.버튼
            Case MessageBoxButtons.YesNo
                b아니오.Focus()

            Case MessageBoxButtons.OK
                b확인.Focus()
        End Select
    End Sub

    Private Sub b아니오_Click(sender As Object, e As EventArgs) Handles b아니오.Click
        메세지.응답 = DialogResult.No

        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub b예_Click(sender As Object, e As EventArgs) Handles b예.Click
        메세지.응답 = DialogResult.Yes

        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub b확인_Click(sender As Object, e As EventArgs) Handles b확인.Click
        메세지.응답 = DialogResult.OK

        Me.Dispose()
        Me.Close()
    End Sub
End Class