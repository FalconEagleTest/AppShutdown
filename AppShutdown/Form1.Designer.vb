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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblMouse = New System.Windows.Forms.Label()
        Me.LblKeybaord = New System.Windows.Forms.Label()
        Me.LblController = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblEnterSleep = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
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
        Me.LblMouse.BackColor = System.Drawing.Color.Transparent
        Me.LblMouse.Font = New System.Drawing.Font("Kalam", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblMouse.ForeColor = System.Drawing.SystemColors.Info
        Me.LblMouse.Location = New System.Drawing.Point(12, 9)
        Me.LblMouse.Name = "LblMouse"
        Me.LblMouse.Size = New System.Drawing.Size(64, 25)
        Me.LblMouse.TabIndex = 1
        Me.LblMouse.Text = "Mouse: "
        '
        'LblKeybaord
        '
        Me.LblKeybaord.AutoSize = True
        Me.LblKeybaord.BackColor = System.Drawing.Color.Transparent
        Me.LblKeybaord.Font = New System.Drawing.Font("Kalam", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblKeybaord.ForeColor = System.Drawing.SystemColors.Info
        Me.LblKeybaord.Location = New System.Drawing.Point(12, 34)
        Me.LblKeybaord.Name = "LblKeybaord"
        Me.LblKeybaord.Size = New System.Drawing.Size(76, 25)
        Me.LblKeybaord.TabIndex = 2
        Me.LblKeybaord.Text = "Keyboard:"
        '
        'LblController
        '
        Me.LblController.AutoSize = True
        Me.LblController.BackColor = System.Drawing.Color.Transparent
        Me.LblController.Font = New System.Drawing.Font("Kalam", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblController.ForeColor = System.Drawing.SystemColors.Info
        Me.LblController.Location = New System.Drawing.Point(12, 58)
        Me.LblController.Name = "LblController"
        Me.LblController.Size = New System.Drawing.Size(86, 25)
        Me.LblController.TabIndex = 3
        Me.LblController.Text = "Controller: "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Kalam", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(12, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "sleep_now"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Kalam", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(109, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(34, 33)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "30"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Kalam", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(15, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Sleep After"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Kalam", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Info
        Me.Label2.Location = New System.Drawing.Point(149, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Min"
        '
        'LblEnterSleep
        '
        Me.LblEnterSleep.AutoSize = True
        Me.LblEnterSleep.BackColor = System.Drawing.Color.Transparent
        Me.LblEnterSleep.Font = New System.Drawing.Font("Kalam", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblEnterSleep.ForeColor = System.Drawing.SystemColors.Info
        Me.LblEnterSleep.Location = New System.Drawing.Point(15, 117)
        Me.LblEnterSleep.Name = "LblEnterSleep"
        Me.LblEnterSleep.Size = New System.Drawing.Size(117, 25)
        Me.LblEnterSleep.TabIndex = 8
        Me.LblEnterSleep.Text = "Enter Sleep in: "
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "AppShutDown"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(219, 198)
        Me.Controls.Add(Me.LblEnterSleep)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblController)
        Me.Controls.Add(Me.LblKeybaord)
        Me.Controls.Add(Me.LblMouse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "AppShutdown"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblMouse As Label
    Friend WithEvents LblKeybaord As Label
    Friend WithEvents LblController As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblEnterSleep As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
