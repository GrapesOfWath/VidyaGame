<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BattleScreen1 = New VidyaGame.BattleScreen()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BattleScreen1
        '
        Me.BattleScreen1.BackgroundImage = CType(resources.GetObject("BattleScreen1.BackgroundImage"), System.Drawing.Image)
        Me.BattleScreen1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BattleScreen1.Location = New System.Drawing.Point(0, 0)
        Me.BattleScreen1.Name = "BattleScreen1"
        Me.BattleScreen1.Size = New System.Drawing.Size(727, 480)
        Me.BattleScreen1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 480)
        Me.Controls.Add(Me.BattleScreen1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Battlegrounds"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BattleScreen1 As VidyaGame.BattleScreen
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
