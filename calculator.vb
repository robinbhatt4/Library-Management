Public Class calculator

    Dim num As String
    Dim sign As String
    Private Sub btn_10_Click(sender As Object, e As EventArgs) Handles btn_10.Click
        If (txt_input.Text = 0) Then
            txt_input.Text = 0
            num = txt_input.Text
        ElseIf (sign <> "+" And sign <> "-" And sign <> "Mod" And sign <> "/" And sign <> "*") Then
            txt_input.Text = txt_input.Text + btn_10.Text
            num = txt_input.Text
        ElseIf ((sign = "+" Or sign = "-" Or sign = "Mod" Or sign = "/" Or sign = "*") And (txt_input.Text = num)) Then
            txt_input.Text = 0
        Else
            txt_input.Text = txt_input.Text + btn_10.Text
        End If
    End Sub
    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles Btn_1.Click
        If (txt_input.Text = 0) Then
            txt_input.Text = 1
            num = txt_input.Text
        ElseIf (sign <> "+" And sign <> "-" And sign <> "Mod" And sign <> "/" And sign <> "*") Then
            txt_input.Text = txt_input.Text + Btn_1.Text
            num = txt_input.Text
        ElseIf ((sign = "+" Or sign = "-" Or sign = "Mod" Or sign = "/" Or sign = "*") And (txt_input.Text = num)) Then
            txt_input.Text = 1
        Else
            txt_input.Text = txt_input.Text + Btn_1.Text
        End If
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        If (txt_input.Text = 0) Then
            txt_input.Text = 2
            num = txt_input.Text
        ElseIf (sign <> "+" And sign <> "-" And sign <> "Mod" And sign <> "/" And sign <> "*") Then
            txt_input.Text = txt_input.Text + Btn_2.Text
            num = txt_input.Text
        ElseIf ((sign = "+" Or sign = "-" Or sign = "Mod" Or sign = "/" Or sign = "*") And (txt_input.Text = num)) Then
            txt_input.Text = 2
        Else
            txt_input.Text = txt_input.Text + Btn_2.Text
        End If
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        If (txt_input.Text = 0) Then
            txt_input.Text = 3
            num = txt_input.Text
        ElseIf (sign <> "+" And sign <> "-" And sign <> "Mod" And sign <> "/" And sign <> "*") Then
            txt_input.Text = txt_input.Text + btn_3.Text
            num = txt_input.Text
        ElseIf ((sign = "+" Or sign = "-" Or sign = "Mod" Or sign = "/" Or sign = "*") And (txt_input.Text = num)) Then
            txt_input.Text = 3
        Else
            txt_input.Text = txt_input.Text + btn_3.Text
        End If
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        If (txt_input.Text = 0) Then
            txt_input.Text = 4
            num = txt_input.Text
        ElseIf (sign <> "+" And sign <> "-" And sign <> "Mod" And sign <> "/" And sign <> "*") Then
            txt_input.Text = txt_input.Text + btn_4.Text
            num = txt_input.Text
        ElseIf ((sign = "+" Or sign = "-" Or sign = "Mod" Or sign = "/" Or sign = "*") And (txt_input.Text = num)) Then
            txt_input.Text = 4
        Else
            txt_input.Text = txt_input.Text + btn_4.Text
        End If
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        If (txt_input.Text = 0) Then
            txt_input.Text = 5
            num = txt_input.Text
        ElseIf (sign <> "+" And sign <> "-" And sign <> "Mod" And sign <> "/" And sign <> "*") Then
            txt_input.Text = txt_input.Text + btn_5.Text
            num = txt_input.Text
        ElseIf ((sign = "+" Or sign = "-" Or sign = "Mod" Or sign = "/" Or sign = "*") And (txt_input.Text = num)) Then
            txt_input.Text = 5
        Else
            txt_input.Text = txt_input.Text + btn_5.Text
        End If
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        If (txt_input.Text = 0) Then
            txt_input.Text = 6
            num = txt_input.Text
        ElseIf (sign <> "+" And sign <> "-" And sign <> "Mod" And sign <> "/" And sign <> "*") Then
            txt_input.Text = txt_input.Text + btn_6.Text
            num = txt_input.Text
        ElseIf ((sign = "+" Or sign = "-" Or sign = "Mod" Or sign = "/" Or sign = "*") And (txt_input.Text = num)) Then
            txt_input.Text = 6
        Else
            txt_input.Text = txt_input.Text + btn_6.Text
        End If
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        If (txt_input.Text = 0) Then
            txt_input.Text = 7
            num = txt_input.Text
        ElseIf (sign <> "+" And sign <> "-" And sign <> "Mod" And sign <> "/" And sign <> "*") Then
            txt_input.Text = txt_input.Text + btn_7.Text
            num = txt_input.Text
        ElseIf ((sign = "+" Or sign = "-" Or sign = "Mod" Or sign = "/" Or sign = "*") And (txt_input.Text = num)) Then
            txt_input.Text = 7
        Else
            txt_input.Text = txt_input.Text + btn_7.Text
        End If
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        If (txt_input.Text = 0) Then
            txt_input.Text = 8
            num = txt_input.Text
        ElseIf (sign <> "+" And sign <> "-" And sign <> "Mod" And sign <> "/" And sign <> "*") Then
            txt_input.Text = txt_input.Text + btn_8.Text
            num = txt_input.Text
        ElseIf ((sign = "+" Or sign = "-" Or sign = "Mod" Or sign = "/" Or sign = "*") And (txt_input.Text = num)) Then
            txt_input.Text = 8
        Else
            txt_input.Text = txt_input.Text + btn_8.Text
        End If
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click

        If (txt_input.Text = 0) Then
            txt_input.Text = 9
            num = txt_input.Text
        ElseIf (sign <> "+" And sign <> "-" And sign <> "Mod" And sign <> "/" And sign <> "*") Then
            txt_input.Text = txt_input.Text + btn_9.Text
            num = txt_input.Text
        ElseIf ((sign = "+" Or sign = "-" Or sign = "Mod" Or sign = "/" Or sign = "*") And (txt_input.Text = num)) Then
            txt_input.Text = 9
        Else
            txt_input.Text = txt_input.Text + btn_9.Text
        End If
    End Sub

    Private Sub btn_plus_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        sign = btn_plus.Text
    End Sub

    Private Sub btn_minus_Click(sender As Object, e As EventArgs) Handles btn_minus.Click
        sign = btn_minus.Text
    End Sub

    Private Sub btn_mult_Click(sender As Object, e As EventArgs) Handles btn_mult.Click
        sign = btn_mult.Text
    End Sub

    Private Sub btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        sign = btn_div.Text
    End Sub

    Private Sub btn_mod_Click(sender As Object, e As EventArgs) Handles btn_mod.Click
        sign = btn_mod.Text
    End Sub

    Private Sub btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        If (sign = "+") Then
            txt_input.Text = " " & num & " + " & txt_input.Text & " = " & CInt(num) + CInt(txt_input.Text)
        ElseIf (sign = "-") Then
            txt_input.Text = CInt(num) - CInt(txt_input.Text)
        ElseIf (sign = "*") Then
            txt_input.Text = CInt(num) * CInt(txt_input.Text)
        ElseIf (sign = "/") Then
            txt_input.Text = CInt(num) / CInt(txt_input.Text)
        ElseIf (sign = "Mod") Then
            txt_input.Text = CInt(num) Mod CInt(txt_input.Text)
        End If
    End Sub

    

    Private Sub Btn_clear_Click_1(sender As Object, e As EventArgs) Handles Btn_clear.Click
        txt_input.Text = 0
        sign = " "
    End Sub
End Class
