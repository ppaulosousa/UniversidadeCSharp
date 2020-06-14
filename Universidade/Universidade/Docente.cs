using System.Collections.Generic;

namespace Universidade
{
    public class Docente : DadosPessoais
    {
        public int N_Docente;
        public List<Grau> gr;

    }
    public class Grau
    {
        public string Grau_obtencao { get; set; }
        public string Local { get; set; }
        public string Dt_obtencao { get; set; }

    }

    
}
