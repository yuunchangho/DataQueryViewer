Imports System.IO
Imports System.IO.DirectoryInfo

Module CONTROL
    Public Structure type메세지
        Public 타이틀 As String
        Public 메세지 As String

        Public 이미지 As Integer

        Public 버튼 As Integer
        Public 응답 As Integer
    End Structure

    Public 메세지 As type메세지

    Public Function fLABEL_HTML(ByVal s작업 As String, ByVal s문자열 As String) As String
        fLABEL_HTML = s문자열

        ' 문자열 ----------------------------------------------------------------------------------------------
        '<size=12><color=255, 0, 0><b>환경설정정보 등록이 완료되었습니다.</b></color><br><br><size=10><color=0, 0, 0>※ 주의</color>

        s문자열 = Replace(s문자열, "<sz=", "<size=")

        s문자열 = Replace(s문자열, "<br2>", "<br><br>")

        s문자열 = Replace(s문자열, "<white>", "<color=255, 255, 255>")
        s문자열 = Replace(s문자열, "<red>", "<color=255, 0, 0>")
        s문자열 = Replace(s문자열, "<black>", "<color=0, 0, 0>")
        s문자열 = Replace(s문자열, "<blue>", "<color=0, 84, 255>")
        s문자열 = Replace(s문자열, "<steelblue>", "<color=70, 130, 180>")
        s문자열 = Replace(s문자열, "<green>", "<color=35, 164, 26>")
        s문자열 = Replace(s문자열, "<greenyellow>", "<color=173, 255, 47>")
        s문자열 = Replace(s문자열, "<yellow>", "<color=255, 228, 0>")
        s문자열 = Replace(s문자열, "<gray>", "<color=140, 140, 140>")

        s문자열 = Replace(s문자열, "<최고>", "<color=255, 0, 0>")
        s문자열 = Replace(s문자열, "<최고도>", "<color=255, 0, 0>")
        s문자열 = Replace(s문자열, "<고도>", "<color=255, 99, 71>")
        s문자열 = Replace(s문자열, "<중도>", "<color=100, 149, 237>")
        s문자열 = Replace(s문자열, "<경도>", "<color=72, 209, 204>")
        s문자열 = Replace(s문자열, "<신체저하>", "<color=140, 140, 140>")
        s문자열 = Replace(s문자열, "<선택입원군>", "<color=140, 140, 140>")
        s문자열 = Replace(s문자열, "<선택>", "<color=140, 140, 140>")

        s문자열 = Replace(s문자열, "</c>", "</color>")

        fLABEL_HTML = s문자열
    End Function

    Public Function f메세지창(ByVal s작업 As String, ByVal s타이틀 As String, ByVal s메세지 As String, ByVal i버튼 As Integer) As Integer
        메세지.버튼 = i버튼

        Select Case i버튼
            Case MessageBoxButtons.OK
                메세지.응답 = DialogResult.OK

            Case Else
                메세지.응답 = DialogResult.No
        End Select

        With frm메세지
            .BringToFront()

            Call .s초기값("", s타이틀, s메세지, i버튼)

            .ShowDialog()
        End With

        Return 메세지.응답
    End Function

    Public Function fINI가져오기(ByVal s작업 As String, ByVal sAppName As String, sKeyName As String, Optional sFileName As String = "c:\Sense\SenseNEW\New병동\New병동.ini") As String
        Dim res As Integer

        Dim sb As String, intSize As Integer

        fINI가져오기 = ""

        ' ....................................................................................................
        sb = Space(255) : intSize = 255

        res = GetPrivateProfileString(sAppName, sKeyName, "", sb, intSize, sFileName)

        fINI가져오기 = Trim(Replace(sb, vbNullChar, ""))

        ' ....................................................................................................
        Return fINI가져오기
    End Function


    Public Function fXML체크(ByVal s작업 As String, ByVal s파일 As String, ByVal s적용일 As String) As Boolean
        On Error Resume Next

        fXML체크 = False

        If Replace(Format(File.GetLastWriteTime(s파일), e형식.yyyyMMdd), "-", "") < Replace(s적용일, "-", "") Then
            My.Computer.FileSystem.DeleteFile(s파일, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
                                                                                FileIO.RecycleOption.DeletePermanently)
        Else
            fXML체크 = True
        End If

        Return fXML체크
    End Function
    Public Sub s스프레드환경정보(ByVal s작업 As String, ByVal s폴더 As String, ByVal f스프레드 As FarPoint.Win.Spread.FpSpread)
        ' Directory check
        If Not Directory.Exists("c:\sense\SenseNEW\" & s폴더 & "\xml") Then
            MkDir("c:\sense\SenseNEW\" & s폴더 & "\xml")
        End If

        Select Case UCase(s작업)
            Case "재원현황"
                f스프레드.Save("c:\sense\SenseNEW\" & s폴더 & "\xml\재원현황sheet.xml", False)

            Case "금일처방"
                f스프레드.Save("c:\sense\SenseNEW\" & s폴더 & "\xml\금일처방sheet.xml", False)

            Case "간호기록"
                f스프레드.Save("c:\sense\SenseNEW\" & s폴더 & "\xml\간호기록sheet.xml", False)

            Case "액팅처방"
                f스프레드.Save("c:\sense\SenseNEW\" & s폴더 & "\xml\액팅sheet.xml", False)

            Case "일괄액팅"
                f스프레드.Save("c:\sense\SenseNEW\" & s폴더 & "\xml\일괄액팅sheet.xml", False)

            Case "청구심사대상"
                f스프레드.Save("c:\sense\SenseNEW\" & s폴더 & "\xml\청구심사대상sheet.xml", False)

            Case "청구심사처방"
                f스프레드.Save("c:\sense\SenseNEW\" & s폴더 & "\xml\청구심사처방sheet.xml", False)
        End Select
    End Sub

    Public Sub slu항목구분(ByVal s작업 As String, ByVal luCONTROL As System.Object, ByVal lDROPROW As Long)
        Dim ii As Integer

        ' ....................................................................................................
        ReDim 기초자료_자료(0)

        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "초진료" : 기초자료_자료(ii).항목2 = "0101"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "재진료" : 기초자료_자료(ii).항목2 = "0102"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "의약품관리료" : 기초자료_자료(ii).항목2 = "0103"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "응급및회송료" : 기초자료_자료(ii).항목2 = "0104"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "가정간호" : 기초자료_자료(ii).항목2 = "0105"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "만성질환" : 기초자료_자료(ii).항목2 = "0106"

        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "입원료-일반" : 기초자료_자료(ii).항목2 = "0201"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "입원료-내소아정신과" : 기초자료_자료(ii).항목2 = "0202"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "입원료-집중치료" : 기초자료_자료(ii).항목2 = "0203"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "입원료-격리병실" : 기초자료_자료(ii).항목2 = "0204"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "입원료-기타입원" : 기초자료_자료(ii).항목2 = "0205"

        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "식대(기본)" : 기초자료_자료(ii).항목2 = "0210"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "식대(가산)" : 기초자료_자료(ii).항목2 = "0211"

        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "내복약" : 기초자료_자료(ii).항목2 = "0301"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "외용약" : 기초자료_자료(ii).항목2 = "0302"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "처방전" : 기초자료_자료(ii).항목2 = "0303"

        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "피하근육내" : 기초자료_자료(ii).항목2 = "0401"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "정맥내" : 기초자료_자료(ii).항목2 = "0402"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "수액" : 기초자료_자료(ii).항목2 = "0403"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "기타주사" : 기초자료_자료(ii).항목2 = "0404"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "수혈" : 기초자료_자료(ii).항목2 = "0405"

        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "마취료" : 기초자료_자료(ii).항목2 = "0501"

        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "이학요법료" : 기초자료_자료(ii).항목2 = "0601"

        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "정신요법료" : 기초자료_자료(ii).항목2 = "0701"

        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "치치.수술료" : 기초자료_자료(ii).항목2 = "0801"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "캐스트료" : 기초자료_자료(ii).항목2 = "0803"

        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "자체검사" : 기초자료_자료(ii).항목2 = "0901"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "위탁검사관리" : 기초자료_자료(ii).항목2 = "0902"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "위탁검사" : 기초자료_자료(ii).항목2 = "0903"

        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "방사선-진단" : 기초자료_자료(ii).항목2 = "1001"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "방사선-치료" : 기초자료_자료(ii).항목2 = "1002"

        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "CT진단료" : 기초자료_자료(ii).항목2 = "SS01"
        ii = UBound(기초자료_자료) + 1 : ReDim Preserve 기초자료_자료(ii) : 기초자료_자료(ii).항목1 = "MRI진단료" : 기초자료_자료(ii).항목2 = "SS02"

        Call slu초기값("", luCONTROL, 15) : luCONTROL.EditValue = 기초자료_자료(1).항목2
    End Sub

    Public Sub slu보호종별(ByVal s작업 As String, ByVal luCONTROL As System.Object, ByVal lDROPROW As Long)
        ' ....................................................................................................
        ReDim 기초자료_자료(7)

        기초자료_자료(1).항목1 = "" : 기초자료_자료(1).항목2 = "X"
        기초자료_자료(2).항목1 = "1종" : 기초자료_자료(2).항목2 = "1"
        기초자료_자료(3).항목1 = "2종" : 기초자료_자료(3).항목2 = "2"
        기초자료_자료(4).항목1 = "행려" : 기초자료_자료(4).항목2 = "4"
        기초자료_자료(5).항목1 = "장애인2차" : 기초자료_자료(5).항목2 = "6"
        기초자료_자료(6).항목1 = "장애인1창" : 기초자료_자료(6).항목2 = "8"
        기초자료_자료(7).항목1 = "노숙자외국인" : 기초자료_자료(7).항목2 = "9"

        Call slu초기값("", luCONTROL, 15) : luCONTROL.EditValue = 기초자료_자료(1).항목2
    End Sub

    Public Sub slu보험유형(ByVal s작업 As String, ByVal luCONTROL As System.Object, ByVal lDROPROW As Long)
        ' ....................................................................................................
        ReDim 기초자료_자료(7)

        기초자료_자료(1).항목1 = "국민건강" : 기초자료_자료(1).항목2 = "1"
        기초자료_자료(2).항목1 = "의료급여" : 기초자료_자료(2).항목2 = "2"
        기초자료_자료(3).항목1 = "자동차보험" : 기초자료_자료(3).항목2 = "3"
        기초자료_자료(4).항목1 = "산업재해" : 기초자료_자료(4).항목2 = "4"
        기초자료_자료(5).항목1 = "국민건강(본인)" : 기초자료_자료(5).항목2 = "5"
        기초자료_자료(6).항목1 = "자동차보험(본인)" : 기초자료_자료(6).항목2 = "6"
        기초자료_자료(7).항목1 = "산업재해(본인)" : 기초자료_자료(7).항목2 = "7"

        Call slu초기값("", luCONTROL, 15) : luCONTROL.EditValue = 기초자료_자료(1).항목2
    End Sub

    Public Sub slu외래입원(ByVal s작업 As String, ByVal luCONTROL As System.Object, ByVal lDROPROW As Long)
        ' ....................................................................................................
        ReDim 기초자료_자료(2)

        기초자료_자료(1).항목1 = "외래" : 기초자료_자료(1).항목2 = "0"
        기초자료_자료(2).항목1 = "입원" : 기초자료_자료(2).항목2 = "1"

        Call slu초기값("", luCONTROL, 15) : luCONTROL.EditValue = 기초자료_자료(1).항목2
    End Sub

    Public Sub slu병원종별(ByVal s작업 As String, ByVal luCONTROL As System.Object, ByVal lDROPROW As Long)
        ' ....................................................................................................
        ReDim 기초자료_자료(4)

        기초자료_자료(1).항목1 = "의원" : 기초자료_자료(1).항목2 = "0"
        기초자료_자료(2).항목1 = "병원" : 기초자료_자료(2).항목2 = "1"
        기초자료_자료(3).항목1 = "병원(읍면)" : 기초자료_자료(3).항목2 = "2"
        기초자료_자료(4).항목1 = "요양병원" : 기초자료_자료(4).항목2 = "3"

        Call slu초기값("", luCONTROL, 15) : luCONTROL.EditValue = 기초자료_자료(1).항목2
    End Sub

    Public Sub s챠트뷰어자료읽기건수설정(ByVal s작업 As String, ByVal luCONTROL As System.Object, ByVal lDROPROW As Long)
        ' ....................................................................................................
        ReDim 기초자료_자료(4)

        기초자료_자료(1).항목1 = "전체" : 기초자료_자료(1).항목2 = "ALL"
        기초자료_자료(2).항목1 = "5회" : 기초자료_자료(2).항목2 = "5"
        기초자료_자료(3).항목1 = "10회" : 기초자료_자료(3).항목2 = "10"
        기초자료_자료(4).항목1 = "15회" : 기초자료_자료(4).항목2 = "15"

        Call CONTROL.slu초기값("", luCONTROL, 15) : luCONTROL.EditValue = "ALL"
    End Sub

    Public Sub slu초기값(ByVal s작업 As String, ByVal luCONTROL As System.Object, ByVal lDROPROW As Long)
        luCONTROL.Properties.DataSource = Data초기값.GetData(s작업)

        luCONTROL.Properties.DisplayMember = "명칭"
        luCONTROL.Properties.ValueMember = "코드"

        luCONTROL.Properties.DropDownRows = lDROPROW
        luCONTROL.ItemIndex = 0
    End Sub

    Public Sub s버튼설정(ByVal f스프레드 As FarPoint.Win.Spread.FpSpread, ByVal iROW As Integer, ByVal iCOL As Integer, ByVal sTEXT As String, ByVal iLOCK As Boolean)
        Dim bttncell As New FarPoint.Win.Spread.CellType.ButtonCellType()

        bttncell.ButtonColor = Color.Cyan
        bttncell.DarkColor = Color.DarkCyan
        bttncell.LightColor = Color.AliceBlue

        bttncell.TwoState = False

        bttncell.Text = sTEXT
        bttncell.TextDown = sTEXT

        f스프레드.Sheets(0).Cells(iROW, iCOL).Locked = False
        f스프레드.Sheets(0).Cells(iROW, iCOL).CellType = bttncell
    End Sub

    Public Sub s콤보셀설정(ByVal f스프레드 As FarPoint.Win.Spread.FpSpread, ByVal iROW As Integer, ByVal iCOL As Integer,
                                                                ByVal s항목 As String, ByVal sITEMDATA As String, ByVal i폭 As Integer)
        Dim cmbocell As New FarPoint.Win.Spread.CellType.ComboBoxCellType()

        Dim s자료() As String, s자료1() As String
        Dim s코드() As String, s코드1() As String

        On Error GoTo ERR_RTN

        s자료 = Split(Replace(s항목, "「0", ""), "|")
        s자료1 = Split(Replace(s항목, "「0", ""), "|")

        s코드 = Split(Replace(sITEMDATA, "「0", ""), "|")

        ' ....................................................................................................
        ' 
        If Trim(sITEMDATA) <> "" Then
            s코드 = Split(Replace(sITEMDATA, "「0", ""), "|")

            cmbocell.Items = s자료1
            cmbocell.ItemData = s코드
        Else
            ReDim s자료1(UBound(s자료) - 1)

            For idx = 1 To UBound(s자료)
                s자료1(idx - 1) = s자료(idx)
            Next

            cmbocell.Items = s자료1
            cmbocell.ItemData = s자료1
        End If

        cmbocell.EditorValue = FarPoint.Win.Spread.CellType.EditorValue.ItemData

        cmbocell.AcceptsArrowKeys = FarPoint.Win.SuperEdit.AcceptsArrowKeys.AllArrows
        cmbocell.AutoSearch = FarPoint.Win.AutoSearch.SingleCharacter
        cmbocell.Editable = False
        cmbocell.ListAlignment = FarPoint.Win.ListAlignment.Left

        cmbocell.ListOffset = 20
        cmbocell.MaxDrop = 20

        If i폭 = 0 Then
            cmbocell.ListWidth = 200
        Else
            cmbocell.ListWidth = i폭
        End If

        If iROW = -1 Then
            f스프레드.Sheets(0).Columns(iCOL).CellType = cmbocell
        Else
            f스프레드.Sheets(0).Cells(iROW, iCOL).CellType = cmbocell
        End If

ERR_RTN:

    End Sub
    Public Sub sRB(ByVal RB As System.Object)
        If RB.checked Then
            RB.BackColor = Color.Cornsilk
            RB.Font = New Font("맑은 고딕", 9, FontStyle.Underline)
        Else
            RB.BackColor = Color.White
            RB.Font = New Font("맑은 고딕", 9)
        End If
    End Sub
    Public Sub gcFOCUS(ByVal combo As System.Object)
        With combo
            .forecolor = Color.Black
            .backcolor = Color.Ivory
        End With
    End Sub
    Public Sub lcFOCUS(ByVal combo As System.Object)
        With combo
            .forecolor = Color.Black
            .backcolor = Color.White
        End With
    End Sub
    Public Sub gtFOCUS(ByVal textbox As System.Object, bSEL As Boolean)
        With textbox
            .forecolor = Color.Black
            .backcolor = Color.Ivory

            If bSEL Then
                .selectionstart = 0
                .selectionlength = Len(.text) * 2
            Else
                .selectionstart = Len(.text) * 2
                .selectionlength = Len(.text) * 2
            End If
        End With
    End Sub
    Public Sub ltFOCUS(ByVal textbox As System.Object)
        With textbox
            .forecolor = Color.Black
            .backcolor = Color.White
        End With
    End Sub
    Public Sub gCOLOR(ByVal CONTROL As System.Object)
        With CONTROL
            .forecolor = Color.Black
            .backcolor = Color.Ivory
        End With
    End Sub
    Public Sub lCOLOR(ByVal CONTROL As System.Object)
        With CONTROL
            .forecolor = Color.Black
            .backcolor = Color.White
        End With
    End Sub
    Public Sub ckCLICK(ByVal check As System.Object, ByRef value As Boolean)
        With check
            If value = False Then
                .ForeColor = Color.Silver
            Else
                .ForeColor = Color.Black
            End If
        End With
    End Sub
    Public Function flookup(ByVal s작업 As String, ByVal CONTROL As System.Object) As String
        If CONTROL.EditValue = Nothing Then
            flookup = ""
        Else
            flookup = Replace(CONTROL.EditValue.ToString(), "<Null>", "")
        End If

        Return flookup
    End Function
    Public Function fcheck값(ByVal CONTROL As System.Object) As String
        If CONTROL.checked Then
            fcheck값 = "Y"
        Else
            fcheck값 = "N"
        End If
    End Function
    Public Function fcheck설정(ByVal s값 As String) As Boolean
        Select Case UCase(Trim(s값))
            Case "Y"
                fcheck설정 = True

            Case Else
                fcheck설정 = False
        End Select
    End Function
    Public Sub sROW증가(ByVal CONTROL As System.Object, ByVal iROW As Integer)
        If (CONTROL.sheets(0).RowCount - CONTROL.sheets(0).NonEmptyRowCount) <= iROW Then
            CONTROL.sheets(0).RowCount = CONTROL.sheets(0).NonEmptyRowCount + iROW + 1
        End If
    End Sub

    Public Function f컬럼존재(ByVal fp스프레드 As System.Object, ByVal s컬럼 As String) As Boolean
        Dim s값 As String, iFLAG As Integer

        f컬럼존재 = False

        With fp스프레드.sheets(0)
            For idx = 0 To .ColumnCount - 1
                s값 = fp스프레드.sheets(0).Models.ColumnHeaderData.GetValue(0, idx)

                If Replace(Replace(UCase(Trim(s값)), " ", ""), vbNewLine, "") = Replace(UCase(Trim(s컬럼)), " ", "") Then
                    f컬럼존재 = idx

                    Exit For
                End If
            Next
        End With

        Return f컬럼존재
    End Function

    Public Sub sIMAGE설정(ByVal CONTROL As System.Object, ByVal s그룹 As String, ByVal lROW As Long, ByVal lCOL As Long)

        'Dim image As System.Drawing.Image = System.Drawing.Image.FromFile("d:\CSprg\icon\XR1.bmp")

        If Trim(s그룹) = "" Then Exit Sub

        Select Case UCase(Trim(s그룹))
            Case "XRAY", "X-RAY", "방사선"
                s그룹 = "d:\CSprg\icon\xr1.bmp"
            Case "LAB", "검사"
                s그룹 = "d:\CSprg\icon\임상병리.bmp"
            Case "세부"
                s그룹 = "d:\CSprg\icon\세부.bmp"
            Case Else
                s그룹 = "d:\CSprg\icon\folder.bmp"
        End Select

        Dim imgct As New FarPoint.Win.Spread.CellType.ImageCellType()
        Dim image As System.Drawing.Image = System.Drawing.Image.FromFile(s그룹)

        imgct.Style = FarPoint.Win.RenderStyle.Stretch
        imgct.TransparencyColor = Color.Black
        imgct.TransparencyTolerance = 20

        'fp처방.Sheets(0).Cells(lROW, lCOL, lROW, lCOL).BackColor = Color.Magenta
        'fp처방.Sheets(0).Columns(lROW, lCOL).Width = 100
        'fp처방.Sheets(0).Rows(lROW, lROW).Height = 50

        CONTROL.Sheets(0).Cells(lROW, lCOL, lROW, lCOL).CellType = imgct
        CONTROL.Sheets(0).Cells(lROW, lCOL).Value = image
    End Sub

End Module
