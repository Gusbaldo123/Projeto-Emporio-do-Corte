using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaguar.Classes
{
    class Schedule
    {
        int id, idperson;
        DateTime dtOpen, dtClose, dtPrize;
        bool ispaid;
        string state, desc;

        public int ID { get => id; set => id = value; }
        public int IdPerson { get => idperson; set => idperson = value; }
        public DateTime DtOpen { get => dtOpen; set => dtOpen = value; }
        public DateTime DtClose { get => dtClose; set => dtClose = value; }
        public DateTime DtPrize { get => dtPrize; set => dtPrize = value; }
        public bool isPaid { get => ispaid; set => ispaid = value; }
        public string State { get => state; set => state = value; }
        public string Desc { get => desc; set => desc = value; }
    }
}
