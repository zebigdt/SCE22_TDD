using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesManager
{
    public class Worker
    {
        private String firstName;
        private String lastName;
        private String id;
        private String email;
        private String phoneNum;
        private String address;
        private String salary;
        private String netSalary;

        public Worker()
        {
            firstName = Utility.generateFirstName();
            lastName = Utility.generateLastName();
            id = Utility.generateID();
            email = Utility.generateEmail(firstName,lastName);
            phoneNum = "052-111VeEinShamAfEhad";
            address = "N0where";
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
            this.netSalary = (Int32.Parse(salary) - Utility.monthtax(salary, Utility.tax(salary))).ToString();
        }
        public String getFirstName() { return firstName; }
        public String getLastName() { return lastName; }
        public String getId() { return id; }
        public String getEmail() { return email; }
        public String getPhoneNum() { return phoneNum; }
        public String getAddress() { return address; }
        public String getSalary() { return salary; }
        public String getNetSalary() { return netSalary; }
       
    }

}
