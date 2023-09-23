using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPC.MotorSAC.WF.Controllers;
using UPC.MotorSAC.WF.DataSource;
using UPC.MotorSAC.WF.Models;

namespace UPC.MotorSAC.WF
{
    public partial class Form1 : Form
    {
        //private readonly SedeData objSedeData;
        public Form1()
        {
            InitializeComponent();
            var sedeController = new SedeController();
            sedeController.CargaInicial();
            MostrarSedes(SedeData.sedes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var objSede = new SedeModel();
            //{
            //    nombre = "Sede Surco",
            //    distrito = "Surco",
            //    ventas = new List<VentaModel>()
            //};
            objSede.nombre = txtNombre.Text;
            objSede.distrito = txtDistrito.Text;
            objSede.ventas = new List<VentaModel>();

            var service = new SedeController();
            service.Registrar(objSede);
            MostrarSedes(SedeData.sedes);
        }

        private void MostrarSedes(List<SedeModel> sedes) {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < sedes.Count; i++)
            {
                dataGridView1.Rows.Add(sedes[i].id_sede, sedes[i].nombre, sedes[i].distrito);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form2 = new frmSedeRegistro(1);
            form2.Show();
            //form2.Close();
        }
    }
}
