Module 센스상수

    Public Enum e초재구분
        초진 = 0
        재진 = 1
        처방전 = 2
        물리치료 = 3
        정액수가 = 6
        촉탁의 = 7
        진찰료없음 = 9
        가정간호 = 12
    End Enum

    Public Enum e원내원외
        원내 = 0
        원외 = 1
    End Enum

    Public Enum e진료지원상태
        대기 = 0
        진행 = 1
        완료 = 5
        취소 = 6
    End Enum

    Public Enum e입원유형
        주 = 0
        이중 = 1
        협진 = 9
    End Enum

    Public Enum e입원상태
        재원 = 0
        퇴원 = 1
        취소 = 2
        이중 = 5
        협진 = 9
    End Enum
    Public Enum e청구방법
        분리청구 = 0
        퇴원청구 = 1
        DRG청구 = 2
        DRG분리청구 = 4
    End Enum

    Public Enum e건강검진
        없음 = 0
        일반검진 = 1
        생애전환 = 2
        암검진 = 3
    End Enum


    Public Structure eEDI코드구분
        Public Shared 수가 As String = "1"
        Public Shared 보험등재약 As String = "3"
        Public Shared 치료재료 As String = "8"
    End Structure

    Public Function f입원상태(ByVal s작업 As String, ByVal s코드 As String, ByVal s명칭 As String) As String
        f입원상태 = ""

        Select Case s작업
            Case "", "명칭", "코드->명칭", "코드→명칭"
                Select Case Val(s코드)
                    Case e입원상태.재원
                        f입원상태 = "재원"

                    Case e입원상태.퇴원
                        f입원상태 = "퇴원"

                    Case e입원상태.취소
                        f입원상태 = "취소"

                    Case e입원상태.이중
                        f입원상태 = "이중"

                    Case e입원상태.협진
                        f입원상태 = "협진"
                End Select

            Case "코드", "명칭->코드", "명칭→코드"
                Select Case Val(s명칭)
                    Case "재원"
                        f입원상태 = e입원상태.재원

                    Case "퇴원"
                        f입원상태 = e입원상태.퇴원

                    Case "취소"
                        f입원상태 = e입원상태.취소

                    Case "이중"
                        f입원상태 = e입원상태.이중

                    Case "협진"
                        f입원상태 = e입원상태.협진
                End Select
        End Select

        Return f입원상태
    End Function

    Public Function f진료상태(ByVal s작업 As String, ByVal s코드 As String, ByVal s명칭 As String) As String
        f진료상태 = ""

        Select Case s작업
            Case "", "명칭", "코드->명칭", "코드→명칭"
                Select Case Val(s코드)
                    Case e진료상태.접수
                        f진료상태 = "접수"

                    Case e진료상태.취소
                        f진료상태 = "취소"

                    Case e진료상태.입원
                        f진료상태 = "입원"

                    Case e진료상태.지원
                        f진료상태 = "지원"

                    Case e진료상태.완료
                        f진료상태 = "완료"
                End Select

            Case "코드", "명칭->코드", "명칭→코드"
                Select Case Val(s명칭)
                    Case "접수"
                        f진료상태 = e진료상태.접수

                    Case "취소"
                        f진료상태 = e진료상태.취소

                    Case "입원"
                        f진료상태 = e진료상태.입원

                    Case "지원"
                        f진료상태 = e진료상태.지원

                    Case "완료"
                        f진료상태 = e진료상태.완료
                End Select
        End Select

        Return f진료상태
    End Function

    Public Function f원내원외(ByVal s작업 As String, ByVal s코드 As String, ByVal s명칭 As String) As String
        f원내원외 = ""

        Select Case s작업
            Case "", "명칭", "코드->명칭", "코드→명칭"
                Select Case Val(s코드)
                    Case e원내원외.원내
                        f원내원외 = "원내"
                    Case e원내원외.원외
                        f원내원외 = "원외"
                End Select

            Case "코드", "명칭->코드", "명칭→코드"
                Select Case Val(s명칭)
                    Case "원내"
                        f원내원외 = "0"

                    Case "원외"
                        f원내원외 = "1"
                End Select
        End Select

        Return f원내원외
    End Function

    Public Function f진료지원상태(ByVal s작업 As String, ByVal s진료지원상태 As String) As String
        f진료지원상태 = ""

        Select Case s작업
            Case "", "명칭", "코드->명칭", "코드→명칭"
                Select Case UCase(s진료지원상태)
                    Case "5"
                        f진료지원상태 = "완료"

                    Case "6"
                        f진료지원상태 = "취소"

                    Case "1"
                        'f진료지원상태 = "미시행"
                        f진료지원상태 = "진행"

                    Case "0"
                        'f진료지원상태 = "접수"
                        f진료지원상태 = "대기"

                    Case Else
                        f진료지원상태 = ""
                End Select

            Case "코드", "명칭->코드", "명칭→코드"
                Select Case UCase(s진료지원상태)
                    Case "완료"
                        f진료지원상태 = e진료지원상태.완료

                    Case "취소"
                        f진료지원상태 = e진료지원상태.취소

                    Case "진행"
                        f진료지원상태 = e진료지원상태.진행

                    Case "대기"
                        f진료지원상태 = e진료지원상태.대기

                    Case Else
                        f진료지원상태 = ""
                End Select
        End Select

        Return f진료지원상태
    End Function

    Public Function f급여구분(ByVal s구분 As String, ByVal i보험유형 As Integer, ByVal s명칭 As String, ByVal i단가적용 As Integer,
                                        ByVal i급여구분 As Integer, ByVal i자보급여 As Integer, ByVal i산재급여 As Integer) As String
        f급여구분 = ""

        Select Case UCase(s구분)
            Case "명칭->코드", "명칭→코드"
                f급여구분 = "0"

                Select Case UCase(s명칭)
                    Case "급여"
                        f급여구분 = "0"

                    Case "비급여"
                        f급여구분 = "3"

                    Case "100%", "전액본인"
                        f급여구분 = "6"

                    Case "무료단가"
                        f급여구분 = "8"

                    Case "선별A(50%)"
                        f급여구분 = "10"

                    Case "선별B(80%)"
                        f급여구분 = "11"

                    Case "선별D(30%)"
                        f급여구분 = "12"

                    Case "선별E(90%)"
                        f급여구분 = "13"
                End Select

            Case "코드"
                f급여구분 = "20"

                Select Case i단가적용
                    Case 3, 6, 8
                        ' 비급여, 전액본인, 무료단가
                        f급여구분 = i단가적용

                    Case 10, 11, 12, 13
                        ' 10.선별급여A(50%), 11.선별급여B(80%), 12.선별급여D(30%), 13.선별급여E(90%)
                        f급여구분 = i단가적용

                    Case Else
                        Select Case i보험유형
                            Case 1, 2
                                ' 국민건강, 의료급여
                                Select Case i급여구분
                                    Case 3, 6
                                        ' 3.비급여, 6.전액본인(100%)
                                        f급여구분 = i급여구분
                                End Select

                            Case 3
                                ' 자보 ??
                                f급여구분 = i자보급여

                            Case 4
                                ' 산재 ??
                                f급여구분 = i산재급여

                            Case Else
                                f급여구분 = "3"
                        End Select
                End Select

            Case "명칭", "코드→명칭", "코드->명칭"
                f급여구분 = "급여"

                Select Case i단가적용
                    Case 3
                        f급여구분 = "비급여"

                    Case 6
                        f급여구분 = "전액본인"

                    Case 8
                        f급여구분 = "무료단가"

                    Case 10
                        f급여구분 = "선별A(50%)"

                    Case 11
                        f급여구분 = "선별B(80%)"

                    Case 12
                        f급여구분 = "선별D(30%)"

                    Case 13
                        f급여구분 = "선별E(90%)"

                    Case Else
                        Select Case i보험유형
                            Case 0
                                ' 일반 ??
                                f급여구분 = "비급여"

                            Case 1, 2
                                ' 국민건강, 의료급여
                                Select Case i단가적용
                                    Case 0
                                        f급여구분 = "급여"

                                    Case Else
                                        Select Case i급여구분
                                            Case 3
                                                f급여구분 = "비급여"
                                            Case 6
                                                f급여구분 = "전액본인"
                                            Case 8
                                                f급여구분 = "무료단가"
                                            Case 10
                                                f급여구분 = "선별A(50%)"
                                            Case 11
                                                f급여구분 = "선별B(80%)"
                                            Case 12
                                                f급여구분 = "선별D(30%)"
                                            Case 13
                                                f급여구분 = "선별E(90%)"
                                            Case Else
                                                f급여구분 = "급여"
                                        End Select
                                End Select

                            Case 3
                                ' 자보 ??
                                f급여구분 = "급여"

                            Case 4
                                ' 산재 ??
                                f급여구분 = "급여"

                            Case 5
                                ' 전액본인
                                f급여구분 = "전액본인"

                            Case 6, 7
                                f급여구분 = "전액본인"

                            Case Else
                                f급여구분 = "급여"
                        End Select
                End Select
        End Select

        Return f급여구분
    End Function

    Public Function f보호종별(ByVal s작업 As String, ByVal s자료 As String) As String
        f보호종별 = ""

        Select Case s작업
            Case "", "명칭", "코드->명칭", "코드→명칭"
                Select Case Val(s자료)
                    Case 1
                        f보호종별 = "1종"

                    Case 2
                        f보호종별 = "2종"

                    Case Else
                        f보호종별 = s자료
                End Select
        End Select

        Return f보호종별
    End Function

    Public Function f보험유형(ByVal s작업 As String, ByVal s자료 As String) As String
        f보험유형 = ""

        Select Case s작업
            Case "", "명칭", "코드->명칭", "코드→명칭"
                Select Case Val(s자료)
                    Case ocsEnumBohumKind.ocsBohumKind1국민공단
                        f보험유형 = "국민건강"

                    Case ocsEnumBohumKind.ocsBohumKind5국민공단본인
                        f보험유형 = "국민건강(본)"

                    Case ocsEnumBohumKind.ocsBohumKind2의료급여
                        f보험유형 = "의료급여"

                    Case ocsEnumBohumKind.ocsBohumKind3자동차보험
                        f보험유형 = "자보"

                    Case ocsEnumBohumKind.ocsBohumKind6자보본인
                        f보험유형 = "자보(본)"

                    Case ocsEnumBohumKind.ocsBohumKind4산업재해
                        f보험유형 = "산재"

                    Case ocsEnumBohumKind.ocsBohumKind7산재본인
                        f보험유형 = "산재(본)"

                    Case ocsEnumBohumKind.ocsBohumKind8계약
                        f보험유형 = "계약"

                    Case ocsEnumBohumKind.ocsBohumKind0일반
                        f보험유형 = "일반"
                End Select
        End Select

        Return f보험유형
    End Function

    Public Function fEDI구분(ByVal s작업 As String, ByVal s자료 As String) As String
        fEDI구분 = ""

        Select Case s작업
            Case "", "명칭", "코드->명칭", "코드→명칭"
                Select Case s자료
                    Case eEDI코드구분.수가
                        fEDI구분 = "수가"

                    Case eEDI코드구분.보험등재약
                        fEDI구분 = "보험등재약"

                    Case eEDI코드구분.치료재료
                        fEDI구분 = "치료재료"
                End Select
        End Select

        Return fEDI구분
    End Function


End Module
