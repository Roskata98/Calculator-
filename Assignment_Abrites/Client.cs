using SuperSimpleTcp;
using System.Text;

namespace Assignment_Abrites
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            Result_Textbox.Visible = false;
            Problem_Textbox.Visible = false;
            labelproblem.Visible = false;
            labelresult.Visible = false;
            client = new(IPtxb.Text);
            Calculatebtn.Visible = false;
            Deletebtn.Visible = false;
            Disconnectbtn.Visible = false; 
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;
        }

        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {

            this.Invoke((MethodInvoker)delegate
            {
                MessageBox.Show("!!!Disonnected!!!", "Status", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                Result_Textbox.Visible = false;
                Problem_Textbox.Visible = false;
                labelproblem.Visible = false;
                labelresult.Visible = false;
                Calculatebtn.Visible = false;
                Deletebtn.Visible = false;
                Disconnectbtn.Visible = false;
                Connectbtn.Visible = true;
            });          
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                string datafromclient = Encoding.ASCII.GetString(e.Data);
                Result_Textbox.Text = datafromclient;
            });
           
        }

        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                MessageBox.Show("Connected", "Status", MessageBoxButtons.OK);
                Result_Textbox.Visible = true;
                Problem_Textbox.Visible = true;
                Calculatebtn.Visible = true;
                labelproblem.Visible = true;
                labelresult.Visible = true;
                Connectbtn.Visible = false;
                Deletebtn.Visible = true;
                Disconnectbtn.Visible = true;
            });            
        }

        private void Calculatebtn_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                var bytesofstring=System.Text.ASCIIEncoding.Unicode.GetByteCount(Problem_Textbox.Text);
                //int bytes = Problem_Textbox.Text.Length * sizeof(char);
                if (bytesofstring <= 1024)
                {
                    if (Problem_Textbox.Text != null)
                    {
                        client.Send(Problem_Textbox.Text.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Your Textbox is empty or has invalid symbols!");
                    }
                }
                else
                {
                    MessageBox.Show("Your string is more than 1 MB !!!");
                }
            }
            else
            {
                MessageBox.Show("You are not connected with the server");
            }
        }

        private void Connectbtn_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Problem_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Problem_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^\-^*^/^(^)^]") && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            Problem_Textbox.Text = "";
            Result_Textbox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}