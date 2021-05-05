using Cambios.Servicos;
using Cambios.Modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cambios
{
    public partial class Form1 : Form
    {
        #region Atributos

        private List<Rate> Rates;

        private NetworkService networkService;

        private ApiService apiService;

        private DialogService dialogService;

        private DataService dataService;




        #endregion

        #region Propriedades

       

        #endregion

        public Form1()
        {
            InitializeComponent();
            networkService = new NetworkService();
            apiService = new ApiService();
            dialogService = new DialogService();
            dataService = new DataService();
            LoadRates();
        }

        private async void LoadRates()
        {
             bool load;

            lbl_resultado.Text = "A atualizar taxas....";

            var connection = networkService.checkConnection();

            if (!connection.IsSucess)
            {

                LoadLocalRates();
                load = false;
                
            }
            else
            {
                await LoadApiRates();
                load = true;
            }

            if(Rates.Count == 0)
            {
                lbl_resultado.Text =    "Não há ligação á internet" +
                                        Environment.NewLine + "e não foram prévimente carregadas" +
                                        Environment.NewLine + "Tente novamente mais tarde!";

                lbl_status.Text = "Primeira inicialização deverá ter ligação á internet";

                return;
           
            }
  
            cb_origem.DataSource = Rates;
            cb_origem.DisplayMember = "Name";

            //Dividir os valores das ComboBox - corrige bug microsoft
            cb_destino.BindingContext = new BindingContext();

            cb_destino.DataSource = Rates;
            cb_destino.DisplayMember = "Name";

           

            lbl_resultado.Text = "Taxas atualizadas...";

            if (load)
            {
                lbl_status.Text = string.Format("Taxas carregadas da internet em {0:f}", DateTime.Now);
            }
            else
            {
                lbl_status.Text = string.Format("Taxas carregadas da Base de Dados.");
            }

            ProgressBar1.Value = 100;

            btn_converter.Enabled = true;
            btn_troca.Enabled = true;
        }

        private void LoadLocalRates()
        {
           Rates =  dataService.GetData();
        }

        private async Task LoadApiRates()
        {
            ProgressBar1.Value = 0;

            var response = await apiService.GetRates("http://cambios.somee.com", "/api/rates");

            Rates = (List<Rate>) response.Result;

            dataService.DeleteData();

            dataService.SaveData(Rates);

            
        }

        private void btn_converter_Click(object sender, EventArgs e)
        {
            Converter();
        }

        private void Converter()
        {
            if (string.IsNullOrEmpty(txt_valor.Text))
            {
                dialogService.ShowMessage("Erro","Insira um valor a converter");
                return;
            }

            decimal valor;
            if(!decimal.TryParse(txt_valor.Text, out valor))
            {
                dialogService.ShowMessage("Erro de conversão", "Valor terá que ser numérico");
                return;
            }

            if(cb_origem.SelectedItem == null)
            {
                dialogService.ShowMessage("Erro"," Tem que escolher uma moeda a converter");
                return;
            }
            if (cb_destino.SelectedItem == null)
            {
                dialogService.ShowMessage("Erro", " Tem que escolher uma moeda de destino para converter");
                return;
            }

            var taxaOrigem = (Rate)cb_origem.SelectedItem;

            var taxtaDestino = (Rate)cb_destino.SelectedItem;

            var valorConvertido = valor / (decimal)taxaOrigem.TaxRate * (decimal)taxtaDestino.TaxRate;

            lbl_resultado.Text = string.Format("{0} {1:C2} = {2} {3:C2}", taxaOrigem.Code, valor,taxtaDestino.Code, valorConvertido);
        }

        private void btn_troca_Click(object sender, EventArgs e)
        {
            Troca();
        }

        private void Troca()
        {
            var aux = cb_origem.SelectedItem;
            cb_origem.SelectedItem = cb_destino.SelectedItem;
            cb_destino.SelectedItem = aux;
            Converter();
        }
    }
}
