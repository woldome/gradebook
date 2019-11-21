using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string [] args)
        {
            List<Double> grades = new List<Double>{30,10,50.1};
            GradeBook gradeBook = new GradeBook(grades);
            gradeBook.getStatisticas();
        
        }
    }
    
}
