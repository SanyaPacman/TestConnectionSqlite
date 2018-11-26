using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConnection.Tables
{
    public class Sale : Entity
    {
         private int procent; 
        public int Procent
        {
            get { return procent; }
            set
            {
                procent = value;
                OnPropertyChanged("Price");
            }
        }

    }
}
