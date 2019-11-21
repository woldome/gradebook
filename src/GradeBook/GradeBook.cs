using System;
using System.Collections.Generic;
namespace GradeBook
{
    public class GradeBook
    {
        private readonly List<Double> _gradeList;
        public GradeBook(List<Double> gradeList)
        {
            _gradeList=gradeList;
        }
       
       public GradeBook()
       {
           _gradeList = new List<double>();
       }
       public void addGrade(double grade)
       {
           _gradeList.Add(grade);
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
        public Stat getStat()
        {
            var stat = new Stat
            {
                avg = getAverage(),
                min = getMin(),
                max = getMax()
            };
            return stat;
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