using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.Threading;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.IO.Compression;


namespace ContentApiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ImportaConteudo_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            ObtendoInfo form = new ObtendoInfo();

            form.Show();

                string endereco = client.DownloadString("https://api-content.ingresso.com/v0/templates/highlights/1/partnership/home");

                dynamic contbody = JsonConvert.DeserializeObject<dynamic>(endereco);

                txtConteudo.Text = endereco;

            form.Close();

        }

        private void ExportaExcel_Click(object sender, EventArgs e)
        {


            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;

            excel.Visible = true;

            ws.Cells[1, 1] = "Dados da Conteudo";
            ws.Cells[2, 1] = txtConteudo.Text;

        }

        private void Compactar_Click(object sender, EventArgs e)
        {
            string[] arquivo = {txtConteudo.Text};
            string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (StreamWriter envia = new StreamWriter(Path.Combine(dirPath, "Compactado.txt")))
            {
                foreach (string line in arquivo)
                    envia.WriteLine(line);
            }

            string startPath = dirPath;
            string zipPath = dirPath;

            try
            {

                ZipFile.CreateFromDirectory(startPath, zipPath);
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}