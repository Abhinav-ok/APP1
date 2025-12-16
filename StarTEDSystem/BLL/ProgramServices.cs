using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarTEDSystem.DAL;
using StarTEDSystem.Entities;

namespace StarTEDSystem.BLL
{
    public class ProgramServices
    {
        private readonly StarTEDContext _context;

        internal ProgramServices(StarTEDContext registeredContext)
        {
            _context = registeredContext;
        }

        // Simple query to test database connection
        public int Program_Count()
        {
            return _context.Programs.Count();
        }
    }
}
