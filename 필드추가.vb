Imports System.Data.SqlClient

Imports System.IO
Module 필드추가
    Public Sub s필드체크(ByVal sDB명 As String)
        If Not f컬럼_존재_체크("", sDB명, "TB_입원병동", "격리병실적용") Then
            Call s컬럼ADD("", sDB명, "TB_입원병동", "격리병실적용", "[char](1) null")
        End If
    End Sub

    Public Sub s컬럼ADD(ByVal s작업 As String, ByVal sDB명 As String, ByVal s테이블명 As String, ByVal s컬럼명 As String, ByVal s자료형식 As String)
        Dim sSQL As SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String
        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "USE [" & sDB명 & "] "
        QRY = QRY & "alter table " & sDB명 & ".." & s테이블명 & " add " & s컬럼명 & " " & s자료형식 & " "
        'QRY = QRY & " "

        sSQL = New SqlCommand(QRY, SVREMR)

        rs = sSQL.ExecuteReader()

        While rs.Read()

        End While

        ' ...................................................................................................
        rs.Close()
    End Sub

    Public Function f컬럼_존재_체크(ByVal s작업 As String, ByVal sDB명 As String, ByVal s테이블명 As String, ByVal s필드명 As String) As Boolean
        Dim sSQL As SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        Application.DoEvents()

        If Trim(sDB명) = "" Then sDB명 = DBname

        f컬럼_존재_체크 = False

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "use  " & sDB명 & " "
        'QRY = QRY & "   go "
        QRY = QRY & "   select	count(*) "
        QRY = QRY & "   from	INFORMATION_SCHEMA.COLUMNS "
        QRY = QRY & "   where	table_name	= '" & s테이블명 & "' "
        QRY = QRY & "   and		column_name	= '" & s필드명 & "'"

        sSQL = New SqlCommand(QRY, SVREMR)

        sSQL.CommandTimeout = 600

        rs = sSQL.ExecuteReader()

        While rs.Read()
            If Val(fNULL(rs.GetValue(0))) > 0 Then
                f컬럼_존재_체크 = True
            End If
        End While

        ' ....................................................................................................
        rs.Close()

        ' ....................................................................................................
        Return f컬럼_존재_체크
    End Function

    Public Function fDB존재체크(ByVal sDB명 As String) As Boolean
        Dim sSQL As New SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        'If Trim(sDB명) = "" Then sDB명 = DBname

        fDB존재체크 = False

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "select count(name) from sys.sysdatabases where name='" & sDB명 & "' "

        sSQL = New SqlCommand(QRY, SVREMR)

        rs = sSQL.ExecuteReader()

        While rs.Read()
            If fNULL(rs.GetValue(0)) > 0 Then
                fDB존재체크 = True
            End If
        End While

        ' ...................................................................................................
        rs.Close()

        ' ...................................................................................................
        Return fDB존재체크
    End Function

    Public Function f테이블존재체크(ByVal sDB명 As String, ByVal s테이블명 As String) As Boolean
        Dim sSQL As New SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        If Trim(sDB명) = "" Then sDB명 = DBname

        f테이블존재체크 = False

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "If exists(Select * from " & sDB명 & ".information_schema.tables where table_name='" & s테이블명 & "') "
        QRY = QRY & "        select '있음' "
        QRY = QRY & "   else "
        QRY = QRY & "        select '없음'"

        sSQL = New SqlCommand(QRY, SVREMR)

        rs = sSQL.ExecuteReader()

        While rs.Read()
            Select Case UCase(fNULL(rs.GetValue(0)))
                Case "있음"
                    f테이블존재체크 = True
            End Select
        End While

        ' ...................................................................................................
        rs.Close()

        ' ...................................................................................................
        Return f테이블존재체크
    End Function

End Module
