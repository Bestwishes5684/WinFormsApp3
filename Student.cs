using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStrory.Models;

namespace WinFormsApp3
{
    public class Student
    {
        public string FullName { get; set; }
        public Guid Id { get; set; }

        public DateTime Datarod { get; set; }

        public Gender Gender { get; set; }

        public FormOB FormOB { get; set; }

        public decimal Russian { get; set; }

        public decimal Mathematics { get; set; }
        public decimal informatics { get; set; }
        
       public decimal totalpoints { get; set; }






    }
}
