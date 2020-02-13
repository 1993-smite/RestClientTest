using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebClientTestRestApi;

namespace RestClientFormTest
{
    public partial class MainRestClientForm : Form
    {
        private int _urlIndex = 0;
        private int _statusIndex = 1;
        private int _lengthIndex = 2;

        public MainRestClientForm()
        {
            InitializeComponent();
        }

        private void MainRestClientForm_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("source.txt"))
            {
                while (!sr.EndOfStream)
                {
                    urlList.Rows.Add(sr.ReadLine());
                }
            }

        }

        private void CheckUrls()
        {
            BasicAuthWebClientTest restApi = new BasicAuthWebClientTest(new BasicAuthUser("avsasov", "090693"));
            for (int i = 0; i < urlList.Rows.Count; i++)
            {
                var res = restApi.GetRequest((string) urlList.Rows[i].Cells[_urlIndex].Value);
                urlList.Rows[i].Cells[_statusIndex].Value = res.StatusCode;
                urlList.Rows[i].Cells[_lengthIndex].Value = 100;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckUrls();
        }
    }
}
