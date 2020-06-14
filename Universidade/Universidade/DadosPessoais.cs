using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    public class DadosPessoais
    {
        public string Nome;
        public string Morada;
        public int Codigo_Postal;
        public int Telemovel;
        public int BI;
        public string Email;
        public int Horas_semanais;
        public string Curso;
    }

    public struct ImportExport
    {
        public List<Aluno> al;
        public List<Docente> dc;
    }
}
