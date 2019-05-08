using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoEx3AConsoleApp
{
    public partial class Enrollment
    {
        public Enrollment(int id, GradeTypesEnum gradeType, GradesEnum grades, Student student, Section sections)
        {
            this.Id = id;
            this.GradeType = gradeType;
            this.Grade = grades;
            this.AssignmentGrades = new HashSet<AssignmentGrade>();
            Student.Enrollments.Add(this);
            Section.Enrollments.Add(this);
        }
        public AssignmentGrade FindAssignmentGrade(string assign)
        {
            
            AssignmentGrade foundAssignmentGrade = null;

            foreach (AssignmentGrade a in this.AssignmentGrades)
            {
                if (a.Assignment.Assign == assign)
                {
                    foundAssignmentGrade = a;
                    break;
                }
            }
            return foundAssignmentGrade;
        }
       
    }
}
