Imports System.Data.SqlClient

Module 공용
    Public Sub s문서결재정보(ByVal s작업 As String, ByVal s문서명 As String)
        Dim sSQL As New SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String
        Dim ii As Object
        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        ReDim 결재(0)

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "select	결재01,				결재02,				결재03,				결재04,				결재05,
		                결재06,				결재07,				결재08,				결재09,				결재10
                    from	" & DBreceipt & "..TB_문서결재정보
                    where	문서명			=  '" & fQRY(s문서명) & "'
                    and		isnull(삭제,'')	=  ''"

        sSQL = New SqlCommand(QRY, SVREMR)

        rs = sSQL.ExecuteReader()

        While rs.Read()
            For xx = 0 To 9
                If fNULL(rs.GetValue(xx)) <> "" Then
                    ii = UBound(결재) + 1
                    ReDim Preserve 결재(ii)

                    결재(ii) = fNULL(rs.GetValue(xx))
                End If
            Next
        End While

        ' ....................................................................................................
        rs.Close()
    End Sub
End Module
