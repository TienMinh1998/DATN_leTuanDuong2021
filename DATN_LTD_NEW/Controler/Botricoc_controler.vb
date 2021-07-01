Public Class Botricoc_controler
    Public Shared Function Hmin() As Double
        Dim v As Double ' giá trị
        Dim luccat As Double = DATA.Qxtt ' lực cắt theo phương ngang
        Dim b As Double = DATA.b
        Dim l As Double = DATA.l
        Dim v1, v2, v3 As Double

        v1 = (DaiMong.Hm - DaiMong.Hd) * (l * b) ' thể tích có cả cột và đất
        v2 = DaiMong.Hcot * DaiMong.Bcot * (DaiMong.Hm - DaiMong.Hd) ' thể tích của cột
        v3 = v1 - v2 ' thể tích của đất 
        Dim trongluongrieng As Double
        trongluongrieng = v3 * 26.87 ' 26.87 là trọng lượng riêng của đất
        Dim gocmasat As Double = LST_DiaChat(0).GocMS * Math.PI / 180

        v = Math.Tan(Math.PI / 4 - gocmasat / 2) * Math.Sqrt((luccat / trongluongrieng * b))

        Return Math.Round(v, 2)
    End Function
End Class
