<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_Gerar = New System.Windows.Forms.Button()
        Me.B_Progress = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TXT_INFOCC = New System.Windows.Forms.TextBox()
        Me.CM = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SalvarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CK_CVV = New System.Windows.Forms.CheckBox()
        Me.ND_Quantidades = New System.Windows.Forms.NumericUpDown()
        Me.ND_BIN = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CM.SuspendLayout()
        CType(Me.ND_Quantidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ND_BIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Gerar
        '
        Me.btn_Gerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Gerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Gerar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Gerar.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btn_Gerar.Location = New System.Drawing.Point(454, 318)
        Me.btn_Gerar.Name = "btn_Gerar"
        Me.btn_Gerar.Size = New System.Drawing.Size(105, 30)
        Me.btn_Gerar.TabIndex = 0
        Me.btn_Gerar.Text = "Gerar"
        Me.btn_Gerar.UseVisualStyleBackColor = True
        '
        'B_Progress
        '
        Me.B_Progress.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.B_Progress.Location = New System.Drawing.Point(0, 358)
        Me.B_Progress.Name = "B_Progress"
        Me.B_Progress.Size = New System.Drawing.Size(569, 20)
        Me.B_Progress.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(398, 318)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'TXT_INFOCC
        '
        Me.TXT_INFOCC.BackColor = System.Drawing.Color.Black
        Me.TXT_INFOCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_INFOCC.ContextMenuStrip = Me.CM
        Me.TXT_INFOCC.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_INFOCC.ForeColor = System.Drawing.Color.MediumPurple
        Me.TXT_INFOCC.Location = New System.Drawing.Point(12, 12)
        Me.TXT_INFOCC.Multiline = True
        Me.TXT_INFOCC.Name = "TXT_INFOCC"
        Me.TXT_INFOCC.ReadOnly = True
        Me.TXT_INFOCC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_INFOCC.Size = New System.Drawing.Size(547, 291)
        Me.TXT_INFOCC.TabIndex = 11
        '
        'CM
        '
        Me.CM.BackColor = System.Drawing.Color.Black
        Me.CM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalvarToolStripMenuItem})
        Me.CM.Name = "CM"
        Me.CM.ShowImageMargin = False
        Me.CM.Size = New System.Drawing.Size(86, 26)
        '
        'SalvarToolStripMenuItem
        '
        Me.SalvarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalvarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem"
        Me.SalvarToolStripMenuItem.Size = New System.Drawing.Size(85, 22)
        Me.SalvarToolStripMenuItem.Text = "Salvar"
        '
        'CK_CVV
        '
        Me.CK_CVV.AutoSize = True
        Me.CK_CVV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CK_CVV.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CK_CVV.ForeColor = System.Drawing.Color.DodgerBlue
        Me.CK_CVV.Location = New System.Drawing.Point(247, 305)
        Me.CK_CVV.Name = "CK_CVV"
        Me.CK_CVV.Size = New System.Drawing.Size(49, 19)
        Me.CK_CVV.TabIndex = 12
        Me.CK_CVV.Text = "CVV"
        Me.CK_CVV.UseVisualStyleBackColor = True
        '
        'ND_Quantidades
        '
        Me.ND_Quantidades.BackColor = System.Drawing.Color.Black
        Me.ND_Quantidades.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ND_Quantidades.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ND_Quantidades.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ND_Quantidades.Location = New System.Drawing.Point(298, 324)
        Me.ND_Quantidades.Maximum = New Decimal(New Integer() {1874919423, 2328306, 0, 0})
        Me.ND_Quantidades.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ND_Quantidades.Name = "ND_Quantidades"
        Me.ND_Quantidades.Size = New System.Drawing.Size(94, 23)
        Me.ND_Quantidades.TabIndex = 13
        Me.ND_Quantidades.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'ND_BIN
        '
        Me.ND_BIN.BackColor = System.Drawing.Color.Black
        Me.ND_BIN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ND_BIN.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ND_BIN.Location = New System.Drawing.Point(12, 324)
        Me.ND_BIN.Maximum = New Decimal(New Integer() {1874919423, 2328306, 0, 0})
        Me.ND_BIN.Name = "ND_BIN"
        Me.ND_BIN.Size = New System.Drawing.Size(280, 23)
        Me.ND_BIN.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(8, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Bin:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(295, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Count:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(569, 378)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ND_BIN)
        Me.Controls.Add(Me.ND_Quantidades)
        Me.Controls.Add(Me.TXT_INFOCC)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.B_Progress)
        Me.Controls.Add(Me.btn_Gerar)
        Me.Controls.Add(Me.CK_CVV)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GERADOR BIN V0.1 [SOOFTT.BLOGSPOT.COM]"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CM.ResumeLayout(False)
        CType(Me.ND_Quantidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ND_BIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Gerar As System.Windows.Forms.Button
    Friend WithEvents B_Progress As System.Windows.Forms.ProgressBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TXT_INFOCC As System.Windows.Forms.TextBox
    Friend WithEvents CK_CVV As System.Windows.Forms.CheckBox
    Friend WithEvents ND_Quantidades As System.Windows.Forms.NumericUpDown
    Friend WithEvents ND_BIN As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CM As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SalvarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
