using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Person
    {
        protected string name, adress, id;
        public Person()
        {
            name = null;
            adress = null;
            id = null;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
