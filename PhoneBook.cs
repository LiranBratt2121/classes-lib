using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace ConsoleApp8
{
    internal class PhoneBook
    {
        //משתני המחלקה
        private Entry[] entries;
        private int count;

        //בנאי שבונה ספר טלפונים על פי גודל נתון
        public PhoneBook(int size)
        {
            this.entries = new Entry[size];
            count = 0;
        }
        //פעולה שבודקת במקרה וקיימת או לא קיימת רשימה של מישהו במערך. מוסיפה או מעדכנת אותה
        public bool AddEntry(Entry entry)
        {
            for(int i = 0; i < entries.Length; i++)
            {
                //בודק את גודל האריי של הכניסות
                if (entries[i] != null)
                {
                    this.count++;
                }
            }
            //תנאי שבודק במקרה ואין מקום ברשימה
            if (count >= entries.Length)
                return false;
            for (int i = 0; i < entries.Length; i++)
            {
                //תנאי שבודק במקרה ויש באינדקס הניתן של המערך את האינדקס הנל
                if (this.entries[i].equals(entry))
                {
                    //עדכון האינדקס במקרה והוא קיים
                    this.entries[i] = new Entry(entry);
                }
                else //ישום האינדקס בסוף האנטריז הנתונים במקרה והוא לא קיים
                    this.entries[count] = new Entry(entry);
                
            }
            return true;
        }
        
        //פעולה "שמוחקת" אנטרי נבחר מהמערך הרגיל 
        public bool DeleteEntry(Entry entry)
        {
            //יצירת אריי עזר כדי להשתמש בו כדי "למחוק" את האנטרי הנבחר
            Entry[] newEntry = new Entry[this.entries.Length];
            //יצירת משתנה בשם "גי" שישמש כקאונטר עבור המערך החדש
            int j = 0;
            for (int i = 0; i < entries.Length; i++)
            {
                //בדיקה במקרה והאנטרי נמצא במערך במקרה והוא נמצא הוא לא יכנס למערך החדש
                if (!(entry.equals(this.entries[i])))
                {
                    newEntry[j] = this.entries[i];
                    j++;
                }
            }
            //בדיקה שבודקת במקרה והמערכים שווים במקרה והם שווים זה או אומר שהאנטרי פשוט לא היה קיים במערך או שהוא לא נמחק אז תשובה שלילית
            if (this.entries.Equals(newEntry))
                return false;
            //ישום  המערך למערך הראשי ללא האנטרי הנבחר
            this.entries = newEntry;

            return true;


        }
    }
}
