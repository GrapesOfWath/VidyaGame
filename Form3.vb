Imports VidyaGame.Player

Public Class Form3

    Public p As Player

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        p = New Player(TextBox1.Text, ComboBox1.SelectedItem)
        p.HP = TextBox14.Text
        p.mana = TextBox15.Text
        p.maxHP = TextBox14.Text
        p.maxmana = TextBox15.Text
        p.prof = ComboBox2.SelectedItem
        p.attackskill = TextBox10.Text
        p.magicskill = TextBox11.Text
        p.defenseskill = TextBox12.Text
        p.magicdefenseskill = TextBox13.Text
        p.lvl = TextBox16.Text
        Form1.p = p
        MsgBox("Your character has been created.")
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.DataSource = [Enum].GetValues(GetType(Profession))
    End Sub
End Class