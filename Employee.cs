using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskD04
{
    public class Employee
    {
        int age;
        string name;
        int id;
        decimal salary;


        #region Setters and Getters
        //public int GetAge()
        //{
        //    return age;
        //}
        //public int GetId()
        //{
        //    return id;
        //}
        //public decimal GetSalary()
        //{
        //    return salary;
        //}
        //public void SetAge(int _age)
        //{
        //    age = _age;
        //}
        //public string GetName()
        //{
        //    return name;
        //}
        //public void SetName(string _name)
        //{
        //    name = _name;
        //}
        //public void SetId(int _id)
        //{
        //    id = _id;
        //}
        #endregion

        #region properties
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }
        #endregion


        public string toString()
        {
            return$"{Name} {Salary}";
        }
    }
}
