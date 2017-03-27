using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Pollos
{
    public partial class reportes : Form
    {
        public reportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader filer = new System.IO.StreamReader("reportsPaths.txt");
            string path = filer.ReadLine();
            Querys query = new Querys();
            int cantidad;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Application xlApp1 = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                return;
            }
            Workbook wb = xlApp.Workbooks.Open(path, 0, false, 5, null, null, false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, null, true, false, 0, true, false, false);
            Workbook wb1 = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            Worksheet ws1 = (Worksheet)wb1.Worksheets[1];
            
          
            if (ws == null)
            {
                Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
            }
            ws.Copy(ws1);
            wb.Close();
            ws1 = (Worksheet)wb1.Worksheets[1];
            cantidad = query.contarProducto(1, dateReport.Text);
            ws1.Cells[2, 5] = cantidad;
            ws1.Cells[2, 5] = dateReport.Text;

            xlApp.Visible = true;
        }
    }
}
