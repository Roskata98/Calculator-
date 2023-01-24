
using SuperSimpleTcp;
using System.Data;
using System.Text;

namespace TCP_Server
{
    public partial class ServerSide : Form
    {
        Calculator calculator;
        ExpressionEvaluator exev;
        public ServerSide()
        {
            InitializeComponent();
            Stopserverbtn.Visible=false;
            calculator = new Calculator();
            exev= new ExpressionEvaluator();
            this.Testing();
        }
        SimpleTcpServer server;

        private void StartServerbtn_Click(object sender, EventArgs e)
        {
            server.Start();
            InfoListbox.Items.Add("Server is started");
            StartServerbtn.Visible = false;
            Stopserverbtn.Visible = true;
            InfoListbox.Items.Add("Server is running...");

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer(ServerIPtxtb.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                string datafromclient = Encoding.ASCII.GetString(e.Data);
                int result = calculator.Calculate(datafromclient);
                InfoListbox.Items.Add("IP:" + e.IpPort + " has a request: " + datafromclient);
                if (server.IsListening)
                {
                    if (result != null)
                    {
                        InfoListbox.Items.Add("IP:"+ e.IpPort+ " has a result: " + result );
                        server.Send(e.IpPort, result.ToString());
                    }
                }
            });            
        }

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                ListBoxConnectionsClients.Items.Add(e.IpPort + " has disconnected");
            });                       
        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                ListBoxConnectionsClients.Items.Add(e.IpPort +" has connected");
            });
        }

        private void Stopserverbtn_Click(object sender, EventArgs e)
        {
            server.Stop();
            InfoListbox.Items.Add("Server is stoped");
            StartServerbtn.Visible = true;
            Stopserverbtn.Visible = false;
        }
        public void Testing()
        {
            string exampledata = "2+3";
            string exampledata2 = "1 + (2 * 3 - (4 / 2))";
            //int testresult = calculator.Calculate(exampledata2);
            int testresult = Convert.ToInt32(exev.Evaluate(exampledata));
            if (testresult != 5)
            {
                throw new Exception();
            }
        }
    }
}