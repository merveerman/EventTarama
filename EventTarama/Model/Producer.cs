using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTarama
{
    public class Producer
    {
        public virtual int ProducerId { get; set; }
        public virtual int ProducerPriority { get; set; }
    }
}
