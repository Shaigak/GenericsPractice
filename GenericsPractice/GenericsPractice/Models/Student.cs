using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice.Models
{
    public class Student:IStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
