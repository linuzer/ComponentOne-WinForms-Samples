﻿Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim m01 As Bitmap = My.Resources.m01
        Dim m02 As Bitmap = My.Resources.m02
        Dim m03 As Bitmap = My.Resources.m03
        Dim m04 As Bitmap = My.Resources.m04
        Dim m05 As Bitmap = My.Resources.m05
        Dim m06 As Bitmap = My.Resources.m06
        Dim m07 As Bitmap = My.Resources.m07
        Dim m08 As Bitmap = My.Resources.m08
        Dim m09 As Bitmap = My.Resources.m09
        Dim m10 As Bitmap = My.Resources.m10
        Dim m11 As Bitmap = My.Resources.m11
        Dim m12 As Bitmap = My.Resources.m12

        Dim t01 As String = "January"
        Dim t02 As String = "February"
        Dim t03 As String = "March"
        Dim t04 As String = "April"
        Dim t05 As String = "May"
        Dim t06 As String = "June"
        Dim t07 As String = "July"
        Dim t08 As String = "August"
        Dim t09 As String = "September"
        Dim t10 As String = "October"
        Dim t11 As String = "November"
        Dim t12 As String = "December"

        tile1.Image1 = m01
        tile1.Text1 = t01
        tile1.Image2 = m02
        tile1.Text2 = t02
        tile1.Image3 = m03
        tile1.Text3 = t03
        tile1.Image4 = m09
        tile1.Text4 = t09
        tile1.Image5 = m12
        tile1.Text5 = t12

        tile2.Image1 = m04
        tile2.Text1 = t04
        tile2.Image2 = m05
        tile2.Text2 = t05
        tile2.Image3 = m06
        tile2.Text3 = t06
        tile2.Image4 = m10
        tile2.Text4 = t10
        tile2.Image5 = m07
        tile2.Text5 = t07

        tile3.Image1 = m07
        tile3.Text1 = t07
        tile3.Image2 = m08
        tile3.Text2 = t08
        tile3.Image3 = m09
        tile3.Text3 = t09
        tile3.Image4 = m02
        tile3.Text4 = t02
        tile3.Image5 = m11
        tile3.Text5 = t11

        tile4.Image1 = m10
        tile4.Text1 = t10
        tile4.Image2 = m11
        tile4.Text2 = t11
        tile4.Image3 = m12
        tile4.Text3 = t12
        tile4.Image4 = m03
        tile4.Text4 = t03
        tile4.Image5 = m05
        tile4.Text5 = t05

        tile5.Image1 = m06
        tile5.Text1 = t06
        tile5.Image2 = m04
        tile5.Text2 = t04
        tile5.Image3 = m02
        tile5.Text3 = t02
        tile5.Image4 = m09
        tile5.Text4 = t09
        tile5.Image5 = m10
        tile5.Text5 = t10

        tile6.Image1 = m08
        tile6.Text1 = t08
        tile6.Image2 = m10
        tile6.Text2 = t10
        tile6.Image3 = m12
        tile6.Text3 = t12
        tile6.Image4 = m02
        tile6.Text4 = t02
        tile6.Image5 = m04
        tile6.Text5 = t04

        tile7.Image1 = m03
        tile7.Text1 = t03
        tile7.Image2 = m06
        tile7.Text2 = t06
        tile7.Image3 = m09
        tile7.Text3 = t09
        tile7.Image4 = m01
        tile7.Text4 = t01
        tile7.Image5 = m04
        tile7.Text5 = t04

        tile8.Image1 = m12
        tile8.Text1 = t12
        tile8.Image2 = m02
        tile8.Text2 = t02
        tile8.Image3 = m05
        tile8.Text3 = t05
        tile8.Image4 = m06
        tile8.Text4 = t06
        tile8.Image5 = m07
        tile8.Text5 = t07

        tile9.Image1 = m08
        tile9.Text1 = t08
        tile9.Image2 = m11
        tile9.Text2 = t11
        tile9.Image3 = m01
        tile9.Text3 = t01
        tile9.Image4 = m03
        tile9.Text4 = t03
        tile9.Image5 = m02
        tile9.Text5 = t02

        tile10.Image1 = m12
        tile10.Text1 = t12
        tile10.Image2 = m11
        tile10.Text2 = t11
        tile10.Image3 = m10
        tile10.Text3 = t10
        tile10.Image4 = m04
        tile10.Text4 = t04
        tile10.Image5 = m07
        tile10.Text5 = t07

        tile11.Image1 = m09
        tile11.Text1 = t09
        tile11.Image2 = m08
        tile11.Text2 = t08
        tile11.Image3 = m07
        tile11.Text3 = t07
        tile11.Image4 = m01
        tile11.Text4 = t01
        tile11.Image5 = m12
        tile11.Text5 = t12

        tile12.Image1 = m05
        tile12.Text1 = t05
        tile12.Image2 = m04
        tile12.Text2 = t04
        tile12.Image3 = m03
        tile12.Text3 = t03
        tile12.Image4 = m11
        tile12.Text4 = t11
        tile12.Image5 = m09
        tile12.Text5 = t09

        tile13.Image1 = m02
        tile13.Text1 = t02
        tile13.Image2 = m01
        tile13.Text2 = t01
        tile13.Image3 = m06
        tile13.Text3 = t06
        tile13.Image4 = m08
        tile13.Text4 = t08
        tile13.Image5 = m07
        tile13.Text5 = t07

        tile14.Image1 = m05
        tile14.Text1 = t05
        tile14.Image2 = m09
        tile14.Text2 = t09
        tile14.Image3 = m10
        tile14.Text3 = t10
        tile14.Image4 = m03
        tile14.Text4 = t03
        tile14.Image5 = m04
        tile14.Text5 = t04

        tile15.Image1 = m07
        tile15.Text1 = t07
        tile15.Image2 = m02
        tile15.Text2 = t02
        tile15.Image3 = m05
        tile15.Text3 = t05
        tile15.Image4 = m08
        tile15.Text4 = t08
        tile15.Image5 = m12
        tile15.Text5 = t12

        tile16.Image1 = m11
        tile16.Text1 = t11
        tile16.Image2 = m01
        tile16.Text2 = t01
        tile16.Image3 = m10
        tile16.Text3 = t10
        tile16.Image4 = m05
        tile16.Text4 = t05
        tile16.Image5 = m06
        tile16.Text5 = t06

        tile17.Image1 = m08
        tile17.Text1 = t08
        tile17.Image2 = m12
        tile17.Text2 = t12
        tile17.Image3 = m03
        tile17.Text3 = t03
        tile17.Image4 = m02
        tile17.Text4 = t02
        tile17.Image5 = m10
        tile17.Text5 = t10

        tile18.Image1 = m06
        tile18.Text1 = t06
        tile18.Image2 = m07
        tile18.Text2 = t07
        tile18.Image3 = m09
        tile18.Text3 = t09
        tile18.Image4 = m11
        tile18.Text4 = t11
        tile18.Image5 = m03
        tile18.Text5 = t03

    End Sub
End Class
