
Friend Class clsRTFReport
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' clsRTFReport
    ' Tao report RTF
    ' Lap boi: Nguyen Phu Quang - bo mon Tin hoc Xay dung, khoa CNTT
    '                             truong Dai hoc Xay dung
    ' Ban co the su dung, sua doi, phan phoi lai doan ma nguon nay
    ' De nghi giu lai phan thong tin ve tac gia
    ' Lien he: nguyenphuquang@gmail.com
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Content As String

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Sao chep Report ra 1 ban khac
    Public Function Copy() As clsRTFReport
        Copy = New clsRTFReport
        Copy.Content = Content
    End Function

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Lay thong tin trong cap Bookmark
    ' Trong file vi du la: start_TenBookMark va end_TenBookMark
    Public Function GetBookMark(ByRef strBookMarkName As String) As clsRTFReport
        Dim startBookmark, endBookmark As String
        startBookmark = "{\*\bkmkstart start_" & strBookMarkName & "}"
        endBookmark = "{\*\bkmkend end_" & strBookMarkName & "}"

        Dim a, b As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        a = Split(Content, startBookmark)
        'UPGRADE_WARNING: Couldn't resolve default property of object a(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object b. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        b = Split(a(1), endBookmark)

        startBookmark = "{\*\bkmkstart " & strBookMarkName & "}"
        endBookmark = "{\*\bkmkend " & strBookMarkName & "}"
        'UPGRADE_WARNING: Couldn't resolve default property of object b(1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object a(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Content = a(0) & startBookmark & endBookmark & b(1)
        'UPGRADE_WARNING: Couldn't resolve default property of object b(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        b(0) = Replace(b(0), "{\*\bkmkend start_" & strBookMarkName & "}", "")
        'UPGRADE_WARNING: Couldn't resolve default property of object b(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        b(0) = Replace(b(0), "{\*\bkmkstart end_" & strBookMarkName & "}", "")
        GetBookMark = New clsRTFReport
        'UPGRADE_WARNING: Couldn't resolve default property of object b(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        GetBookMark.Content = b(0)
    End Function

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Chen noi dung InsertText vao dung vi tri cua cap BookMark da lay
    ' Voi 1 cap bookmark, co the chen lien tiep nhieu noi dung noi tiep nhau
    Public Sub InsertBookmark(ByRef strBookMarkName As String, ByRef InsertText As String)
        Dim findText As String
        findText = "{\*\bkmkstart " & strBookMarkName & "}{\*\bkmkend " & strBookMarkName & "}"
        Content = Replace(Content, findText, InsertText & findText, 1, 1)
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Lay noi dung template tu file RTF (file soan thao trong Word)
    Public Sub GetTemplate(ByRef fileName As String)
        Dim f As Short
        f = FreeFile()
        FileOpen(f, fileName, OpenMode.Input)
        Dim line As String
        Content = ""
        Do Until EOF(f)
            line = LineInput(f)
            Content = Content & line
        Loop
        FileClose(f)
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Thay the noi dung trong file template bang gia tri [Value]
    Public Sub SetValue(ByRef strValueName As String, ByRef Value As Object)
        'UPGRADE_WARNING: Couldn't resolve default property of object Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Content = Replace(Content, strValueName, Value)
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Dua noi dung file RTF sau khi da thay the ra file Report
    Public Sub WriteToRTF(ByRef fileName As String)
        Dim f As Short
        f = FreeFile()
        FileOpen(f, fileName, OpenMode.Output)
        PrintLine(f, Content)
        FileClose(f)
    End Sub
End Class