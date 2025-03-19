Module 챠트뷰어
    Public Enum e처방
        형식 = 0
        구분
        선택
        처방코드
        수가코드
        처방명
        총투여량
        투여량
        횟수
        일수
        보험구분
        경로
        비고
        등록자명
        삭제
    End Enum

    Public Function f상병전송자료(ByVal s작업 As String, ByVal f스프레드 As FarPoint.Win.Spread.FpSpread) As String
        f상병전송자료 = ""

        With f스프레드.Sheets(0)
            For ii = 0 To .NonEmptyRowCount - 1
                Select Case .GetText(ii, e처방.형식)
                    Case "상병"
                        If 스프레드.f체크CELL("get", f스프레드, ii, e처방.선택, "") = "1" Then
                            ' 해당 상병코드가 존재하지 않는 경우.
                            If InStr(1, UCase(f상병전송자료), UCase(.GetText(ii, e처방.처방코드))) = 0 Then
                                If Trim(f상병전송자료) <> "" Then f상병전송자료 = f상병전송자료 & "|"

                                f상병전송자료 = f상병전송자료 & "D~" & .GetText(ii, e처방.처방코드) & "~" & .GetText(ii, e처방.수가코드)
                            End If
                        End If
                End Select
            Next
        End With

        Return f상병전송자료
    End Function

    Public Function f처방전송자료(ByVal s작업 As String, ByVal f스프레드 As FarPoint.Win.Spread.FpSpread) As String
        Dim s급여구분 As String, s복약법 As String

        f처방전송자료 = ""

        With f스프레드.Sheets(0)
            For ii = 0 To .NonEmptyRowCount - 1
                Select Case .GetText(ii, e처방.형식)
                    Case "처방"
                        If 스프레드.f체크CELL("get", f스프레드, ii, e처방.선택, "") = "1" Then
                            Select Case UCase(.GetText(ii, e처방.보험구분))
                                Case "G", "3"
                                    s급여구분 = "비급"
                                Case "B", "6"
                                    s급여구분 = "전액"
                                Case Else
                                    s급여구분 = "급여"
                            End Select

                            Select Case s작업
                                Case "엔지테크"
                                    s복약법 = .Cells(ii, e처방.비고).Tag
                                    's복약법 = .GetText(ii, e처방.비고)

                                Case Else
                                    s복약법 = ""
                            End Select

                            If Trim(f처방전송자료) <> "" Then f처방전송자료 = f처방전송자료 & "|"

                            If Not 사용자.회투사용 Then
                                f처방전송자료 = f처방전송자료 & "M~~" & .GetText(ii, e처방.처방코드) &
                                                            "~" & IIf(Val(.GetText(ii, e처방.총투여량)) <> 0, .GetText(ii, e처방.총투여량), "1") &
                                                            "~" & IIf(Val(.GetText(ii, e처방.투여량)) <> 0, .GetText(ii, e처방.투여량), "1") &
                                                            "~" & IIf(Val(.GetText(ii, e처방.횟수)) <> 0, .GetText(ii, e처방.횟수), "1") &
                                                            "~" & IIf(Val(.GetText(ii, e처방.일수)) <> 0, .GetText(ii, e처방.일수), "1") &
                                                            "~" & s급여구분 & "~" & s복약법

                            Else
                                f처방전송자료 = f처방전송자료 & "M~~" & .GetText(ii, e처방.처방코드) &
                                                            "~" & IIf(Val(.GetText(ii, e처방.총투여량)) <> 0, .GetText(ii, e처방.총투여량), "1") &
                                                            "~" & IIf(Val(.GetText(ii, e처방.총투여량)) <> 0, .GetText(ii, e처방.총투여량), "1") &
                                                            "~" & IIf(Val(.GetText(ii, e처방.횟수)) <> 0, .GetText(ii, e처방.횟수), "1") &
                                                            "~" & IIf(Val(.GetText(ii, e처방.일수)) <> 0, .GetText(ii, e처방.일수), "1") &
                                                            "~" & s급여구분 & "~" & s복약법
                            End If
                        End If
                End Select
            Next
        End With

        Return f처방전송자료
    End Function

    Public Function fNULL(ByVal s값) As String
        If Not (s값 Is System.DBNull.Value) Then
            fNULL = Replace(Trim(s값), "^", "'")
        Else
            fNULL = ""
        End If

        Return Trim(fNULL)
    End Function

End Module
