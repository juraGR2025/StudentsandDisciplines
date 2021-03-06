using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentsandDisciplines.Data;
using StudentsandDisciplines.Models;

namespace StudentsandDisciplines.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly StudentsandDisciplines.Data.StudentsandDisciplinesContext _context;

        public IndexModel(StudentsandDisciplines.Data.StudentsandDisciplinesContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
