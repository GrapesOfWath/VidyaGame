Imports VidyaGame.Player
Imports VidyaGame.Enemy

Public Class BattleScreen
    Public p As Player
    Public enemies(7) As Enemy
    Public targetid As Integer
    Private Sub BattleScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 0 To enemies.Length - 1
            If enemies(i).id = targetid Then
                enemies(i).recdmg((3 * Form1.p.attackskill + Form1.p.lvl) / 2 - 10)
                Exit For
            End If
        Next
        Form2.updatebars()
        My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If p.prof = Profession.Wizard Then
            For i As Integer = 0 To enemies.Length - 1
                If enemies(i).id = targetid Then
                    enemies(i).recdmg(((1.5 * Form1.p.magicskill + Form1.p.lvl) / 1.2 - 8) + (p.magicskill * 0.25))
                    Exit For
                End If
            Next
        Else
            For i As Integer = 0 To enemies.Length - 1
                If enemies(i).id = targetid Then
                    enemies(i).recdmg((1.5 * Form1.p.magicskill + Form1.p.lvl) / 1.2 - 8)
                    Exit For
                End If
            Next
        End If
                Form2.updatebars()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If p.prof = Profession.Cleric Then
            p.HP += ((1.5 * Form1.p.magicskill + Form1.p.lvl) / 1.2 + (p.magicskill * 0.25))
        Else
            p.HP += ((1.5 * Form1.p.magicskill + Form1.p.lvl) / 1.2)
        End If
        Form2.updatebars()
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        targetid = ComboBox1.SelectedValue.id
    End Sub
End Class
