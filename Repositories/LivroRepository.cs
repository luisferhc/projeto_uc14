using projeto_uc14.Contexts;
using projeto_uc14.Models;

namespace projeto_uc14.Repositories
{
    public class LivroRepository
    {
        private readonly SqlContext _context;

        public LivroRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Livro> Listar() 
        {
            return _context.Livros.ToList();
        }


    }
}
