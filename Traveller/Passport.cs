using System.Net.Http.Headers;

namespace ConsoleApp8
{
    internal class Passport 
    {
        private string name;
        private int number;
        private Date expiryDate;

        //פעולה בונה רגילה
        public Passport(string name, int number, Date expiryDate)
        {
            this.name = name;
            this.number = number;
            //שימוש בפעולה הבונה המעתיקה ממחלקה "דייט" כדי לא ליצור "מצביע" בטעות
            this.expiryDate = new Date(expiryDate);
        }
        //בנאי העתקה
        public Passport(Passport passport)
        {
            this.number = passport.number;
            this.expiryDate = passport.expiryDate;
        }
        //פעולות מאחזרות
        public string GetName() { return this.name; }
        public int GetNumber() { return this.number; }
        public Date GetExpiryDate() { return this.expiryDate; }
        //פעולות קובעות
        public void SetName(string name) { this.name = name; }
        public void SetNumber(int number) { this.number = number; }
        //פעולה שמעדכנת את תאריך התפוגה של הדרכון אבל לא פוגעת בתוצאות העבר
        public void SetExpiryDate(Date newExpiryDate) { this.expiryDate = new Date(newExpiryDate); }

        //פעולה שבודקת במקרה ותאריך הדרכון תקף
        public bool IsValid(Date dateChecked) 
        {
            if (this.expiryDate.before(dateChecked))
                return true;
            return false;
        }

        //פעולה מאחזרת שתחזיר את ערכי המחלקה
        public override string ToString()
        {
            return $"Name: {this.GetName()}\nPassNum: {this.GetNumber()}\nExp date: {this.expiryDate.ToString()}";
        }
    }
}
