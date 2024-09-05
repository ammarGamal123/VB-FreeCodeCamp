<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(267, 341)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(200, 117)
        Me.btnCheck.TabIndex = 1
        Me.btnCheck.Text = "Check Temperature"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lblTemperature
        '
        Me.lblTemperature.AutoSize = True
        Me.lblTemperature.Location = New System.Drawing.Point(92, 274)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(143, 20)
        Me.lblTemperature.TabIndex = 2
        Me.lblTemperature.Text = "Enter Temperature"
        '
        'txtTemperature
        '
        Me.txtTemperature.Location = New System.Drawing.Point(267, 268)
        Me.txtTemperature.MaxLength = 4
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(200, 26)
        Me.txtTemperature.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 682)
        Me.Controls.Add(Me.txtTemperature)
        Me.Controls.Add(Me.lblTemperature)
        Me.Controls.Add(Me.btnCheck)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnCheck As Button
    Friend WithEvents lblTemperature As Label
    Friend WithEvents txtTemperature As TextBox
End Class
