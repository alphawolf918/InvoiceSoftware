using App = System.Windows.Forms.Application;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System;
using System.Drawing;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace InvoiceSoftware {
    public class Utils {
        private static readonly frmMain core = frmMain.instance;

        public static bool SystemResize = false;

        public static double MoneyVal(object input, bool asPercent = true) {
            string strNumVal = Utils.Nz(input.ToString(), "0.00");
            strNumVal = Utils.GetDoubleValue(strNumVal);
            double dblNumVal = Utils.CDbl(strNumVal);
            if (asPercent) {
                dblNumVal /= 100.00;
            }
            return dblNumVal;
        }

        public static bool UpdateStatusBar(string strText) {
            core.lblStatusBar.Text = strText;
            return true;
        }

        public static bool CheckIfEmptyOrNull(string strValue, string fieldName = "Field") {
            strValue.Replace("  ", " ");
            strValue.Replace(" ", "");
            if (strValue == "" || strValue == " " || strValue is null) {
                DialogBox.Error(fieldName + " cannot be empty.");
                return true;
            }
            return false;
        }

        public static string Nz(string strValue, string valOut = "NULL") {
            if (strValue == "" || strValue is null) {
                return valOut;
            }
            return strValue;
        }

        public static void RemoveAllFromListView(ListView lv) {
            foreach (ListViewItem viewItem in lv.Items) {
                lv.Items.Remove(viewItem);
            }
        }

        public static bool isSomethingSelected(ListView lv) {
            bool res = false;
            if (lv.SelectedItems.Count > 0) {
                string strID = Nz(lv.SelectedItems[0].Text, "-1");
                long ID = CLng(strID);
                bool enable = (ID > -1);
                res = enable;
            }
            return res;
        }

        public static string SqlFormat(object str) {
            string res = str.ToString().Replace("  ", " ");
            res = res.Replace("  ", " ");
            res = res.Replace("'", "\'");
            res = res.Trim();
            return res;
        }

        public static void ExportToExcel(ListView lv) {
            Cursor.Current = Cursors.WaitCursor;
            App.DoEvents();
            UpdateStatusBar("Exporting results...");
            Excel.Application xla = new Excel.Application {
                Visible = true
            };
            Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet) xla.ActiveSheet;

            int colNum = lv.Columns.Count;
            int color = -1;
            int i = 2;
            int j = 1;
            int x = 1;
            int y = 1;

            foreach (ColumnHeader ch in lv.Columns) {
                if (ch.Width <= 0) {
                    ws.Cells[x, y].ColumnWidth = 0;
                } else {
                    ws.Cells[x, y] = ch.Text;
                }
                y++;
            }

            foreach (ListViewItem lvi in lv.Items) {
                if (ws.Cells[i, j].ColumnWidth > 0) {
                    ws.Cells[i, j] = lvi.Text.ToString();
                }
                color = Utils.CInt(lvi.BackColor.ToArgb());
                foreach (ListViewSubItem drv in lvi.SubItems) {
                    if (ws.Cells[i, j].ColumnWidth > 0) {
                        if (color != 1694498815 && color != -1) {
                            ws.Cells[i, j].EntireRow.Interior.Color = lvi.BackColor;
                        } else {
                            ws.Cells[i, j].EntireRow.Interior.Color = Color.White;
                        }
                        ws.Cells[i, j] = drv.Text.ToString();
                    }
                    j++;
                }
                j = 1;
                i++;
            }

            ws.Cells.Select();
            ws.Cells.EntireColumn.AutoFit();
            Cursor.Current = Cursors.Default;
            App.DoEvents();
            UpdateStatusBar("Ready");
            core.Select();
            ReleaseObjects(ws, wb);
        }

        internal static bool ExceptionFilter(Exception ex) {
            return (ex is SqlException || ex is NullReferenceException);
        }

        internal static void CommandError(Exception ex) {
            DialogBox.Error("There was an error running this command:\n\n" + ex.Message);
        }

        public static void PreventColumnResize(ListView ls, object sender, ColumnWidthChangingEventArgs e) {
            if (!SystemResize) {
                e.NewWidth = ls.Columns[e.ColumnIndex].Width;
                e.Cancel = true;
            }
        }

        public static void ReleaseObjects(params object[] obj) {
            foreach (object o in obj) {
                ReleaseObject(obj);
            }
        }

        public static void ReleaseObject(object obj) {
            try {
                Marshal.ReleaseComObject(obj);
                obj = null;
            } catch {
                obj = null;
            } finally {
                GC.Collect();
            }
        }

        public static string GetDoubleValue(string valIn, int index = 0) {
            double[] output = valIn.ExtractDoubles();
            return output[index].ToString();
        }
        public static void SizeLastColumn(ListView lv) => lv.Columns[lv.Columns.Count - 1].Width = -2;
        public static string CStr(object value) => Convert.ToString(value);
        public static int CInt(object value) => Convert.ToInt32(value);
        public static long CLng(object value) => Convert.ToInt64(value);
        public static double CDbl(object value) => Convert.ToDouble(value);
        public static bool CBool(object value) => Convert.ToBoolean(value);
    }
}