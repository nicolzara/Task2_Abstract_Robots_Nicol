using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Robots_inc
{
    public abstract class Worker
    {
        private string fullName;
        private string idNumber;
        private DateTime birthDate;
        private string password;


        public Worker(string name, string id, DateTime bDate, string pass)
        {
            this.fullName = name;
            this.idNumber = id;
            this.birthDate = bDate;
            this.password = pass;
        }

        public string GetFullName() { return this.fullName; }
        public void SetFullName(string  fullName) { this.fullName = fullName; } 

        public string GetIdNumber() { return this.idNumber; }
        public void SetIdNumber(string id) {  this.idNumber = id; }

        public DateTime GetBirthDate() { return this.birthDate; }
        public void SetBirthDate(DateTime bDate) {  this.birthDate = bDate; }

        public string GetPassword() { return this.password; }
        public void SetPassword(string pass) { this.password = pass; }
        
        public abstract double salary();

        public override string ToString()
        {
            string str = "";
            if(birthDate.Equals(DateTime.Today))
                str=" - HappyBirthDay";
            return fullName + " ID." + idNumber + str;

        }
    }
}
