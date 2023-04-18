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
        Me.picPhone = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmbOptions = New System.Windows.Forms.ComboBox()
        Me.lblMonthSavings = New System.Windows.Forms.Label()
        Me.lblAveSavings = New System.Windows.Forms.Label()
        Me.lblMostSavings = New System.Windows.Forms.Label()
        Me.btnDisplayStats = New System.Windows.Forms.Button()
        CType(Me.picPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPhone
        '
        Me.picPhone.Image = CType(resources.GetObject("picPhone.Image"), System.Drawing.Image)
        Me.picPhone.Location = New System.Drawing.Point(1, 1)
        Me.picPhone.Name = "picPhone"
        Me.picPhone.Size = New System.Drawing.Size(341, 259)
        Me.picPhone.TabIndex = 0
        Me.picPhone.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Franklin Gothic Medium", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(430, 53)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(248, 74)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Smart Home" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Electric Savings" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbOptions
        '
        Me.cmbOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOptions.FormattingEnabled = True
        Me.cmbOptions.Location = New System.Drawing.Point(460, 165)
        Me.cmbOptions.Name = "cmbOptions"
        Me.cmbOptions.Size = New System.Drawing.Size(181, 39)
        Me.cmbOptions.TabIndex = 2
        '
        'lblMonthSavings
        '
        Me.lblMonthSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthSavings.Location = New System.Drawing.Point(108, 280)
        Me.lblMonthSavings.Name = "lblMonthSavings"
        Me.lblMonthSavings.Size = New System.Drawing.Size(570, 23)
        Me.lblMonthSavings.TabIndex = 3
        Me.lblMonthSavings.Text = "Label1"
        Me.lblMonthSavings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMonthSavings.Visible = False
        '
        'lblAveSavings
        '
        Me.lblAveSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAveSavings.Location = New System.Drawing.Point(108, 382)
        Me.lblAveSavings.Name = "lblAveSavings"
        Me.lblAveSavings.Size = New System.Drawing.Size(570, 23)
        Me.lblAveSavings.TabIndex = 4
        Me.lblAveSavings.Text = "Label2"
        Me.lblAveSavings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAveSavings.Visible = False
        '
        'lblMostSavings
        '
        Me.lblMostSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostSavings.Location = New System.Drawing.Point(108, 424)
        Me.lblMostSavings.Name = "lblMostSavings"
        Me.lblMostSavings.Size = New System.Drawing.Size(570, 23)
        Me.lblMostSavings.TabIndex = 5
        Me.lblMostSavings.Text = "Label3"
        Me.lblMostSavings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMostSavings.Visible = False
        '
        'btnDisplayStats
        '
        Me.btnDisplayStats.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnDisplayStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayStats.ForeColor = System.Drawing.Color.White
        Me.btnDisplayStats.Location = New System.Drawing.Point(238, 315)
        Me.btnDisplayStats.Name = "btnDisplayStats"
        Me.btnDisplayStats.Size = New System.Drawing.Size(341, 48)
        Me.btnDisplayStats.TabIndex = 6
        Me.btnDisplayStats.Text = "Display Statistics"
        Me.btnDisplayStats.UseVisualStyleBackColor = False
        Me.btnDisplayStats.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDisplayStats)
        Me.Controls.Add(Me.lblMostSavings)
        Me.Controls.Add(Me.lblAveSavings)
        Me.Controls.Add(Me.lblMonthSavings)
        Me.Controls.Add(Me.cmbOptions)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picPhone)
        Me.Name = "Form1"
        Me.Text = "Smart Home Application"
        CType(Me.picPhone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPhone As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents cmbOptions As ComboBox
    Friend WithEvents lblMonthSavings As Label
    Friend WithEvents lblAveSavings As Label
    Friend WithEvents lblMostSavings As Label
    Friend WithEvents btnDisplayStats As Button
End Class
