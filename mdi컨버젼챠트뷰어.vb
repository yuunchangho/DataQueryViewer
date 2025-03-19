Imports System.Data.SqlClient

Imports System.Net

Public Class mdi컨버젼챠트뷰어
    Private Function f윈도우버젼(ByVal s작업 As String) As String
        Dim OS As OperatingSystem = Environment.OSVersion

        f윈도우버젼 = "UnKnown Version(OS.Version.Minor->" & OS.Version.Minor & ")"

        Select Case OS.Version.Major
            Case 4
                f윈도우버젼 = "Windows NT 4.0"

            Case 5
                Select Case OS.Version.Minor
                    Case 0
                        f윈도우버젼 = "Windows 2000"

                    Case 1
                        f윈도우버젼 = "Windows XP"

                    Case Else
                        f윈도우버젼 = "Windows 2003"
                End Select

            Case 6
                Select Case OS.Version.Minor
                    Case 0
                        f윈도우버젼 = "Windows Vista"

                    Case 1
                        f윈도우버젼 = "Windows 7"

                    Case 2
                        f윈도우버젼 = "Windows 10 Home"

                    Case 3
                        f윈도우버젼 = "Windows 11 Home"

                    Case Else
                        f윈도우버젼 = "Windows 8"
                End Select

            Case 10
                Select Case OS.Version.Minor
                    Case 0
                        f윈도우버젼 = "Windows 10"

                    Case Else
                        f윈도우버젼 = "Windows 10"
                End Select
        End Select

        Return f윈도우버젼
    End Function

    Private Sub s사용PC정보등록(ByVal s작업 As String, ByVal sIP As String, ByVal s업무 As String, ByVal s버젼 As String)
        Dim sSQL As SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "insert into " & DBname & "..YY_사용PC정보 "
        QRY = QRY & "       (   IP,                                     업무, "
        QRY = QRY & "           컴퓨터이름,								컴퓨터사용자이름, "
        QRY = QRY & "           OS버젼, "
        QRY = QRY & "           버젼,								    접속일시 ) "
        QRY = QRY & "   select  '" & sIP & "',                          '" & s업무 & "', "
        QRY = QRY & "           '" & 사용자.컴퓨터이름 & "',        		'" & 사용자.컴퓨터사용자이름 & "', "
        QRY = QRY & "           '" & fQRY(사용자.OS버젼) & "', "
        QRY = QRY & "           '" & s버젼 & "',        					getdate() "

        sSQL = New SqlCommand(QRY, SVREMR)

        rs = sSQL.ExecuteReader()

        While rs.Read()

        End While

        ' ....................................................................................................
        rs.Close()
    End Sub

    Private Sub s사용PC정보수정(ByVal s작업 As String, ByVal sIP As String, ByVal s업무 As String, ByVal s버젼 As String)
        Dim sSQL As SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "update " & DBname & "..YY_사용PC정보 "
        QRY = QRY & "   set     컴퓨터이름		= '" & 사용자.컴퓨터이름 & "', "
        QRY = QRY & "           컴퓨터사용자이름	= '" & 사용자.컴퓨터사용자이름 & "', "
        QRY = QRY & "           OS버젼    		= '" & fQRY(사용자.OS버젼) & "', "
        QRY = QRY & "           버젼				= '" & s버젼 & "', "
        QRY = QRY & "           접속일시			= getdate() "
        QRY = QRY & "   where	IP				= '" & sIP & "' "
        QRY = QRY & "	and		업무				= '" & s업무 & "'"

        sSQL = New SqlCommand(QRY, SVREMR)

        rs = sSQL.ExecuteReader()

        While rs.Read()

        End While

        ' ....................................................................................................
        rs.Close()
    End Sub

    Private Function f사용PC정보체크(ByVal s작업 As String, ByVal sIP As String, ByVal s업무 As String, ByVal s버젼 As String) As Boolean
        Dim sSQL As SqlCommand
        Dim rs As SqlDataReader

        Dim QRY As String

        ' ＲＥＴＵＲＮ　ＶＡＬＵＥ
        f사용PC정보체크 = False

        ' ＳＱＬ　ＳＴＡＴＥＭＥＮＴ
        QRY = "if	exists(	select	* "
        QRY = QRY & "               from	" & DBname & "..YY_사용PC정보 "
        QRY = QRY & "   			where	IP			= '" & sIP & "' "
        QRY = QRY & "				and		업무			= '" & s업무 & "' ) "
        QRY = QRY & "   	select	'존재' "
        QRY = QRY & "   else "
        QRY = QRY & "   	select	''"

        sSQL = New SqlCommand(QRY, SVREMR)

        rs = sSQL.ExecuteReader()

        While rs.Read()
            If fNULL(rs.GetValue(0)) = "존재" Then
                f사용PC정보체크 = True
            End If
        End While

        ' ....................................................................................................
        rs.Close()
    End Function

    Public Sub s빌드정보(ByVal s작업 As String)
        Dim s버젼() As String

        Dim s업무 As String = "New통계"

        ' ----------------------------------------------------------------------------------------------------
        프로그램.버젼 = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()

        s버젼 = Split(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(), ".")

        For xx = 1 To UBound(s버젼)
            If xx < 3 Then s버젼(xx) = f0PADDING(s버젼(xx), 2)
        Next

        프로그램.버젼 = ""

        For xx = 0 To UBound(s버젼)
            프로그램.버젼 &= IIf(프로그램.버젼 <> "", "." & s버젼(xx), s버젼(xx))
        Next

        ' ----------------------------------------------------------------------------------------------------
        사용자.OS버젼 = f윈도우버젼("")

        ' ----------------------------------------------------------------------------------------------------
        Me.Text = "▒ 데이터뷰어 (●요양기관 : " & 사용자.기관명 & "   ●부서 : " & 사용자.부서명칭 & "   ●사용자 : " & 사용자.성명 & "-" & 사용자.코드 & ")    " &
                                            Screen.AllScreens(0).WorkingArea.Width & "*" & Screen.AllScreens(0).WorkingArea.Height & "(" & 프로그램.버젼 & ")"
    End Sub

    Private Sub s초기INI값설정()


    End Sub

    Public Sub sIP정보()
        'Dim ip As String
        'Dim ip2 As String

        Dim h As System.Net.IPHostEntry = Nothing

        Try
            h = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName)

            If InStr(1, h.AddressList.GetValue(1).ToString, ":") <> 0 Then
                사용자.IP = h.AddressList.GetValue(2).ToString
            Else
                사용자.IP = h.AddressList.GetValue(1).ToString
            End If

            ' MAC ADDRESS
            사용자.MAC_ADDRESS = h.AddressList.GetValue(0).ToString

        Catch ex As Exception

        End Try

        ' ....................................................................................................
        사용자.컴퓨터이름 = Environment.MachineName
        사용자.컴퓨터사용자이름 = Environment.UserName
    End Sub '

    Private Sub mdi컨버젼챠트뷰어_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ....................................................................................................
        Call sIP정보()

        ' ....................................................................................................
        Call s초기INI값설정()

        Call DB정보.s센스INI정보읽기("sense")

        DB메트로name = "METRO"

        Application.DoEvents()

        Call DB정보.s센스DB연결시작("", SERVERname, DBname, USERID, USERPASSWD)

        Dim arguments As Object
        Dim s자료 As Object
        ' 사용자 정보 읽기 .....................................................................................
        ' ....................................................................................................
        arguments = Environment.GetCommandLineArgs()

        ' command line
        If UBound(arguments) = 1 Then
            s자료 = Split(arguments(1), "/")

            ' DB/사용자id/비밀번호 인수로 넘어오는 경우
            DBname = s자료(0)
        Else
            ReDim s자료(2)

            s자료(1) = IIf(Trim(s최종로그인ID) <> "", s최종로그인ID, "admin") : s자료(2) = "tmzpdlfdjq"
        End If

        Call 통계.s사용자정보("", s자료(1), s자료(2))

        Call s빌드정보("")

        'Call 테이블정보.s심사테이블생성()

        ' ....................................................................................................
        Application.DoEvents()
        With frm자료보기
            .MdiParent = Me

            .Left = 0 : .Top = 0

            .BringToFront()

            .Show()
        End With

    End Sub


End Class