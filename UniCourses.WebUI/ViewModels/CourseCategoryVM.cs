﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UniCourses.Dal.Entities;

namespace UniCourses.WebUI.ViewModels
{
    public class CourseCategoryVM : Controller
    {
        public List<Course> Courses { get; set; }
        public List<Category> Categories { get; set; }
        public List<Category> Scategories { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Course> CoursesPage { get; set; }
        public int PageSize { get; set; }
        public int Pagenumber { get; set; }
        public List<Educator> Educators { get; set; }
        public List<Member> Members { get; set; }
        public IEnumerable<CourseMember> courseMember { get; set; }
    }
}
