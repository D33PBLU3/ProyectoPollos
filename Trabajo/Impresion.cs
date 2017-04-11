using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Pollos
{
    class Impresion
    {   private static int CANT_SPACES=20;
        Decimal total = 0;
        public int imprimirVenta(String nombre, VentaClas p, List<Producto> listProductos)
        {
            StringBuilder tiket = new StringBuilder();
            DateTime thisDay = DateTime.Today;
            tiket.AppendLine("*****Servicio a domicilio*****");
            tiket.AppendLine("");
            tiket.AppendLine("Nota de venta No. " + Convert.ToString(p.idVenta));
            tiket.AppendLine("Fecha:" + Convert.ToString(p.fechaPedido));
            tiket.AppendLine("Nombre:");
            tiket.AppendLine("La Barca Rosticerias");
            tiket.AppendLine("Telefono:");
            tiket.AppendLine("38542175");
            tiket.AppendLine("Direccion:");
            tiket.AppendLine("Av. de los Maestros 1316");
            tiket.AppendLine("Entre:");
            tiket.AppendLine("Jose Maria Coss y Federalismo");
            // tiket.AppendLine("Telefono:");
            //tiket.AppendLine("38542175");

            // tiket.AppendLine("Nombre vendedor:");
            //tiket.AppendLine(nombre + "\n");


            tiket.AppendLine("");
            tiket.AppendLine("venta:");
            foreach (Producto pr in listProductos)
            {
                tiket.AppendLine(pr.cantidad + " " + pr.nombre + " " + pr.cantidad * pr.precio);
            }
            tiket.AppendLine("");
            tiket.AppendLine("\nTotal: " + p.totalVenta);
            tiket.AppendLine("Efectivo: " + p.efectivo);
            tiket.AppendLine("Cambio: " + p.cambio);
            tiket.AppendLine(p.comentarios);
            tiket.AppendLine("");
            tiket.AppendLine("");
            tiket.AppendLine("");
            tiket.AppendLine("");

            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter("ticketsVentas/ticket" + Convert.ToString(p.idVenta) + ".txt");
                file.WriteLine(tiket.ToString());
                RawPrinterHelper.SendStringToPrinter(getImpresoraPorDefecto(), tiket.ToString());
                file.Close();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error al imprimir tiket");
                return -1;
            }
            return 1;
        }
        public int imprimirPedido(Clientes c, Pedido p,List<Producto> listProductos)
        {
            StringBuilder tiket = new StringBuilder();
            DateTime thisDay = DateTime.Today;
            tiket.AppendLine("*****Servicio a domicilio*****");
            tiket.AppendLine("");
            tiket.AppendLine("Numero de venta: " + Convert.ToString(p.idPedidos));
            tiket.AppendLine("Fecha:"+ Convert.ToString(p.fechaPedido));
            tiket.AppendLine("Nombre:");
            tiket.AppendLine("La Barca Rosticerias");
            tiket.AppendLine("Nombre cliente:");
            tiket.AppendLine(c.nombre+"\n");
            //tiket.AppendLine("");
            tiket.AppendLine("Telefono:");
            tiket.AppendLine(c.tel+"\n");
            tiket.AppendLine("");
            tiket.AppendLine("Direccion de venta:");
            tiket.AppendLine(c.direccion+"\n");
            //tiket.AppendLine("Colonia:");
            //tiket.AppendLine(c.colonia+"\n");
            //tiket.AppendLine("");
            tiket.AppendLine("Entre:");
            tiket.AppendLine(c.calles+"\n");
            tiket.AppendLine("");
          tiket.AppendLine("Pedido:");
            foreach(Producto pr in listProductos)
            {
                tiket.AppendLine(pr.cantidad + " " + pr.nombre + " " + pr.cantidad * pr.precio);
            }
            tiket.AppendLine("");
            tiket.AppendLine("\nTotal: " + p.totalPedido);
            
            tiket.AppendLine(p.comentarios);
            tiket.AppendLine("");
            tiket.AppendLine("");
            tiket.AppendLine("");
            tiket.AppendLine("");

            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter("ticketsPedidos/ticket" + Convert.ToString(p.idPedidos) + ".txt");
                file.WriteLine(tiket.ToString());
                RawPrinterHelper.SendStringToPrinter(getImpresoraPorDefecto(), tiket.ToString());
                file.Close();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error al imprimir tiket");
                return -1;
            }
            return 1;
        }
        public static string getImpresoraPorDefecto()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                    return printer;
            }
            return string.Empty;
        }
        public int granTicket(string dateTicket)
        {
            TotalProducto tp;
            Producto p;
            total = 0;
            int totalCantEndaladas = 0;
            Decimal totalPrecioEnsaladas = 0;
            StringBuilder tiket = new StringBuilder();
            Querys query = new Querys();
            tiket.AppendLine("Total venta " + dateTicket);
            tiket.AppendLine("");
            escribeProducto(1, tiket, dateTicket);
            escribeProducto(14, tiket, dateTicket);
            escribeProducto(39, tiket, dateTicket);
            escribeProducto(40, tiket, dateTicket);
            escribeProducto(31, tiket, dateTicket);
            escribeProducto(41, tiket, dateTicket);
            escribeProducto(8, tiket, dateTicket);
            escribeProducto(21, tiket, dateTicket);
            escribeProducto(9, tiket, dateTicket);
            escribeProducto(32, tiket, dateTicket);
            escribeProducto(33, tiket, dateTicket);
            escribeProducto(42, tiket, dateTicket);
            escribeProducto(2, tiket, dateTicket);
            escribeProducto(34, tiket, dateTicket);
            tp = query.contarProducto(3, dateTicket);
            totalCantEndaladas += tp.cantidad;
            totalPrecioEnsaladas += tp.precio * tp.cantidad;
            tp = query.contarProducto(4, dateTicket);
            totalCantEndaladas += tp.cantidad;
            totalPrecioEnsaladas += tp.precio * tp.cantidad;
            tp = query.contarProducto(5, dateTicket);
            totalCantEndaladas += tp.cantidad;
            totalPrecioEnsaladas += tp.precio * tp.cantidad;
            tp = query.contarProducto(6, dateTicket);
            totalCantEndaladas += tp.cantidad;
            totalPrecioEnsaladas += tp.precio*tp.cantidad;
            tp.cantidad = totalCantEndaladas;
            tp.precio = totalPrecioEnsaladas;
            tiket.AppendLine(tp.cantidad+new string(' ', ((tp.cantidad>9)? 2:3))+ "Ensaladas" + new string(' ' , 11) + "$" + tp.precio);
            escribeProducto(3, tiket, dateTicket);
            escribeProducto(4, tiket, dateTicket);
            escribeProducto(5, tiket, dateTicket);
            escribeProducto(6, tiket, dateTicket);
            totalPrecioEnsaladas = 0;
            totalCantEndaladas = 0;
            tp = query.contarProducto(26, dateTicket);
            totalCantEndaladas += tp.cantidad;
            totalPrecioEnsaladas += tp.precio;
            tp = query.contarProducto(27, dateTicket);
            totalCantEndaladas += tp.cantidad;
            totalPrecioEnsaladas += tp.precio;
            tp = query.contarProducto(28, dateTicket);
            totalCantEndaladas += tp.cantidad;
            totalPrecioEnsaladas += tp.precio;
            tp = query.contarProducto(29, dateTicket);
            totalCantEndaladas += tp.cantidad;
            totalPrecioEnsaladas += tp.precio;
            tp.cantidad = totalCantEndaladas;
            tp.precio = totalPrecioEnsaladas;
            tiket.AppendLine(tp.cantidad + new string(' ', ((tp.cantidad > 9) ? 2 : 3)) + "Ensaladas de Paquete" + new string(' ', 9) );
            escribeProducto(35, tiket, dateTicket);
            escribeProducto(20, tiket, dateTicket);
            escribeProducto(36 ,tiket, dateTicket);
            escribeProducto(7, tiket, dateTicket);
            escribeProducto(16, tiket, dateTicket);
            escribeProducto(37, tiket, dateTicket);
            escribeProducto(38, tiket, dateTicket);
            escribeProducto(18, tiket, dateTicket);
            escribeProducto(10, tiket, dateTicket);
            escribeProducto(13, tiket, dateTicket);
            escribeProducto(12, tiket, dateTicket);
            tiket.AppendLine(new string('_', 30));
            tiket.AppendLine("Total:"+new string(' ', 17)+"$"+total.ToString());
           
    try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter("GranTicket/ticket" +dateTicket.Replace("/","_")+ ".txt");
                file.WriteLine(tiket.ToString());
                RawPrinterHelper.SendStringToPrinter(getImpresoraPorDefecto(), tiket.ToString());
                file.Close();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error al imprimir tiket");
                return -1;
            }
                return 1;
        }
        void escribeProducto(int id,StringBuilder tiket,string dateTicket) 
        {
            TotalProducto tp;
            Producto p=new Producto();
            Querys query = new Querys();
            tp = query.contarProducto(id, dateTicket);
            p = query.buscarProducto(id);
            if (p != null && tp != null)
            {
                if (id == 3 || id == 4 || id == 5 || id == 6)
                    tiket.Append("      ");
                tiket.AppendLine(tp.cantidad + new string(' ', ((tp.cantidad > 9) ? 2 : 3)) + p.nombre + new string(' ', CANT_SPACES - p.nombre.Length) + "$" + (tp.precio * tp.cantidad).ToString());
                total += (tp.precio * tp.cantidad);
            }
         }
    }
   
    public class RawPrinterHelper
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "My C#.NET RAW Document";
            di.pDataType = "RAW";

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        public static bool SendFileToPrinter(string szPrinterName, string szFileName)
        {
            // Open the file.
            FileStream fs = new FileStream(szFileName, FileMode.Open);
            // Create a BinaryReader on the file.
            BinaryReader br = new BinaryReader(fs);
            // Dim an array of bytes big enough to hold the file's contents.
            Byte[] bytes = new Byte[fs.Length];
            bool bSuccess = false;
            // Your unmanaged pointer.
            IntPtr pUnmanagedBytes = new IntPtr(0);
            int nLength;

            nLength = Convert.ToInt32(fs.Length);
            // Read the contents of the file into the array.
            bytes = br.ReadBytes(nLength);
            // Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
            // Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
            // Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength);
            // Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes);
            return bSuccess;
        }
        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }
    }
}
