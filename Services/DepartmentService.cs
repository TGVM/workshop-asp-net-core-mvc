using SalesWebApplicationMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebApplicationMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebApplicationMVCContext _context;

        public DepartmentService(SalesWebApplicationMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync() {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

    }
}
