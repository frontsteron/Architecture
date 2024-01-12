using ClinicServiceNamespace;
using System.Linq.Expressions;

namespace ClinicDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            ICollection<Client> clients = clinicClient.ClientGetAllAsync().Result;

            listViewClients.Items.Clear();

            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.ClientId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.SurName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.FirstName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Patronymic
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Birthday.DateTime.ToShortDateString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Document
                });
                listViewClients.Items.Add(item);
            }
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            if(documentInput.Text != "" && surNameInput.Text != "" && firsNameInput.Text != "")
            {
                clinicClient.ClientCreateAsync(
                    new CreateClientRequest()
                    {
                        Document = documentInput.Text,
                        SurName = surNameInput.Text,
                        FirstName = firsNameInput.Text,
                        Patronymic = patronymicInput.Text,
                        Birthday = birthdayInput.Value
                    }
                ) ;
            }
            
        }
    }
}
