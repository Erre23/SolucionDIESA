using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmConsultaHorarioDisponiblePorTaller : Form
    {

        public FrmConsultaHorarioDisponiblePorTaller()
        {
            InitializeComponent();
            CbTaller.Items.Add("TALLER MANUCCI TUPAC AMARU");
            CbTaller.Items.Add("TALLER TOYOTA SERVICIOS");
            CbTaller.SelectedIndex = 0;

            DgvHorario_Agregar("TALLER MANUCCI TUPAC AMARU", DateTime.Now, new DateTime(2024, 6, 8, 8, 0, 0), "DISPONIBLE", "");
            DgvHorario_Agregar("TALLER MANUCCI TUPAC AMARU", DateTime.Now, new DateTime(2024, 6, 8, 9, 0, 0), "PROGRAMADA", "Eduardo Rodríguez Escobar");
            DgvHorario_Agregar("TALLER MANUCCI TUPAC AMARU", DateTime.Now, new DateTime(2024, 6, 8, 10, 0, 0), "PROGRAMADA", "Daniel Ibañez Zaldivar");
            DgvHorario_Agregar("TALLER MANUCCI TUPAC AMARU", DateTime.Now, new DateTime(2024, 6, 8, 11, 0, 0), "DISPONIBLE", "");
            DgvHorario_Agregar("TALLER MANUCCI TUPAC AMARU", DateTime.Now, new DateTime(2024, 6, 8, 12, 0, 0), "DISPONIBLE", "");
            DgvHorario_Agregar("TALLER MANUCCI TUPAC AMARU", DateTime.Now, new DateTime(2024, 6, 8, 13, 0, 0), "PROGRAMADA", "Sheyla Diaz Lavado");
            DgvHorario_Agregar("TALLER MANUCCI TUPAC AMARU", DateTime.Now, new DateTime(2024, 6, 8, 14, 0, 0), "PROGRAMADA", "Cesia Riquelme Carrasco");
            DgvHorario_Agregar("TALLER MANUCCI TUPAC AMARU", DateTime.Now, new DateTime(2024, 6, 8, 15, 0, 0), "DISPONIBLE", "");            
        }

        private void DgvHorario_Agregar(string taller, DateTime fecha, DateTime hora, string estado, string inspectorAsignado)
        {
            var index = DgvHorario.Rows.Add(taller, fecha.ToString("dddd dd/MM/yyyy"), hora.ToString("hh:mm tt"), estado, inspectorAsignado);
            if (estado == "DISPONIBLE") DgvHorario.Rows[index].Cells[3].Style.ForeColor = Color.Green;
        }

        private void BnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void BnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
