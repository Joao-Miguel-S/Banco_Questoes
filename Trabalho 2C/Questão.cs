using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_2C
{
    public class Questão
    {

        public static List<Questão> list=new List<Questão>();

        public string enunciado;
        public string altA;
        public string altB;
        public string altC;
        public string altD;
        public string altE;
        public string resp;
        public string path;

        public Questão(string enun, string A, string B, string C, string D, string E, string res, string path)
        {
            enunciado = enun;
            altA = A;
            altB = B;
            altC = C;
            altD = D;
            altE = E;
            resp= res;
            this.path = path;
        }
    }
}
