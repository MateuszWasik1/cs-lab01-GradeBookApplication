using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public GradeBookType Type { get; set; }

        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = GradeBookType.Ranked;
        }
        //public override char GetLetterGrade(double averageGrade)
        //{
        //    if (Students.Count() < 5)
        //       throw new InvalidOperationException();
        //    return base.GetLetterGrade(averageGrade);
        //}
        public override void CalculateStatistics()
        {
            if (Students.Count() < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else
                base.CalculateStatistics();
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count() < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else
                base.CalculateStudentStatistics(name);
        }
    }
}
