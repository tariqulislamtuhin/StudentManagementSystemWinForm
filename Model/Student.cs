﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntryUI.Model
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
    }
}
