using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestConnection.Tables
{
    public class Phone : Entity
    {
        private string title;
        private int companyId;
        private int price;

        public Company Company { get; set; }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }
        public int CompanyId
        {
            get { return companyId; }
            set
            {
                companyId = value;
                OnPropertyChanged("CompanyId");
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }


    }
}
