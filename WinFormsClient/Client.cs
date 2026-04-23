using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClient
{
    public class Client
    {
        public string host = "127.0.0.1";
        public int port = 8888;
        public TcpClient client;
        public StreamReader reader {  get; set; }
        public StreamWriter writer {  get; set; }
        public string mes;
        public Client()
        {
            
        }
        public async Task ConnectAsync()
        {
            client = new TcpClient();
            await client.ConnectAsync(host,port);
            var gs = client.GetStream();
            reader = new StreamReader(gs);
            writer = new StreamWriter(gs);
        }
        
        public async Task ListenAsync(ListBox box)
        {
            try
            {
                while (true)
                { 
                    string listenMessage = await reader.ReadLineAsync();
                    if (string.IsNullOrEmpty(listenMessage))
                        break;
                    box.Invoke(box.Items.Add, listenMessage);
                }
                await Close();
            }
            catch
            {
                return;
            }
        }
        public async Task SendMessageAsync(string message)
        {
            await writer.WriteLineAsync(message);
            await writer.FlushAsync();
        }
        public async Task Close()
        {
            writer.Close();
            reader.Close();
            client.Close();
        }










    }
}
