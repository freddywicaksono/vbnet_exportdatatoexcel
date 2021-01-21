Imports ExcelLib.Client
Public Class Form1
    Private xls As New ExcelLib.Client
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        ofakultas.GetAllData(DataGridView1)
    End Sub


    Private Sub btnExport_Click(sender As System.Object, e As System.EventArgs) Handles btnExport.Click
        'ExportToExcel("c:\data\laporanDataFakultas.xlsx", "Sheet1", DataGridView1)
        xls.FileName = "c:\data\laporanDataFakultas2.xlsx"
        xls.SheetName = "Sheet1"
        xls.Visible = False
        xls.ExportToExcel(DataGridView1)
    End Sub
End Class
