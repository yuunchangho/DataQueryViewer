Imports System.Data.SqlClient

Public Class frm쿼리추가
    Public Sub New()

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

    End Sub
    Private strD_DBName As String

    Enum e검색
        분류 = 0
        소분류
        내용
        타이틀
        인덱스
    End Enum
    Private Sub frm쿼리추가_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call s초기값()
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
        strL_SQL &= " [분류] [varchar](400) NULL, " & vbNewLine
        strL_SQL &= " [타이틀] [varchar](100) NULL, " & vbNewLine
        strL_SQL &= " [쿼리] [Text] NULL, " & vbNewLine
        strL_SQL &= " [확인방법] [Text] NULL, " & vbNewLine
        strL_SQL &= " [처리방법] [Text] NULL, " & vbNewLine
        strL_SQL &= " [인덱스ID] [nchar](10) NULL, " & vbNewLine
        strL_SQL &= " [이전인덱스] [Int] NULL, " & vbNewLine
        strL_SQL &= " [다음인덱스] [Int] NULL " & vbNewLine
        strL_SQL &= " ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY] " & vbNewLine
        strL_SQL &= " End End" & vbNewLine

        sSQL = New SqlCommand(strL_SQL, SVREMR)

        rs = sSQL.ExecuteReader()

        While rs.Read()

        End While

        ' ....................................................................................................
        rs.Close()
    End Sub
    Public Sub s초기값()
        Call sINI정보읽기("sense")

        Call sDB연결("", SERVERname, DBname, USERID, USERPASSWD)

        ' 서버에 존재하는 DB정보 load ...........................................................................
        Call sDB정보("")

        luDB.EditValue = DBname

        ' ----------------------------------------------------------------------------------------------------
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
    Private Sub s입력값()
        't대분류.Text
        't소분류.Text
        't분류.Text
        't타이틀.Text
        ' t확인.Text
        't쿼리.Text
    End Sub

End Class