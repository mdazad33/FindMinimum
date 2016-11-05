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
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum3 = New System.Windows.Forms.TextBox()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblNum3 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtMinNum = New System.Windows.Forms.TextBox()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(54, 15)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(80, 20)
        Me.txtNum1.TabIndex = 0
        Me.txtNum1.Tag = ""
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(182, 15)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(84, 20)
        Me.txtNum2.TabIndex = 1
        '
        'txtNum3
        '
        Me.txtNum3.Location = New System.Drawing.Point(311, 15)
        Me.txtNum3.Name = "txtNum3"
        Me.txtNum3.Size = New System.Drawing.Size(80, 20)
        Me.txtNum3.TabIndex = 2
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.Location = New System.Drawing.Point(10, 15)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(38, 18)
        Me.lblNum1.TabIndex = 3
        Me.lblNum1.Text = "#1 =>"
        Me.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum2.Location = New System.Drawing.Point(140, 13)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(38, 18)
        Me.lblNum2.TabIndex = 4
        Me.lblNum2.Text = "#2 =>"
        Me.lblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum3
        '
        Me.lblNum3.AutoSize = True
        Me.lblNum3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum3.Location = New System.Drawing.Point(267, 13)
        Me.lblNum3.Name = "lblNum3"
        Me.lblNum3.Size = New System.Drawing.Size(38, 18)
        Me.lblNum3.TabIndex = 5
        Me.lblNum3.Text = "#3 =>"
        Me.lblNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCalculate.Location = New System.Drawing.Point(74, 86)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(192, 56)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Determine Minimum Number"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'txtMinNum
        '
        Me.txtMinNum.BackColor = System.Drawing.Color.DarkGreen
        Me.txtMinNum.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinNum.ForeColor = System.Drawing.SystemColors.Window
        Me.txtMinNum.Location = New System.Drawing.Point(176, 189)
        Me.txtMinNum.Name = "txtMinNum"
        Me.txtMinNum.ReadOnly = True
        Me.txtMinNum.Size = New System.Drawing.Size(191, 39)
        Me.txtMinNum.TabIndex = 7
        Me.txtMinNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblMin.Location = New System.Drawing.Point(10, 203)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(145, 18)
        Me.lblMin.TabIndex = 8
        Me.lblMin.Text = "Minimum Number:"
        Me.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 261)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.txtMinNum)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblNum3)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.txtNum3)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtNum3 As TextBox
    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents lblNum3 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtMinNum As TextBox
    Friend WithEvents lblMin As Label
End Class
