using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesManager
{
    public class Worker
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly string id;
        private readonly string email;
        private readonly string phoneNum;
        private readonly string address;
        private readonly string salary;
        private readonly string netSalary;

        public Worker()
        {
            firstName = Utility.GenerateFirstName();
            lastName = Utility.GenerateLastName();
            id = Utility.GenerateID();
            email = Utility.GenerateEmail(firstName, lastName);
            phoneNum = Utility.GeneratePhoneNum();
            address = Utility.GenerateAddress();
            salary = Utility.GenerateSalary();
            netSalary = (Double.Parse(salary) - Utility.CalculateIncomeTax(Double.Parse(salary))).ToString();
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
            this.netSalary = (Double.Parse(salary) - Utility.CalculateIncomeTax(Double.Parse(salary))).ToString();
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
            netSalary = other.netSalary;
        }
        public string GetFirstName() { return firstName; }
        public string GetLastName() { return lastName; }
        public string GetId() { return id; }
        public string GetEmail() { return email; }
        public string GetPhoneNum() { return phoneNum; }
        public string GetAddress() { return address; }
        public string GetSalary() { return salary; }
        public string GetNetSalary() { return netSalary; }
    }
}
