using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace QuanLyCuaHangTienLoi
{
    public class ExcelUtlity
    {
        /// <summary>
        /// FUNCTION FOR EXPORT TO EXCEL
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="worksheetName"></param>
        /// <param name="saveAsLocation"></param>
        /// <returns></returns>
        public bool WriteDataTableToExcel(DataGridView dgvProducts, string worksheetName, string saveAsLocation, string ReporType, int idBBill, String ten, String sdt, String tongTien)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkBook;
            Microsoft.Office.Interop.Excel.Worksheet excelSheet;
            Microsoft.Office.Interop.Excel.Range excelCellrange;

            try
            {
                // Start Excel and get Application object.
                excel = new Microsoft.Office.Interop.Excel.Application();

                // for making Excel visible
                excel.Visible = false;
                excel.DisplayAlerts = false;

                // Creation a new Workbook
                excelworkBook = excel.Workbooks.Add(Type.Missing);

                // Workk sheet
                excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
                excelSheet.Name = worksheetName;






                excelSheet.Cells[2, 1] = "ID Bill:" + idBBill;
                excelSheet.Cells[3, 1] = "Tên khách hàng:" + ten;
                excelSheet.Cells[4, 1] = "Số điện thoại khách hàng:" + sdt;
                excelSheet.Cells[5, 1] = "Tổng tiền khách hàng:" + tongTien;
                excelSheet.Cells[6, 1] = "Chi tiết hóa đơn";
                excelSheet.Cells[7, 1] = "Tên sản phẩm";
                excelSheet.Cells[7, 2] = "Số lượng";
                excelSheet.Cells[7, 3] = "Giá bán";

                /*int rowcount = 7;
                foreach (DataRow datarow in dataTable.Rows)
                {
                    rowcount += 1;
                    for (int i = 1; i <= dataTable.Columns.Count; i++)
                    {

                        excelSheet.Cells[rowcount, i] = datarow[i - 1].ToString();
                    }

                }*/

                int rowcount = 7;
                for (int i = 0; i < dgvProducts.RowCount - 1; i++)
                {
                    rowcount += 1;
                    DataGridViewRow selected = dgvProducts.Rows[i];
                    string TenSp = selected.Cells["TenSp"].Value.ToString();
                    string GiaBan = selected.Cells["GiaBan"].Value.ToString();
                    string SoLuong = selected.Cells["SoLuong"].Value.ToString();
                    excelSheet.Cells[rowcount, 1] = TenSp;
                    excelSheet.Cells[rowcount, 2] = SoLuong;
                    excelSheet.Cells[rowcount, 3] = GiaBan;

                }

                excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[rowcount, dgvProducts.Columns.Count]];
                excelCellrange.EntireColumn.AutoFit();

                excelworkBook.SaveAs(saveAsLocation); ;
                excelworkBook.Close();
                excel.Quit();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                excelSheet = null;
                excelCellrange = null;
                excelworkBook = null;
            }

        }





    }
}
