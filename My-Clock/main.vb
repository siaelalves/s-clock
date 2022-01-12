Public Class main

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRlg.Font = New Font(lblRlg.Font.Name, My.Settings.size)
        lblRlg.Text = Today.Date.ToString("d' de 'MMMM' de 'yyyy") & Chr(10)
        lblRlg.Text &= TimeOfDay.ToString("HH:mm:ss")
        tmCnt.Start()
    End Sub

    Private Sub tmCnt_Tick(sender As Object, e As EventArgs) Handles tmCnt.Tick
        lblRlg.Text = Today.Date.ToString("d' de 'MMMM' de 'yyyy") & Chr(10)
        lblRlg.Text &= TimeOfDay.ToString("HH:mm:ss")
        Me.Update()
    End Sub

    Private Sub main_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.OemMinus Or e.KeyCode = Keys.Subtract Then
            My.Settings.size -= 2
            lblRlg.Font = New Font(lblRlg.Font.Name, lblRlg.Font.Size - 2)
        ElseIf e.KeyCode = Keys.Oemplus Or e.KeyCode = Keys.Add Then
            My.Settings.size += 2
            lblRlg.Font = New Font(lblRlg.Font.Name, lblRlg.Font.Size + 2)
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Right Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            Dim MyAlpha As Integer
            Dim MyRed As Integer
            Dim MyGreen As Integer
            Dim MyBlue As Integer
            Randomize()
            MyAlpha = CInt(Int((254 * Rnd()) + 0))
            Randomize()
            MyRed = CInt(Int((254 * Rnd()) + 0))
            Randomize()
            MyGreen = CInt(Int((254 * Rnd()) + 0))
            Randomize()
            MyBlue = CInt(Int((254 * Rnd()) + 0))
            lblRlg.ForeColor = Color.FromArgb(MyAlpha, MyRed, MyGreen, MyBlue)
        End If
    End Sub

    Private Sub lblRlg_Click(sender As Object, e As EventArgs) Handles lblRlg.Click
        Me.Close()
    End Sub
End Class
