
' ........................................................................................................
Imports System.Data.SqlClient

Imports System.IO

Module 함수
    Public Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String,
                                                        ByVal lpKeyName As String,
                                                        ByVal lpDefault As String,
                                                        ByVal lpReturnedString As String,
                                                        ByVal nSize As Integer,
                                                        ByVal lpFileName As String) As Integer

    Public Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" _
                                                            (ByVal lpApplicationName As String,
                                                             ByVal lpKeyName As String,
                                                             ByVal lpString As String,
                                                             ByVal lpFileName As String) As Long

    Public Function f문자길이(ByVal s문자 As String) As Integer
        f문자길이 = 0

        For idx = 1 To Len(s문자)
            Select Case Asc(Mid(s문자, idx, 1))
                Case Is < 0
                    f문자길이 += 2

                Case Else
                    f문자길이 += 1
            End Select
        Next

        Return f문자길이
    End Function

    Public Function f공휴일정보(ByVal s작업 As String, ByVal s적용일 As String) As Boolean
        Dim sSQL As SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        Dim i윤달여부 As Boolean = IIf(DateDiff("d", Mid(s적용일, 1, 4) & "-02-01", Mid(s적용일, 1, 4) & "-03-01") = 28, False, True)

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        f공휴일정보 = False

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "if	exists(	select	*
				                from	" & DBname & "..TB_공휴일
				                where	공휴일일자		= substring('" & fG_ConvertSunToLun(s적용일, i윤달여부) & "',6,5)
				                and		공휴일구분		= 1 )
	                select	'공휴일(음력)'
                else
	                if	exists(	select	*
					                from	" & DBname & "..TB_공휴일
					                where	공휴일일자		= substring('" & s적용일 & "',6,5)
					                and		공휴일구분		= 0 )
			                select	'공휴일(양력)'
		                else
			                if	exists(	select	*
							                from	" & DBname & "..TB_공휴일
							                where	공휴일일자		= '" & s적용일 & "')
				                select	'공휴일(임시/대체)'
			                else
				                select	'평일'"

        sSQL = New SqlCommand(QRY, SVREMR)

        rs = sSQL.ExecuteReader()

        While rs.Read()
            If InStr(1, fNULL(rs.GetValue(0)), "공휴일") <> 0 Then
                f공휴일정보 = True
            End If
        End While

        ' ....................................................................................................
        rs.Close()

        ' ....................................................................................................
        Return f공휴일정보
    End Function

    Public Function f위탁계산(ByVal i위탁 As Integer) As String
        f위탁계산 = ""
        Select Case i위탁
            Case "0"

            Case "1"
                f위탁계산 = "위탁"

            Case "2"
                f위탁계산 = "코로나"


        End Select

        Return f위탁계산

    End Function


    Public Function f요일(ByVal s구분 As String, ByVal s일자 As String) As String
        Select Case UCase(Trim(s구분))
            Case "월"
                Select Case Weekday(s일자)
                    Case vbSunday
                        f요일 = "일"
                    Case vbMonday
                        f요일 = "월"
                    Case vbTuesday
                        f요일 = "화"
                    Case vbWednesday
                        f요일 = "수"
                    Case vbThursday
                        f요일 = "목"
                    Case vbFriday
                        f요일 = "금"
                    Case vbSaturday
                        f요일 = "토"
                    Case Else
                        f요일 = "Err"
                End Select

            Case "월요일"
                Select Case Weekday(s일자)
                    Case vbSunday
                        f요일 = "일요일"
                    Case vbMonday
                        f요일 = "월요일"
                    Case vbTuesday
                        f요일 = "화요일"
                    Case vbWednesday
                        f요일 = "수요일"
                    Case vbThursday
                        f요일 = "목요일"
                    Case vbFriday
                        f요일 = "금요일"
                    Case vbSaturday
                        f요일 = "토요일"
                    Case Else
                        f요일 = "Err"
                End Select

            Case Else
                Select Case Weekday(s일자)
                    Case vbSunday
                        f요일 = "SUN"
                    Case vbMonday
                        f요일 = "MON"
                    Case vbTuesday
                        f요일 = "TUE"
                    Case vbWednesday
                        f요일 = "WED"
                    Case vbThursday
                        f요일 = "THU"
                    Case vbFriday
                        f요일 = "FRI"
                    Case vbSaturday
                        f요일 = "SAT"
                    Case Else
                        f요일 = "Err"
                End Select
        End Select

        Return f요일

    End Function
    Public Function f초재구분(ByVal s작업 As String, ByVal s자료 As String) As String
        f초재구분 = ""

        Select Case s자료
            Case e초재구분.초진
                f초재구분 = "초진"

            Case e초재구분.재진
                f초재구분 = "재진"

            Case e초재구분.처방전
                f초재구분 = "처방전(보호자)"

            Case e초재구분.물리치료
                f초재구분 = "물리치료"

            Case e초재구분.정액수가
                f초재구분 = "정액수가"

            Case e초재구분.촉탁의
                f초재구분 = "촉닥의"

            Case e초재구분.진찰료없음
                f초재구분 = "진찰료X"

            Case e초재구분.가정간호
                f초재구분 = "가정간호"
        End Select

        Return f초재구분
    End Function

    Public Function f건강검진(ByVal s작업 As String, ByVal s자료 As String) As String
        f건강검진 = ""

        Select Case s자료
            Case e건강검진.일반검진
                f건강검진 = "일반검진"

            Case e건강검진.생애전환
                f건강검진 = "생애전환"

            Case e건강검진.암검진
                f건강검진 = "암검진"
        End Select

        Return f건강검진
    End Function

    Public Function f청구방법(ByVal s작업 As String, ByVal s청구방법 As String) As String
        f청구방법 = "퇴원"

        Select Case s청구방법
            Case e청구방법.분리청구
                f청구방법 = "분리"

            Case e청구방법.DRG청구
                f청구방법 = "DRG"

            Case e청구방법.DRG분리청구
                f청구방법 = "DRG분리"
        End Select

        Return f청구방법
    End Function

    Public Sub sTAG값보기(ByVal s작업 As String, ByVal f스프레드 As FarPoint.Win.Spread.FpSpread, ByVal iROW As Integer, ByVal iCOL As Integer)
        With f스프레드.Sheets(0)
            MessageBox.Show(".tag value -> " & .Cells(iROW, iCOL).Tag)
        End With
    End Sub

    Public Function f산정특례(ByVal s작업 As String, ByVal i산정특례 As Integer) As String
        f산정특례 = ""

        Select Case i산정특례
            Case 0
                f산정특례 = "미적용"

            Case 1
                f산정특례 = "20%"

            Case 2
                f산정특례 = "10%"

            Case 3
                f산정특례 = "약가30%"

            Case 4
                f산정특례 = "면제"

            Case 5
                f산정특례 = "5%"

            Case 6
                f산정특례 = "40%"

            Case 8
                f산정특례 = "30%"

            Case 9
                f산정특례 = "3%"
        End Select

        Return f산정특례
    End Function

    Public Function f검사종류구분(ByVal s작업 As String, ByVal s가루약적용 As String) As String
        f검사종류구분 = ""

        Select Case s가루약적용
            Case "0"
                f검사종류구분 = "해당없음"

            Case "1"
                f검사종류구분 = "진단검사"

            Case "2"
                f검사종류구분 = "병리검사"

            Case "3"
                f검사종류구분 = "핵의학검사"
        End Select

        Return f검사종류구분
    End Function

    Public Function f병원종별(ByVal s작업 As String, ByVal i병원종별 As Integer) As String
        f병원종별 = ""

        Select Case i병원종별
            Case 0
                f병원종별 = "의원"

            Case 1
                f병원종별 = "병원"

            Case 2
                f병원종별 = "병원(읍면)"

            Case 3
                f병원종별 = "요양병원"

            Case 2
                f병원종별 = "사회복지법인"
        End Select

        Return f병원종별
    End Function

    Public Function f가루약적용구분(ByVal s작업 As String, ByVal s가루약적용 As String) As String
        f가루약적용구분 = ""

        Select Case s가루약적용
            Case "0"

            Case "1"
                f가루약적용구분 = "적용안함"

            Case "2"
                f가루약적용구분 = "적용"
        End Select

        Return f가루약적용구분
    End Function

    Public Function f수납구분(ByVal s작업 As String, ByVal s수납구분 As String) As String
        f수납구분 = ""

        Select Case Val(s수납구분)
            Case e수납구분.환불
                ' 환불
                f수납구분 = "환불"

            Case e수납구분.변경
                ' 변경
                f수납구분 = "변경"

            Case e수납구분.재발행
                ' 재발행
                f수납구분 = "재발행"

            Case e수납구분.취소
                ' 취소
                f수납구분 = "취소"
        End Select

        ' ....................................................................................................
        Return f수납구분
    End Function

    Public Function f중간퇴원납입구분(ByVal s작업 As String, ByVal i입원ID As Integer, ByVal i중간퇴원 As Integer) As String
        f중간퇴원납입구분 = ""

        Select Case i입원ID
            Case 0
                f중간퇴원납입구분 = "외래"

            Case Else
                Select Case i중간퇴원
                    Case e중간퇴원.중간
                        f중간퇴원납입구분 = "중간납입"

                    Case e중간퇴원.퇴원
                        f중간퇴원납입구분 = "퇴원납입"

                    Case e중간퇴원.선수금
                        f중간퇴원납입구분 = "선수금"

                    Case e중간퇴원.수납대기_퇴원납입
                        f중간퇴원납입구분 = "수납대기(퇴원납입)"

                    Case e중간퇴원.수납대기_중도금
                        f중간퇴원납입구분 = "수납대기(중간납입)"

                    Case e중간퇴원.수납대기_가퇴원
                        f중간퇴원납입구분 = "수납대기(가퇴원)"
                End Select
        End Select

        ' ....................................................................................................
        Return f중간퇴원납입구분
    End Function

    Public Sub s디렉토리만들기(ByVal s작업 As String, ByVal s디렉토리 As String)
        ' Directory check
        If Not Directory.Exists(s디렉토리) Then
            MkDir(s디렉토리)
        End If
    End Sub

    Public Function f주민번호_성별(ByVal s주민번호 As String) As String
        Select Case Mid(s주민번호, 8, 1)
            Case "1", "3", "5", "7"
                f주민번호_성별 = "M"

            Case Else
                f주민번호_성별 = "F"
        End Select

        Return f주민번호_성별
    End Function

    Public Function f주민번호복호(ByVal s작업 As String, ByVal s자료 As String) As String
        Dim 주민번호 As New NeoEncryption.cls암호화복호화

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ

        ' ....................................................................................................
        f주민번호복호 = 주민번호.fG_복호화(s자료)

        ' ....................................................................................................
        Return f주민번호복호
    End Function

    Public Function f초재진구분(ByVal s작업 As String, ByVal i초재구분 As Integer, ByVal s초재명칭 As String) As String
        Select Case UCase(s작업)
            Case "코드→명칭", "코드->명칭", "명칭"
                Select Case i초재구분
                    Case ocsEnumChoJaeKind.ocsChoJaeKind0초진
                        f초재진구분 = "초진"
                    Case ocsEnumChoJaeKind.ocsChoJaeKind1재진
                        f초재진구분 = "재진"
                    Case ocsEnumChoJaeKind.ocsChoJaeKind2처방전
                        f초재진구분 = "처방전발급"
                    Case ocsEnumChoJaeKind.ocsChoJaeKind4입원
                        f초재진구분 = "입원"
                    Case ocsEnumChoJaeKind.ocsChoJaeKind5외박
                        f초재진구분 = "외박"
                    Case ocsEnumChoJaeKind.ocsChoJaeKind6정액수가
                        f초재진구분 = "정액수가"
                    Case ocsEnumChoJaeKind.ocsChoJaeKind7촉탁의
                        f초재진구분 = "촉탁의"
                    Case ocsEnumChoJaeKind.ocsChoJaeKind9진찰료없음
                        f초재진구분 = "진찰료없음"
                    Case ocsEnumChoJaeKind.ocsChoJaeKind10건강검진초진
                        f초재진구분 = "건강검진(초진)"
                    Case ocsEnumChoJaeKind.ocsChoJaeKind11건강검진재진
                        f초재진구분 = "건강검진(재진)"
                    Case ocsEnumChoJaeKind.ocsChoJaeKind12가정간호
                        f초재진구분 = "가정간호"
                End Select

            Case "명칭→코드", "명칭->코드", "코드"
                Select Case s초재명칭
                    Case "초진"
                        f초재진구분 = ocsEnumChoJaeKind.ocsChoJaeKind0초진
                    Case "재진"
                        f초재진구분 = ocsEnumChoJaeKind.ocsChoJaeKind1재진
                    Case "처방전발급"
                        f초재진구분 = ocsEnumChoJaeKind.ocsChoJaeKind2처방전
                    Case "입원"
                        f초재진구분 = ocsEnumChoJaeKind.ocsChoJaeKind4입원
                    Case "외박"
                        f초재진구분 = ocsEnumChoJaeKind.ocsChoJaeKind5외박
                    Case "정액수가"
                        f초재진구분 = ocsEnumChoJaeKind.ocsChoJaeKind6정액수가
                    Case "촉탁의"
                        f초재진구분 = ocsEnumChoJaeKind.ocsChoJaeKind7촉탁의
                    Case "진찰료없음"
                        f초재진구분 = ocsEnumChoJaeKind.ocsChoJaeKind9진찰료없음
                    Case "건강검진(초진)"
                        f초재진구분 = ocsEnumChoJaeKind.ocsChoJaeKind10건강검진초진
                    Case "건강검진(재진)"
                        f초재진구분 = ocsEnumChoJaeKind.ocsChoJaeKind11건강검진재진
                    Case "가정간호"
                        f초재진구분 = ocsEnumChoJaeKind.ocsChoJaeKind12가정간호
                End Select
        End Select

        Return f초재진구분
    End Function

    Public Function f특정코드센스(ByVal s작업 As String, ByVal s자료 As String) As String
        f특정코드센스 = ""

        Select Case UCase(s작업)
            Case "코드→명칭", "코드->명칭"
                Select Case UCase(s자료)
                    Case "01"
                        f특정코드센스 = "수액100ml"
                    Case "05"
                        f특정코드센스 = "수액500ml"
                    Case "10"
                        f특정코드센스 = "수액1000ml"
                    Case "DD"
                        f특정코드센스 = "퇴원약"
                    Case "HA"
                        f특정코드센스 = "비급여청구"
                    Case "XX"
                        f특정코드센스 = "의사지시"
                    Case "AA"
                        f특정코드센스 = "수기료산정안함"
                    Case "0X"
                        f특정코드센스 = "수액100ml 유지침X"
                    Case "5X"
                        f특정코드센스 = "수액500ml 유지침X"
                    Case "1X"
                        f특정코드센스 = "수액1000ml 유지침X"
                    Case "BX"
                        f특정코드센스 = "본인부담X"
                    Case "LD"
                        f특정코드센스 = "검사검출있음(연결코드X)"
                    Case "SD"
                        f특정코드센스 = "사이드수기료(KK054)"
                    Case Else
                        f특정코드센스 = ""
                End Select

            Case "명칭→코드", "명칭->코드"
                Select Case UCase(s자료)
                    Case "수액100ml", "수액100ML"
                        f특정코드센스 = "01"
                    Case "수액500ml", "수액500ML"
                        f특정코드센스 = "05"
                    Case "수액1000ml", "수액1000ML"
                        f특정코드센스 = "10"
                    Case "퇴원약"
                        f특정코드센스 = "DD"
                    Case "비급여청구"
                        f특정코드센스 = "HA"
                    Case "의사지시"
                        f특정코드센스 = "XX"
                    Case "수기료산정안함"
                        f특정코드센스 = "AA"
                    Case "수액100ml 유지침X", "수액100ML 유지침X"
                        f특정코드센스 = "0X"
                    Case "수액500ml 유지침X", "수액500ML 유지침X"
                        f특정코드센스 = "5X"
                    Case "수액1000ml 유지침X", "수액1000ML 유지침X"
                        f특정코드센스 = "1X"
                    Case "본인부담X"
                        f특정코드센스 = "BX"
                    Case "검사검출있음(연결코드X)"
                        f특정코드센스 = "LD"
                    Case "사이드수기료(KK054)"
                        f특정코드센스 = "SD"
                    Case Else
                        f특정코드센스 = ""
                End Select
        End Select
    End Function

    Public Function f식이종류(ByVal s작업 As String, ByVal s자료 As Integer) As String
        f식이종류 = ""

        Select Case s자료
            Case 0
                f식이종류 = "아침"

            Case 1
                f식이종류 = "점심"

            Case 2
                f식이종류 = "저녁"

            Case Else
                f식이종류 = "간식"
        End Select

        Return f식이종류
    End Function

    Public Function fDATE_TIME(ByVal s작업 As String) As String
        Dim sSQL As SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        Select Case UCase(s작업)
            Case "DATE"
                fDATE_TIME = DateTime.Now.ToString("yyyy/MM/dd")

            Case Else
                fDATE_TIME = DateTime.Now.ToString("HH:mm:ss")
        End Select

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        Select Case UCase(s작업)
            Case "DATE"
                QRY = "select	convert(char(10), getdate(), 23)"

            Case Else
                QRY = "select	convert(char(10), getdate(), 24)"
        End Select

        sSQL = New SqlCommand(QRY, SVREMR)

        sSQL.CommandTimeout = 600

        rs = sSQL.ExecuteReader()

        Select Case UCase$(s작업)
            Case "DATE"
                While rs.Read()
                    fDATE_TIME = rs.GetValue(0)
                End While

            Case Else
                While rs.Read()
                    fDATE_TIME = rs.GetValue(0)
                End While
        End Select

        ' ................................................................
        rs.Close()

        Return fDATE_TIME
    End Function

    Public Function f주민번호_성별(ByVal s작업 As String, ByVal s주민번호 As String) As String
        Select Case s작업
            Case "남자", "여자"
                Select Case Mid(s주민번호, 8, 1)
                    Case "1", "3", "5", "7"
                        f주민번호_성별 = "남자"

                    Case Else
                        f주민번호_성별 = "여자"
                End Select

            Case Else
                Select Case Mid(s주민번호, 8, 1)
                    Case "1", "3", "5", "7"
                        f주민번호_성별 = "M"

                    Case Else
                        f주민번호_성별 = "F"
                End Select
        End Select

        Return f주민번호_성별
    End Function

    Public Function f생년월일(ByVal s주민번호 As String) As String
        Dim s생년월일 As String

        If InStr(1, s주민번호, "-") = 0 And Len(Trim(s주민번호)) = 13 Then
            s주민번호 = Mid(s주민번호, 1, 6) & "-" & Mid(s주민번호, 7, 7)
        End If

        Select Case Mid(s주민번호, 8, 1)
            Case "3", "4", "7", "8"
                s생년월일 = "20" & Mid(s주민번호, 1, 6)

            Case Else
                s생년월일 = "19" & Mid(s주민번호, 1, 6)
        End Select

        f생년월일 = Format(Val(s생년월일), e형식.년월일)
    End Function

    Public Function f연령(ByVal s구분 As String, ByVal s기준일 As String, ByVal s생년월일 As String) As String
        Dim i개월수 As Integer

        If Not IsDate(s생년월일) Then
            Return 50

            Exit Function
        End If

        ' 개월수 
        i개월수 = DateDiff("m", s생년월일, s기준일)

        If Mid(s생년월일, 9, 2) > Mid(s기준일, 9, 2) Then
            i개월수 -= 1
        End If

        ' ....................................................................................................
        Select Case UCase(Trim(s구분))
            Case "년.개월"
                If i개월수 < 24 Then
                    f연령 = i개월수 & "개월"
                Else
                    f연령 = Int(i개월수 / 12) & "." & f0PADDING(i개월수 Mod 12, 2) & "세"
                End If

            Case "연령", "나이", "세", "Y"
                f연령 = Int(i개월수 / 12)

            Case "월", "개월", "M"
                f연령 = i개월수 Mod 12

            Case "출생일수"
                f연령 = DateDiff("d", s생년월일, s기준일) + 1
        End Select

        Return f연령
    End Function

    Public Function fQRY(ByVal s값) As String
        fQRY = Replace(s값, "'", "^")

        Return Trim(fQRY)
    End Function

    Public Function f0PADDING_RIGHT(ByVal s값 As String, ByVal i길이 As Integer) As String
        f0PADDING_RIGHT = s값

        If i길이 - Len(s값) > 0 Then
            f0PADDING_RIGHT = s값 & StrDup(i길이 - Len(s값), "0")
        End If

        Return f0PADDING_RIGHT
    End Function
    Public Function f0PADDING(ByVal s값 As String, ByVal i길이 As Integer) As String
        f0PADDING = s값

        If IsNumeric(s값) Then
            If i길이 - Len(s값) > 0 Then
                f0PADDING = StrDup(i길이 - Len(s값), "0") & s값
            End If
        End If

        Return f0PADDING
    End Function

    Public Function fL정렬(ByVal s문자 As String, ByVal i길이 As Integer) As String
        Dim i문자길이 As Integer = 0

        fL정렬 = ""

        For ii = 1 To Len(s문자)
            Select Case Asc(Mid(s문자, ii, 1))
                Case Is < 0
                    i문자길이 += 2

                Case Else
                    i문자길이 += 1
            End Select

            fL정렬 = fL정렬 & Mid(s문자, ii, 1)

            If i문자길이 >= i길이 Then Exit For
        Next

        If i길이 > i문자길이 Then
            fL정렬 = fL정렬 & Space(i길이 - i문자길이)
        Else
            fL정렬 = fL정렬
        End If

        ' ....................................................................................................
        Return fL정렬
    End Function

    Public Function fR정렬(ByVal s문자 As String, ByVal i길이 As Integer) As String
        Dim i문자길이 As Integer = 0

        For ii = 1 To Len(s문자)
            Select Case Asc(Mid(s문자, ii, 1))
                Case Is < 0
                    i문자길이 += 2

                Case Else
                    i문자길이 += 1
            End Select
        Next

        If i길이 > i문자길이 Then
            fR정렬 = Space(i길이 - i문자길이) & s문자
        Else
            fR정렬 = s문자
        End If

        ' ....................................................................................................
        Return fR정렬
    End Function
End Module
