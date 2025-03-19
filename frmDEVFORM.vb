Imports System.Data.SqlClient
Imports System.Net
Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.CompilerServices

Public Class frmDEVFORM
    Public emr중외 As SqlConnection

    Enum e내원
        내원일 = 0
        세
        개월
        외래입원
        진료과
        진료의
        접수시간
        비고
    End Enum

    Private Sub s경과기록(ByVal s작업 As String, ByVal iCHARTSEQ As Integer)
        Dim QRY As String

        Dim dr As SqlDataReader

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "select  LINETYPE,       PROGRESS
                    from    emr_onr_progress
                    where   chartseq        =  " & iCHARTSEQ & ""

        Dim cmd As SqlCommand = New SqlCommand(QRY, emr중외)

        cmd = emr중외.CreateCommand

        cmd.CommandText = QRY

        dr = cmd.ExecuteReader()

        While dr.Read
            If Val(fNULL(dr.Item(0))) = 0 Then
            End If
        End While

        dr.Close()

        lCHARTSEQ.Text = "      " & iCHARTSEQ
    End Sub

    Private Sub s처방정보읽기(ByVal s작업 As String, ByVal s챠트번호 As String, ByVal s처방일1 As String, ByVal s처방일2 As String, ByVal i메세지표시 As Boolean)
        Dim QR1 As String, QR2 As String, QR3 As String, QR4 As String

        Dim rs As SqlDataReader

        Dim s처방일 As String = "", i경과기록 As Boolean = False
        Dim i입원처방 As Boolean

        Dim i표시여부 As Boolean = True

        Dim s작업일 As String = DateTime.Now.ToString("yyyy-MM-dd")

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        Call 스프레드.s지우기("", f처방, 0)

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QR1 = "select   'ㄱㄱ' BB,
                        a.ACCOUNTDATE AA,
                        '',                 '',       	        '',
                        0, 				    0, 			        0,              0,
                        '', 			    '', 		        '',
                        0 SEQ,        
                        0,                  '',                 '',
                        0 DSEQ,             'BILLFLAG',
                        '',                 '',                 '',             '',                 
                        a.DEPTCODE,         b.DEPTNAMEK,        a.DRCODE,       c.DRNAME,
                        a.JUPSUTIME,        a.REMARK,           '',
                        '',                 '',                 '',             '',
                        '' INOUT
                from    PDO_MASTER a
                    inner join BTC_DEPT b
                        on  b.DEPTCODE      =  a.DEPTCODE
                    inner join BTC_DOCTOR c
                        on  c.DRCODE        =  a.DRCODE
                where   PTNO                =  '" & s챠트번호 & "'
                and    	a.ACCOUNTDATE 	    between '" & s처방일1 & "' and '" & s처방일2 & "' "

        QR2 = "select   '경과기록' BB,
                        a.ACCOUNTDATE AA,
                        '',                 '',       	        '',
                        0, 			        0, 				    0, 				    0,
                        '', 			    '', 		        '',
                        0 SEQ,
                        b.CHARTSEQ,       	'',                 b.PROGRESS,
                        0 DSEQ,             '',
                        '',                 '',                 '',                 '',
                        '',                 '',                 '',                 '',
                        '',                 '',                 '',
                        '',                 '',                 '',                  '',
                        '' INOUT
                from    EMR_M_CHARTMASTER a
                    inner join EMR_ONR_PROGRESS b
                        on  b.CHARTSEQ      =  a.CHARTSEQ
                where   a.ptno            	=  '" & s챠트번호 & "'
                and    	a.ACCOUNTDATE 	    between '" & s처방일1 & "' and '" & s처방일2 & "'
                and     a.DELFLAG           = 0 "

        QR3 = "select   '상병' BB,
                        a.ACCOUNTDATE AA,
                        '',                 '',       	        '',
                        0, 			        0, 				    0, 				    0,
                        '', 			    '', 		        '',
                        0 SEQ,
                        0,       	        b.DXCODE,           b.DXNAME,
                        b.DISPSEQ DSEQ,     '',
                        '',                 '',                 '',                 '',
                        '',                 '',                 '',                 '',
                        '',                 '',                 '',
                        '',                 '',                 '',                  '',
                        '' INOUT
                from    PDO_MASTER a
                    inner join ORD_DIAGNOSIS b
                        on  b.PTNO          =  a.PTNO
                        and b.DEPTCODE      =  a.DEPTCODE
                        and b.STARTDATE     <= a.ACCOUNTDATE 
                        and b.ENDDATE       >= a.ACCOUNTDATE         
                where   a.ptno            	=  '" & s챠트번호 & "'
                and    	a.ACCOUNTDATE 	    between '" & s처방일1 & "' and '" & s처방일2 & "' "


        QR4 = "select	'처방' BB,
                        a.ORDERDATE AA,
                        a.ORDERCODE,        a.SUCODE,       	a.ORDERNAME,
                        a.QTY, 				a.FRQQTY, 			a.FREQUENCY,        a.NAL,
                        a.USERID, 			a.USERNAME, 		a.REMARK,
                        a.DRDISPSEQ SEQ,        
                        0,                  '',                 '',
                        0 DSEQ,             a.BILLFLAG,
                        a.ROUTE,            a.DOSAGECODE,       u.DOSAGENAME,       '',
                        '',                 '',                 '',                 '',
                        '',                 '',                 '',
                        '',                 '',                 '',                 a.SELFFLAG,
                        a.IPDOPD INOUT
                from   	ORD_DRORDER a
                        left outer join BTO_DRUGDOSAGE u
                            on  u.DOSAGECODE    =  a.DOSAGECODE
                where  	a.PTNO				=  '" & s챠트번호 & "'
                and    	a.ORDERDATE 		between '" & s처방일1 & "' and '" & s처방일2 & "'
                order by AA desc, BB, INOUT, SEQ, DSEQ"

        Dim cmd As SqlCommand = New SqlCommand(QR1 & " union all " & QR2 & " union all " & QR3 & " union all " & QR4, emr중외)

        cmd = emr중외.CreateCommand

        cmd.CommandText = QR1 & " union all " & QR2 & " union all " & QR3 & " union all " & QR4

        rs = cmd.ExecuteReader()

        While rs.Read
            With f처방.Sheets(0)
                ' 처방일 변경시
                If Trim(s처방일) <> fNULL(rs.Item(1)) Then
                    If Trim(s처방일) <> "" Then
                        .RowCount += 1
                    End If

                    .RowCount += 1

                    .AddSpanCell(.RowCount - 1, e처방.구분, 1, 12)

                    .Cells(.RowCount - 1, e처방.구분).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left

                    .Cells(.RowCount - 1, e처방.구분).ForeColor = Color.White

                    .Cells(.RowCount - 1, e처방.구분).Font = New Font("맑은 고딕", 10, FontStyle.Bold)

                    .SetText(.RowCount - 1, e처방.형식, "일자")

                    If fNULL(rs.Item(33)) = "I" Then
                        .Cells(.RowCount - 1, e처방.구분).BackColor = Color.Green

                        .SetText(.RowCount - 1, e처방.구분, "  " & 함수.fL정렬(fNULL(rs.Item(1)), 14) & 함수.fL정렬(IIf(DateDiff("d", fNULL(rs.Item(1)), s작업일) = 0, "오늘", DateDiff("d", fNULL(rs.Item(1)), s작업일) & " " & "일전"), 14) &
                                                                    함수.fL정렬("입원", 20))
                    Else
                        .Cells(.RowCount - 1, e처방.구분).BackColor = Color.SteelBlue

                        .SetText(.RowCount - 1, e처방.구분, "  " & 함수.fL정렬(fNULL(rs.Item(1)), 14) & 함수.fL정렬(IIf(DateDiff("d", fNULL(rs.Item(1)), s작업일) = 0, "오늘", DateDiff("d", fNULL(rs.Item(1)), s작업일) & " " & "일전"), 14) &
                                                                    함수.fL정렬(fNULL(rs.Item(22)), 20) & 함수.fL정렬(fNULL(rs.Item(24)), 16) & fNULL(rs.Item(25)))
                    End If

                    s처방일 = fNULL(rs.Item(1)) : i입원처방 = False
                End If

                Select Case fNULL(rs.Item(0))
                    Case "ㄱㄱ"
                        '.RowCount += 1

                        '.AddSpanCell(.RowCount - 1, e처방.구분, 1, 12)

                        '.Cells(.RowCount - 1, e처방.구분).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left

                        '.Cells(.RowCount - 1, e처방.구분).ForeColor = Color.White
                        '.Cells(.RowCount - 1, e처방.구분).BackColor = Color.SteelBlue

                        '.Cells(.RowCount - 1, e처방.구분).Font = New Font("맑은 고딕", 10, FontStyle.Bold)

                        '.SetText(.RowCount - 1, e처방.형식, "일자")
                        '.SetText(.RowCount - 1, e처방.구분, "  " & 함수.fL정렬(fNULL(rs.Item(1)), 14) & 함수.fL정렬(IIf(DateDiff("d", fNULL(rs.Item(1)), s작업일) = 0, "오늘", DateDiff("d", fNULL(rs.Item(1)), s작업일) & " " & "일전"), 14) &
                        '                                            함수.fL정렬(fNULL(rs.Item(22)), 20) & 함수.fL정렬(fNULL(rs.Item(24)), 16) & fNULL(rs.Item(25)))

                    Case "경과기록"
                        .RowCount += 1


                        .AddSpanCell(.RowCount - 1, e처방.처방코드, 1, 9)

                        .Cells(.RowCount - 1, e처방.구분).ForeColor = Color.Blue
                        .Cells(.RowCount - 1, e처방.처방코드).ForeColor = Color.Blue

                        .SetText(.RowCount - 1, e처방.형식, "증상")
                        .SetText(.RowCount - 1, e처방.구분, "증상")

                        .SetText(.RowCount - 1, e처방.처방코드, "")

                        ' 증상 여러줄인 경우에  wordwrap
                        .Rows(.RowCount - 1).Height = .GetPreferredRowHeight(.RowCount - 1)

                        .Cells(.RowCount - 1, e처방.선택).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
                        .Cells(.RowCount - 1, e처방.처방코드).Font = New Font("맑은 고딕", 9, FontStyle.Bold)

                        i경과기록 = True

                    Case "상병"
                        .RowCount += 1

                        If i경과기록 Then
                            .AddSpanCell(.RowCount - 1, e처방.처방코드, 1, 7)

                            .RowCount += 1

                            i경과기록 = False
                        End If

                        .AddSpanCell(.RowCount - 1, e처방.수가코드, 1, 7)

                        .Cells(.RowCount - 1, e처방.구분).ForeColor = Color.Green
                        .Cells(.RowCount - 1, e처방.처방코드).ForeColor = Color.Green
                        .Cells(.RowCount - 1, e처방.수가코드).ForeColor = Color.Green

                        .SetText(.RowCount - 1, e처방.형식, "상병")
                        .SetText(.RowCount - 1, e처방.구분, "상병")

                        ' 상병코드, 상병명
                        .SetText(.RowCount - 1, e처방.처방코드, fNULL(rs.Item(14)))
                        .SetText(.RowCount - 1, e처방.수가코드, fNULL(rs.Item(15)))

                    Case Else
                        ' 취소처방 표시여부
                        i표시여부 = IIf(Not ck취소처방보기.Checked And fNULL(rs.Item(17)) = "9", False, True)
                        'i표시여부 = True

                        If i표시여부 Then
                            .RowCount += 1

                            If i경과기록 Then
                                .AddSpanCell(.RowCount - 1, e처방.처방코드, 1, 7)

                                .RowCount += 1

                                i경과기록 = False
                            End If

                            .SetText(.RowCount - 1, e처방.형식, "처방")
                            .SetText(.RowCount - 1, e처방.구분, "처방")

                            .SetText(.RowCount - 1, e처방.처방코드, fNULL(rs.Item(2)))
                            .SetText(.RowCount - 1, e처방.수가코드, fNULL(rs.Item(3)))
                            ' 처방명
                            .SetText(.RowCount - 1, e처방.처방명, Trim(Replace(fNULL(rs.Item(4)), "[비급여]", "")))
                            .Cells(.RowCount - 1, e처방.처방명).Tag = fNULL(rs.Item(4))

                            ' 총투여
                            .SetText(.RowCount - 1, e처방.총투여량, IIf(Val(fNULL(rs.Item(5))) <> 0, fNULL(rs.Item(5)), "1"))
                            ' 투여량, 횟수
                            .SetText(.RowCount - 1, e처방.투여량, IIf(Val(fNULL(rs.Item(6))) <> 0, fNULL(rs.Item(6)), "1"))
                            .SetText(.RowCount - 1, e처방.횟수, IIf(Val(fNULL(rs.Item(7))) <> 0, fNULL(rs.Item(7)), "1"))
                            ' 일수
                            .SetText(.RowCount - 1, e처방.일수, IIf(Val(fNULL(rs.Item(8))) <> 0, fNULL(rs.Item(8)), "1"))
                            ' 경로
                            .SetText(.RowCount - 1, e처방.경로, fNULL(rs.Item(18)))

                            .SetText(.RowCount - 1, e처방.비고, fNULL(rs.Item(11)))
                            .SetText(.RowCount - 1, e처방.등록자명, fNULL(rs.Item(10)))

                            ' 용법
                            If fNULL(rs.Item(20)) <> "" Then
                                .SetText(.RowCount - 1, e처방.비고, fNULL(rs.Item(20)))
                            End If

                            ' 보험구분(32)
                            Select Case Val(fNULL(rs.GetValue(32)))
                                Case 1
                                    Call 스프레드.f명칭아이콘설정("비급", f처방, .RowCount - 1, e처방.보험구분, FarPoint.Win.Spread.CellHorizontalAlignment.Center, "", "")

                                Case 3
                                    Call 스프레드.f명칭아이콘설정("전액", f처방, .RowCount - 1, e처방.보험구분, FarPoint.Win.Spread.CellHorizontalAlignment.Center, "", "")

                                Case 4
                                    .SetText(.RowCount - 1, e처방.보험구분, "선별80%")
                                Case 5
                                    .SetText(.RowCount - 1, e처방.보험구분, "선별50%")
                                Case 6
                                    .SetText(.RowCount - 1, e처방.보험구분, "선별90%")
                                Case 7
                                    .SetText(.RowCount - 1, e처방.보험구분, "선별30%")
                            End Select

                            ' 입원처방 여부
                            If fNULL(rs.Item(33)) = "I" Then i입원처방 = True

                            ' 입원 처방중 외래입력처방
                            If i입원처방 And fNULL(rs.Item(33)) = "O" Then
                                Call 스프레드.f명칭아이콘설정("외래", f처방, .RowCount - 1, e처방.처방명, FarPoint.Win.Spread.CellHorizontalAlignment.Left, "", .GetText(.RowCount - 1, e처방.처방명))
                            End If

                            ' 취소(?)
                            If fNULL(rs.Item(17)) = "9" Then
                                .SetText(.RowCount - 1, e처방.삭제, "Y")

                                .Rows(.RowCount - 1).Font = New Font("맑은 고딕", 8, FontStyle.Strikeout)
                                .Rows(.RowCount - 1).ForeColor = Color.Red
                            End If
                        End If
                End Select
            End With
        End While

        rs.Close()

        With f처방.Sheets(0)
            For ii = 0 To .NonEmptyRowCount - 1
                Select Case .GetText(ii, e처방.형식)
                    Case "일자"
                        .Rows(ii).Height = 28

                    Case "경과", "증상"

                    Case Else
                        .Rows(ii).Height = 25

                        .Cells(ii, e처방.선택).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
                End Select
            Next
        End With
    End Sub

    Private Sub s내원정보읽기(ByVal s작업 As String, ByVal s챠트번호 As String)
        Dim QRY As String, QR1 As String, QR2 As String

        Dim dr As SqlDataReader

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        Call 스프레드.s지우기("", f내원, 0)

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QR1 = "select   a.ACCOUNTDATE vdate,
                        'O',
                        a.AGE,              a.AGEMONTH,         a.SEX,
                        a.DEPTCODE,         b.DEPTNAMEK,        a.DRCODE,           c.DRNAME,
                        a.JUPSUTIME,        a.REMARK
                    from    PDO_MASTER a
                        inner join BTC_DEPT b
                            on  b.DEPTCODE      = a.DEPTCODE
                        inner join BTC_DOCTOR c
                            on  c.DRCODE        = a.DRCODE
                    where   a.PTNO              =  '" & s챠트번호 & "'"

        QR2 = "select   a.ADMISSIONDATE vdate,
                        'I',
                        a.AGE,              a.AGEMONTH,         a.SEX,
                        a.DEPTCODE,         b.DEPTNAMEK,        a.DRCODE,           c.DRNAME,
                        '',                 a.REMARK
                    from    PDI_MASTER a
                        inner join BTC_DEPT b
                            on  b.DEPTCODE      = a.DEPTCODE
                        inner join BTC_DOCTOR c
                            on  c.DRCODE        = a.DRCODE
                    where   a.PTNO              =  '" & s챠트번호 & "'
                    order by vdate desc"

        QRY = QR1 & " union all " & QR2

        Dim cmd As SqlCommand = New SqlCommand(QRY, emr중외)

        cmd = emr중외.CreateCommand

        cmd.CommandText = QRY

        dr = cmd.ExecuteReader()

        While dr.Read
            With f내원.Sheets(0)
                .RowCount += 1

                .SetText(.RowCount - 1, e내원.내원일, fNULL(dr.Item(0)))
                .SetText(.RowCount - 1, e내원.외래입원, IIf(UCase(fNULL(dr.Item(1))) = "I", "입원", fNULL(dr.Item(1))))

                .SetText(.RowCount - 1, e내원.세, fNULL(dr.Item(2)))
                .SetText(.RowCount - 1, e내원.개월, fNULL(dr.Item(3)))

                .SetText(.RowCount - 1, e내원.진료과, fNULL(dr.Item(5)) & "." & fNULL(dr.Item(6)))
                .SetText(.RowCount - 1, e내원.진료의, fNULL(dr.Item(8)))

                .SetText(.RowCount - 1, e내원.접수시간, fNULL(dr.Item(9)))
                .SetText(.RowCount - 1, e내원.비고, fNULL(dr.Item(10)))

                Select Case UCase(.GetText(.RowCount - 1, e내원.외래입원))
                    Case "입원"
                        .Rows(.RowCount - 1).ForeColor = Color.Blue
                        .Rows(.RowCount - 1).BackColor = Color.Cornsilk
                End Select
            End With
        End While

        dr.Close()

        With f내원.Sheets(0)
            For ii = 0 To .NonEmptyRowCount - 1
                .Rows(ii).Height = 25
                '.Rows(ii).font = New Font("맑은 고딕", 8, FontStyle.Bold)
            Next
        End With
    End Sub

    Private Sub s진료특이읽기(ByVal s작업 As String, ByVal s챠트번호 As String)
        Dim QRY As String

        Dim dr As SqlDataReader

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        t진료특이.Text = ""

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "select  WRITEDATE,      REMARK
                    from    btm_patientinfor
                    where   PTNO            = '" & fQRY(s챠트번호) & " '
                    order by WRITEDATE desc"

        Dim cmd As SqlCommand = New SqlCommand(QRY, emr중외)

        cmd = emr중외.CreateCommand

        cmd.CommandText = QRY

        dr = cmd.ExecuteReader()

        While dr.Read
            t진료특이.Text = fNULL(dr.Item(1))
        End While

        dr.Close()
    End Sub

    Private Sub s환자정보읽기(ByVal s작업 As String, ByVal s챠트번호 As String)
        Dim QRY As String

        Dim dr As SqlDataReader

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "select	a.PTNO,             a.SNAME,        a.BIRTHDAY,
                        a.JUMIN1,           a.JUMIN2,       a.HANDPHONE,
                        a.DATESTART,        a.DATELAST,
                        a.KIHO,             a.GKIHO,
                        a.JUSO,             a.REMARK
                    from    BTM_PATIENT a
                    where   a.PTNO            = '" & s챠트번호 & "'"

        Dim cmd As SqlCommand = New SqlCommand(QRY, emr중외)

        cmd = emr중외.CreateCommand

        cmd.CommandText = QRY

        dr = cmd.ExecuteReader()

        While dr.Read
            t성명.Text = fNULL(dr.Item(1))
            t생년월일.Text = fNULL(dr.Item(2))

            t휴대전화.Text = fNULL(dr.Item(5))

            t주소.Text = fNULL(dr.Item(10))
            t메모.Text = fNULL(dr.Item(11))
        End While

        dr.Close()
    End Sub

    Private Sub s중외DB연결종료()
        On Error Resume Next

        emr중외.Close()
    End Sub

    Private Sub s중외DB연결시작()
        Dim Connect_String As String = String.Format("User Id={0};password = {1};Data Source=192.168.100.100/{2};", "dreamer", "dsdvp", "CIT")

        emr중외 = New SqlConnection(Connect_String)

        bDB연결.Enabled = True

        Try
            emr중외.Open()

            If emr중외.State = ConnectionState.Open Then
                l오라클연결.Left = l오라클해제.Left : l오라클연결.Top = l오라클해제.Top

                l오라클연결.Visible = True
                l오라클해제.Visible = False

                bSQL테스트.Enabled = True
                bDB연결.Enabled = False
            Else
                l오라클연결.Visible = False
                l오라클해제.Visible = True
            End If

        Catch ex As Exception
            MsgBox("DB연결 오류" + ex.Message)
        End Try
    End Sub

    Private Sub s화면지우기()
        t성명.Text = "" : t생년월일.Text = "" : t휴대전화.Text = ""
        t주소.Text = "" : t메모.Text = ""

        t진료특이.Text = ""

        Call 스프레드.s지우기("", f내원, 0)

        Call 스프레드.s지우기("", f처방, 0)

        mnu선택된처방Repeat진료실전송.Enabled = False
    End Sub

    Public Sub s초기값()
        ' ....................................................................................................
        ReDim 기초자료_자료(4)

        기초자료_자료(1).항목1 = "전체" : 기초자료_자료(1).항목2 = "ALL"
        기초자료_자료(2).항목1 = "5회" : 기초자료_자료(2).항목2 = "5"
        기초자료_자료(3).항목1 = "10회" : 기초자료_자료(3).항목2 = "10"
        기초자료_자료(4).항목1 = "15회" : 기초자료_자료(4).항목2 = "15"

        Call slu초기값("", lu표시내원횟수, 15) : lu표시내원횟수.EditValue = "ALL"
    End Sub

    Private Sub frmDEVFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call s초기값()

        ' 화면 지우기
        Call s화면지우기()

        Call bDB연결_Click(Nothing, Nothing)

        ' 컨버젼챠트뷰어 ini 생성 ...............................................................................
        If Not Directory.Exists(sINI위치) Then
            MkDir(sINI위치)

            Call s컨버젼챠트뷰어_ini등록(sINI위치 & "\컨버전뷰어.ini", "컨버젼챠트뷰어", "업체", "중외(CIT)")
        End If

        Call s컨버젼챠트뷰어_ini등록(sINI위치 & "\컨버전뷰어.ini", "컨버젼챠트뷰어", "연동", "Y")
        Call s컨버젼챠트뷰어_ini등록(sINI위치 & "\컨버전뷰어.ini", "컨버젼챠트뷰어", "챠트번호(진료실)", "")
        Call s컨버젼챠트뷰어_ini등록(sINI위치 & "\컨버전뷰어.ini", "컨버젼챠트뷰어", "챠트번호(뷰어)", "")
    End Sub

    Private Sub bDB연결_Click(sender As Object, e As EventArgs) Handles bDB연결.Click
        Call s중외DB연결시작()
    End Sub

    Private Sub b종료_Click(sender As Object, e As EventArgs) Handles b종료.Click
        Call s중외DB연결종료()

        End
    End Sub

    Private Sub bSQL테스트_Click(sender As Object, e As EventArgs) Handles bSQL테스트.Click
        Dim s챠트번호 As String

        Dim i표시내원횟수 As Integer = Val(CONTROL.flookup("get", lu표시내원횟수))

        If Trim(t챠트번호.Text) <> "" Then
            Me.Cursor = Cursors.WaitCursor

            Call INI.sINI등록("", "", Trim(t챠트번호.Text), "", "")

            Call s환자정보읽기("", s챠트번호)

            Call s내원정보읽기("", s챠트번호)

            With f내원.Sheets(0)
                If f내원.Sheets(0).NonEmptyRowCount > 0 Then
                    ' 진료특이 읽기
                    Call s진료특이읽기("", s챠트번호)

                    Call s처방정보읽기("", s챠트번호, .GetText(.NonEmptyRowCount - 1, e내원.내원일), Format(Now, "yyyy-MM-dd"), False)

                    Select Case UCase(CONTROL.flookup("get", lu표시내원횟수))
                        Case "ALL"
                            If f내원.Sheets(0).NonEmptyRowCount > 0 Then
                                'Call s처방정보읽기("", t챠트번호.Text, .GetText(.NonEmptyRowCount - 1, e내원.내원일), .GetText(0, e내원.내원일))

                                Call s처방정보읽기("", s챠트번호, .GetText(.NonEmptyRowCount - 1, e내원.내원일), Format(Now, "yyyy-MM-dd"), False)
                            End If

                        Case Else
                            ' 5, 10, 15회
                            If .NonEmptyRowCount >= i표시내원횟수 Then
                                Call s처방정보읽기("", s챠트번호, .GetText(i표시내원횟수 - 1, e내원.내원일), .GetText(0, e내원.내원일), False)
                            Else
                                Call s처방정보읽기("", s챠트번호, .GetText(.NonEmptyRowCount - 1, e내원.내원일), .GetText(0, e내원.내원일), False)
                            End If
                    End Select
                End If
            End With

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub f내원_CellClick(sender As Object, e As FarPoint.Win.Spread.CellClickEventArgs) Handles f내원.CellClick
        Dim s챠트번호 As String

        Select Case e.ColumnHeader
            Case True

            Case Else
                Me.Cursor = Cursors.WaitCursor
                With f내원.Sheets(0)
                    Call s처방정보읽기("", s챠트번호, .GetText(e.Row, e내원.내원일), .GetText(e.Row, e내원.내원일), True)
                End With

                Me.Cursor = Cursors.Default
        End Select
    End Sub

    Private Sub frmDEVFORM_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        'If l오라클연결.Visible Then
        '    Call s경과기록("", Val(Trim(lCHARTSEQ.Text)) + 1)
        'End If
    End Sub

    Private Sub frmDEVFORM_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.Modifiers
            Case Keys.Control

            Case Else
                Select Case e.KeyCode
                    Case Keys.Escape
                        ' 챠트번호 이동
                        t챠트번호.Focus()
                End Select
        End Select
    End Sub

    Private Sub t챠트번호_EditValueChanged(sender As Object, e As EventArgs) Handles t챠트번호.EditValueChanged
        ' 화면 지우기
        Call s화면지우기()
    End Sub

    Private Sub t챠트번호_KeyUp(sender As Object, e As KeyEventArgs) Handles t챠트번호.KeyUp
        Select Case e.Modifiers
            Case Keys.Control

            Case Else
                Select Case e.KeyCode
                    Case Keys.Return
                        If l오라클연결.Visible Then
                            If Trim(t챠트번호.Text) <> "" Then
                                Call bSQL테스트_Click(Nothing, Nothing)
                            End If
                        End If
                End Select
        End Select
    End Sub

    Private Sub s선택된처방Repeat진료실전송메뉴활성(ByVal s작업 As String)
        mnu선택된처방Repeat진료실전송.Enabled = False

        With f처방.Sheets(0)
            For ii = 0 To .NonEmptyRowCount - 1
                If 스프레드.f체크CELL("get", f처방, ii, e처방.선택, "") = "1" Then
                    mnu선택된처방Repeat진료실전송.Enabled = True

                    Exit For
                End If
            Next
        End With
    End Sub



    Private Sub tm챠트번호_Tick(sender As Object, e As EventArgs) Handles tm챠트번호.Tick
        Dim s챠트번호 As String = INI.f컨버젼챠트뷰어_ini읽기(sINI위치 & "\컨버전뷰어.ini", "컨버젼챠트뷰어", "챠트번호(진료실)")

        If Trim(s챠트번호) <> "" Then
            If Trim(t챠트번호.Text) <> s챠트번호 Then
                t챠트번호.Text = s챠트번호

                Call bSQL테스트_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub mnu선택된처방Repeat진료실전송_Click(sender As Object, e As EventArgs) Handles mnu선택된처방Repeat진료실전송.Click
        Dim s상병전송자료 As String, s처방전송자료 As String

        s상병전송자료 = 챠트뷰어.f상병전송자료("", f처방)
        s처방전송자료 = 챠트뷰어.f처방전송자료("", f처방)

        Call INI.sINI등록("", "", Trim(t챠트번호.Text), s상병전송자료, s처방전송자료)
    End Sub

    Private Sub lu표시내원횟수_EditValueChanged(sender As Object, e As EventArgs) Handles lu표시내원횟수.EditValueChanged
        Dim i표시내원횟수 As Integer = Val(CONTROL.flookup("get", lu표시내원횟수))

        If Trim(t챠트번호.Text) <> "" Then
            Me.Cursor = Cursors.WaitCursor

            With f내원.Sheets(0)
                Select Case UCase(CONTROL.flookup("get", lu표시내원횟수))
                    Case "ALL"
                        If f내원.Sheets(0).NonEmptyRowCount > 0 Then
                            Call s처방정보읽기("", t챠트번호.Text, .GetText(.NonEmptyRowCount - 1, e내원.내원일), .GetText(0, e내원.내원일), False)
                        End If

                    Case Else
                        ' 5, 10, 15회
                        If .NonEmptyRowCount >= i표시내원횟수 Then
                            Call s처방정보읽기("", t챠트번호.Text, .GetText(i표시내원횟수 - 1, e내원.내원일), .GetText(0, e내원.내원일), False)
                        Else
                            Call s처방정보읽기("", t챠트번호.Text, .GetText(.NonEmptyRowCount - 1, e내원.내원일), .GetText(0, e내원.내원일), False)
                        End If
                End Select
            End With

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ck취소처방보기_CheckedChanged(sender As Object, e As EventArgs) Handles ck취소처방보기.CheckedChanged
        ck취소처방보기.Text = IIf(ck취소처방보기.Checked, "Yes", "No")

        Call bSQL테스트_Click(Nothing, Nothing)
    End Sub

    Private Sub frmDEVFORM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Call s컨버젼챠트뷰어_ini등록(sINI위치 & "\컨버전뷰어.ini", "컨버젼챠트뷰어", "연동", "")
    End Sub

End Class

Public Class Data초기값
    Public Shared Function GetData(ByVal s작업 As String) As BindingList(Of rec초기값)
        Dim records As New BindingList(Of rec초기값)()
        Dim 기초자료_LOOKUP As Object
        Select Case UCase(s작업)
            Case "LOOKUP"
                For i As Integer = 1 To UBound(기초자료_LOOKUP)
                    records.Add(New rec초기값() With
                        {
                            .명칭 = 기초자료_LOOKUP(i).항목1,
                            .코드 = 기초자료_LOOKUP(i).항목2
                        })
                Next i

            Case Else
                For i As Integer = 1 To UBound(LOOKUP)
                    records.Add(New rec초기값() With
                        {
                            .명칭 = LOOKUP(i).항목1,
                            .코드 = LOOKUP(i).항목2
                        })
                Next i
        End Select

        Return records
    End Function
End Class

Public Class rec초기값
    Implements INotifyPropertyChanged
    Public Sub New()

    End Sub

    Private s코드 As String
    <DisplayName("코드")>
    Public Property 코드() As String
        Get
            Return s코드
        End Get

        Set(ByVal value As String)
            If s코드 <> value Then
                s코드 = value
                OnPropertyChanged()
            End If
        End Set
    End Property

    Private s명칭 As String
    <DisplayName("명칭")>
    Public Property 명칭() As String
        Get
            Return s명칭
        End Get

        Set(ByVal value As String)
            If s명칭 <> value Then
                s명칭 = value
                OnPropertyChanged()
            End If
        End Set
    End Property

    Public Overrides Function ToString() As String
        'Return String.Format("코드11 = {0}, 명칭22 = {1}", 코드, 명칭)
        Return 명칭
    End Function

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = "")
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class

