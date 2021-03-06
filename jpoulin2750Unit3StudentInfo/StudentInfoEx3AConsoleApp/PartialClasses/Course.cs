﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoEx3AConsoleApp
{
    public partial class Course
    {
        public Course(int id, string courseNum, string courseTitle, short credits, Department department)
        {
            this.Sections = new HashSet<Section>();
            this.Id = id;
            this.CourseNum = courseNum;
            this.CourseTitle = courseTitle;
            department.Courses.Add(this);
        }

        public Section FindSection(int id)
        {
            
            Section foundSection = null;

            foreach (Section s in this.Sections)
            {
                if (s.Id == id)
                {
                    foundSection = s;
                    break;
                }
            }
            return foundSection;
        }
    }
}
