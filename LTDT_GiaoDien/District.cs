using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class District
    {
        string name;
        List<Item> listItems;
        List<Employee> listEmployees;

        public District(string _name = "null")
        {
            name = _name;
            listItems = new List<Item>();
            listEmployees = new List<Employee>();
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public List<Item> getListItems()
        {
            return listItems;
        }

        public List<Employee> getListEmployees()
        {
            return listEmployees;
        }

        public void addItem(Item item)
        {
            listItems.Add(item);
        }

        public void addEmployee(Employee employee)
        {
            listEmployees.Add(employee);
        }
    }
}
