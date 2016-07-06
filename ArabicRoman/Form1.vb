'Imports predefined RegularExpressions Class to validate given input
Imports System.Text.RegularExpressions
' Class Name : ArabicRoman
' Author : karthik Reddy Beereddy
' Purpose : Creating a form to read Arabic or Roman from user
'           and display Arabic and Roman of each Arabic and Roman read
'            from user
' Date 1 May,2014
' Modified Date 1 May,2014
' Modified Date 2 May,2014
' Modified Date 3 May,2014
Public Class ArabicRoman
    'declaring property variables to  set and get values
    Property _Arabic As Integer
    Property _Roman As String

    ' property to get and set Arabic value as Integer
    Property Arabic As Integer
        Get
            Return _Arabic
        End Get
        Set(ByVal value As Integer)
            _Arabic = value
        End Set
    End Property
    'property to get and set Roman  value as string
    Property Roman As String
        Get
            Return _Arabic
        End Get
        Set(ByVal value As String)
            _Roman = value
        End Set
    End Property
    'Creating Object 'ObjNum' for ArabicRoman Class
    'ONLY ONE object to set and get arabic and roman values accordingly
    Shared ObjNum As New ArabicRoman

    '***  Method Name : ButtonSave_Click
    '***  Method Author : karthik Reddy Beereddy
    '******************************************************
    '*** Purpose of the Method : Validates for User input in TextboxValue
    '                           and Sets Arabic Roman value corresponding
    '                           to user input
    '******************************************************
    '*** Date 1-May-2014
    '*** Modified Date 1-May-2014
    '*** Modified Date 2-May-2014
    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        'validating user input  for valid Arabic or Roman value
        Dim inputArab As Match = Regex.Match(TextBoxValue.Text, "[^0-9]", RegexOptions.IgnoreCase)
        Dim inputRoman As Match = Regex.Match(TextBoxValue.Text, "[^IVXLCDM]", RegexOptions.IgnoreCase)

        'If user input is not valid display message asking to enter correct input value
        If (inputRoman.Success And inputArab.Success) Then
            MsgBox(TextBoxValue.Text & " is not a valid value " & vbCrLf & _
                   "Entered  value should be either  Arabic or Roman Number")
        Else
            'making retrieveArabic and RetrieveRoman buttons visible after valid  input
            ButtonRetrieveArabic.Visible = True
            ButtonRoman.Visible = True

            'checking if Arabic is entered  else value entered will be roman
            If Not inputArab.Success Then
                'Sets Arabic and Roman Values when Arabic Value is given
                ObjNum._Arabic = Convert.ToInt32(TextBoxValue.Text)
                ObjNum._Roman = ConvertArabicToRoman()
            Else
                'Sets Arabic and Roman Values when Roman Value is given
                ObjNum._Arabic = ConvertRomanToArabic()
                ObjNum._Roman = ConvertArabicToRoman()
            End If
        End If

    End Sub

    '***  Method Name : ConvertArabicToRoman
    '***  Method Author : karthik Reddy Beereddy
    '******************************************************
    '*** Purpose of the Method : Converts given  Arabic input to Roman
    '******************************************************
    '*** Date 1-May-2014
    '*** Modified Date 1-May-2014
    '*** Modified Date 2-May-2014


    Private Function ConvertArabicToRoman() As String
        Dim Roman As String
        Dim digit As Integer
        Dim arab As Integer
        Dim harray As Array = {"C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", "M"}
        Dim tarray As Array = {"X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC", "C"}
        Dim oarray As Array = {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X"}
        Roman = ""
        arab = ObjNum._Arabic
        'Add thousands to Roman
        digit = arab \ 1000
        Roman = Roman & New String("M", digit)
        arab = arab - digit * 1000

        'Add hundreds to Roman 
        digit = arab \ 100
        If Not digit = 0 Then
            Roman = Roman & harray(digit - 1)
        End If
        arab = arab - digit * 100

        'Add tens to Roman
        digit = arab \ 10
        If Not digit = 0 Then
            Roman = Roman & tarray(digit - 1)
        End If
        arab = arab - digit * 10

        'Add ones to Roman
        digit = arab
        If Not digit = 0 Then
            Roman = Roman & oarray(digit - 1)
        End If

        Return Roman
    End Function
    '***  Method Name : ConvertRomanToArabic
    '***  Method Author : karthik Reddy Beereddy
    '******************************************************
    '*** Purpose of the Method : Converts given  Roman input to Arabic number
    '******************************************************
    '*** Date 1-May-2014
    '*** Modified Date 1-May-2014
    '*** Modified Date 2-May-2014
    Private Function ConvertRomanToArabic() As Integer
        Dim Arabic As Integer
        Dim temp As Integer
        Dim prev As Integer
        Dim ch As Char
        'converting  input value to uppercase and storing in "rom" string
        Dim rom = TextBoxValue.Text.ToUpper
        'traversing Each character of roman String
        For i As Integer = 0 To rom.Length - 1
            ch = rom(i)
            Select Case ch
                Case "M"
                    temp = 1000
                Case "D"
                    temp = 500
                Case "C"
                    temp = 100
                Case "L"
                    temp = 50
                Case "X"
                    temp = 10
                Case "V"
                    temp = 5
                Case "I"
                    temp = 1
            End Select

            'Single subraction of shortcut roman numbers
            'Example : IX =(10-1)
            If i > 0 Then
                If prev < temp Then
                    Arabic += temp - 2 * prev
                Else
                    Arabic += temp
                End If
            Else
                Arabic += temp
            End If
            prev = temp

        Next
        'return converted value to Buttonsave_click to set arabic value
        Return Arabic
    End Function
    '***  Method Name : ButtonRetrieveArabic_Click
    '***  Method Author : karthik Reddy Beereddy
    '******************************************************
    '*** Purpose of the Method : Display message with Arabic value in message box

    '******************************************************
    '*** Date 1-May-2014
    '*** Modified Date 1-May-2014
    '*** Modified Date 2-May-2014
    Private Sub ButtonRetrieveArabic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRetrieveArabic.Click
        'gets Arabic value stored in Object 'ObjNum'
        Dim str = "Arabic Value is : " & ObjNum._Arabic

        MsgBox(str, MsgBoxStyle.Information, "Value")

        ButtonRetrieveArabic.Visible = False

    End Sub
    '***  Method Name : ButtonRoman_Click
    '***  Method Author : karthik Reddy Beereddy
    '******************************************************
    '*** Purpose of the Method : Display message with Roman value in message box
    '******************************************************
    '*** Date 1-May-2014
    '*** Modified Date 1-May-2014
    '*** Modified Date 2-May-2014
    Private Sub ButtonRoman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRoman.Click
        'gets Roman value Stored in Object 'ObjectNum'
        Dim str = "Roman Value is : " & ObjNum._Roman
        MsgBox(str, MsgBoxStyle.Information, "Value")

        ButtonRoman.Visible = False
    End Sub
End Class
