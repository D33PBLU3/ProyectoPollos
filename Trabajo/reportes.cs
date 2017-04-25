using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;

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
            Impresion imp = new Impresion();
            imp.granTicket(dateReport.Text);
            imp = null;
         /*   System.IO.StreamReader filer = new System.IO.StreamReader("reportsPaths.txt");
            string path = filer.ReadLine();
            string fileName = "reporte" + dateReport.Text.Replace("/","-")+".xls";
            System.IO.File.Copy(path+"/plantilla.xls", "reportes/"+fileName, true);
            Querys query = new Querys();
            int cantidad=1;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                return;
            }
            Workbook wb = xlApp.Workbooks.Open(path+"/reportes/"+fileName, 0, false, 5, null, null, false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, null, true, false, 0, true, false, false);
           // Workbook wb1 = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = (Worksheet)wb.Worksheets[1];
           // Worksheet ws1 = (Worksheet)wb1.Worksheets[1];
            
          
            if (ws == null)
            {
                Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
            }
            //ws.Copy(ws1);
            //wb.Close();
            cantidad = query.contarProducto(1, dateReport.Text);
            ws.Cells[2, 5] = dateReport.Text;
            ws.Cells[6, 2] = cantidad;
           cantidad = query.contarProducto(14, dateReport.Text);
            ws.Cells[7, 2] = cantidad;
            cantidad = query.contarProducto(8, dateReport.Text);
            ws.Cells[12, 2] = cantidad;
            cantidad = query.contarProducto(21, dateReport.Text);
            ws.Cells[13, 2] = cantidad;
            cantidad = query.contarProducto(9, dateReport.Text);
            ws.Cells[14, 2] = cantidad;
            cantidad = query.contarProducto(2, dateReport.Text);
            ws.Cells[20, 2] = cantidad;
            cantidad = query.contarProducto(3, dateReport.Text);
            cantidad=cantidad+ query.contarProducto(4, dateReport.Text);
            cantidad = cantidad + query.contarProducto(5, dateReport.Text);
            cantidad = cantidad + query.contarProducto(6, dateReport.Text);
            ws.Cells[24, 2] = cantidad;
            cantidad = query.contarProducto(20, dateReport.Text);
            ws.Cells[27, 2] = cantidad;
            cantidad = query.contarProducto(7, dateReport.Text);
            ws.Cells[30, 2] = cantidad;
            cantidad = query.contarProducto(16, dateReport.Text);
            ws.Cells[31, 2] = cantidad;
            cantidad = query.contarProducto(19, dateReport.Text);
            ws.Cells[33, 2] = cantidad;
            cantidad = query.contarProducto(18, dateReport.Text);
            ws.Cells[34, 2] = cantidad;
            xlApp.Visible = true;
            */
        }
      
        private void reportes_Load(object sender, EventArgs e)
        {
            dateReport.CustomFormat = "yyyy/MM/dd";
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text== "REPORTE DIARIO")
            {
                dateReport.Visible = true;
                label2.Visible = true;

            }
        }
    }
}
