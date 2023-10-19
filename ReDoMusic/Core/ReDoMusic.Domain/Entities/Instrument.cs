using ReDoMusic.Domain.Common;
using ReDoMusic.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDoMusic.Domain.Entities
{
    public class Instrument : EntityBase<Guid>
    {
        public string Name { get; set; }
        public Brand Brand { get; set; } //Enum x,Value Obj x, Entities
        public string Model { get; set; }
        public ColorType Color { get; set; }
        public DateTime? ProductionYear { get; set; }
        public decimal Price { get; set; }

    }
}
