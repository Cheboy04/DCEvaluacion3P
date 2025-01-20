using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCEvaluacion3P.Models
{
    public class DCCat
    {
        public string ID { get; set; } = string.Empty;
        public string Name {  get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Origin {  get; set; } = string.Empty;
        public string Temperament { get; set; } = string.Empty;
        public Peso Weight { get; set; } = new();
        public DCImage Image { get; set; } = new();
    }   
}
