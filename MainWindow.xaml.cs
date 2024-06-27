using System.Collections.ObjectModel;
using System.Windows;

namespace Telefonbuch
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Contact> Contacts { get; set; }

        public Contact SelectedContact { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Beispielhafte Daten
            Contacts = new ObservableCollection<Contact>
            {
                new Contact { FullName = "Max Mustermann", PhoneNumber = "123456789" },
                new Contact { FullName = "Erika Musterfrau", PhoneNumber = "987654321" }
            };

            DataContext = this;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string phoneNumber = txtPhoneNumber.Text;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(phoneNumber))
            {
                Contact newContact = new Contact { FullName = name, PhoneNumber = phoneNumber };
                Contacts.Add(newContact);

                txtName.Text = string.Empty;
                txtPhoneNumber.Text = string.Empty;
            }
        }
    }

    public class Contact
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
