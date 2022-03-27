using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentsandDisciplines.Models;

namespace StudentsandDisciplines.Data
{
    public class StudentsandDisciplinesContext : DbContext
    {
        public StudentsandDisciplinesContext (DbContextOptions<StudentsandDisciplinesContext> options)
            : base(options)
        {
        }

        public DbSet<StudentsandDisciplines.Models.Student> Student { get; set; }
    }
}
