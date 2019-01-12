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
        ApplicationContex db;
        public MainWindow()
        {
            InitializeComponent();

            db = new ApplicationContex();
            db.Phones.Load();
            db.Companies.Load();
            this.DataContext = db.Phones.Local.ToBindingList();
            
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
        // редактирование
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (phonesList.SelectedItem == null) return;
            // получаем выделенный объект
            Phone phone = phonesList.SelectedItem as Phone;

            PhoneWindow phoneWindow = new PhoneWindow(new Phone
            {
                Id = phone.Id,
                CompanyId = phone.CompanyId,
                Price = phone.Price,
                Title = phone.Title
            });

            if (phoneWindow.ShowDialog() == true)
            {
                // получаем измененный объект
                phone = db.Phones.Find(phoneWindow.Phone.Id);
                if (phone != null)
                {
                    phone.CompanyId = phoneWindow.Phone.CompanyId;
                    phone.Title = phoneWindow.Phone.Title;
                    phone.Price = phoneWindow.Phone.Price;
                    db.Entry(phone).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
        // удаление
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (phonesList.SelectedItem == null) return;
            // получаем выделенный объект
            Phone phone = phonesList.SelectedItem as Phone;
            db.Phones.Remove(phone);
            db.SaveChanges();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
