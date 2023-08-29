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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblMouse = New System.Windows.Forms.Label()
        Me.LblKeybaord = New System.Windows.Forms.Label()
        Me.LblController = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'LblMouse
        '
        Me.LblMouse.AutoSize = True
        Me.LblMouse.Location = New System.Drawing.Point(12, 9)
        Me.LblMouse.Name = "LblMouse"
        Me.LblMouse.Size = New System.Drawing.Size(49, 15)
        Me.LblMouse.TabIndex = 1
        Me.LblMouse.Text = "Mouse: "
        '
        'LblKeybaord
        '
        Me.LblKeybaord.AutoSize = True
        Me.LblKeybaord.Location = New System.Drawing.Point(12, 24)
        Me.LblKeybaord.Name = "LblKeybaord"
        Me.LblKeybaord.Size = New System.Drawing.Size(60, 15)
        Me.LblKeybaord.TabIndex = 2
        Me.LblKeybaord.Text = "Keyboard:"
        '
        'LblController
        '
        Me.LblController.AutoSize = True
        Me.LblController.Location = New System.Drawing.Point(12, 39)
        Me.LblController.Name = "LblController"
        Me.LblController.Size = New System.Drawing.Size(66, 15)
        Me.LblController.TabIndex = 3
        Me.LblController.Text = "Controller: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblController)
        Me.Controls.Add(Me.LblKeybaord)
        Me.Controls.Add(Me.LblMouse)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblMouse As Label
    Friend WithEvents LblKeybaord As Label
    Friend WithEvents LblController As Label
End Class
