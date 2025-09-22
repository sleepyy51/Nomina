using Newtonsoft.Json;
using Nomina.Recursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina
{
    public partial class frmPago : Form
    {
        public string rutaJson = Path.Combine("datos.json");

        public frmPago()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                datosJson datos = new datosJson(Convert.ToDouble(txtHorasRegulares.Text), Convert.ToDouble(txtHorasExtra.Text), Convert.ToDouble(txtDobleTurno.Text));
                guardarJson(datos);

                MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarJson(datosJson dato)
        {
            var registrosJson = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            };

            string json = JsonConvert.SerializeObject(dato, registrosJson);
            File.WriteAllText(rutaJson, json);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
