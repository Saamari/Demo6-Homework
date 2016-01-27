using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_Homework
{
    class Song
    {
        public string Songs { get; set; }
        public double Length { get; set; }

        public override string ToString()
        {
            return Songs + " " + Length + " ";
        }


    }
}
