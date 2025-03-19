Imports System.Data.SqlClient

Module 통계
    Structure cfg프로그램
        Public 버젼 As String
    End Structure

    Public 프로그램 As cfg프로그램

    Private Function f요양기관정보(ByVal s작업 As String, ByVal s항목 As String) As String
        Dim sSQL As New SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "select	데이터1 "
        QRY = QRY & "   from	" & DBname & "..TB_요양기관정보 "
        QRY = QRY & "   where	항목		= '" & fQRY(s항목) & "'"

        sSQL = New SqlCommand(QRY, SVREMR)

        rs = sSQL.ExecuteReader()

        While rs.Read()
            f요양기관정보 = fNULL(rs.GetValue(0))
        End While

        ' ....................................................................................................
        rs.Close()
    End Function

    Public Sub s사용자정보(ByVal s작업 As String, ByVal s코드 As String, ByVal s비밀번호 As String)
        Dim sSQL As New SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "select	u.이름, "
        QRY = QRY & "   u.진료지원코드,	u.직분,			u.전문의번호,		u.비밀번호수정일자, "
        QRY = QRY & "   u.병동,			d.진료지원실,		u.사용자PWD "
        QRY = QRY & "   from    " & DBname & "..TB_사용자정보 u with(nolock) "
        QRY = QRY & "   	left outer join " & DBname & "..TB_진료지원 d with(nolock) "
        QRY = QRY & "   		on	d.진료지원코드	=  u.진료지원코드 "
        QRY = QRY & "   where	u.사용자ID	        =  '" & Replace(s코드, "'", "^") & "'"

        sSQL = New SqlCommand(QRY, SVREMR)

        sSQL.CommandTimeout = 600

        rs = sSQL.ExecuteReader()

        While rs.Read()
            ' ID, 성명
            사용자.코드 = s코드
            사용자.성명 = fNULL(rs.GetValue(0))
            ' 비밀번호
            사용자.비밀번호 = fNULL(rs.GetValue(7))
            ' 진료지원코드, 직분
            사용자.진료지원코드 = fNULL(rs.GetValue(1))
            사용자.직분 = fNULL(rs.GetValue(2))
            ' 전문의번호, 비밀번호수정일
            사용자.전문의번호 = fNULL(rs.GetValue(3))
            사용자.비밀번호수정일 = fNULL(rs.GetValue(4))
            ' 요양기관명
            사용자.기관명 = f요양기관정보("기관명", "병원이름")
            ' 병동, 부서명칭
            사용자.병동 = Replace(UCase(fNULL(rs.GetValue(5))), "전체", "ALL")
            사용자.부서명칭 = fNULL(rs.GetValue(6))
        End While

        ' ....................................................................................................
        rs.Close()
    End Sub
End Module
