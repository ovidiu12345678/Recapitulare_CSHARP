using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recapitulare_CSHARP
{
    internal class Address
    {
        public string Strada { get; set; }
        public string Oras { get; set; }
        public int Numar { get; set; }
        public string Judet { get; set; }
        public Address() 
        {
        }

        public override string ToString() =>
            $"Strade: {Strada}, Oras: {Oras}, Numar : {Numar}, Judet : {Judet}";
        
    }
}
