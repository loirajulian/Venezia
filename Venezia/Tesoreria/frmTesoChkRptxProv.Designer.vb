<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTesoChkRptxProv
    Inherits TemplateForm

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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProove = New System.Windows.Forms.TextBox()
        Me.lblNomProove = New System.Windows.Forms.Label()
        Me.btnBusq = New System.Windows.Forms.Button()
        Me.groupGeneral = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaOpH = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFechaOpD = New System.Windows.Forms.DateTimePicker()
        Me.groupGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(314, 109)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(95, 21)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(210, 109)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(95, 21)
        Me.btnGenerar.TabIndex = 19
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 51)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Proveedor:"
        '
        'txtProove
        '
        Me.txtProove.Location = New System.Drawing.Point(68, 50)
        Me.txtProove.Margin = New System.Windows.Forms.Padding(1)
        Me.txtProove.Name = "txtProove"
        Me.txtProove.Size = New System.Drawing.Size(62, 20)
        Me.txtProove.TabIndex = 4
        Me.txtProove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNomProove
        '
        Me.lblNomProove.AutoSize = True
        Me.lblNomProove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomProove.Location = New System.Drawing.Point(157, 51)
        Me.lblNomProove.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblNomProove.Name = "lblNomProove"
        Me.lblNomProove.Size = New System.Drawing.Size(115, 13)
        Me.lblNomProove.TabIndex = 48
        Me.lblNomProove.Text = "__________________"
        '
        'btnBusq
        '
        Me.btnBusq.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBusq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBusq.Location = New System.Drawing.Point(132, 47)
        Me.btnBusq.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBusq.Name = "btnBusq"
        Me.btnBusq.Size = New System.Drawing.Size(21, 21)
        Me.btnBusq.TabIndex = 47
        Me.btnBusq.Text = "..."
        Me.btnBusq.UseVisualStyleBackColor = False
        '
        'groupGeneral
        '
        Me.groupGeneral.Controls.Add(Me.Label1)
        Me.groupGeneral.Controls.Add(Me.dtpFechaOpH)
        Me.groupGeneral.Controls.Add(Me.btnBusq)
        Me.groupGeneral.Controls.Add(Me.lblNomProove)
        Me.groupGeneral.Controls.Add(Me.txtProove)
        Me.groupGeneral.Controls.Add(Me.Label6)
        Me.groupGeneral.Controls.Add(Me.Label5)
        Me.groupGeneral.Controls.Add(Me.dtpFechaOpD)
        Me.groupGeneral.ForeColor = System.Drawing.Color.Gainsboro
        Me.groupGeneral.Location = New System.Drawing.Point(4, 9)
        Me.groupGeneral.Margin = New System.Windows.Forms.Padding(1)
        Me.groupGeneral.Name = "groupGeneral"
        Me.groupGeneral.Padding = New System.Windows.Forms.Padding(1)
        Me.groupGeneral.Size = New System.Drawing.Size(404, 89)
        Me.groupGeneral.TabIndex = 22
        Me.groupGeneral.TabStop = False
        Me.groupGeneral.Text = "Datos Generales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Hasta "
        '
        'dtpFechaOpH
        '
        Me.dtpFechaOpH.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaOpH.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaOpH.Location = New System.Drawing.Point(268, 19)
        Me.dtpFechaOpH.Margin = New System.Windows.Forms.Padding(1)
        Me.dtpFechaOpH.Name = "dtpFechaOpH"
        Me.dtpFechaOpH.Size = New System.Drawing.Size(99, 20)
        Me.dtpFechaOpH.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Fecha Pago Desde:"
        '
        'dtpFechaOpD
        '
        Me.dtpFechaOpD.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaOpD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaOpD.Location = New System.Drawing.Point(110, 19)
        Me.dtpFechaOpD.Margin = New System.Windows.Forms.Padding(1)
        Me.dtpFechaOpD.Name = "dtpFechaOpD"
        Me.dtpFechaOpD.Size = New System.Drawing.Size(99, 20)
        Me.dtpFechaOpD.TabIndex = 0
        '
        'frmTesoChkRptxProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 142)
        Me.Controls.Add(Me.groupGeneral)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.btnSalir)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "frmTesoChkRptxProv"
        Me.Text = "Listado de Cheques x Proveedor"
        Me.groupGeneral.ResumeLayout(False)
        Me.groupGeneral.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGenerar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtProove As TextBox
    Friend WithEvents lblNomProove As Label
    Friend WithEvents btnBusq As Button
    Friend WithEvents groupGeneral As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFechaOpH As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpFechaOpD As DateTimePicker
End Class
