using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M3P_BackEnd_Squad1.Models.Enums;

namespace M3P_BackEnd_Squad1.Models
{
    public class Collection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Budget { get; set; }
        public string Color { get; set; }
        public DateTime ReleaseYear { get; set; }
        public SeasonsEnum Seasons { get; set; }
        public StatusEnum Status { get; set; }

        public ICollection<Model> Models { get; set; }
    }
}