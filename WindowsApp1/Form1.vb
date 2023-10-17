Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem.ToString() = "US Dollar" Then
            Flag_1.Visible = True
            Flag_1.Image = My.Resources.USA__1_
        End If
        If ComboBox1.SelectedItem.ToString() = "Hongkong Dollar" Then
            Flag_1.Visible = True
            Flag_1.Image = My.Resources.HongK
        End If
        If ComboBox1.SelectedItem.ToString() = "Canadian Dollar" Then
            Flag_1.Visible = True
            Flag_1.Image = My.Resources.Canada
        End If
        If ComboBox1.SelectedItem.ToString() = "Indian Rupee" Then
            Flag_1.Visible = True
            Flag_1.Image = My.Resources.india
        End If
        If ComboBox1.SelectedItem.ToString() = "Sri Lankan Rupee" Then
            Flag_1.Visible = True
            Flag_1.Image = My.Resources.sri
        End If
        If ComboBox1.SelectedItem.ToString() = "UAE Dinar" Then
            Flag_1.Visible = True
            Flag_1.Image = My.Resources.UAE
        End If
        If ComboBox1.SelectedItem.ToString() = "Philippine Peso" Then
            Flag_1.Visible = True
            Flag_1.Image = My.Resources.Phil
        End If
        If ComboBox1.SelectedItem.ToString() = "UK Pound" Then
            Flag_1.Visible = True
            Flag_1.Image = My.Resources.UK
        End If
        If ComboBox1.SelectedItem.ToString() = "Japanese Yen" Then
            Flag_1.Visible = True
            Flag_1.Image = My.Resources.jap
        End If
        If ComboBox1.SelectedItem.ToString() = "Euro" Then
            Flag_1.Visible = True
            Flag_1.Image = My.Resources.eu
        End If

    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem.ToString() = "US Dollar" Then
            Flag_2.Visible = True
            Flag_2.Image = My.Resources.USA__1_
        End If
        If ComboBox2.SelectedItem.ToString() = "Hongkong Dollar" Then
            Flag_2.Visible = True
            Flag_2.Image = My.Resources.HongK
        End If
        If ComboBox2.SelectedItem.ToString() = "Canadian Dollar" Then
            Flag_2.Visible = True
            Flag_2.Image = My.Resources.Canada
        End If
        If ComboBox2.SelectedItem.ToString() = "Indian Rupee" Then
            Flag_2.Visible = True
            Flag_2.Image = My.Resources.india
        End If
        If ComboBox2.SelectedItem.ToString() = "Sri Lankan Rupee" Then
            Flag_2.Visible = True
            Flag_2.Image = My.Resources.sri
        End If
        If ComboBox2.SelectedItem.ToString() = "UAE Dinar" Then
            Flag_2.Visible = True
            Flag_2.Image = My.Resources.UAE
        End If
        If ComboBox2.SelectedItem.ToString() = "Philippine Peso" Then
            Flag_2.Visible = True
            Flag_2.Image = My.Resources.Phil
        End If
        If ComboBox2.SelectedItem.ToString() = "UK Pound" Then
            Flag_2.Visible = True
            Flag_2.Image = My.Resources.UK
        End If
        If ComboBox2.SelectedItem.ToString() = "Japanese Yen" Then
            Flag_2.Visible = True
            Flag_2.Image = My.Resources.jap
        End If
        If ComboBox2.SelectedItem.ToString() = "Euro" Then
            Flag_2.Visible = True
            Flag_2.Image = My.Resources.eu
        End If

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"
        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub btnp_Click(sender As Object, e As EventArgs) Handles btnp.Click
        If Not (TextBox1.Text.Contains(".")) Then
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        If (TextBox1.Text.Length > 0) Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        End If
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        Try
            Dim amount As Double
            If Double.TryParse(TextBox1.Text, amount) Then
                Dim fromCurrency As String = ComboBox1.SelectedItem.ToString()
                Dim toCurrency As String = ComboBox2.SelectedItem.ToString()

                ' Check if From and To currencies are the same
                If fromCurrency = toCurrency Then
                    MessageBox.Show("From and To currencies cannot be the same.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim exchangeRate As Double = GetExchangeRate(fromCurrency, toCurrency)
                If exchangeRate >= 0 Then
                    Dim convertedAmount As Double = amount * exchangeRate
                    Dim currencySymbol As String = ""
                    Select Case toCurrency
                        Case "US Dollar"
                            currencySymbol = "$"
                        Case "Hongkong Dollar"
                            currencySymbol = "HKD"
                        Case "Canadian Dollar"
                            currencySymbol = "CAD"
                        Case "Indian Rupee"
                            currencySymbol = "₹"
                        Case "Sri Lankan Rupee"
                            currencySymbol = "₨"
                        Case "UAE Dinar"
                            currencySymbol = "AED"
                        Case "UK Pound"
                            currencySymbol = "£"
                        Case "Japanese Yen"
                            currencySymbol = "¥"
                        Case "Euro"
                            currencySymbol = "€"
                        Case "Philippine Peso"
                            currencySymbol = "₱"
                    End Select
                    TextBox2.Text = currencySymbol & " " & convertedAmount.ToString("F2")
                Else
                    MessageBox.Show("Invalid conversion rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Else
                MessageBox.Show("Invalid input amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception
            MessageBox.Show("Error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function GetExchangeRate(fromCurrency As String, toCurrency As String) As Double
        Select Case fromCurrency
            Case "US Dollar"
                Select Case toCurrency
                    Case "Hongkong Dollar"
                        Return 6.25
                    Case "Canadian Dollar"
                        Return 40
                    Case "Indian Rupee"
                        Return 0.5
                    Case "Sri Lankan Rupee"
                        Return 0.25
                    Case "UAE Dinar"
                        Return 10
                    Case "UK Pound"
                        Return 0.018
                    Case "Japanese Yen"
                        Return 0.4
                    Case "Euro"
                        Return 0.022
                    Case "Philippine Peso"
                        Return 50
                End Select
            Case "Hongkong Dollar"
                Select Case toCurrency
                    Case "US Dollar"
                        Return 0.16
                    Case "Canadian Dollar"
                        Return 6.25
                    Case "Indian Rupee"
                        Return 8
                    Case "Sri Lankan Rupee"
                        Return 16
                    Case "UAE Dinar"
                        Return 0.65
                    Case "UK Pound"
                        Return 0.12
                    Case "Japanese Yen"
                        Return 13
                    Case "Euro"
                        Return 0.14
                    Case "Philippine Peso"
                        Return 8
                End Select
            Case "Canadian Dollar"
                Select Case toCurrency
                    Case "Phiippine Peso"
                        Return 40
                    Case "US Dollar"
                        Return 0.8
                    Case "Hongkong Dollar"
                        Return 5.6
                    Case "Indian Rupee"
                        Return 53.6
                    Case "Sri Lankan Rupee"
                        Return 122.4
                    Case "UAE Dinar"
                        Return 2.2
                    Case "UK Pound"
                        Return 0.45
                    Case "Japanese Yen"
                        Return 77.1
                    Case "Euro"
                        Return 0.65
                End Select
            Case "Indian Rupee"
                Select Case toCurrency
                    Case "Philippine Peso"
                        Return 0.68
                    Case "US Dollar"
                        Return 0.014
                    Case "Hongkong Dollar"
                        Return 0.12
                    Case "Canadian Dollar"
                        Return 0.019
                    Case "Sri Lankan Rupee"
                        Return 2.3
                    Case "UAE Dinar"
                        Return 0.048
                    Case "UK Pound"
                        Return 0.011
                    Case "Japanese Yen"
                        Return 1.48
                    Case "Euro"
                        Return 0.013
                End Select
            Case "Sri Lankan Rupee"
                Select Case toCurrency
                    Case "Philippine Peso"
                        Return 4
                    Case "US Dollar"
                        Return 0.022
                    Case "Hongkong Dollar"
                        Return 0.17
                    Case "Canadian Dollar"
                        Return 0.028
                    Case "Indian Rupee"
                        Return 0.43
                    Case "UAE Dinar"
                        Return 0.045
                    Case "UK Pound"
                        Return 0.01
                    Case "Japanese Yen"
                        Return 1.37
                    Case "Euro"
                        Return 0.012
                End Select
            Case "UAE Dinar"
                Select Case toCurrency
                    Case "Philippine Peso"
                        Return 10
                    Case "US Dollar"
                        Return 3.67
                    Case "Hongkong Dollar"
                        Return 27.25
                    Case "Canadian Dollar"
                        Return 2.75
                    Case "Indian Dollar"
                        Return 20.16
                    Case "Sri Lankan Rupee"
                        Return 22.22
                    Case "UK Pound"
                        Return 0.49
                    Case "Japanese Yen"
                        Return 14.04
                    Case "Euro"
                        Return 0.42
                End Select
            Case "UK Pound"
                Select Case toCurrency
                    Case "Philippine Peso"
                        Return 55
                    Case "US Dollar"
                        Return 1.38
                    Case "Hongkong Dollar"
                        Return 10.34
                    Case "Canadian Dollar"
                        Return 1.72
                    Case "Indian Rupee"
                        Return 97.81
                    Case "Sri Lankan Rupee"
                        Return 214.53
                    Case "UAE Dinar"
                        Return 2.02
                    Case "Japanese Yen"
                        Return 151.37
                    Case "Euro"
                        Return 1.17
                End Select
            Case "Japanese Yen"
                Select Case toCurrency
                    Case "Philippine Peso"
                        Return 2.5
                    Case "US Dollar"
                        Return 0.0091
                    Case "Hongkong Dollar"
                        Return 0.072
                    Case "Canadian Dollar"
                        Return 0.012
                    Case "Indian Rupee"
                        Return 0.64
                    Case "Sri Lankan Rupee"
                        Return 1.39
                    Case "UAE Dinar"
                        Return 0.013
                    Case "UK Pound"
                        Return 0.0066
                    Case "Euro"
                        Return 0.0085
                End Select
            Case "Euro"
                Select Case toCurrency
                    Case "Philippine Peso"
                        Return 45
                    Case "US Dollar"
                        Return 1.18
                    Case "Hongkong Dollar"
                        Return 9.36
                    Case "Canadian Dollar"
                        Return 1.56
                    Case "Indian Rupee"
                        Return 83.79
                    Case "Sri Lankan Rupee"
                        Return 182.18
                    Case "UAE Dinar"
                        Return 1.97
                    Case "UK Pound"
                        Return 0.89
                    Case "Japanese Yen"
                        Return 117.65
                End Select
            Case "Philippine Peso"
                Select Case toCurrency
                    Case "US Dollar"
                        Return 0.02
                    Case "Hongkong Dollar"
                        Return 0.16
                    Case "Canadian Dollar"
                        Return 0.025
                    Case "Indian Rupee"
                        Return 1.47
                    Case "Sri Lankan Rupee"
                        Return 4.0
                    Case "UAE Dinar"
                        Return 0.1
                    Case "UK Pound"
                        Return 0.018
                    Case "Japanese Yen"
                        Return 2.5
                    Case "Euro"
                        Return 0.022
                End Select
        End Select
        Return -1
    End Function
End Class

