using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M3P_BackEnd_Squad1.Models.Enums;

namespace M3P_BackEnd_Squad1.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ResponsibleID { get; set; }
        public virtual User Responsible { get; set; }
        public int CollectionID { get; set; }
        public virtual Collection Collection { get; set; }
        public double RealCost { get; set; }
        public ModelType Type { get; set; }
        public bool Embroidery { get; set; }
        public bool Print { get; set; }
    }
}
