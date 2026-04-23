using System.Net.Sockets;

namespace WinFormsClient
{
    public partial class Form1 : Form
    {
        public Client clientCL = new Client();
       
        
        public Form1()
        {
            InitializeComponent();            
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            //удалить обработчик
        }

        private async void btnMessage_Click(object sender, EventArgs e)
        {
            string message = textMessage.Text;            
            await clientCL.SendMessageAsync(message);
        }

        private async void btnUserName_Click(object sender, EventArgs e)
        {
            await clientCL.ConnectAsync();
            string message = textName.Text;
            ListBox box = listBox1;
            Task.Run(() => clientCL.ListenAsync(box));
            await clientCL.SendMessageAsync(message);

        }
    }
}
