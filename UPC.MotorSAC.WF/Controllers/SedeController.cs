using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.MotorSAC.WF.DataSource;
using UPC.MotorSAC.WF.Models;

namespace UPC.MotorSAC.WF.Controllers
{
    public class SedeController
    {
        List<SedeModel> sedes;
        public SedeController()
        {
            //SedeData sedeData = new SedeData();
            sedes = new List<SedeModel>();
            sedes = SedeData.sedes;
        }

        public void CargaInicial() {
            var sede1 = new SedeModel { 
                nombre = "Sede La Molina",
                distrito = "La Molina",
                ventas = new List<VentaModel>()
            };

            var sede2 = new SedeModel
            {
                nombre = "Sede San Miguel",
                distrito = "San Miguel",
                ventas = new List<VentaModel>()
            };

            SedeData.sedes.Add(sede1);
            SedeData.sedes.Add(sede2);
        }

        public SedeModel Registrar(SedeModel sede) { 
            sedes.Add(sede);
            return sede;
        }
    }
}
