using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using TestConnection.Tables;

namespace TestConnection
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ApplicationViewModel();
        }
        // добавление
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            PhoneWindow phoneWindow = new PhoneWindow(new Phone());
            if (phoneWindow.ShowDialog() == true)
            {
                Phone phone = phoneWindow.Phone;
                db.Phones.Add(phone);
                db.SaveChanges();
            }
        }
       
    }
}
