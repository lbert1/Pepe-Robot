using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pepe
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //METODO PARA BUSCAR E PREENCHER AS COTAÇÕES DO DATAGRIDVIEW
        public void GetQuotes()
        {
            Robot robot = new Robot();
            MethodInvoker invPBarStart = delegate
             {
                //ZERAR BARRA DE PROGRESSO
                pBar.Value = 0;
                //DEFININDO VALOR DA BARRA DE PROGRESSO
                pBar.Maximum = dgvMain.RowCount;
                //PERCORRER REGISTROS DO DATAGRIDVIEW
            };
            Invoke(invPBarStart);

            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                MethodInvoker invDgvStart = delegate
                {
                    //TRAVAR ADICONAR NO DATAGRIDVIEW
                    dgvMain.AllowUserToAddRows = false;            
                };
                Invoke(invDgvStart);
                string codActive = row.Cells[0].Value.ToString();
                //MONTAR URL DE NAVEGAÇÃO COM CÓDIGO OBTIDO
                string url = "https://www.fundamentus.com.br/detalhes.php?papel=" + codActive;
                //NAVEGAR PARA SITE (URL)
                robot.GoToUrl(url);
                //PREENCHER COLUNA DO DATAGRIDVIEW COM A COTAÇÃO OBTIDA NO SITE
                row.Cells[1].Value = robot.ReadByXPath("/html/body/div[1]/div[2]/table[1]/tbody/tr[1]/td[4]/span", "innerHTML");
                //INCREMENTAR BARRA DE PROGRESSO
                MethodInvoker invPBarStep = delegate
                {
                    pBar.PerformStep();
                };
                Invoke(invPBarStep);
            }
            //FECHAR ROBO
            robot.RobotQuit();
            MethodInvoker invDgvEnd = delegate
            {            
                //HABILITAR DATAGRIDVIEW
                dgvMain.AllowUserToAddRows = true;
            };
            Invoke(invDgvEnd);
        }

        private async void bntPlay_Click(object sender, EventArgs e)
        {
            await Task.Run(() => GetQuotes());
        }

    }
}
