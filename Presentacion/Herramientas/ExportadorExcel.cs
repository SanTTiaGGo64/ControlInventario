using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

public class ExportadorExcel
{
    public static void ExportarExcel(DataView dataView)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        // Crear un nuevo libro de trabajo y una hoja de trabajo
        using (ExcelPackage excelPackage = new ExcelPackage())
        {
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Datos");

            // Rellenar la hoja de trabajo con los datos del DataView
            worksheet.Cells["A1"].LoadFromDataTable(dataView.ToTable(), true);

            // Guardar el libro de trabajo en un archivo
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                DateTime fechaDia = DateTime.Now;
                string strFecha = fechaDia.ToString("yyyy-MM-dd");

                saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
                saveFileDialog.FileName = "Reporte_"+ strFecha + ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                    excelPackage.SaveAs(excelFile);

                    MessageBox.Show("Datos exportados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
