<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTesoChkPagoPendte
    Inherits TemplateForm


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
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.groupGeneral = New System.Windows.Forms.GroupBox()
        Me.btnBusq = New System.Windows.Forms.Button()
        Me.lblNomProove = New System.Windows.Forms.Label()
        Me.txtProove = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.groupGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerar
        '
        Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(420, 10)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(95, 21)
        Me.btnGenerar.TabIndex = 25
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(420, 49)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(95, 21)
        Me.btnSalir.TabIndex = 24
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'groupGeneral
        '
        Me.groupGeneral.Controls.Add(Me.btnBusq)
        Me.groupGeneral.Controls.Add(Me.lblNomProove)
        Me.groupGeneral.Controls.Add(Me.txtProove)
        Me.groupGeneral.Controls.Add(Me.Label6)
        Me.groupGeneral.ForeColor = System.Drawing.Color.Gainsboro
        Me.groupGeneral.Location = New System.Drawing.Point(3, 6)
        Me.groupGeneral.Margin = New System.Windows.Forms.Padding(1)
        Me.groupGeneral.Name = "groupGeneral"
        Me.groupGeneral.Padding = New System.Windows.Forms.Padding(1)
        Me.groupGeneral.Size = New System.Drawing.Size(404, 64)
        Me.groupGeneral.TabIndex = 26
        Me.groupGeneral.TabStop = False
        Me.groupGeneral.Text = "Datos Generales"
        '
        'btnBusq
        '
        Me.btnBusq.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBusq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBusq.Location = New System.Drawing.Point(132, 21)
        Me.btnBusq.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBusq.Name = "btnBusq"
        Me.btnBusq.Size = New System.Drawing.Size(21, 21)
        Me.btnBusq.TabIndex = 47
        Me.btnBusq.Text = "..."
        Me.btnBusq.UseVisualStyleBackColor = False
        '
        'lblNomProove
        '
        Me.lblNomProove.AutoSize = True
        Me.lblNomProove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomProove.Location = New System.Drawing.Point(157, 25)
        Me.lblNomProove.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblNomProove.Name = "lblNomProove"
        Me.lblNomProove.Size = New System.Drawing.Size(115, 13)
        Me.lblNomProove.TabIndex = 48
        Me.lblNomProove.Text = "__________________"
        '
        'txtProove
        '
        Me.txtProove.Location = New System.Drawing.Point(68, 24)
        Me.txtProove.Margin = New System.Windows.Forms.Padding(1)
        Me.txtProove.Name = "txtProove"
        Me.txtProove.Size = New System.Drawing.Size(62, 20)
        Me.txtProove.TabIndex = 4
        Me.txtProove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Proveedor:"
        '
        'frmTesoChkPagoPendte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 81)
        Me.Controls.Add(Me.groupGeneral)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "frmTesoChkPagoPendte"
        Me.Text = "frmTesoChkPagoPendte"
        Me.groupGeneral.ResumeLayout(False)
        Me.groupGeneral.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents groupGeneral As GroupBox
    Friend WithEvents btnBusq As Button
    Friend WithEvents lblNomProove As Label
    Friend WithEvents txtProove As TextBox
    Friend WithEvents Label6 As Label
End Class
