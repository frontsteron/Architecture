using ClinicService.Data;

namespace ClinicDesctop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadClients_Click(object sender, EventArgs e)
        {
            ClinicServiceClient clinicClient = new ClinicServiceClient("http://localhost:5036/", new HttpClient());

            List<Client> clients = clinicClient.ClientGetAllAsync().Result.ToList();

            listViewClients.Items.Clear();

            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.ClientId.ToString();

                ListViewItem.ListViewSubItem subItem1 = new ListViewItem.ListViewSubItem();
                subItem1.Text = client.SurName;
                item.SubItems.Add(subItem1);

                ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem();
                subItem2.Text = client.FirstName;
                item.SubItems.Add(subItem2);

                ListViewItem.ListViewSubItem subItem3 = new ListViewItem.ListViewSubItem();
                subItem3.Text = client.Patronymic;
                item.SubItems.Add(subItem3);

                ListViewItem.ListViewSubItem subItem4 = new ListViewItem.ListViewSubItem();
                subItem4.Text = client.Document;
                item.SubItems.Add(subItem4);


                listViewClients.Items.Add(item);
            }

        }
    }
}
