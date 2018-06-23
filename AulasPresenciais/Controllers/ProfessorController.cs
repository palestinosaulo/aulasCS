using Modelos;
using System.Collections.Generic;

namespace Controllers
{
    public class ProfessorController
    {
        List<Professor> TabelaProfessor = new List<Professor>();

        public void inserir (Professor p)
        {
            TabelaProfessor.Add(p);
        }

        public List<Professor> ListarTodos()
        {
            return TabelaProfessor;
        }
    }
}
