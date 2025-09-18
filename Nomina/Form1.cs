using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Nomina
{
    public partial class Form1 : Form
    {
        List<string> columnas;
        public Form1()
        {
            InitializeComponent();
            columnas =new List<string>();
            columnas.Add("EE");
            columnas.Add("Nombre");
            columnas.Add("Apellido");
            columnas.Add("Rg. Hrs");
            columnas.Add("OT. Hrs.");
            columnas.Add("D Hrs.");
        }
        
        private void importarExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdExcel.ShowDialog() == DialogResult.OK)
            {
                string archivo = ofdExcel.FileName;
                //MessageBox.Show("Archivo seleccionado: " + archivo);
                CargarExcel(archivo);

            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            ttsHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void CargarExcel(string path)
        {
            DataTable dt = new DataTable();
            ExcelPackage.License.SetNonCommercialPersonal("Jose Luis Mota Espeleta");

            using (var package = new ExcelPackage(new System.IO.FileInfo(path)))
            {
                if (package.Workbook.Worksheets.Count == 0)
                {
                    MessageBox.Show("El archivo de Excel no contiene hojas de trabajo.");
                    return; //En caso que no haya hojas
                }

                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                

                // Leer los encabezados de columna
                foreach (var col in columnas)
                {
                    dt.Columns.Add(col);
                }

                // Leer las filas de datos
                int rowCount = 0;
                for (int i = 3; i < worksheet.Dimension.End.Row; i++)
                {
                    if (worksheet.Cells[i, 1].Text == "")
                        break;
                    else
                        rowCount = rowCount + 1;
                }
                rowCount = rowCount + 3;
                for (int i = 3; i < rowCount; i++)
                        {
                            DataRow row = dt.NewRow();
                            for (int j = 1; j < dt.Columns.Count + 1; j++)
                            {
                                if (worksheet.Cells[i, j].Text == "")
                                    break;
                                row[j - 1] = worksheet.Cells[i, j].Text;
                                if (j == 2)
                                {
                                    string[] partes = SepararNombre(worksheet.Cells[i, j].Text);
                                    row[1] = partes[1];
                                    row[2] = partes[0];
                                    j++;
                                }
                            }
                            dt.Rows.Add(row);
                        }


            }

            // Mostrar los datos en el DataGridView
            dgvInformacion.Rows.Add(dt.Rows.Count);

           for(int i=0;i<dt.Rows.Count;i++)
           {
                for(int j = 0; j < 6; j++)
                {
                  dgvInformacion.Rows[i].Cells[j].Value = dt.Rows[i][j].ToString();
                }

           }
        }

        private string [] SepararNombre(string nombreCompleto)
        { 
            
            string[] partes = nombreCompleto.Split(',');
            if (partes.Length >= 2)
            {
                string apellido = partes[0];
                string nombre = partes[1]; 
                partes[1] = nombre.Trim();               
            }
            return partes;
        }
    }
}