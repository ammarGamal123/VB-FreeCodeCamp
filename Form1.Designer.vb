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
        Me.lblExamScore = New System.Windows.Forms.Label()
        Me.txtExamScore = New System.Windows.Forms.TextBox()
        Me.btnGrade = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lblExamScore
        '
        Me.lblExamScore.AutoSize = True
        Me.lblExamScore.Location = New System.Drawing.Point(87, 229)
        Me.lblExamScore.Name = "lblExamScore"
        Me.lblExamScore.Size = New System.Drawing.Size(213, 20)
        Me.lblExamScore.TabIndex = 14
        Me.lblExamScore.Text = "What country your are from ?"
        '
        'txtExamScore
        '
        Me.txtExamScore.Location = New System.Drawing.Point(322, 229)
        Me.txtExamScore.Name = "txtExamScore"
        Me.txtExamScore.Size = New System.Drawing.Size(134, 26)
        Me.txtExamScore.TabIndex = 15
        '
        'btnGrade
        '
        Me.btnGrade.Location = New System.Drawing.Point(322, 288)
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.Size = New System.Drawing.Size(134, 40)
        Me.btnGrade.TabIndex = 16
        Me.btnGrade.Text = "Get Grade"
        Me.btnGrade.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 682)
        Me.Controls.Add(Me.btnGrade)
        Me.Controls.Add(Me.txtExamScore)
        Me.Controls.Add(Me.lblExamScore)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lblExamScore As Label
    Friend WithEvents txtExamScore As TextBox
    Friend WithEvents btnGrade As Button
End Class
