using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.MotorSAC.WF.Models
{
    public class SedeModel
    {
        public string id_sede { get; } = Guid.NewGuid().ToString();
        public string nombre { get; set; }
        public string distrito { get; set; }
        public List<VentaModel> ventas { get; set; }

    }
}
