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
    public partial class FrmConsultaInspeccionRealizadaPorTaller : Form
    {

        public FrmConsultaInspeccionRealizadaPorTaller()
        {
            InitializeComponent();
            CbTaller.Items.Add("TALLER MANUCCI TUPAC AMARU");
            CbTaller.Items.Add("TALLER TOYOTA SERVICIOS");
            CbTaller.SelectedIndex = 0;

            DgvHorario_Agregar("TALLER MANUCCI TUPAC AMARU", DateTime.Now, new DateTime(2024, 6, 8, 9, 0, 0), "Eduardo Rodríguez Escobar", "T5V789", "RUC: 20525567240 - Servicios Industriales SRL", "APROBADA", "Ver Detalle");
            DgvHorario_Agregar("TALLER MANUCCI TUPAC AMARU", DateTime.Now, new DateTime(2024, 6, 8, 10, 0, 0), "Daniel Ibañez Zaldivar", "B5B123", "DNI: 78787878 - Noemi Saldaña Vega", "REQUIERE MANTENIMIENTO", "Ver Detalle");
            DgvHorario_Agregar("TALLER MANUCCI TUPAC AMARU", DateTime.Now, new DateTime(2024, 6, 8, 13, 0, 0), "Sheyla Diaz Lavado", "A9X159", "DNI: 44556677 - Vanessa Angeldones Torres", "REQUIERE MANTENIMIENTO", "Ver Detalle");
            DgvHorario_Agregar("TALLER MANUCCI TUPAC AMARU", DateTime.Now, new DateTime(2024, 6, 8, 14, 0, 0), "Cesia Riquelme Carrasco", "Z9Q456", "RUC: 20202020123 - Coorporación CIMEX", "APROBADA", "Ver Detalle");
        }

        private void DgvHorario_Agregar(string taller, DateTime fecha, DateTime hora, string inspectorAsignado, string vehiculo, string cliente, string estado, string accion)
        {
            var index = DgvHorario.Rows.Add(taller, fecha.ToString("dddd dd/MM/yyyy"), hora.ToString("hh:mm tt"), inspectorAsignado, vehiculo, cliente, estado, accion);
            DgvHorario.Rows[index].Cells[6].Style.ForeColor = estado == "APROBADA" ? Color.Green : Color.Red;
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
