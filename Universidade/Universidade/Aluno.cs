using System.Collections.Generic;

namespace Universidade
{
    public class Aluno : DadosPessoais
    {
        public int N_Aluno;
        public List<Notas> nt;

        
    }

    public class Notas
    {
        public string Disciplina { get; set; }
        public string Nota { get; set; }
      
    }
 
}
