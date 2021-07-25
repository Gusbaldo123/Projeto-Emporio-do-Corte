using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaguar.Classes
{
    class Person
    {
        string name;
        string phone, cellphone;
        string address;
        string complement;
        string city, state, houseid;
        int id;

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Cellphone { get => cellphone; set => cellphone = value; }
        public int ID { get => id; set => id = value; }
    }
}
