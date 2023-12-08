using System;
using System.Collections.Generic;
using System.Text;

namespace Menagelec.Entity
{
    class Commande
    {
       private int? id;
       private DateTime? date;
       private int? estPayee  ;
       private int? estExpediee;
       private int? client ;

        public Commande(int? id, DateTime? date, int? estPayee, int? estExpediee, int? client)
        {
            this.id = id;
            this.date = date;
            this.estPayee = estPayee;
            this.estExpediee = estExpediee;
            this.client = client;
        }

        public int? Id { get => id; set => id = value; }
        public DateTime? Date { get => date; set => date = value; }
        public int? EstPayee { get => estPayee; set => estPayee = value; }
        public int? EstExpediee { get => estExpediee; set => estExpediee = value; }
        public int? Client { get => client; set => client = value; }
    }
}
