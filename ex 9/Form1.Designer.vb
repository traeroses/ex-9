<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBro = New System.Windows.Forms.RadioButton()
        Me.radSis = New System.Windows.Forms.RadioButton()
        Me.radDad = New System.Windows.Forms.RadioButton()
        Me.radMom = New System.Windows.Forms.RadioButton()
        Me.lblTranslation = New System.Windows.Forms.Label()
        Me.cmbLanguages = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(306, 89)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "Translate!"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(306, 118)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radBro)
        Me.GroupBox1.Controls.Add(Me.radSis)
        Me.GroupBox1.Controls.Add(Me.radDad)
        Me.GroupBox1.Controls.Add(Me.radMom)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(107, 130)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "English"
        '
        'radBro
        '
        Me.radBro.AutoSize = True
        Me.radBro.Location = New System.Drawing.Point(3, 85)
        Me.radBro.Name = "radBro"
        Me.radBro.Size = New System.Drawing.Size(59, 17)
        Me.radBro.TabIndex = 3
        Me.radBro.TabStop = True
        Me.radBro.Text = "&Brother"
        Me.radBro.UseVisualStyleBackColor = True
        '
        'radSis
        '
        Me.radSis.AutoSize = True
        Me.radSis.Location = New System.Drawing.Point(3, 62)
        Me.radSis.Name = "radSis"
        Me.radSis.Size = New System.Drawing.Size(51, 17)
        Me.radSis.TabIndex = 2
        Me.radSis.TabStop = True
        Me.radSis.Text = "&Sister"
        Me.radSis.UseVisualStyleBackColor = True
        '
        'radDad
        '
        Me.radDad.AutoSize = True
        Me.radDad.Location = New System.Drawing.Point(3, 39)
        Me.radDad.Name = "radDad"
        Me.radDad.Size = New System.Drawing.Size(55, 17)
        Me.radDad.TabIndex = 1
        Me.radDad.TabStop = True
        Me.radDad.Text = "&Father"
        Me.radDad.UseVisualStyleBackColor = True
        '
        'radMom
        '
        Me.radMom.AutoSize = True
        Me.radMom.Location = New System.Drawing.Point(3, 16)
        Me.radMom.Name = "radMom"
        Me.radMom.Size = New System.Drawing.Size(58, 17)
        Me.radMom.TabIndex = 0
        Me.radMom.TabStop = True
        Me.radMom.Text = "&Mother"
        Me.radMom.UseVisualStyleBackColor = True
        '
        'lblTranslation
        '
        Me.lblTranslation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTranslation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTranslation.Location = New System.Drawing.Point(156, 118)
        Me.lblTranslation.Name = "lblTranslation"
        Me.lblTranslation.Size = New System.Drawing.Size(117, 62)
        Me.lblTranslation.TabIndex = 4
        Me.lblTranslation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbLanguages
        '
        Me.cmbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLanguages.FormattingEnabled = True
        Me.cmbLanguages.Items.AddRange(New Object() {"French", "Italian", "Spanish"})
        Me.cmbLanguages.Location = New System.Drawing.Point(156, 72)
        Me.cmbLanguages.Name = "cmbLanguages"
        Me.cmbLanguages.Size = New System.Drawing.Size(121, 21)
        Me.cmbLanguages.TabIndex = 5
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(412, 263)
        Me.Controls.Add(Me.cmbLanguages)
        Me.Controls.Add(Me.lblTranslation)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.Text = "Translator!"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radBro As RadioButton
    Friend WithEvents radSis As RadioButton
    Friend WithEvents radDad As RadioButton
    Friend WithEvents radMom As RadioButton
    Friend WithEvents lblTranslation As Label
    Friend WithEvents cmbLanguages As ComboBox
End Class
