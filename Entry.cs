using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Entry
    {
        //משתנים של המחלקה
        private string firstName;
        private string lastName;
        private string phoneNumber;

        //בנאי רגיל
        public Entry(string firstName, string lastName, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
        }

        //בנאי מעתיק
        public Entry(Entry otherEntry)
        {
            this.firstName = otherEntry.firstName;
            this.lastName = otherEntry.lastName;
            this.phoneNumber = otherEntry.phoneNumber;
        }
        //פעולות מאחזרות
        public string GetFirstName() { return this.firstName; }
        public string GetLastName() { return this.lastName; }
        public string GetPhoneNumber() { return this.phoneNumber; }

        //פעולה שבודקת במקרה והשם הפרטי והמשפחה של האובייט הנבחר זהים
        public bool equals(Entry otherEntry)
        {
            if (otherEntry.firstName == this.firstName && otherEntry.lastName == this.lastName)
                return true;
            return false;
        }

        //פעולה שמחזירה את ערכי המחלקה
        public override string ToString()
        {
            return $"First name: {this.firstName}\nLast name: {this.lastName}\nTelephone number: {this.phoneNumber}";
        }


    }
}
