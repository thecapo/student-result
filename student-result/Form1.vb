Option Strict On
Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim user As Decimal
        Dim maximum As Decimal = 0
        Dim maxindex As Decimal = 0
        Dim minimum As Decimal = 100
        Dim minindex As Decimal = 0
        Dim average As Decimal
        Dim ave As Decimal

        If Decimal.TryParse(txtbxUserInput.Text, user) Then
            user = CDec(txtbxUserInput.Text)
            lstbxResults.Items.Add(user)
        Else
            MsgBox("Please Enter A Number")
        End If

        'entering data into an array
        If Not lstbxResults.Items.Count = 21 Then 'with IF NOT only 20 items can be entered in the listbox
        ElseIf Not lstbxResults.Items.Count = 20 Then
            lstbxResults.Items.Remove(user)
            MsgBox("Cannot enter more than 20 results")
        End If
        txtbxUserInput.Clear()

        'enter data not less than 0 and not more than 100
        If user < 0 Or user > 100 Then
            MsgBox("Please enter a number between 0 and 100")
            lstbxResults.Items.Remove(user)
        End If

        'get maximum
        For count As Integer = 0 To lstbxResults.Items.Count - 1
            If maximum < CDec(lstbxResults.Items.Item(count)) Then
                maximum = CDec(lstbxResults.Items.Item(count))
                maxindex = count
                lblMaxResult.Text = lstbxResults.Items.Item(CInt(maxindex)).ToString
            End If
        Next

        'get minimum
        For count As Integer = 0 To lstbxResults.Items.Count - 1
            If minimum > CDec(lstbxResults.Items.Item(count)) Then
                minimum = CDec(lstbxResults.Items.Item(count))
                minindex = count
                lblMinResult.Text = lstbxResults.Items.Item(CInt(minindex)).ToString
            End If
        Next

        'get average
        For count As Integer = 0 To lstbxResults.Items.Count - 1
            ave = ave + CDec(lstbxResults.Items.Item(count))
            average = CDec(ave / lstbxResults.Items.Count)
            lblAveResult.Text = FormatNumber(average.ToString, 4)
        Next

        'items entered
        For count As Integer = 0 To lstbxResults.Items.Count - 1
            lblItemsResult.Text = CDec(lstbxResults.Items.Count).ToString
        Next
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        lstbxResults.Items.Clear()
        txtbxUserInput.Clear()
        lblAveResult.Text = "0"
        lblMaxResult.Text = "0"
        lblMinResult.Text = "0"
    End Sub
End Class
