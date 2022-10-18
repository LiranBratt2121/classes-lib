using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Date
    {
        private int day;
        private int month;
        private int year;

        //בנאי רגיל
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        //בנאי שמעתיק אובייקט 
        public Date(Date date)
        {
            this.day = date.day;
            this.month = date.month;
            this.year = date.year;
        }
        //פעולות מחזירות
        public int GetDay() { return day; }
        public int GetMonth() { return month; }
        public int GetYear() { return year; }
        //פעולות מעדכנות
        public void SetDay(int day) { this.day = day; }
        public void SetMonth(int month) { this.month = month; }
        public void SetYear(int year) { this.year = year; }

        //פעולה שמחזירה "אמת" רק כאשר התאריך הנוכחי קודם לתאריך הפרמטר
        public bool before(Date date)
        {
            if (this.year < date.GetYear())
                return true;
            else if (this.year == date.GetYear())
                if (this.month < date.GetMonth())
                    return true;
                else if (this.month == date.GetMonth())
                    if (this.day < date.GetDay())
                        return true;
                return false;
        }
        //פעולה מאחזרת ששולחת את תוכן המחלקה
        public override string ToString()
        {
            return $"({GetDay()}/{GetMonth()}/{GetYear()})";
        }

    }
}
