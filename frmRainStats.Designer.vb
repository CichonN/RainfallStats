<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRainStats
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
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalRainfall = New System.Windows.Forms.Label()
        Me.lblAverageRainfall = New System.Windows.Forms.Label()
        Me.lblMinimumRainfall = New System.Windows.Forms.Label()
        Me.lblMaximumRainfall = New System.Windows.Forms.Label()
        Me.btnInputRainfall = New System.Windows.Forms.Button()
        Me.btnDisplayStats = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstResult
        '
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.ItemHeight = 16
        Me.lstResult.Items.AddRange(New Object() {"Monthly Rainfall Input", "---------------------------------"})
        Me.lstResult.Location = New System.Drawing.Point(29, 35)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(257, 276)
        Me.lstResult.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(325, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Monthly Rainfall Statistics:"
        '
        'lblTotalRainfall
        '
        Me.lblTotalRainfall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalRainfall.Location = New System.Drawing.Point(328, 96)
        Me.lblTotalRainfall.Name = "lblTotalRainfall"
        Me.lblTotalRainfall.Size = New System.Drawing.Size(328, 23)
        Me.lblTotalRainfall.TabIndex = 6
        '
        'lblAverageRainfall
        '
        Me.lblAverageRainfall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageRainfall.Location = New System.Drawing.Point(328, 151)
        Me.lblAverageRainfall.Name = "lblAverageRainfall"
        Me.lblAverageRainfall.Size = New System.Drawing.Size(328, 23)
        Me.lblAverageRainfall.TabIndex = 7
        '
        'lblMinimumRainfall
        '
        Me.lblMinimumRainfall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMinimumRainfall.Location = New System.Drawing.Point(328, 202)
        Me.lblMinimumRainfall.Name = "lblMinimumRainfall"
        Me.lblMinimumRainfall.Size = New System.Drawing.Size(328, 23)
        Me.lblMinimumRainfall.TabIndex = 8
        '
        'lblMaximumRainfall
        '
        Me.lblMaximumRainfall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaximumRainfall.Location = New System.Drawing.Point(328, 255)
        Me.lblMaximumRainfall.Name = "lblMaximumRainfall"
        Me.lblMaximumRainfall.Size = New System.Drawing.Size(328, 23)
        Me.lblMaximumRainfall.TabIndex = 9
        '
        'btnInputRainfall
        '
        Me.btnInputRainfall.Location = New System.Drawing.Point(56, 350)
        Me.btnInputRainfall.Name = "btnInputRainfall"
        Me.btnInputRainfall.Size = New System.Drawing.Size(128, 50)
        Me.btnInputRainfall.TabIndex = 10
        Me.btnInputRainfall.Text = "Input Monthly Rainfall"
        Me.btnInputRainfall.UseVisualStyleBackColor = True
        '
        'btnDisplayStats
        '
        Me.btnDisplayStats.Location = New System.Drawing.Point(224, 350)
        Me.btnDisplayStats.Name = "btnDisplayStats"
        Me.btnDisplayStats.Size = New System.Drawing.Size(128, 50)
        Me.btnDisplayStats.TabIndex = 11
        Me.btnDisplayStats.Text = "Display Stats"
        Me.btnDisplayStats.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(392, 350)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(128, 50)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(560, 350)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 50)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayStats)
        Me.Controls.Add(Me.btnInputRainfall)
        Me.Controls.Add(Me.lblMaximumRainfall)
        Me.Controls.Add(Me.lblMinimumRainfall)
        Me.Controls.Add(Me.lblAverageRainfall)
        Me.Controls.Add(Me.lblTotalRainfall)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstResult)
        Me.Name = "Form1"
        Me.Text = "Rainfall Statistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstResult As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalRainfall As Label
    Friend WithEvents lblAverageRainfall As Label
    Friend WithEvents lblMinimumRainfall As Label
    Friend WithEvents lblMaximumRainfall As Label
    Friend WithEvents btnInputRainfall As Button
    Friend WithEvents btnDisplayStats As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
