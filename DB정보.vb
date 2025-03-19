Imports System.Data.SqlClient

Module DB정보
    Public emr메디챠트 As SqlConnection
    Public emr센스 As SqlConnection
    Public emr자료백업 As SqlConnection

    Public SVREMR As SqlConnection

    Public SERVERname As String

    Public DBname As String
    Public DBreceipt As String
    Public DBreview As String

    Public USERID As String
    Public USERPASSWD As String

    Public s최종로그인ID As String

    Public DB엔지테크name As String
    Public DB메트로name As String

    Public Sub s센스INI정보읽기(ByVal s프로그램 As String)
        Dim res As Integer
        Dim sb As String

        Dim intSize As Integer

        ' 서버 정보 ...........................................................................................
        sb = Space(255) : intSize = 255

        res = GetPrivateProfileString("Database Server", "server_name", "", sb, intSize, "c:\" & s프로그램 & "\Bin\" & s프로그램 & ".ini")

        SERVERname = Trim(Replace(sb, vbNullChar, ""))

        ' DataBase 정보 .......................................................................................
        sb = Space(255) : intSize = 255

        res = GetPrivateProfileString("Database Server", "database_name", "", sb, intSize, "c:\" & s프로그램 & "\Bin\" & s프로그램 & ".ini")

        DBname = Trim(Replace(sb, vbNullChar, ""))

        ' 심사 DataBase 정보 .................................................................................
        sb = Space(255) : intSize = 255

        res = GetPrivateProfileString("Database Server", "database_name_simsa", "", sb, intSize, "c:\" & s프로그램 & "\Bin\" & s프로그램 & ".ini")

        DBreview = Trim(Replace(sb, vbNullChar, ""))

        ' 영수증 DataBase 정보 .................................................................................
        sb = Space(255) : intSize = 255

        res = GetPrivateProfileString("Database Server", "database_name_receipt", "", sb, intSize, "c:\" & s프로그램 & "\Bin\" & s프로그램 & ".ini")

        DBreceipt = Trim(Replace(sb, vbNullChar, ""))

        ' 사용자 계정 ..........................................................................................
        sb = Space(255) : intSize = 255

        res = GetPrivateProfileString("Database Server", "server_id", "", sb, intSize, "c:\" & s프로그램 & "\Bin\" & s프로그램 & ".ini")

        USERID = Trim(Replace(sb, vbNullChar, ""))

        ' 비밀번호 ............................................................................................
        sb = Space(255) : intSize = 255

        res = GetPrivateProfileString("Database Server", "server_pwd", "", sb, intSize, "c:\" & s프로그램 & "\Bin\" & s프로그램 & ".ini")

        USERPASSWD = Trim(Replace(sb, vbNullChar, ""))

        ' 최종 로그인 정보 .....................................................................................
        sb = Space(255) : intSize = 255

        res = GetPrivateProfileString("Login", "UserID", "", sb, intSize, "c:\Sense\Bin\sense.ini")

        s최종로그인ID = Trim(Replace(sb, vbNullChar, ""))
    End Sub

    Public Sub s센스DB연결시작(ByVal s작업 As String, ByVal s서버명 As String, ByVal sDB명 As String, ByVal s사용자 As String, ByVal s비밀번호 As String)
        Try
            SVREMR = New SqlConnection("Server=" & s서버명 & ";Database=" & sDB명 & ";User Id=" & s사용자 & ";Password=" & s비밀번호 & ";MultipleActiveResultSets=true")

            SVREMR.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "DB 연결", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
