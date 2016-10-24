Imports Microsoft.Reporting.WinForms
Imports VzTesoreria
Imports VzAdmin
Imports VzComercial


Public Class frmTesoChkPagoPendte
    Private Sub frmTesoChkPagoPendte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Me.Tag = "TESOCHKPAGOPENDTE"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "frmTesoChkPagoPendte.frmTesoChkPagoPendte_Load")
            gAdmin.Log.fncGrabarLogERR("Error en frmTesoChkPagoPendte.frmTesoChkPagoPendte_Load:" & ex.Message)
        End Try
    End Sub

    Private Sub txtProove_TextChanged(sender As Object, e As EventArgs) Handles txtProove.TextChanged
        Dim pProove As cProveedor = Nothing
        Try
            If Not txtProove.Text.Trim = "" Then
                pProove = cProveedor.GetProveedorxNro(gAdmin, txtProove.Text.Trim)
                If Not IsNothing(pProove) Then
                    SetProveedor(pProove)
                Else
                    txtProove.Text = ""
                    lblNomProove.Text = "_____________"
                    txtProove.Tag = Nothing
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "frmTesoChkPagoPendte.txtProove_LostFocus")
            gAdmin.Log.fncGrabarLogERR("Error en frmTesoChkPagoPendte.txtProove_LostFocus:" & ex.Message)
        End Try
    End Sub

    Public Sub SetProveedor(ByVal pProove As cProveedor)
        Try
            lblNomProove.Text = pProove.Nombre
            txtProove.Text = pProove.Id_Proveedor
            txtProove.Tag = pProove
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "frmTesoChkPagoPendte.btnBusq_Click")
            gAdmin.Log.fncGrabarLogERR("Error en frmTesoChkPagoPendte.btnBusq_Click:" & ex.Message)
        End Try
    End Sub


    Private Sub btnBusq_Click(sender As Object, e As EventArgs) Handles btnBusq.Click
        Try
            DirectCast(Me.MdiParent, frmPrincipal).SubAbrirConsulta(cAdmin.EnuOBJETOS.Proveedores, Me)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "frmTesoChkPagoPendte.btnBusq_Click")
            gAdmin.Log.fncGrabarLogERR("Error en frmTesoChkPagoPendte.btnBusq_Click:" & ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim lDt As DataTable
        Dim lBs As BindingSource = Nothing
        Dim lArrDS As New ArrayList
        Dim lArrayParameters As New ArrayList
        Dim lRds As ReportDataSource = Nothing
        Dim lRPar As ReportParameter = Nothing
        Dim lPrintSettings As New System.Drawing.Printing.PageSettings
        Dim lRDLC As String
        Dim lNombreRpt As String = ""

        Try
            lRDLC = "rptTesoChkPagosPendte.rdlc"


            lDt = cCheque.Dat_RptTesoChkPagosPendte(gAdmin, "N", Date.Now, 0)


            lBs = New BindingSource
            lBs.DataSource = lDt
            lRds = New ReportDataSource("DataSet1", lBs)
            lArrDS.Add(lRds)

            lRPar = New ReportParameter("pTitulo", "Reporte de Pagos pendientes")
            lArrayParameters.Add(lRPar)

            lArrayParameters.Add(lRPar)



            'A4  	 8.3in x 11.7in 210 × 297mm
            'Letter  8.5in x 11in	216 x 279mm
            'Legal   8.5in x 14in	216 x 356mm

            'Seteo la configuracion de impresion.
            lPrintSettings.Margins.Top = 10
            lPrintSettings.Margins.Bottom = 10
            lPrintSettings.Margins.Right = 10
            lPrintSettings.Margins.Left = 10
            lPrintSettings.Landscape = False
            Dim lSize As New System.Drawing.Printing.PaperSize
            lSize.RawKind = System.Drawing.Printing.PaperKind.Letter
            lSize.Width = 850
            lSize.Height = 1100
            lPrintSettings.PaperSize = lSize

            DirectCast(Me.MdiParent, frmPrincipal).SubArirReporteBase(lArrDS, lArrayParameters, lRDLC, lPrintSettings, "Reporte de Cheques en Cartera - Vto " & gFncConvertDateToString(Date.Now, "DD/MM/YYYY") & " a " & gFncConvertDateToString(Date.Now, "DD/MM/YYYY"), lNombreRpt)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "cCheque.Dat_RptTesoChkPagosPendte")
            pAdmin.Log.fncGrabarLogERR("Error en cCheque.Dat_RptTesoChkPagosPendte:  " & ex.Message)

        End Try
    End Sub

    ''comentario prueba

End Class