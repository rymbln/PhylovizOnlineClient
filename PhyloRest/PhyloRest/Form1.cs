using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using System.Net.Http.Headers;
using System.Net;
using Newtonsoft.Json.Linq;

namespace PhyloRest
{
    public partial class Form1 : Form
    {
     
        private string datasetId = "";
    

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenProfiles_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.tbxProfiles.Text = openFileDialog1.FileName;
            }
        }

        private void btnOpenAux_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.tbxAux.Text = openFileDialog1.FileName;
            }
        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            datasetId = await PhylovizClient.Upload(tbxLogin.Text, tbxPass.Text, tbxProfiles.Text, tbxAux.Text);
            textBox1.Text = datasetId;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            tbxLogin.Text = "demo";
            tbxPass.Text = "demo";
            textBox1.Text =  await PhylovizClient.Login(tbxLogin.Text, tbxPass.Text);
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            datasetId = await PhylovizClient.GoeBurst(datasetId);
            textBox1.Text = "https://online.phyloviz.net/main/dataset/" + datasetId;
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = await PhylovizClient.MakeVisible(datasetId);
        }

        private async void button5_Click(object sender, EventArgs e)
        {
           textBox1.Text = await PhylovizClient.MakeLink(datasetId);
        }
    }
}
