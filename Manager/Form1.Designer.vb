<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSouvenir = New System.Windows.Forms.Button()
        Me.btnInterior = New System.Windows.Forms.Button()
        Me.btnBumaga = New System.Windows.Forms.Button()
        Me.btnPseudo = New System.Windows.Forms.Button()
        Me.btnPlastic = New System.Windows.Forms.Button()
        Me.btnVizitki = New System.Windows.Forms.Button()
        Me.btnPPK = New System.Windows.Forms.Button()
        Me.btnPK = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGetProp = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbDep = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSouvenir
        '
        Me.btnSouvenir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSouvenir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnSouvenir.ForeColor = System.Drawing.Color.White
        Me.btnSouvenir.Location = New System.Drawing.Point(13, 325)
        Me.btnSouvenir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSouvenir.Name = "btnSouvenir"
        Me.btnSouvenir.Size = New System.Drawing.Size(313, 41)
        Me.btnSouvenir.TabIndex = 23
        Me.btnSouvenir.Text = "СУВЕНИРКА"
        Me.btnSouvenir.UseMnemonic = False
        Me.btnSouvenir.UseVisualStyleBackColor = True
        '
        'btnInterior
        '
        Me.btnInterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnInterior.ForeColor = System.Drawing.Color.White
        Me.btnInterior.Location = New System.Drawing.Point(13, 282)
        Me.btnInterior.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInterior.Name = "btnInterior"
        Me.btnInterior.Size = New System.Drawing.Size(313, 36)
        Me.btnInterior.TabIndex = 22
        Me.btnInterior.Text = "ШИРОКОФОРМАТКА"
        Me.btnInterior.UseMnemonic = False
        Me.btnInterior.UseVisualStyleBackColor = True
        '
        'btnBumaga
        '
        Me.btnBumaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBumaga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnBumaga.ForeColor = System.Drawing.Color.White
        Me.btnBumaga.Location = New System.Drawing.Point(13, 238)
        Me.btnBumaga.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBumaga.Name = "btnBumaga"
        Me.btnBumaga.Size = New System.Drawing.Size(313, 36)
        Me.btnBumaga.TabIndex = 21
        Me.btnBumaga.Text = "БУМАГА"
        Me.btnBumaga.UseMnemonic = False
        Me.btnBumaga.UseVisualStyleBackColor = True
        '
        'btnPseudo
        '
        Me.btnPseudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPseudo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPseudo.ForeColor = System.Drawing.Color.White
        Me.btnPseudo.Location = New System.Drawing.Point(14, 192)
        Me.btnPseudo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPseudo.Name = "btnPseudo"
        Me.btnPseudo.Size = New System.Drawing.Size(312, 39)
        Me.btnPseudo.TabIndex = 20
        Me.btnPseudo.Text = "ПСЕВДОПЛАСТИК"
        Me.btnPseudo.UseMnemonic = False
        Me.btnPseudo.UseVisualStyleBackColor = True
        '
        'btnPlastic
        '
        Me.btnPlastic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlastic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPlastic.ForeColor = System.Drawing.Color.White
        Me.btnPlastic.Location = New System.Drawing.Point(13, 148)
        Me.btnPlastic.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPlastic.Name = "btnPlastic"
        Me.btnPlastic.Size = New System.Drawing.Size(313, 36)
        Me.btnPlastic.TabIndex = 19
        Me.btnPlastic.Text = "ПЛАСТИК"
        Me.btnPlastic.UseMnemonic = False
        Me.btnPlastic.UseVisualStyleBackColor = True
        '
        'btnVizitki
        '
        Me.btnVizitki.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVizitki.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnVizitki.ForeColor = System.Drawing.Color.White
        Me.btnVizitki.Location = New System.Drawing.Point(14, 58)
        Me.btnVizitki.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVizitki.Name = "btnVizitki"
        Me.btnVizitki.Size = New System.Drawing.Size(312, 37)
        Me.btnVizitki.TabIndex = 18
        Me.btnVizitki.Text = "ВИЗИТКИ"
        Me.btnVizitki.UseVisualStyleBackColor = True
        '
        'btnPPK
        '
        Me.btnPPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPPK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPPK.ForeColor = System.Drawing.Color.White
        Me.btnPPK.Location = New System.Drawing.Point(14, 102)
        Me.btnPPK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPPK.Name = "btnPPK"
        Me.btnPPK.Size = New System.Drawing.Size(312, 38)
        Me.btnPPK.TabIndex = 17
        Me.btnPPK.Text = "ППК"
        Me.btnPPK.UseVisualStyleBackColor = True
        '
        'btnPK
        '
        Me.btnPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPK.ForeColor = System.Drawing.Color.White
        Me.btnPK.Location = New System.Drawing.Point(13, 10)
        Me.btnPK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPK.Name = "btnPK"
        Me.btnPK.Size = New System.Drawing.Size(313, 41)
        Me.btnPK.TabIndex = 16
        Me.btnPK.Text = "ПК"
        Me.btnPK.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnGetProp)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbDep)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnPlastic)
        Me.Panel1.Controls.Add(Me.btnPK)
        Me.Panel1.Controls.Add(Me.btnPPK)
        Me.Panel1.Controls.Add(Me.btnSouvenir)
        Me.Panel1.Controls.Add(Me.btnVizitki)
        Me.Panel1.Controls.Add(Me.btnPseudo)
        Me.Panel1.Controls.Add(Me.btnInterior)
        Me.Panel1.Controls.Add(Me.btnBumaga)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(694, 381)
        Me.Panel1.TabIndex = 25
        '
        'btnGetProp
        '
        Me.btnGetProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetProp.Location = New System.Drawing.Point(541, 177)
        Me.btnGetProp.Name = "btnGetProp"
        Me.btnGetProp.Size = New System.Drawing.Size(88, 27)
        Me.btnGetProp.TabIndex = 31
        Me.btnGetProp.Text = "ОК"
        Me.btnGetProp.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(392, 291)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(237, 22)
        Me.ProgressBar1.TabIndex = 30
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(392, 177)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(122, 27)
        Me.TextBox1.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(447, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "номер сделки"
        '
        'cmbDep
        '
        Me.cmbDep.FormattingEnabled = True
        Me.cmbDep.Items.AddRange(New Object() {"Кард Экспресс", "КЭ Братск", "КЭ Брянск", "КЭ Москва", "КЭ Нижний Новгород", "КЭ Самара"})
        Me.cmbDep.Location = New System.Drawing.Point(392, 92)
        Me.cmbDep.Name = "cmbDep"
        Me.cmbDep.Size = New System.Drawing.Size(237, 24)
        Me.cmbDep.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(441, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "подразделение"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(360, 402)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Менеджер"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSouvenir As System.Windows.Forms.Button
    Friend WithEvents btnInterior As System.Windows.Forms.Button
    Friend WithEvents btnBumaga As System.Windows.Forms.Button
    Friend WithEvents btnPseudo As System.Windows.Forms.Button
    Friend WithEvents btnPlastic As System.Windows.Forms.Button
    Friend WithEvents btnVizitki As System.Windows.Forms.Button
    Friend WithEvents btnPPK As System.Windows.Forms.Button
    Friend WithEvents btnPK As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnGetProp As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbDep As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
