Module INI
    Public Const sINI위치 = "c:\Sense\SenseNEW"

    Public Function f컨버젼챠트뷰어_ini읽기(ByVal sINI As String, ByVal sApplicationName As String, ByVal sKeyName As String) As String
        Dim sb As String, intSize As Integer
        Dim res As Integer
        'Call f켠버젼챠트뷰어_ini읽기("c:\Sense\Resource\config\ChartInfo.ini", "문서관리", "챠트번호")

        f컨버젼챠트뷰어_ini읽기 = ""

        ' ....................................................................................................
        sb = Space(255) : intSize = 255

        res = GetPrivateProfileString(sApplicationName, sKeyName, "", sb, intSize, sINI)

        If Val(UCase(Trim(Replace(sb, vbNullChar, "")))) > 0 Then
            f컨버젼챠트뷰어_ini읽기 = Trim(Replace(sb, vbNullChar, ""))

        ElseIf trim(sb) = vbNullChar Then
            f컨버젼챠트뷰어_ini읽기 = ""
        Else
            f컨버젼챠트뷰어_ini읽기 = Trim(sb)
        End If

        Return Replace(f컨버젼챠트뷰어_ini읽기, vbNullChar, "")
    End Function

    Public Sub s컨버젼챠트뷰어_ini등록(ByVal sINI As String, ByVal sApplicationName As String, ByVal sKeyName As String, ByVal sValue As String)
        'Call s컨버젼챠트뷰어_ini등록("c:\Sense\Resource\config\ChartInfo.ini", "문서관리", "챠트번호", Trim(t챠트번호.Text))

        WritePrivateProfileString(sApplicationName, sKeyName, sValue, sINI)
    End Sub

    Public Sub sINI등록(ByVal s작업 As String, ByVal s챠트번호_진료실 As String, ByVal s챠트번호_뷰어 As String, ByVal s상병전송자료 As String, ByVal s처방전송자료 As String)

        s상병전송자료 = IIf(Trim(s상병전송자료) = "", " ", s상병전송자료)
        s처방전송자료 = IIf(Trim(s처방전송자료) = "", " ", s처방전송자료)

        Call s컨버젼챠트뷰어_ini등록(sINI위치 & "\컨버전뷰어.ini", "컨버젼챠트뷰어", "챠트번호(진료실)", s챠트번호_진료실)
        Call s컨버젼챠트뷰어_ini등록(sINI위치 & "\컨버전뷰어.ini", "컨버젼챠트뷰어", "챠트번호(뷰어)", s챠트번호_뷰어)

        Call s컨버젼챠트뷰어_ini등록(sINI위치 & "\컨버전뷰어.ini", "컨버젼챠트뷰어", "상병 REPEAT", s상병전송자료)
        Call s컨버젼챠트뷰어_ini등록(sINI위치 & "\컨버전뷰어.ini", "컨버젼챠트뷰어", "처방 REPEAT", s처방전송자료)

    End Sub
End Module
