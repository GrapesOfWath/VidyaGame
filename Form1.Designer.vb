<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TestingMenu1 = New VidyaGame.TestingMenu()
        Me.SuspendLayout()
        '
        'TestingMenu1
        '
        Me.TestingMenu1.BackgroundImage = CType(resources.GetObject("TestingMenu1.BackgroundImage"), System.Drawing.Image)
        Me.TestingMenu1.Location = New System.Drawing.Point(0, -1)
        Me.TestingMenu1.Name = "TestingMenu1"
        Me.TestingMenu1.Size = New System.Drawing.Size(755, 482)
        Me.TestingMenu1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 481)
        Me.Controls.Add(Me.TestingMenu1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Welcome to Pooplandia!"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TestingMenu1 As VidyaGame.TestingMenu

End Class
