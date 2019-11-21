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
    class GradeBook
    {
        private readonly List<Double> _gradeList;
        public GradeBook(List<Double> gradeList)
        {
            _gradeList=gradeList;
        }
       
        public List<double> getGradeList()
        {
            return _gradeList;
        }

        public double getAverage()
        {
            double sum =0;
            foreach(var item in _gradeList) sum+=item;
            return  sum/_gradeList.Count;
        }
        public double getMax()
        {
            double tmp = double.MinValue;
            foreach(var item in _gradeList) {if(item >tmp) tmp=item;}
            return tmp;
        }
        public double getMin()
        {
            double tmp = double.MaxValue;
            foreach(var item in _gradeList) {if(item <tmp) tmp=item;}
            return tmp;
        }
        public void printList()
        {
            foreach(var item in _gradeList) Console.Write(item+" ");
            Console.WriteLine();
        }
        public void getStatisticas()
        {
            Console.WriteLine("the grades are");
            printList();
            
            Console.WriteLine("highest grade is: "+getMax());
            Console.WriteLine("lowest grade is: "+getMin());
            Console.WriteLine("average of grades is: "+getAverage());
        }
    }
}
