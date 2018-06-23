using Modelos;
using System.Collections.Generic;

namespace Controllers
{
    public class DisciplinasController
    {
        List<Disciplina> TabelaProfessor = new List<Disciplina>();

        public void inserir(Disciplina p)
        {
            TabelaProfessor.Add(p);
        }

        public List<Disciplina> ListarTodos()
        {
            return TabelaDisciplinas;
        }
    }
}