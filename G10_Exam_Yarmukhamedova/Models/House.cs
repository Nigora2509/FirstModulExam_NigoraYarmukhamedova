using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G10_Exam_Yarmukhamedova.Models
{
    public class House
    {
        public Guid Id { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int QuentityRooms { get; set; }
    }
}
