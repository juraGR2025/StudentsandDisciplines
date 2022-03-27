using System;
using System.ComponentModel.DataAnnotations;

namespace StudentsandDisciplines.Models
{
    public class Student
    {
        // ID студента
        public virtual int StudentId { get; set; }
        // Имя студента
        public virtual string NameStudent { get; set; }
        // Название дисциплины
        public virtual string DisciplineName { get; set; }
        // Дата оценивания
        [DataType(DataType.Date)]
        public virtual DateTime assessmentDate { get; set; }
        // Максимальная сумма баллов по дисциплине
        public virtual int totalPoints { get; set; }
    }
}
