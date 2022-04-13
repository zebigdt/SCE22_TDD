using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesManager
{
    public class Worker
    {
        private string firstName;
        private string lastName;
        private string id;
        private string email;
        private string phoneNum;
        private string address;
        private string salary;
        private string netSalary;

        public Worker()
        {
            firstName = Utility.generateFirstName();
            lastName = Utility.generateLastName();
            id = Utility.generateID();
            email = Utility.generateEmail(firstName,lastName);
            phoneNum = Utility.generatePhoneNum();
            address = Utility.generateAddress();
            salary = Utility.generateSalary();
            netSalary = (Int32.Parse(salary) - Utility.monthtax(salary, Utility.tax(salary))).ToString();
        }
        public Worker(string firstName, string lastName, string id, string email, string phoneNum, string address, string salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.email = email;
            this.phoneNum = phoneNum;
            this.address = address;
            this.salary = salary;
            //כמה כסף נשאר לך אחרי שחלבו אותך 
            this.netSalary = (Int32.Parse(salary) - Utility.monthtax(salary, Utility.tax(salary))).ToString();
        }
        public Worker(Worker other)
        {
            firstName = other.firstName;
            lastName = other.lastName;
            id = other.id;
            email = other.email;
            phoneNum = other.phoneNum;
            address = other.address;
            salary = other.salary;
            netSalary =other.netSalary;
        }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getId() { return id; }
        public string getEmail() { return email; }
        public string getPhoneNum() { return phoneNum; }
        public string getAddress() { return address; }
        public string getSalary() { return salary; }
        public string getNetSalary() { return netSalary; }
    }
}
