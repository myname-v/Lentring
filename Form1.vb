Public Class Form1

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
		Me.Text = "Lentring - 문자열 계산기 (" & TextBox1.TextLength & "글자)"
	End Sub

	Private Sub TextBox1_DoubleClick(sender As Object, e As EventArgs) Handles TextBox1.DoubleClick
		TextBox1.Text = ""
	End Sub
End Class
