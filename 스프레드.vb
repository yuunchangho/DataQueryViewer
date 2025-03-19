Module 스프레드
    Public Function f컬럼(ByVal s작업 As String, ByVal fp스프레드 As System.Object, ByVal iROW As Integer, ByVal s컬럼 As String, ByVal i역순 As Boolean) As Integer
        Dim s값 As String, iFLAG As Integer

        iFLAG = False

        f컬럼 = IIf(s작업 = "존재", -1, 0)

        With fp스프레드.Sheets(0)
            ' 진행방항 -> 역순 .................................................................................
            If i역순 Then
                For idx = .ColumnCount - 1 To 0 Step -1
                    s값 = Replace(fp스프레드.sheets(0).Models.ColumnHeaderData.GetValue(0, idx), vbNewLine, "")

                    If Replace(UCase(Trim(s값)), " ", "") = Replace(UCase(Trim(s컬럼)), " ", "") Then
                        f컬럼 = idx : iFLAG = True

                        Exit For
                    End If
                Next
            Else
                For idx = 0 To .ColumnCount - 1
                    s값 = Replace(fp스프레드.sheets(0).Models.ColumnHeaderData.GetValue(0, idx), vbNewLine, "")

                    If Replace(UCase(Trim(s값)), " ", "") = Replace(UCase(Trim(s컬럼)), " ", "") Then
                        f컬럼 = idx : iFLAG = True

                        Exit For
                    End If
                Next
            End If

            If Not iFLAG Then
                ' 진행방항 -> 역순 .............................................................................
                If i역순 Then
                    For idx = .ColumnCount - 1 To 0 Step -1
                        s값 = Replace(fp스프레드.sheets(0).Models.ColumnHeaderData.GetValue(1, idx), vbNewLine, "")

                        If Replace(UCase(Trim(s값)), " ", "") = Replace(UCase(Trim(s컬럼)), " ", "") Then
                            f컬럼 = idx

                            Exit For
                        End If
                    Next
                Else
                    For idx = 0 To .ColumnCount - 1
                        s값 = Replace(fp스프레드.sheets(0).Models.ColumnHeaderData.GetValue(1, idx), vbNewLine, "")

                        If Replace(UCase(Trim(s값)), " ", "") = Replace(UCase(Trim(s컬럼)), " ", "") Then
                            f컬럼 = idx

                            Exit For
                        End If
                    Next
                End If
            End If
        End With


        If f컬럼 = -1 And iROW <> -1 Then
            With fp스프레드.Sheets(0)
                ' 진행방항 -> 역순 .................................................................................
                If i역순 Then
                    For idx = .ColumnCount - 1 To 0 Step -1
                        s값 = Replace(.gettext(iROW, idx), vbNewLine, "")

                        If Replace(UCase(Trim(s값)), " ", "") = Replace(UCase(Trim(s컬럼)), " ", "") Then
                            f컬럼 = idx : iFLAG = True

                            Exit For
                        End If
                    Next
                Else
                    For idx = 0 To .ColumnCount - 1
                        s값 = Replace(.gettext(iROW, idx), vbNewLine, "")

                        If Replace(UCase(Trim(s값)), " ", "") = Replace(UCase(Trim(s컬럼)), " ", "") Then
                            f컬럼 = idx : iFLAG = True

                            Exit For
                        End If
                    Next
                End If
            End With
        End If

        Return f컬럼
    End Function

    Public Sub s결재정보표시(ByVal f스프레드 As FarPoint.Win.Spread.FpSpread, ByVal s문서명 As String, ByVal i기준ROW As Integer, ByVal i기준COL As Integer)
        ' ----------------------------------------------------------------------------------------------------
        Call 공용.s문서결재정보("", s문서명)

        ' ----------------------------------------------------------------------------------------------------
        If UBound(결재) > 0 Then
            With f스프레드.Sheets(0)
                For xx = UBound(결재) To 1 Step -1
                    .AddSpanCell(i기준ROW, i기준COL - (UBound(결재) - xx) * 2, 1, 2)
                    .AddSpanCell(i기준ROW + 1, i기준COL - (UBound(결재) - xx) * 2, 2, 2)

                    .Cells(i기준ROW, i기준COL - (UBound(결재) - xx) * 2).BackColor = Color.WhiteSmoke

                    .SetText(i기준ROW, i기준COL - (UBound(결재) - xx) * 2, 결재(xx))
                Next

                .AddSpanCell(i기준ROW, i기준COL - UBound(결재) * 2 + 1, 3, 1)

                .Cells(i기준ROW, i기준COL - UBound(결재) * 2 + 1).BackColor = Color.WhiteSmoke

                .SetText(i기준ROW, i기준COL - UBound(결재) * 2 + 1, "결재")

                ' boarder line
                .Cells(i기준ROW, i기준COL - UBound(결재) * 2 + 1).Border = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered, Color.Black, Color.Black, 1,
                                                                                                           True, False, True, True)

                .Cells(i기준ROW, i기준COL - UBound(결재) * 2 + 2, i기준ROW + 2, i기준COL).Border = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered, Color.Black, Color.Blue, 1,
                                                                                                           False, False, True, True)
            End With
        End If
    End Sub
    '특정 약품이나 주사와 관련된 이미지를 스프레드시트의 셀에 표시하는 데 사용
    Public Sub s약주사이미지(ByVal f스프레드 As FarPoint.Win.Spread.FpSpread, ByVal i양한방 As Integer, ByVal s항목 As String, ByVal s메모 As String, ByVal i치매약제 As Integer,
                                                ByVal lROW As Long, ByVal lCOL As Long)
        Dim txtcell As New FarPoint.Win.Spread.CellType.TextCellType()

        Dim s이미지 As String

        'Dim image As System.Drawing.Image = System.Drawing.Image.FromFile("d:\CSprg\icon\XR1.bmp")

        'If Trim(s항목) = "" Or s메모 = "메모" Or s메모 = "-메모-" Then
        If Trim(s항목) = "" Then
            f스프레드.Sheets(0).Cells(lROW, lCOL, lROW, lCOL).CellType = txtcell
            f스프레드.Sheets(0).SetText(lROW, lCOL, "")

            Exit Sub
        End If

        s이미지 = ""

        Select Case UCase(s항목)
            Case "심사지침"
                If Len(Dir(Application.StartupPath & "\icon\심사지침.bmp")) <> 0 Then
                    s이미지 = Application.StartupPath & "\icon\심사지침.bmp"
                Else
                    s이미지 = Application.StartupPath & "\icon\폴더.bmp"
                End If

            Case "알림"
                If Len(Dir(Application.StartupPath & "\icon\알림.bmp")) <> 0 Then
                    s이미지 = Application.StartupPath & "\icon\알림.bmp"
                Else
                    s이미지 = Application.StartupPath & "\icon\폴더.bmp"
                End If

            Case "금액"
                If Len(Dir(Application.StartupPath & "\icon\금액.bmp")) <> 0 Then
                    s이미지 = Application.StartupPath & "\icon\금액.bmp"
                Else
                    s이미지 = Application.StartupPath & "\icon\폴더.bmp"
                End If

            Case "오류"
                If Len(Dir(Application.StartupPath & "\icon\오류.bmp")) <> 0 Then
                    s이미지 = Application.StartupPath & "\icon\오류.bmp"
                Else
                    s이미지 = Application.StartupPath & "\icon\폴더.bmp"
                End If

            Case "경고"
                If Len(Dir(Application.StartupPath & "\icon\경고.bmp")) <> 0 Then
                    s이미지 = Application.StartupPath & "\icon\경고.bmp"
                Else
                    s이미지 = Application.StartupPath & "\icon\폴더.bmp"
                End If

            Case "정보"
                If Len(Dir(Application.StartupPath & "\icon\정보.bmp")) <> 0 Then
                    s이미지 = Application.StartupPath & "\icon\정보.bmp"
                Else
                    s이미지 = Application.StartupPath & "\icon\폴더.bmp"
                End If

            Case "메모", "-메모-"
                If Len(Dir(Application.StartupPath & "\icon\메모.bmp")) <> 0 Then
                    s이미지 = Application.StartupPath & "\icon\메모.bmp"
                Else
                    s이미지 = Application.StartupPath & "\icon\폴더.bmp"
                End If

            Case "셀프"
                If Len(Dir(Application.StartupPath & "\icon\셀프.bmp")) <> 0 Then
                    s이미지 = Application.StartupPath & "\icon\셀프.bmp"
                Else
                    s이미지 = Application.StartupPath & "\icon\폴더.bmp"
                End If

            Case "그룹"
                If Len(Dir(Application.StartupPath & "\icon\그룹.bmp")) <> 0 Then
                    s이미지 = Application.StartupPath & "\icon\그룹.bmp"
                Else
                    s이미지 = Application.StartupPath & "\icon\폴더.bmp"
                End If

            Case "잠김", "LOCK"
                If Len(Dir(Application.StartupPath & "\icon\자물쇠02.bmp")) <> 0 Then
                    s이미지 = Application.StartupPath & "\icon\자물쇠02.bmp"
                Else
                    s이미지 = Application.StartupPath & "\icon\자물쇠.bmp"
                End If

            Case Else
                Select Case Trim(Mid(UCase(s항목), 1, 2))
                    Case "01"
                        If Len(Dir(Application.StartupPath & "\icon\진찰료.bmp")) <> 0 Then
                            s이미지 = Application.StartupPath & "\icon\진찰료.bmp"
                        Else
                            s이미지 = Application.StartupPath & "\icon\청진기.bmp"
                        End If

                    Case "02"
                        Select Case UCase(Trim(s항목))
                            Case "0210", "0211"
                                s이미지 = Application.StartupPath & "\icon\식당.bmp"
                            Case Else
                                s이미지 = Application.StartupPath & "\icon\입원.bmp"
                        End Select

                    Case "03"
                        If i치매약제 = 1 Then
                            s이미지 = Application.StartupPath & "\icon\치매.bmp"
                        Else
                            Select Case UCase(s항목)
                                Case "0302"
                                    s이미지 = Application.StartupPath & "\icon\외용.bmp"
                                Case Else
                                    s이미지 = Application.StartupPath & "\icon\약01.bmp"
                            End Select
                        End If

                    Case "04"
                        s이미지 = Application.StartupPath & "\icon\주사.bmp"

                    Case "05"
                        s이미지 = Application.StartupPath & "\icon\마취.bmp"

                    Case "06"
                        s이미지 = Application.StartupPath & "\icon\물리치료.bmp"

                    Case "07"
                        s이미지 = Application.StartupPath & "\icon\정신요법.bmp"

                    Case "08"
                        Select Case UCase(Trim(s항목))
                            Case "0803"
                                s이미지 = Application.StartupPath & "\icon\캐스트.bmp"
                            Case Else
                                s이미지 = Application.StartupPath & "\icon\수술.bmp"
                        End Select

                    Case "09"
                        s이미지 = Application.StartupPath & "\icon\임상병리2.bmp"

                    Case "10"
                        s이미지 = Application.StartupPath & "\icon\방사선.bmp"

                    Case "A"
                        f스프레드.Sheets(0).Cells(lROW, lCOL).CellType = txtcell
                        f스프레드.Sheets(0).SetText(lROW, lCOL, "Ａ")

                    Case "B"
                        f스프레드.Sheets(0).Cells(lROW, lCOL).CellType = txtcell
                        f스프레드.Sheets(0).SetText(lROW, lCOL, "Ｂ")

                    Case "D"
                        f스프레드.Sheets(0).Cells(lROW, lCOL).CellType = txtcell
                        f스프레드.Sheets(0).SetText(lROW, lCOL, "Ｄ")

                    Case "E"
                        f스프레드.Sheets(0).Cells(lROW, lCOL).CellType = txtcell
                        f스프레드.Sheets(0).SetText(lROW, lCOL, "Ｅ")

                    Case "TT"
                        ' 초음파
                        s이미지 = Application.StartupPath & "\icon\초음파.bmp"

                    Case "SS", "C"
                        Select Case UCase(Trim(s항목))
                            Case "SS02"
                                s이미지 = Application.StartupPath & "\icon\MRI.bmp"
                            Case Else
                                s이미지 = Application.StartupPath & "\icon\CT.bmp"
                        End Select

                    Case Else
                        Exit Sub
                End Select
        End Select

        If Len(Dir(s이미지)) = 0 Then
            Exit Sub

        ElseIf Trim(s이미지) = "" Then
            Exit Sub
        End If

        Dim imgct As New FarPoint.Win.Spread.CellType.ImageCellType()
        Dim image As System.Drawing.Image = System.Drawing.Image.FromFile(s이미지)

        imgct.Style = FarPoint.Win.RenderStyle.Stretch
        imgct.TransparencyColor = Color.Black
        imgct.TransparencyTolerance = 20

        f스프레드.Sheets(0).Cells(lROW, lCOL, lROW, lCOL).CellType = imgct
        f스프레드.Sheets(0).Cells(lROW, lCOL, lROW, lCOL).Tag = s항목                 ' 20/03/04 희빈 태그에 항목값 담기
        f스프레드.Sheets(0).Cells(lROW, lCOL).Value = image
    End Sub

    Public Sub s레이블아이콘설정(ByVal s구분 As String, ByVal l레이블 As DevExpress.XtraEditors.LabelControl)
        On Error GoTo EXIT_RTN

        l레이블.ImageOptions.Image = Image.FromFile("c:\Sense\SenseNew\icon\" & s구분 & ".bmp")

EXIT_RTN:

    End Sub

    Public Function f선택자료존재여부(ByVal s작업 As String, ByVal f스프레드 As FarPoint.Win.Spread.FpSpread, ByVal iCOL As Integer) As Boolean
        f선택자료존재여부 = False

        With f스프레드.Sheets(0)
            For ii = 0 To .NonEmptyRowCount - 1
                If 스프레드.f체크CELL("get", f스프레드, ii, iCOL, "") = "1" Then
                    f선택자료존재여부 = True

                    Exit For
                End If
            Next
        End With

        Return f선택자료존재여부
    End Function

    Public Function f명칭아이콘설정(ByVal s구분 As String, ByVal f스프레드 As FarPoint.Win.Spread.FpSpread, ByVal iROW As Integer, ByVal iCOL As Integer, ByVal i수평정렬 As Integer,
                                                            ByVal s코드 As String, ByVal s명칭 As String) As Boolean
        Dim checkcell As New FarPoint.Win.Spread.CellType.CheckBoxCellType

        On Error GoTo EXIT_RTN

        f명칭아이콘설정 = False

        Select Case UCase(s구분)
            Case "선별A(50%)", "선별B(80%)", "선별D(30%)", "선별E(90%)"

            Case "외래"

            Case "삭제", "취소", "원내", "원외", "묶음", "급여", "전액", "전액본인", "비급", "비급여", "무료", "무료단가"

            Case "정보", "경고", "오류", "금액", "사전점검"

            Case "금일", "예정", "픽업", "완료", "주의", "심사", "격리"

            Case "심결"

            Case Else
                s구분 = "정보"
        End Select

        If Dir("c:\Sense\SenseNew\icon\" & s구분 & ".bmp") <> "" Then
            i수평정렬 = If(i수평정렬 = -1, FarPoint.Win.Spread.CellHorizontalAlignment.Left, i수평정렬)

            If Trim(s구분) <> "" Then
                checkcell.Picture(FarPoint.Win.CheckBoxPictureIndex.True) = Image.FromFile("c:\Sense\SenseNew\icon\" & s구분 & ".bmp")
                checkcell.Picture(FarPoint.Win.CheckBoxPictureIndex.TruePressed) = Image.FromFile("c:\Sense\SenseNew\icon\" & s구분 & ".bmp")
                checkcell.Picture(FarPoint.Win.CheckBoxPictureIndex.TrueDisabled) = Image.FromFile("c:\Sense\SenseNew\icon\" & s구분 & ".bmp")

                checkcell.Picture(FarPoint.Win.CheckBoxPictureIndex.False) = Image.FromFile("c:\Sense\SenseNew\icon\" & s구분 & ".bmp")
                checkcell.Picture(FarPoint.Win.CheckBoxPictureIndex.FalsePressed) = Image.FromFile("c:\Sense\SenseNew\icon\" & s구분 & ".bmp")
                checkcell.Picture(FarPoint.Win.CheckBoxPictureIndex.FalseDisabled) = Image.FromFile("c:\Sense\SenseNew\icon\" & s구분 & ".bmp")
            End If

            checkcell.PictureZoomEffect = True

            checkcell.TextTrue = s명칭 : checkcell.TextFalse = s명칭

            checkcell.Caption = s명칭

            f스프레드.Sheets(0).Cells(iROW, iCOL).Locked = True
            f스프레드.Sheets(0).Cells(iROW, iCOL).CellType = checkcell
            'f스프레드.Sheets(0).Cells(iROW, iCOL).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
            f스프레드.Sheets(0).Cells(iROW, iCOL).HorizontalAlignment = i수평정렬

            Select Case UCase(s구분)
                Case "심결"

                Case Else
                    f스프레드.Sheets(0).Rows(iROW).Height = 25
            End Select

            f명칭아이콘설정 = True
        End If

EXIT_RTN:

        Return f명칭아이콘설정

    End Function
    '셀에 주석을 추가하거나 주석 관련 설정을 변경하는 데 사용
    Public Sub sCELLNOTE(ByVal s작업 As String, ByVal fSPREAD As FarPoint.Win.Spread.FpSpread, ByVal iROW As Integer, ByVal iCOL As Integer,
                                        ByVal i높이 As Integer, ByVal i폭 As Integer, ByVal i위치 As Integer, ByVal i색상 As Color, ByVal sNOTE As String)
        With fSPREAD.Sheets(0)
            .Cells(iROW, iCOL).Note = sNOTE
            .Cells(iROW, iCOL).NoteIndicatorSize = New Size(i높이, i폭)
            .Cells(iROW, iCOL).NoteIndicatorColor = i색상
            .Cells(iROW, iCOL).NoteIndicatorPosition = i위치

            .Cells(iROW, iCOL).NoteIndicatorPosition = FarPoint.Win.Spread.NoteIndicatorPosition.TopLeft
        End With
    End Sub
    '스프레드시트의 모든 데이터를 지우고 필요한 경우 행수 재설정
    Public Sub s지우기(ByVal s구분 As String, ByVal f스프레드 As FarPoint.Win.Spread.FpSpread, ByVal iROW As Integer)
        If IsNothing(f스프레드) Then Exit Sub

        If f스프레드.Sheets.Count > 0 Then
            With f스프레드.Sheets(0)
                .ClearRange(0, 0, .RowCount, .ColumnCount, True)

                If iROW <> -1 Then .RowCount = iROW
            End With
        End If
    End Sub

    '스프레드시트의 특정 셀에서 체크된 상태를 가져오거나 설정하는데 사용 
    Public Function f체크CELL(ByVal s구분 As String, ByVal f스프레드 As FarPoint.Win.Spread.FpSpread, ByVal iROW As Integer, ByVal iCOL As Integer, ByVal s값 As String,
                                        Optional ByVal FColor As Color = Nothing, Optional ByVal BColor As Color = Nothing) As String
        f체크CELL = ""

        Select Case UCase(s구분)
            Case "GET"
                Select Case UCase(f스프레드.Sheets(0).GetText(iROW, iCOL))
                    Case "TRUE", "T", "1"
                        f체크CELL = "1"

                    Case Else
                        f체크CELL = "0"
                End Select

            Case "SET"
                Select Case UCase(s값)
                    Case "TRUE", "T", "1"
                        f스프레드.Sheets(0).SetText(iROW, iCOL, "1")

                    Case Else
                        f스프레드.Sheets(0).SetText(iROW, iCOL, "0")
                End Select
        End Select

        Return f체크CELL
    End Function
    '스프레드시트의 특정 셀에 체크박스를 추가하고 설정 이 함수는 사용자가 데이터를 입력하거나 선택할 수 있는 인터페이스를 제공
    Public Sub s체크셀설정(ByVal f스프레드 As FarPoint.Win.Spread.FpSpread, ByVal iROW As Integer, ByVal iCOL As Integer, ByVal i수평정렬 As Integer,
                                                            ByVal s코드 As String, ByVal s명칭 As String, Optional iLOCK As Boolean = False)
        Dim checkcell As New FarPoint.Win.Spread.CellType.CheckBoxCellType

        checkcell.Picture(FarPoint.Win.CheckBoxPictureIndex.True) = Image.FromFile("c:\Sense\SenseNew\icon\체크k_80.bmp")
        checkcell.Picture(FarPoint.Win.CheckBoxPictureIndex.TruePressed) = Image.FromFile("c:\Sense\SenseNew\icon\체크k_80.bmp")
        checkcell.Picture(FarPoint.Win.CheckBoxPictureIndex.TrueDisabled) = Image.FromFile("c:\Sense\SenseNew\icon\체크k_80.bmp")

        checkcell.Picture(FarPoint.Win.CheckBoxPictureIndex.False) = Image.FromFile("c:\Sense\SenseNew\icon\체크00_80.bmp")
        checkcell.Picture(FarPoint.Win.CheckBoxPictureIndex.FalsePressed) = Image.FromFile("c:\Sense\SenseNew\icon\체크00_80.bmp")
        checkcell.Picture(FarPoint.Win.CheckBoxPictureIndex.FalseDisabled) = Image.FromFile("c:\Sense\SenseNew\icon\체크00_80.bmp")

        checkcell.TextTrue = s명칭 : checkcell.TextFalse = s명칭

        checkcell.Caption = s명칭

        If iROW = -1 Then
            f스프레드.Sheets(0).Columns(iCOL).Locked = True
            f스프레드.Sheets(0).Columns(iCOL).CellType = checkcell
            f스프레드.Sheets(0).Columns(iCOL).HorizontalAlignment = i수평정렬
        Else
            f스프레드.Sheets(0).Cells(iROW, iCOL).Locked = True
            f스프레드.Sheets(0).Cells(iROW, iCOL).CellType = checkcell
            'f스프레드.Sheets(0).Cells(iROW, iCOL).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
            f스프레드.Sheets(0).Cells(iROW, iCOL).HorizontalAlignment = i수평정렬
        End If
    End Sub
    '각각 텍스트 입력과 버튼 기능을 셀에 추가
    Public Sub sTEXT_CELL(ByVal f스프레드 As FarPoint.Win.Spread.FpSpread, ByVal iROW As Integer, ByVal iCOL As Integer, ByVal i길이 As Integer,
                                    Optional ByVal i수평정렬 As Integer = FarPoint.Win.Spread.CellHorizontalAlignment.Left, Optional ByVal s텍스트 As String = "")
        Dim tcell As New FarPoint.Win.Spread.CellType.TextCellType()

        tcell.CharacterCasing = CharacterCasing.Normal

        tcell.CharacterSet = FarPoint.Win.Spread.CellType.CharacterSet.Ascii

        tcell.MaxLength = i길이
        tcell.Multiline = True

        If iROW <> -1 Then
            f스프레드.Sheets(0).Cells(iROW, iCOL).Text = ""

            f스프레드.Sheets(0).Cells(iROW, iCOL).CellType = tcell
            f스프레드.Sheets(0).Cells(iROW, iCOL).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
            f스프레드.Sheets(0).Cells(iROW, iCOL).HorizontalAlignment = i수평정렬

            If Trim(s텍스트) <> "" Then f스프레드.Sheets(0).SetText(iROW, iCOL, s텍스트)
        Else
            f스프레드.Sheets(0).Columns(iCOL).CellType = tcell

            f스프레드.Sheets(0).Columns(iCOL).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
            f스프레드.Sheets(0).Columns(iCOL).HorizontalAlignment = i수평정렬

            f스프레드.Sheets(0).Columns(iCOL).Width = 75
        End If
    End Sub
    Public Sub sBUTTON_CELL(ByVal s작업 As String, ByVal f스프레드 As FarPoint.Win.Spread.FpSpread, ByVal iROW As Integer, ByVal iCOL As Integer, ByVal sTEXT As String)
        Dim bttncell As New FarPoint.Win.Spread.CellType.ButtonCellType()

        bttncell.ButtonColor = Color.Cyan
        bttncell.DarkColor = Color.DarkCyan
        bttncell.LightColor = Color.AliceBlue

        bttncell.TwoState = False
        bttncell.Text = sTEXT

        bttncell.ShadowSize = 3

        f스프레드.Sheets(0).Cells(iROW, iCOL).CellType = bttncell
        f스프레드.Sheets(0).Cells(iROW, iCOL).Text = sTEXT
    End Sub
End Module
