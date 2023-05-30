using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchCEP
{
    public class Adress
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
        public string ddd { get; set; }
        public string siafi { get; set; }

        public override string ToString()
        {
            return $"CEP: {cep}\nPublicPlace: {logradouro}\nComplement: {complemento}\nNeighborhood: {bairro}\nLocality: {localidade}\nUF: {uf}\nIBGE: {ibge}\nGIA: {gia}\nDDD: {ddd}\nSIAFI: {siafi}";
        }
    }
}
