using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConnection.Tables
{
    public class Company: Entity
    {
        private string companyName;
        public ICollection<Phone> Phone { get; set; }
        public string CompanyName
        {
            get { return companyName; }
            set
            {
                companyName = value;
                OnPropertyChanged("CompanyName");
            }
        }
    }
}
