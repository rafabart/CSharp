using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        //Metodo 'async' faz o acesso ao banco de forma assincrona, isto é,
        //Não bloquea o banco até o final da execução do metodo.
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
