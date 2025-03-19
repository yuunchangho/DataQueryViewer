Imports System.Data.SqlClient

Imports System
Imports System.IO
Module 테이블정보
    Public Function fDB존재체크(ByVal s작업 As String, ByVal sDB명 As String) As Boolean
        Dim sSQL As New SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        fDB존재체크 = False

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "select 1 from sys.sysdatabases where name = '" & sDB명 & "'"

        sSQL = New SqlCommand(QRY, SVREMR)

        rs = sSQL.ExecuteReader()

        While rs.Read()
            If Val(fNULL(rs.GetValue(0))) > 0 Then
                fDB존재체크 = True
            End If
        End While

        ' ...................................................................................................
        rs.Close()

        ' ...................................................................................................
        Return fDB존재체크
    End Function

    Public Sub s테이블생성_TB_문서결재정보(ByVal sDB As String, ByVal s테이블명 As String)
        Dim sSQL As New SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "USE [" & sDB & "]

                CREATE TABLE [dbo].[" & s테이블명 & "](
	                [문서명] [varchar](50) NOT NULL,
	                [순서] [int] NOT NULL,
	                [분류] [nchar](10) NULL,
	                [결재01] [varchar](20) NULL,
	                [결재02] [varchar](20) NULL,
	                [결재03] [varchar](20) NULL,
	                [결재04] [varchar](20) NULL,
	                [결재05] [varchar](20) NULL,
	                [결재06] [varchar](20) NULL,
	                [결재07] [varchar](20) NULL,
	                [결재08] [varchar](20) NULL,
	                [결재09] [varchar](20) NULL,
	                [결재10] [varchar](20) NULL,
	                [등록] [varchar](12) NULL,
	                [등록일시] [datetime] NULL,
	                [수정] [varchar](12) NULL,
	                [수정일시] [datetime] NULL,
	                [삭제] [varchar](12) NULL,
	                [삭제일시] [datetime] NULL,
	                [IP] [varchar](50) NULL
                ) ON [PRIMARY]

                CREATE UNIQUE NONCLUSTERED INDEX [" & s테이블명 & "_key] ON [dbo].[" & s테이블명 & "]
                (
	                [문서명] ASC,
	                [순서] ASC
                )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]"

        sSQL = New SqlCommand(QRY, SVREMR)

        rs = sSQL.ExecuteReader()

        While rs.Read()

        End While

        ' ...................................................................................................
        rs.Close()
    End Sub

    Public Sub s테이블생성_단어검색정보(ByVal sDB명 As String, ByVal s테이블명 As String)
        Dim sSQL As New SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "USE [" & sDB명 & "] "
        QRY = QRY & "CREATE TABLE [dbo].[" & s테이블명 & "](
	                        [단어] [varchar](40) NOT NULL,
	                        [단축키] [varchar](40) NULL,
                            [빈도수] [int] NULL
                        ) ON [PRIMARY]

                        CREATE UNIQUE NONCLUSTERED INDEX [" & s테이블명 & "_key] ON [dbo].[" & s테이블명 & "]
                        (
	                        [단어] ASC
                        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] "
        QRY = QRY & " "

        sSQL = New SqlCommand(QRY, SVREMR)

        rs = sSQL.ExecuteReader()

        While rs.Read()

        End While

        ' ...................................................................................................
        rs.Close()
    End Sub

    Private Sub s컬럼size변경(ByVal s작업 As String, ByVal sDB As String, ByVal s테이블명 As String, ByVal s컬럼 As String, ByVal 필드크기 As String)
        Dim sSQL As SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        Application.DoEvents()

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        'QRY = "use  " & DBname & " "
        'QRY = QRY & "   go "
        'QRY = QRY & "   sp_rename '" & s테이블명 & ".[" & s필드명F & "]', '" & s필드명T & "', 'COLUMN'"
        QRY = "alter table " & sDB & ".." & s테이블명 & " alter column " & s컬럼 & " " & 필드크기

        sSQL = New SqlCommand(QRY, SVREMR)

        sSQL.CommandTimeout = 600

        rs = sSQL.ExecuteReader()

        While rs.Read()

        End While

        ' ....................................................................................................
        rs.Close()
    End Sub

    Private Sub s컬럼RENAME(ByVal s작업 As String, ByVal s테이블명 As String, ByVal s필드명F As String, ByVal s필드명T As String)
        Dim sSQL As SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        Application.DoEvents()

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        'QRY = "use  " & DBname & " "
        'QRY = QRY & "   go "
        'QRY = QRY & "   sp_rename '" & s테이블명 & ".[" & s필드명F & "]', '" & s필드명T & "', 'COLUMN'"
        QRY = "sp_rename '" & DBname & ".." & s테이블명 & ".[" & s필드명F & "]', '" & s필드명T & "', 'COLUMN'"

        sSQL = New SqlCommand(QRY, SVREMR)

        sSQL.CommandTimeout = 600

        rs = sSQL.ExecuteReader()

        While rs.Read()

        End While

        ' ....................................................................................................
        rs.Close()
    End Sub


    'Public Function f컬럼_존재_체크(ByVal s작업 As String, ByVal sDB명 As String, ByVal s테이블명 As String, ByVal s필드명 As String) As Boolean
    '    Dim sSQL As SqlCommand
    '    Dim rs As SqlDataReader

    '    Dim QRY As String

    '    ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
    '    Application.DoEvents()

    '    f컬럼_존재_체크 = False

    '    ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
    '    QRY = "use  " & sDB명 & " "
    '    'QRY = QRY & "   go "
    '    QRY = QRY & "   select	count(*) "
    '    QRY = QRY & "   from	INFORMATION_SCHEMA.COLUMNS "
    '    QRY = QRY & "   where	table_name	= '" & s테이블명 & "' "
    '    QRY = QRY & "   and		column_name	= '" & s필드명 & "'"

    '    sSQL = New SqlCommand(QRY, SVREMR)

    '    sSQL.CommandTimeout = 600

    '    rs = sSQL.ExecuteReader()

    '    While rs.Read()
    '        If Val(fNULL(rs.GetValue(0))) > 0 Then
    '            f컬럼_존재_체크 = True
    '        End If
    '    End While

    '    ' ....................................................................................................
    '    rs.Close()

    '    ' ....................................................................................................
    '    Return f컬럼_존재_체크
    'End Function

    Public Function f테이블존재체크(ByVal sDB명 As String, ByVal s테이블명 As String) As Boolean
        Dim sSQL As New SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        f테이블존재체크 = False

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "if exists(select * "
        QRY = QRY & "        from " & sDB명 & ".information_schema.tables "
        QRY = QRY & "        where table_name   = '" & s테이블명 & "') "
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

    ' 22/12/02 이인원 추가
    Public Sub s사전심사점검_테이블삭제(ByVal sDB명 As String, ByVal s테이블명 As String)
        Dim sSQL As New SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "USE [" & sDB명 & "] "
        QRY = QRY & " DROP Table dbo.[" & s테이블명 & "] "

        sSQL = New SqlCommand(QRY, SVREMR)

        rs = sSQL.ExecuteReader()

        While rs.Read()

        End While

        ' ...................................................................................................
        rs.Close()
    End Sub

    Public Sub s컬럼추가(ByVal s작업 As String, ByVal sDB명 As String, ByVal s테이블명 As String, ByVal s컬럼명 As String, ByVal s자료형식 As String)
        Dim sSQL As New SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "USE [" & sDB명 & "] "
        QRY = QRY & "alter table " & sDB명 & ".." & s테이블명 & " add " & s컬럼명 & " " & s자료형식 & " "
        QRY = QRY & " "

        sSQL = New SqlCommand(QRY, SVREMR)

        rs = sSQL.ExecuteReader()

        While rs.Read()

        End While

        ' ...................................................................................................
        rs.Close()
    End Sub

    Public Sub s심사테이블생성()
        ' TB_병동정보SUB ......................................................................................
        If Not 테이블정보.f테이블존재체크(DBreceipt, "TB_문서결재정보") Then
            Call s테이블생성_TB_문서결재정보(DBreceipt, "TB_문서결재정보")
        End If
    End Sub

    Public Function f컬럼_존재_체크(ByVal s작업 As String, ByVal sDB As String, ByVal s테이블명 As String, ByVal s필드명 As String) As Boolean
        Dim sSQL As SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        Application.DoEvents()

        f컬럼_존재_체크 = False

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "use  " & sDB & " "
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
End Module

