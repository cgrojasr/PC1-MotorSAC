using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.MotorSAC.WF.Models
{
    public class AutoModel
    {
        public string id_auto { get; } = Guid.NewGuid().ToString();
        public string nombre_modelo { get; set; }
        public string categoria { get; set; }
    }
}
