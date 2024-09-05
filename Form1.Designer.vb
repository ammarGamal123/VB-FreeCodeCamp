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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.btnGreeting = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(87, 229)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(213, 20)
        Me.lblCountry.TabIndex = 14
        Me.lblCountry.Text = "What country your are from ?"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(322, 229)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(134, 26)
        Me.txtCountry.TabIndex = 15
        '
        'btnGreeting
        '
        Me.btnGreeting.Location = New System.Drawing.Point(322, 275)
        Me.btnGreeting.Name = "btnGreeting"
        Me.btnGreeting.Size = New System.Drawing.Size(134, 47)
        Me.btnGreeting.TabIndex = 16
        Me.btnGreeting.Text = "Greeting!"
        Me.btnGreeting.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 682)
        Me.Controls.Add(Me.btnGreeting)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.lblCountry)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lblCountry As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents btnGreeting As Button
End Class
