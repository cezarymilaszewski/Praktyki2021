using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Controllers
{
    public class StudentsController : Controller
    {
        private readonly LicznikiContext _context;

        public StudentsController(LicznikiContext context)
        {
            _context = context;
        }

    }
}
