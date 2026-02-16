Imports System.Text.RegularExpressions

Module Module1

	Sub Main()
		Dim nDecNum = 0
		Dim nBinPower = 1
		Dim nMaxBinaryLen = Math.Truncate(Math.Log(UInteger.MaxValue, 2))
		Dim oRegEx = New Regex("[0-1]")
		Console.WriteLine("Input a binary number")
		Dim strLine = Console.ReadLine()
		Dim nStrLen = strLine.Length
		Dim nMatches = oRegEx.Matches(strLine).Count
		Dim bRightString = (nStrLen <= nMaxBinaryLen) AndAlso (nStrLen = nMatches)
		If Not bRightString Then
			Console.WriteLine("Wrong binary number format!!!")
			Console.Read()
			Return
		End If
		For i As Integer = 0 To nStrLen - 1
			Dim nBinDight As Integer = AscW(strLine.Chars(nStrLen - 1 - i)) - AscW("0"c)
			nDecNum += (nBinDight * nBinPower)
			nBinPower *= 2
		Next i
		Console.WriteLine("The decenary equivalent of the binary number {0} is {1}", strLine, nDecNum)
		Console.Read()
	End Sub

End Module
