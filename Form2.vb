Imports VidyaGame.Player

Public Class Form2

    Dim p As Player

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BattleScreen1.p = Form1.p
        p = BattleScreen1.p
        BattleScreen1.enemies(0) = New Enemy
        BattleScreen1.enemies(1) = New Enemy
        BattleScreen1.ComboBox1.DataSource = BattleScreen1.enemies
        labels()
        updatebars()
        Timer1.Start()
        BattleScreen1.ComboBox1.DisplayMember = "Name"
        BattleScreen1.ComboBox1.ValueMember = "id"
    End Sub

    Public Sub labels()
        BattleScreen1.Label1.Text = p.name & " - " & [Enum].GetName(GetType(Profession), p.prof)
        BattleScreen1.Label2.Text = "HP: " & p.HP & "/" & p.maxHP & " Mana: " & p.mana & "/" & p.maxmana
    End Sub

    Public Sub updatebars()
        Try
            BattleScreen1.ProgressBar1.Maximum = p.maxHP
            BattleScreen1.ProgressBar1.Value = p.HP
        Catch ex As Exception
            If p.HP < 0 Then
                p.HP = 0
                BattleScreen1.ProgressBar1.Maximum = p.maxHP
                BattleScreen1.ProgressBar1.Value = p.HP
                MsgBox("You died.")
            ElseIf p.HP > p.maxHP Then
                p.HP = p.maxHP
                BattleScreen1.ProgressBar1.Maximum = p.maxHP
                BattleScreen1.ProgressBar1.Value = p.HP
            End If
        End Try
        Try
            BattleScreen1.ProgressBar2.Maximum = BattleScreen1.enemies(0).baseHP
            BattleScreen1.ProgressBar2.Value = BattleScreen1.enemies(0).curHP
        Catch ex As Exception
            If BattleScreen1.enemies(0).curHP > BattleScreen1.enemies(0).baseHP Then
                BattleScreen1.enemies(0).curHP = BattleScreen1.enemies(0).baseHP
                BattleScreen1.ProgressBar2.Maximum = BattleScreen1.enemies(0).baseHP
                BattleScreen1.ProgressBar2.Value = BattleScreen1.enemies(0).curHP
            ElseIf BattleScreen1.enemies(0).curHP < 0 Then
                BattleScreen1.enemies(0).curHP = 0
                BattleScreen1.ProgressBar2.Maximum = BattleScreen1.enemies(0).baseHP
                BattleScreen1.ProgressBar2.Value = BattleScreen1.enemies(0).curHP
            End If
        End Try
        Try
            BattleScreen1.ProgressBar3.Maximum = BattleScreen1.enemies(1).baseHP
            BattleScreen1.ProgressBar3.Value = BattleScreen1.enemies(1).curHP
        Catch ex As Exception
            If BattleScreen1.enemies(1).curHP > BattleScreen1.enemies(1).baseHP Then
                BattleScreen1.enemies(1).curHP = BattleScreen1.enemies(1).baseHP
                BattleScreen1.ProgressBar3.Maximum = BattleScreen1.enemies(1).baseHP
                BattleScreen1.ProgressBar3.Value = BattleScreen1.enemies(1).curHP
            ElseIf BattleScreen1.enemies(1).curHP < 0 Then
                BattleScreen1.enemies(1).curHP = 0
                BattleScreen1.ProgressBar3.Maximum = BattleScreen1.enemies(1).baseHP
                BattleScreen1.ProgressBar3.Value = BattleScreen1.enemies(1).curHP
            End If
        End Try
        If BattleScreen1.ProgressBar2.Value = 0 Then
            BattleScreen1.PictureBox1.Image = My.Resources.bananadead
            BattleScreen1.enemies(0).die()
        End If
        If BattleScreen1.ProgressBar3.Value = 0 Then
            BattleScreen1.PictureBox3.Image = My.Resources.bananadead
            BattleScreen1.enemies(1).die()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BattleScreen1.ComboBox1.Visible = False
        BattleScreen1.ComboBox1.Visible = True
        Timer1.Stop()
    End Sub
End Class