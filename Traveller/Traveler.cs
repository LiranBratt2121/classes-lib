using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Traveler
    {
        private Passport passport;
        private bool isPayed;

        //בנאי רגיל
        public Traveler(Passport passport, bool isPayed)
        {
            this.passport = new Passport(passport);
            this.isPayed = isPayed; 
        }
        //פעולות מאחזרות
        public bool GetIsPayed() { return this.isPayed; }
        public Passport GetPassport() { return this.passport; }

        //משנה את סטטוס התשלום משלילי לחיובי
        public void Pay()
        {
            this.isPayed = true;
            Console.WriteLine("thank you paying");
        }
        //פעולה שמחזירה אמת במקרה והנוסע שילם על הנסיעה
        public bool IsPayed()
        {
            if (isPayed)
                return true;
            return false;
        }
        //פעולה שמחזירה "אמת" רק הנסיעה אפשרית הדרכון תקף והלקוח שילם
        public bool CheckTravel(Date travel)
        {
            if (this.passport.IsValid(travel) && IsPayed())
                return true;
            return false;
                
        }
        //פעולה שמאחזרת את פעולה "הטוסטרינג" של אובייקט "הפספורט" וגם במקרה שהנוסע שילם
        public override string ToString()
        {
            return $"{passport.ToString()}\nis payed: {this.GetIsPayed()}";
        }
    }
}
