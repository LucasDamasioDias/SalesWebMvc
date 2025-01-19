using SalesWebMvc.Data;
using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _contex;

        public DepartmentService(SalesWebMvcContext contex)
        {
            _contex = contex;
        }

        public async Task<List<Department>> FindAllAsync() 
        {
            return await _contex.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
