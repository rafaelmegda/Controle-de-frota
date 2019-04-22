using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class MVeiculo
    {
        public string RENAVAM { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public string PessoaCPF { get; set; }
        public string PessoaNome { get; set; }
    }
}
