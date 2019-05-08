using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoEx3AConsoleApp
{
    public partial class Assignment
    {
        public Assignment(int id, string assign, string description, short maxPoints, DateTime dueDate, AssignmentTypesEnum type, Section section)
        {
            this.Id = id;
            this.Assign = assign;
            this.Description = description;
            this.MaxPoints = maxPoints;
            this.DueDate = dueDate;
            this.Type = type;
            Section.Assignments.Add(this);
            this.AssignmentGrades = new HashSet<AssignmentGrade>();
        }
        public AssignmentGrade FindAssignmentGrade(int id)
        {
            
            AssignmentGrade foundAssignmentGrade = null;

            foreach (AssignmentGrade a in this.AssignmentGrades)
            {
                if (a.Id == id)
                {
                    foundAssignmentGrade = a;
                    break;
                }
            }
            return foundAssignmentGrade;
        }
    }
}
