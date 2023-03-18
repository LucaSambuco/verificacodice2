using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VerificaCodice
{
    internal class Alunno
    {
        string Nome;
        string Cognome;
        int Eta;

        public Alunno(string nome, string cognome, int eta)
        {

            Nome = nome;
            Cognome = cognome;
            Eta = eta;

        }
        public string toString()
        {
            string anno;
            if (Eta<16)
            {
                anno = "Biennio";

            }else
            {
                anno = "Trienno";
            }

            string result="";
            result = "Nome:" + Nome + "\nCognome:" + Cognome + "\n Età:" + Eta+"\nAnno:"+anno;
            return result;

        }
    }
}
