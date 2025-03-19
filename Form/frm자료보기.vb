Imports System.Data.SqlClient

Public Class frm자료보기
    Public Sub New()

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

    End Sub

    Enum e검색
        분류 = 0
        소분류
        내용
        타이틀
        인덱스

    End Enum
    Private strD_DBName As String
    Private s기본코드 As Integer
    Private Sub sDB정보(ByVal s작업 As String)
        Dim sSQL As New SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String
        Dim ii As Object
        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        ReDim LOOKUP(0)

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "select	name
                    from	sys.sysdatabases
                    order by name"

        sSQL = New SqlCommand(QRY, SVREMR)

        sSQL.CommandTimeout = 600

        rs = sSQL.ExecuteReader()

        While rs.Read()
            ii = UBound(LOOKUP) + 1
            ReDim Preserve LOOKUP(ii)

            LOOKUP(ii).항목1 = fNULL(rs.GetValue(0)) : LOOKUP(ii).항목2 = fNULL(rs.GetValue(0))
        End While

        ' ....................................................................................................
        rs.Close()

        If UBound(LOOKUP) > 0 Then
            Call slu초기값("", luDB, 40) : luDB.EditValue = LOOKUP(1).항목2
        End If
    End Sub

    Private Sub AS발생자료sub확인(ByVal s작업 As String, ByVal i인덱스 As String)
        Dim sSQL As SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        tab쿼리.TabPages(1).PageVisible = True

        With f결과sub.Sheets(0)
            .RowCount = 0 : .ColumnCount = 0
        End With

        tab쿼리.TabPages(1).Text = "New Query"

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "select	top 1
		                타이틀,				쿼리,				확인방법,				처리방법,
                        분류
                    from	[" & strD_DBName & "]..AS발생자료확인
                    where	인덱스id			=  " & i인덱스 & " 
                    and		인덱스			!= 인덱스id
                    order by 이전인덱스"

        sSQL = New SqlCommand(QRY, emr센스)

        sSQL.CommandTimeout = 600

        rs = sSQL.ExecuteReader()

        ' ----------------------------------------------------------------------------------------------------
        While rs.Read()
            tab쿼리.TabPages(1).Text = fNULL(rs.Item("타이틀"))

            t쿼리sub.Text = fNULL(rs.Item("쿼리"))

            t쿼리sub.Tag = Replace(fNULL(rs.GetValue(1)), "[DBname]", DBname)
            t쿼리sub.Tag = Replace(t쿼리sub.Tag, "[DBreview]", DBreview)
        End While

        ' ----------------------------------------------------------------------------------------------------
        rs.Close()

        ' ----------------------------------------------------------------------------------------------------
        If Trim(t쿼리sub.Tag) <> "" Then
            Call s검색조건대체("", t쿼리sub)
        End If
    End Sub

    Private Sub AS발생자료확인(ByVal s작업 As String, ByVal i인덱스 As String)
        Dim sSQL As SqlCommand
        Dim rs As SqlDataReader


        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        With f결과.Sheets(0)
            .RowCount = 0 : .ColumnCount = 0
        End With

        tab쿼리.TabPages(0).Text = "New Query"
        tab쿼리.TabPages(1).PageVisible = False

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "select	타이틀,				쿼리,				확인방법,				처리방법,
                        분류 , 기본코드
                    from	[" & strD_DBName & "]..AS발생자료확인 with(nolock)
                    where	인덱스		=  " & i인덱스 & " "

        sSQL = New SqlCommand(QRY, emr센스)

        sSQL.CommandTimeout = 600

        rs = sSQL.ExecuteReader()

        ' ----------------------------------------------------------------------------------------------------
        While rs.Read()
            tab쿼리.TabPages(0).Text = fNULL(rs.Item("분류"))

            t쿼리.Text = fNULL(rs.Item("쿼리"))

            t쿼리.Tag = Replace(fNULL(rs.Item("쿼리")), "[DBname]", flookup("get", luDB))
            t쿼리.Tag = Replace(t쿼리.Tag, "[DBreview]", DBreview)

            l확인방법.Text = fNULL(rs.Item("확인방법"))         'fNuLL 에서 쿼리넣었을때 '대신 ^ 섰던 것 변환 , null이면 빈 값

            s기본코드 = fNULL(rs.Item("기본코드"))
        End While

        ' ----------------------------------------------------------------------------------------------------
        rs.Close()

        ' ----------------------------------------------------------------------------------------------------
        If Trim(t쿼리.Tag) <> "" Then
            Call s검색조건대체("", t쿼리)
        End If
    End Sub

    Private Sub s검색(ByVal s작업 As String, ByVal s검색어 As String)
        Dim sSQL As SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        Call 스프레드.s지우기("", f검색, 0)

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "select	대분류,		소분류, 	분류,			인덱스id,      	타이틀
                    from	[" & strD_DBName & "]..AS발생자료확인 with(nolock)
                    where	분류					like '%" & fQRY(s검색어) & "%'
                    and     isnull(분류,'')   	!=  ''
                    order by 대분류, 분류"

        sSQL = New SqlCommand(QRY, emr센스)

        sSQL.CommandTimeout = 600

        rs = sSQL.ExecuteReader()

        ' ----------------------------------------------------------------------------------------------------
        While rs.Read()
            With f검색.Sheets(0)
                .RowCount += 1

                .Rows(.RowCount - 1).Height = 25

                .SetText(.RowCount - 1, e검색.분류, fNULL(rs.Item("대분류")))
                .SetText(.RowCount - 1, e검색.소분류, fNULL(rs.Item("소분류")))
                .SetText(.RowCount - 1, e검색.내용, fNULL(rs.Item("분류")))
                .SetText(.RowCount - 1, e검색.인덱스, fNULL(rs.Item("인덱스id")))
                .SetText(.RowCount - 1, e검색.타이틀, fNULL(rs.Item("타이틀")))

            End With
        End While

        ' ----------------------------------------------------------------------------------------------------
        rs.Close()
    End Sub




    Private Function fDATA_CHECK() As Boolean  'CREATE,DROP,TRUNCATE,INSERT 텍스트 포함되면 실행하지 못하도록 표시
        fDATA_CHECK = True

        If InStr(1, UCase(t쿼리.Text), "CREATE") <> 0 Then
            Call CONTROL.f메세지창("", "Query Error", "<sz=12><red><b>create</b></c> Query는 실행할 수 없습니다 !!", MessageBoxButtons.OK)

            fDATA_CHECK = False
        End If

        If InStr(1, UCase(t쿼리.Text), "DROP") <> 0 Then
            Call CONTROL.f메세지창("", "Query Error", "<sz=12><red><b>drop</b></c> Query는 실행할 수 없습니다 !!", MessageBoxButtons.OK)

            fDATA_CHECK = False
        End If

        If InStr(1, UCase(t쿼리.Text), "TRUNCATE") <> 0 Then
            Call CONTROL.f메세지창("", "Query Error", "<sz=12><red><b>truncate</b></c> Query는 실행할 수 없습니다 !!", MessageBoxButtons.OK)

            fDATA_CHECK = False
        End If

        If InStr(1, UCase(t쿼리.Text), "INSERT") <> 0 Or InStr(1, UCase(t쿼리.Text), "UPDATE") <> 0 Or InStr(1, UCase(t쿼리.Text), "DELETE") <> 0 Then
            Call CONTROL.f메세지창("", "Query Error", "<sz=12><red><b>insert, update, delete</b></c> Query는 실행할 수 없습니다 !!", MessageBoxButtons.OK)

            fDATA_CHECK = False
        End If

        Return fDATA_CHECK
    End Function

    Private Sub s화면지우기(ByVal s작업 As String)
        Select Case UCase(s작업)
            Case "ALL"
                Call 스프레드.s지우기("", f검색, 0)

            Case "기본코드"
                Call 스프레드.s지우기("", sprCodes, 0)

        End Select

        If tab쿼리.TabPages.Count > 0 Then
            tab쿼리.TabPages(0).Text = "New Query"
        End If

        l확인방법.Text = ""
    End Sub

    Public Sub sDB연결(ByVal s작업 As String, ByVal s서버명 As String, ByVal sDB명 As String, ByVal s사용자 As String, ByVal s비밀번호 As String)
        l서버연결해제.Visible = True : l서버연결.Visible = False

        Try
            emr센스 = New SqlConnection("Server=" & s서버명 & ";Database=" & sDB명 & ";User Id=" & s사용자 & ";Password=" & s비밀번호 & ";MultipleActiveResultSets=true")

            emr센스.Open()

            l서버연결.Left = l서버연결해제.Left : l서버연결.Top = l서버연결해제.Top

            l서버연결해제.Visible = False : l서버연결.Visible = True

            'l서버연결해제.Visible = True : l서버연결.Visible = True

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "DB 연결", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub sINI정보읽기(ByVal s프로그램 As String)
        Dim res As Integer
        Dim sb As String

        Dim intSize As Integer

        ' 서버 정보 ...........................................................................................
        SERVERname = CONTROL.fINI가져오기("", "Database Server", "server_name", "c:\" & s프로그램 & "\Bin\" & s프로그램 & ".ini")

        ' DataBase 정보 .......................................................................................
        DBname = CONTROL.fINI가져오기("", "Database Server", "database_name", "c:\" & s프로그램 & "\Bin\" & s프로그램 & ".ini")
        DBreview = CONTROL.fINI가져오기("", "Database Server", "database_name_simsa", "c:\" & s프로그램 & "\Bin\" & s프로그램 & ".ini")

        ' 사용자id 정보 ........................................................................................
        USERID = CONTROL.fINI가져오기("", "Database Server", "server_id", "c:\" & s프로그램 & "\Bin\" & s프로그램 & ".ini")

        ' 사용자pw 정보 ........................................................................................
        USERPASSWD = CONTROL.fINI가져오기("", "Database Server", "server_pwd", "c:\" & s프로그램 & "\Bin\" & s프로그램 & ".ini")

        l서버연결.Text = "      Now " & DBname & " DB Connected...."
        l서버연결해제.Text = DBname & " DB Not Connected...."
    End Sub

    Public Sub s초기값()
        Call sINI정보읽기("sense")

        Call sDB연결("", SERVERname, DBname, USERID, USERPASSWD)

        ' 서버에 존재하는 DB정보 load ...........................................................................
        Call sDB정보("")

        luDB.EditValue = DBname

        ' ----------------------------------------------------------------------------------------------------
        tab쿼리.TabPages(1).PageVisible = False

        With f결과.Sheets(0)
            .RowCount = 0 : .ColumnCount = 0
        End With

        With f결과sub.Sheets(0)
            .RowCount = 0 : .ColumnCount = 0
        End With

        d산출기간1.EditValue = fDATE_TIME("date")
        d산출기간2.EditValue = d산출기간2.EditValue
    End Sub

    Private Sub frm자료보기_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 화면 지우기
        Call s화면지우기("all")
        s초기값()
    End Sub

    Private Sub s컬럼수평정렬(ByVal s작업 As String, ByVal iCOL As Integer, sTYPE As String)
        With f결과.Sheets(0)
            Select Case sTYPE
                Case "SqlByte"
                    .Columns(iCOL).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center

                Case "SqlInt32"
                    .Columns(iCOL).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right

                Case "SqlString"
                    .Columns(iCOL).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left

                Case Else
                    .Columns(iCOL).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
            End Select
        End With
    End Sub

    Private Sub s실행(ByVal s작업 As String, ByVal s쿼리 As String, ByVal f스프레드 As FarPoint.Win.Spread.FpSpread)
        Dim sSQL As SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        Dim xx As Integer

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        With f스프레드.Sheets(0)    '모든 행 열 비우기
            .RowCount = 0 : .ColumnCount = 0
        End With

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        Try
            QRY = s쿼리

            sSQL = New SqlCommand(QRY, emr센스)

            sSQL.CommandTimeout = 600

            rs = sSQL.ExecuteReader()

            ' 컬럼 정보 표시
            If Not rs.IsClosed Then
                With f스프레드.Sheets(0)
                    .ColumnCount = rs.FieldCount

                    For xx = 0 To rs.FieldCount - 1
                        Call 스프레드.sTEXT_CELL(f스프레드, -1, xx, 512)
                    Next

                    For xx = 0 To rs.FieldCount - 1
                        .ColumnHeader.Columns(0, xx).Font = New Font("맑은 고딕", 8, FontStyle.Bold)

                        .SetColumnLabel(0, xx, rs.GetName(xx))

                        Select Case Replace(rs.GetName(xx), " ", "")
                            Case "처방코드", "수가코드", "청구코드"
                                .ColumnHeader.Columns(xx).Width = 75

                            Case "명칭", "처방명", "처방명칭", "한글명", "한글명칭"
                                .ColumnHeader.Columns(xx).Width = 300

                            Case Else
                                'If InStr(1, rs.GetName(xx), "단가") <> 0 Then
                                '    .ColumnHeader.Columns(xx).Width = 75
                                'Else
                                '    .ColumnHeader.Columns(xx).Width = f문자길이(rs.GetName(xx)) * 7
                                'End If
                        End Select

                        .Columns(xx).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
                    Next
                End With
            End If

            ' ----------------------------------------------------------------------------------------------------
            While rs.Read()
                With f스프레드.Sheets(0)
                    .RowCount += 1

                    .Rows(.RowCount - 1).Height = 23

                    'Application.DoEvents()

                    For xx = 0 To rs.FieldCount - 1
                        Call s컬럼수평정렬("", xx, rs.GetSqlValue(xx).GetType.Name)

                        .SetText(.RowCount - 1, xx, fNULL(rs.GetValue(xx)))

                        If InStr(1, .GetColumnLabel(0, xx), "일자") <> 0 Then
                            .Columns(xx).Width = .GetPreferredColumnWidth(xx)
                        End If
                    Next
                End With
            End While

            ' ----------------------------------------------------------------------------------------------------
            rs.Close()

        Catch ex As Exception
            Call CONTROL.f메세지창("", "Query Error", "<sz=12>" & ex.Message, MessageBoxButtons.OK)
            Exit Sub
        End Try
    End Sub

    Private Sub s데이타오류표시(ByVal s작업 As String)
        Dim xx As Integer

        Dim iCOL As Integer

        Select Case UCase(s작업)
            Case "청구 집계금액 비교"
                If 스프레드.f컬럼("존재", f결과, -1, "금액비교", False) <> -1 Then
                    iCOL = 스프레드.f컬럼("", f결과, -1, "금액비교", False)

                    With f결과.Sheets(0)
                        For xx = 0 To .NonEmptyRowCount - 1
                            If .GetText(xx, iCOL) <> "" Then
                                Call 스프레드.f명칭아이콘설정("오류", f결과, xx, iCOL, FarPoint.Win.Spread.CellHorizontalAlignment.Center,
                                                                        "", .GetText(xx, iCOL))
                            End If
                        Next
                    End With
                End If

            Case "처방전교부번호"
                If 스프레드.f컬럼("존재", f결과, -1, "처방전교부번호", False) <> -1 Then
                    iCOL = 스프레드.f컬럼("", f결과, -1, "처방전교부번호", False)

                    With f결과.Sheets(0)
                        For xx = 0 To .NonEmptyRowCount - 1
                            If .GetText(xx, iCOL) < 0 Then
                                Call 스프레드.f명칭아이콘설정("오류", f결과, xx, iCOL, FarPoint.Win.Spread.CellHorizontalAlignment.Center,
                                                                        "", .GetText(xx, iCOL))
                            End If
                        Next
                    End With
                End If

            Case "수탁기관기호 특정내역"
                If 스프레드.f컬럼("존재", f결과, -1, "수탁기관기호", False) <> -1 Then
                    iCOL = 스프레드.f컬럼("", f결과, -1, "수탁기관기호", False)

                    With f결과.Sheets(0)
                        For xx = 0 To .NonEmptyRowCount - 1
                            If .GetText(xx, iCOL) = "" Then
                                Call 스프레드.f명칭아이콘설정("오류", f결과, xx, iCOL, FarPoint.Win.Spread.CellHorizontalAlignment.Center,
                                                                        "", .GetText(xx, iCOL))
                            End If
                        Next
                    End With
                End If

            Case "본인부담상한액 집계"
                If 스프레드.f컬럼("존재", f결과, -1, "본인부담상한금", False) <> -1 Then
                    iCOL = 스프레드.f컬럼("", f결과, -1, "본인부담상한금", False)

                    With f결과.Sheets(0)
                        For xx = 0 To .NonEmptyRowCount - 1
                            If Val(Replace(.GetText(xx, iCOL), ",", "")) <> 0 Then
                                Call 스프레드.f명칭아이콘설정("오류", f결과, xx, iCOL, FarPoint.Win.Spread.CellHorizontalAlignment.Center,
                                                                        "", .GetText(xx, iCOL))
                            End If
                        Next
                    End With
                End If


            Case "예약관리" '25/03/05 범준 진료실사용여부 오류아이콘 추가
                If 스프레드.f컬럼("존재", f결과, -1, "진료실사용여부", False) <> -1 Then
                    iCOL = 스프레드.f컬럼("", f결과, -1, "진료실사용여부", False)

                    With f결과.Sheets(0)
                        For xx = 0 To .NonEmptyRowCount - 1
                            If Val(Replace(.GetText(xx, iCOL), ",", "")) <> 0 Then
                                Call 스프레드.f명칭아이콘설정("오류", f결과, xx, iCOL, FarPoint.Win.Spread.CellHorizontalAlignment.Center,
                                                                        "", .GetText(xx, iCOL))
                            End If
                        Next
                    End With
                End If

            Case "기타메모종류,내용" '25/03/17 범준 기타메모 팝업 사용여부 오류아이콘 추가
                If 스프레드.f컬럼("존재", f결과, -1, "팝업", False) <> -1 Then
                    iCOL = 스프레드.f컬럼("", f결과, -1, "팝업", False)

                    With f결과.Sheets(0)
                        For xx = 0 To .NonEmptyRowCount - 1
                            If Val(Replace(.GetText(xx, iCOL), ",", "")) <> 1 Then
                                Call 스프레드.f명칭아이콘설정("오류", f결과, xx, iCOL, FarPoint.Win.Spread.CellHorizontalAlignment.Center,
                                                                        "", .GetText(xx, iCOL))
                            End If
                        Next
                    End With
                End If

            Case "기타메모팝업" '25/03/17 범준 기타메모 팝업 사용여부 오류아이콘 추가
                If 스프레드.f컬럼("존재", f결과, -1, "기타메모팝업", False) <> -1 Then
                    iCOL = 스프레드.f컬럼("", f결과, -1, "기타메모팝업", False)

                    With f결과.Sheets(0)
                        For xx = 0 To .NonEmptyRowCount - 1
                            If Val(Replace(.GetText(xx, iCOL), ",", "")) <> 1 Then
                                Call 스프레드.f명칭아이콘설정("오류", f결과, xx, iCOL, FarPoint.Win.Spread.CellHorizontalAlignment.Center,
                                                                        "", .GetText(xx, iCOL))
                            End If
                        Next
                    End With
                End If

            Case "위탁진료"
                If 스프레드.f컬럼("존재", f결과, -1, "단가", False) <> -1 Then
                    iCOL = 스프레드.f컬럼("", f결과, -1, "본인부담상한금", False)

                    With f결과.Sheets(0)
                        For xx = 0 To .NonEmptyRowCount - 1
                            If Val(Replace(.GetText(xx, iCOL), ",", "")) = 0 Then
                                Call 스프레드.f명칭아이콘설정("오류", f결과, xx, iCOL, FarPoint.Win.Spread.CellHorizontalAlignment.Center,
                                                                        "", .GetText(xx, iCOL))
                            End If
                        Next
                    End With
                End If

                If 스프레드.f컬럼("존재", f결과, -1, "수탁구분", False) <> -1 Then
                    iCOL = 스프레드.f컬럼("", f결과, -1, "수탁구분", False)

                    With f결과.Sheets(0)
                        For xx = 0 To .NonEmptyRowCount - 1
                            If UCase(Replace(.GetText(xx, iCOL), ",", "")) <> "T" Then
                                Call 스프레드.f명칭아이콘설정("오류", f결과, xx, iCOL, FarPoint.Win.Spread.CellHorizontalAlignment.Center,
                                                                        "", .GetText(xx, iCOL))
                            End If
                        Next
                    End With
                End If

            Case "DRG 적용대상 처방"
                If 스프레드.f컬럼("존재", f결과, -1, "DRG수술구분", False) <> -1 Then
                    iCOL = 스프레드.f컬럼("", f결과, -1, "DRG수술구분", False)

                    With f결과.Sheets(0)
                        For xx = 0 To .NonEmptyRowCount - 1
                            If Val(Replace(.GetText(xx, iCOL), ",", "")) <> 0 Then
                                Call 스프레드.f명칭아이콘설정("오류", f결과, xx, iCOL, FarPoint.Win.Spread.CellHorizontalAlignment.Center,
                                                                        "", .GetText(xx, iCOL))
                            End If
                        Next
                    End With
                End If
        End Select
    End Sub

      Private Sub b실행_Click(sender As Object, e As EventArgs) Handles b실행.Click
        If fDATA_CHECK() Then 'CREATE,DROP,TRUNCATE,INSERT 텍스트 포함되면 실행하지 못하도록 표시
            Me.Cursor = Cursors.WaitCursor '커서 기다리기로 변경

            b실행.Enabled = False
            b종료.Enabled = b실행.Enabled

            Select Case tab쿼리.SelectedTabPageIndex
                Case 0
                    Call s실행("", t쿼리.Text, f결과)
                    Call f기본코드조회("", sprCodes)


                Case 1
                    Call s실행("", t쿼리sub.Text, f결과sub)
            End Select

            Call s데이타오류표시(Trim(l타이틀.Text))

            b실행.Enabled = True
            b종료.Enabled = b실행.Enabled

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub t검색어_EditValueChanged(sender As Object, e As EventArgs) Handles t검색어.EditValueChanged
        ' 화면 지우기
        Call s화면지우기("all")
    End Sub

    Private Sub t검색어_KeyUp(sender As Object, e As KeyEventArgs) Handles t검색어.KeyUp
        Select Case e.Modifiers
            Case Keys.Control

            Case Else
                Select Case e.KeyCode
                    Case Keys.Return
                        If Trim(t검색어.Text) <> "" Then
                            Call b검색_Click(Nothing, Nothing)
                        End If
                End Select
        End Select
    End Sub
    'search 클릭하면 해당 검색어가 포함된 것으로 가져옴 
    Private Sub b검색_Click(sender As Object, e As EventArgs) Handles b검색.Click
        Me.Cursor = Cursors.WaitCursor '현재 화면의 마우스 커서를 대기 상태 커서로 변경합니다

        Call s검색("", t검색어.Text)

        Me.Cursor = Cursors.Default
    End Sub

    Private Function f연결쿼리존재여부(ByVal s작업 As String, ByVal i인덱스 As Integer) As Boolean
        Dim sSQL As SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        f연결쿼리존재여부 = False

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "if	exists(	select	*
					                from	[" & strD_DBName & "]..AS발생자료확인 with(nolock)
					                where	인덱스id			=  " & i인덱스 & "
					                and		인덱스			!= 인덱스id )
	                select	'존재'
                else
	                select	'미존재'"

        sSQL = New SqlCommand(QRY, emr센스)

        sSQL.CommandTimeout = 600

        rs = sSQL.ExecuteReader()

        ' ----------------------------------------------------------------------------------------------------
        While rs.Read()
            If fNULL(rs.GetValue(0)) = "존재" Then
                f연결쿼리존재여부 = True
            End If
        End While

        ' ----------------------------------------------------------------------------------------------------
        rs.Close()

        ' ----------------------------------------------------------------------------------------------------
        Return f연결쿼리존재여부
    End Function

    Private Sub s쿼리읽기(ByVal s작업 As String, ByVal i인덱스 As Integer)
        ' 화면 지우기
        Call s화면지우기("")

        Call s화면지우기("기본코드")



        Call AS발생자료확인("", i인덱스)
    End Sub
    '셀 클릭시 발생 
    Private Sub f검색_CellClick(sender As Object, e As FarPoint.Win.Spread.CellClickEventArgs) Handles f검색.CellClick
        Dim i인덱스 As Integer

        Select Case e.ColumnHeader '스프레드시트의 헤더를 클릭했는지 
            Case True

            Case Else '아니면 고(데이터셀)
                With f검색.Sheets(0)
                    i인덱스 = Val(.GetText(e.Row, e검색.인덱스))

                    l타이틀.Text = "      " & .GetText(e.Row, e검색.타이틀) '저장되어 있는 타이틀값을 가져옴 

                    Call s쿼리읽기("", i인덱스)

                    If f연결쿼리존재여부("", i인덱스) Then
                        Call AS발생자료sub확인("", i인덱스)
                    End If
                End With
        End Select
    End Sub

    Private Sub s검색조건대체(ByVal s작업 As String, ByVal tQUERY As System.Windows.Forms.TextBox)
        Dim sQRY As String = tQUERY.Tag

        'If InStr(1, sQRY, "[DBname]") <> 0 Then
        '    sQRY = Replace(sQRY, "[DBname]", DBname)
        'End If

        'If InStr(1, sQRY, "[DBreview]") <> 0 Then
        '    sQRY = Replace(sQRY, "[DBreview]", DBreview)
        'End If

        If InStr(1, sQRY, "{{챠트번호}}") <> 0 Then
            sQRY = Replace(sQRY, "{{챠트번호}}", t챠트번호.Text)
        End If

        If InStr(1, sQRY, "{{처방코드}}") <> 0 Then
            sQRY = Replace(sQRY, "{{처방코드}}", t처방코드.Text)
        End If

        If InStr(1, sQRY, "{{산출기간1}}") <> 0 Then
            sQRY = Replace(sQRY, "{{산출기간1}}", d산출기간1.EditValue)
        End If

        If InStr(1, sQRY, "{{산출기간2}}") <> 0 Then
            sQRY = Replace(sQRY, "{{산출기간2}}", d산출기간2.EditValue)
        End If

        If InStr(1, sQRY, "{{진료년월일1}}") <> 0 Then
            sQRY = Replace(sQRY, "{{진료년월일1}}", Replace(d산출기간1.EditValue, "-", ""))
        End If

        If InStr(1, sQRY, "{{진료년월일2}}") <> 0 Then
            sQRY = Replace(sQRY, "{{진료년월일2}}", Replace(d산출기간2.EditValue, "-", ""))
        End If

        If InStr(1, sQRY, "{{진료년월일}}") <> 0 Then
            sQRY = Replace(sQRY, "{{진료년월일}}", Replace(d산출기간1.EditValue, "-", ""))
        End If

        If InStr(1, sQRY, "{{청구일련번호}}") <> 0 Then
            sQRY = Replace(sQRY, "{{청구일련번호}}", t청구일련번호.Text)
        End If

        tQUERY.Text = sQRY
    End Sub
    Private Sub t챠트번호_EditValueChanged(sender As Object, e As EventArgs) Handles t챠트번호.EditValueChanged
        ' 화면 지우기
        'Call s화면지우기() 

        If Trim(t쿼리.Tag) <> "" Then
            Call s검색조건대체("", t쿼리)
        End If
    End Sub
    '25/03/12 범준 수진자명으로 검색할 수 있게 기능 추가
    Private Sub t수진자명_EditValueChanged(sender As Object, e As EventArgs) Handles t수진자명.EditValueChanged
        If Trim(t쿼리.Tag) <> "" Then
            Call s검색조건대체("", t쿼리)
        End If
    End Sub

    Private Sub t처방코드_EditValueChanged(sender As Object, e As EventArgs) Handles t처방코드.EditValueChanged
        If Trim(t쿼리.Tag) <> "" Then
            Call s검색조건대체("", t쿼리)
        End If
    End Sub

    Private Sub b종료_Click(sender As Object, e As EventArgs) Handles b종료.Click
        Me.Dispose()

        Me.Close()

    End Sub

    Private Sub frm자료보기_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.Modifiers
            Case Keys.Control

            Case Else
                Select Case e.KeyCode
                    Case Keys.Escape
                        t검색어.Focus()

                    Case Keys.F5
                        Call b실행_Click(Nothing, Nothing)
                End Select
        End Select
    End Sub

    Private Sub d산출기간1_EditValueChanged(sender As Object, e As EventArgs) Handles d산출기간1.EditValueChanged
        If d산출기간1.EditValue > d산출기간2.EditValue Then
            d산출기간2.EditValue = d산출기간1.EditValue
        End If

        If Trim(t쿼리.Tag) <> "" Then
            Call s검색조건대체("", t쿼리)
        End If
    End Sub

    Private Sub d산출기간2_EditValueChanged(sender As Object, e As EventArgs) Handles d산출기간2.EditValueChanged
        If d산출기간1.EditValue > d산출기간2.EditValue Then
            d산출기간1.EditValue = d산출기간2.EditValue
        End If

        If Trim(t쿼리.Tag) <> "" Then
            Call s검색조건대체("", t쿼리)
        End If
    End Sub

    Private Sub t청구일련번호_EditValueChanged(sender As Object, e As EventArgs) Handles t청구일련번호.EditValueChanged
        If Trim(t쿼리.Tag) <> "" Then
            Call s검색조건대체("", t쿼리)
        End If
    End Sub

    Private Sub luDB_EditValueChanged(sender As Object, e As EventArgs) Handles luDB.EditValueChanged
        l서버연결.Text = "      Now " & flookup("get", luDB) & " DB Connected...."
        strD_DBName = flookup("get", luDB)
        If strD_DBName <> "" Then sD_SetCreateDBTable()
    End Sub
    Private Sub sD_SetCreateDBTable()
        Dim strL_SQL As String = ""
        Dim sSQL As SqlCommand
        Dim rs As SqlDataReader

        If strD_DBName = "" Then Exit Sub

        strL_SQL &= " IF EXISTS( select Name from sys.sysdatabases Where Name = '" & strD_DBName & "') BEGIN " & vbNewLine
        strL_SQL &= " IF NOT EXISTS(select Name from [" & strD_DBName & "]..sysobjects where xtype = 'U' and Name = 'AS발생자료확인') BEGIN " & vbNewLine
        strL_SQL &= "  CREATE TABLE [" & strD_DBName & "].[dbo].[AS발생자료확인]( " & vbNewLine
        strL_SQL &= " [인덱스] [Int] IDENTITY(1, 1) Not NULL, " & vbNewLine
        strL_SQL &= " [대분류] [varchar](100) NULL, " & vbNewLine
        strL_SQL &= " [소분류] [varchar](100) NULL, " & vbNewLine
        strL_SQL &= " [분류] [varchar](400) NULL, " & vbNewLine
        strL_SQL &= " [타이틀] [varchar](100) NULL, " & vbNewLine
        strL_SQL &= " [쿼리] [Text] NULL, " & vbNewLine
        strL_SQL &= " [확인방법] [Text] NULL, " & vbNewLine
        strL_SQL &= " [처리방법] [Text] NULL, " & vbNewLine
        strL_SQL &= " [인덱스ID] [nchar](10) NULL, " & vbNewLine
        strL_SQL &= " [이전인덱스] [Int] NULL, " & vbNewLine
        strL_SQL &= " [다음인덱스] [Int] NULL, " & vbNewLine
        strL_SQL &= " [기본코드] [Int] NULL " & vbNewLine

        strL_SQL &= " ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY] " & vbNewLine
        strL_SQL &= " End End" & vbNewLine

        sSQL = New SqlCommand(strL_SQL, SVREMR)

        rs = sSQL.ExecuteReader()

        While rs.Read()

        End While

        ' ....................................................................................................
        rs.Close()
    End Sub
    Private Sub f기본코드조회(ByVal s작업 As String, ByVal sprCodes As FarPoint.Win.Spread.FpSpread)
        Dim sSQL As SqlCommand
        Dim rs As SqlDataReader
        Dim xx As Integer


        Dim QRY As String
        Try
            ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
            With sprCodes.Sheets(0)
                .RowCount = 0 : .ColumnCount = 0
            End With

            ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
            QRY = "select	   			명칭,				코드,            데이터,                데이터0,          데이터1,
              데이터2   ,              데이터3,                데이터4,          데이터5,
              데이터6   ,              데이터7,                데이터8,          데이터9
                    from	[" & strD_DBName & "]..TB_코드정보 with(nolock)
                    where	코드종류		=  " & s기본코드 & ""

            sSQL = New SqlCommand(QRY, emr센스)

            sSQL.CommandTimeout = 600

            rs = sSQL.ExecuteReader()


            If Not rs.IsClosed Then
                With sprCodes.Sheets(0)
                    .ColumnCount = rs.FieldCount

                    For xx = 0 To rs.FieldCount - 1
                        Call 스프레드.sTEXT_CELL(sprCodes, -1, xx, 512)
                    Next

                    For xx = 0 To rs.FieldCount - 1
                        .ColumnHeader.Columns(0, xx).Font = New Font("맑은 고딕", 8, FontStyle.Bold)

                        .SetColumnLabel(0, xx, rs.GetName(xx))

                        .Columns(xx).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
                    Next
                End With
            End If

            ' ----------------------------------------------------------------------------------------------------
            While rs.Read()
                With sprCodes.Sheets(0)
                    .RowCount += 1

                    .Rows(.RowCount - 1).Height = 23

                    'Application.DoEvents()

                    For xx = 0 To rs.FieldCount - 1
                        Call s컬럼수평정렬("", xx, rs.GetSqlValue(xx).GetType.Name)

                        .SetText(.RowCount - 1, xx, fNULL(rs.GetValue(xx)))

                        If InStr(1, .GetColumnLabel(0, xx), "일자") <> 0 Then
                            .Columns(xx).Width = .GetPreferredColumnWidth(xx)
                        End If
                    Next
                End With
            End While

            ' ----------------------------------------------------------------------------------------------------
            rs.Close()

            ' ----------------------------------------------------------------------------------------------------
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

End Class
