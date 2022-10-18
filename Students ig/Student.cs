using Microsoft.SqlServer.Server;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Student
    {
        private string studentName;
        private string studentClass;
        private string studentTrend;
        private int mathMark;
        private int mathGroup;
        private int englishMark;
        private int englishGroup;
        private int hisMark;
        private int hisGroup;

        //בנאי רגיל
        public Student(string studentName, string studentClass, string studentTrend, int mathMark, int mathGroup, int englishMark, int englishGroup, int hisMark, int hisGroup)
        {
            this.studentName = studentName;
            this.studentClass = studentClass;
            this.studentTrend = studentTrend;
            this.mathGroup = mathGroup;
            this.englishMark = englishMark;
            this.englishGroup = englishGroup;
            this.hisMark = hisMark;
            this.hisGroup = hisGroup;
        }
        //פעולות מאחזרות
        public string GetStudentName() { return this.studentName; }
        public string GetStudentClass() { return this.studentClass; }
        public string GetStudentTrend() { return this.studentTrend; }
        public int GetMathMark() { return this.mathMark; }
        public int GetMathGroup() { return this.mathGroup; }
        public int GetEnglishMark() { return this.englishMark; }
        public int GetEnglishGroup() { return this.englishGroup; }
        public int GetHisMark() { return this.hisMark; }
        public int GetHisGroup() { return this.hisGroup; }
        //פעולות קובועות
        public void SetStudentName(string studentName) { this.studentName = studentName; }  
        public void SetStudentClass(string studentClass) { this.studentClass = studentClass; }
        public void SetStudentTrend(string studentTrend) { this.studentTrend = studentTrend; }  
        public void SetMathMark(int mathMark) { this.mathMark = mathMark; }
        public void SetEnglishMark(int englishMark) { this.englishMark = englishMark; } 
        public void SetHisMark(int hisMark) { this.hisMark = hisMark; } 
        public void SetHisGroup(int hisGroup) { this.hisGroup = hisGroup; }

        //מטודת חישוב ציון על פי נוסחה
        public double AvgCalc()
        {
            double avg = 0;
            avg = this.GetMathMark() + this.GetEnglishMark() + this.GetHisMark();
            if (this.GetMathGroup() == 5)
                avg += GetMathMark() * 0.2;
            else if (this.GetMathGroup() == 4)
                avg += GetHisMark() * 0.1;
            if (this.GetEnglishGroup() == 5)
                avg += GetEnglishMark() * 0.2;
            else if (this.GetEnglishGroup() == 4)
                avg += this.GetEnglishMark() * 0.1;
            if (this.GetHisGroup() == 5)
                avg += this.GetHisMark() * 0.2;
            else if (this.GetHisGroup()==4)
                avg += this.GetHisMark() * 0.1;
            return avg;
        }
        //מטודה שמדפיסה את הציונים
        public string Show()
        {
            return $"grade avg: {AvgCalc()}\n";
        }
    }
}
