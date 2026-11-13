using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeVeiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgv_Exibir.DataSource = veiculos;
            comboBox1.Items.Add("Sul");
            comboBox1.Items.Add("Nordeste");
            comboBox1.Items.Add("Norte");
            comboBox1.Items.Add("Centro-Oeste");
            comboBox1.Items.Add("Sudeste");


        }

        List<Veiculo> veiculos = new List<Veiculo> {
                new Veiculo { Proprietario = "Daniel Garcia Felicione", Uf = "PR", Placa = "KSR4186", Ano = 2009, Valor = 38981.25m },
                new Veiculo { Proprietario = "Diogo Alvaro Moncorvo", Uf = "PA", Placa = "TTJ4272", Ano = 2020, Valor = 46706.84m },
                new Veiculo { Proprietario = "Margarida Viola", Uf = "SE", Placa = "VVP8541", Ano = 2020, Valor = 66619.84m },
                new Veiculo { Proprietario = "Juca Tabulante", Uf = "AL", Placa = "WAZ6638", Ano = 2014, Valor = 81805.14m },
                new Veiculo { Proprietario = "Rozalino Ritalino", Uf = "PA", Placa = "SOL8907", Ano = 2019, Valor = 87341.75m },
                new Veiculo { Proprietario = "Fizema Igarro", Uf = "AM", Placa = "TPM0299", Ano = 2008, Valor = 92779.49m },
                new Veiculo { Proprietario = "Luan Barros Cardoso", Uf = "AC", Placa = "TXX9773", Ano = 2007, Valor = 90532.24m },
                new Veiculo { Proprietario = "Vitor Santos Cunha", Uf = "PR", Placa = "GUJ7908", Ano = 2015, Valor = 29602.10m },
                new Veiculo { Proprietario = "Pragilda Lunataque", Uf = "CE", Placa = "WQE5478", Ano = 2025, Valor = 25309.94m },
                new Veiculo { Proprietario = "Isabela Correia Tavares", Uf = "RN", Placa = "YIE1472", Ano = 2010, Valor = 55688.43m },
                new Veiculo { Proprietario = "Juvenal Mosquera", Uf = "SC", Placa = "KZR8409", Ano = 2025, Valor = 33623.94m },
                new Veiculo { Proprietario = "Beatrice Araujo Oliveira", Uf = "PA", Placa = "TIX7965", Ano = 2016, Valor = 64637.62m },
                new Veiculo { Proprietario = "Felizbino Roncato", Uf = "MG", Placa = "BZA8226", Ano = 2019, Valor = 23297.58m },
                new Veiculo { Proprietario = "Filipe Cavaleiro Macedo", Uf = "AM", Placa = "PCB5870", Ano = 2024, Valor = 52244.92m },
                new Veiculo { Proprietario = "Gatunilda Amiuna", Uf = "SP", Placa = "AJC5158", Ano = 2021, Valor = 47959.39m },
                new Veiculo { Proprietario = "Piangela Alvira", Uf = "MS", Placa = "OOT6543", Ano = 2006, Valor = 11656.51m },
                new Veiculo { Proprietario = "Miguelito Fintara", Uf = "RO", Placa = "TOC2018", Ano = 2022, Valor = 86016.65m },
                new Veiculo { Proprietario = "Anna Dias Alves Botafogo", Uf = "PB", Placa = "YTH9800", Ano = 2006, Valor = 22061.91m },
                new Veiculo { Proprietario = "Patasquio Pataqua", Uf = "GO", Placa = "MGE3642", Ano = 2026, Valor = 67491.68m },
                new Veiculo { Proprietario = "Lartina Dumante", Uf = "SC", Placa = "KIY4682", Ano = 2024, Valor = 32851.45m },
                new Veiculo { Proprietario = "Faganeto Rogueti", Uf = "MT", Placa = "OVQ6787", Ano = 2010, Valor = 41499.14m },
                new Veiculo { Proprietario = "Rizonaldo Bino Aguado", Uf = "CE", Placa = "ZRY5626", Ano = 2011, Valor = 61699.43m },
                new Veiculo { Proprietario = "Jubiscleudo Longrazo", Uf = "AM", Placa = "RTL4580", Ano = 2019, Valor = 79872.36m },
                new Veiculo { Proprietario = "Bibiana Fitipalda", Uf = "AC", Placa = "REN2288", Ano = 2007, Valor = 41977.22m },
                new Veiculo { Proprietario = "Eudoxia Cangibrina", Uf = "PI", Placa = "WWB3905", Ano = 2024, Valor = 38437.98m },
                new Veiculo { Proprietario = "Astrogildo Samanco Castrol", Uf = "RN", Placa = "YLS7480", Ano = 2014, Valor = 19429.67m },
                new Veiculo { Proprietario = "Rizonaldo Demonte", Uf = "CE", Placa = "YOE8732", Ano = 2006, Valor = 60039.36m },
                new Veiculo { Proprietario = "Ariadne Vieira Nogueira", Uf = "SE", Placa = "ZXP1200", Ano = 2007, Valor = 49648.15m },
                new Veiculo { Proprietario = "Raquelina Albra", Uf = "BA", Placa = "WSK2124", Ano = 2025, Valor = 64235.53m },
                new Veiculo { Proprietario = "Julieta Costa Rocha", Uf = "PE", Placa = "YST2222", Ano = 2011, Valor = 19541.17m },
                new Veiculo { Proprietario = "Tebaldo Vilcar", Uf = "AC", Placa = "QEG9518", Ano = 2008, Valor = 13770.63m },
                new Veiculo { Proprietario = "Stenico Santana Garcia", Uf = "GO", Placa = "NUN6424", Ano = 2015, Valor = 42699.92m },
                new Veiculo { Proprietario = "Mayra Corrêa Agumari", Uf = "MG", Placa = "DXE8611", Ano = 2020, Valor = 56789.01m },
                new Veiculo { Proprietario = "Leticia Ramos Queiroz", Uf = "ES", Placa = "AJE9752", Ano = 2012, Valor = 43958.19m },
                new Veiculo { Proprietario = "Ademar Terentino", Uf = "BA", Placa = "XFM3032", Ano = 2014, Valor = 88373.20m },
                new Veiculo { Proprietario = "Bartina Lagame", Uf = "DF", Placa = "NEF3603", Ano = 2020, Valor = 58386.87m },
                new Veiculo { Proprietario = "Cleriton Savio Santos", Uf = "SP", Placa = "FJY3261", Ano = 2025, Valor = 15596.22m },
                new Veiculo { Proprietario = "Raquel Gusmão Pacheco", Uf = "PI", Placa = "VZP3501", Ano = 2025, Valor = 74463.85m },
                new Veiculo { Proprietario = "Alairton Masquero", Uf = "AC", Placa = "QTK5008", Ano = 2017, Valor = 48345.35m },
                new Veiculo { Proprietario = "Matusalem Giodize", Uf = "TO", Placa = "RNA6444", Ano = 2019, Valor = 61682.70m },
                new Veiculo { Proprietario = "Ursula Cavasca", Uf = "MA", Placa = "YBX1772", Ano = 2016, Valor = 88119.25m },
                new Veiculo { Proprietario = "Chica da Silva Mirante", Uf = "RR", Placa = "TJH4612", Ano = 2006, Valor = 35186.89m },
                new Veiculo { Proprietario = "Marcos Barbosa Castro Neves", Uf = "SC", Placa = "KSM9215", Ano = 2017, Valor = 88596.91m },
                new Veiculo { Proprietario = "Felizberto Dalemar", Uf = "MS", Placa = "LAC6742", Ano = 2025, Valor = 26075.74m },
                new Veiculo { Proprietario = "Sulivan Mastroiane", Uf = "AC", Placa = "SUK7109", Ano = 2009, Valor = 43299.32m },
                new Veiculo { Proprietario = "Tiburcio Coiote", Uf = "RJ", Placa = "EHI2736", Ano = 2021, Valor = 88986.91m },
                new Veiculo { Proprietario = "Melissa Alessandra Barros", Uf = "GO", Placa = "LOF4192", Ano = 2019, Valor = 66469.54m },
                new Veiculo { Proprietario = "Eleni Magalhães Peres", Uf = "PE", Placa = "WNU6726", Ano = 2010, Valor = 71582.34m },
                new Veiculo { Proprietario = "Tormentina Mianto", Uf = "MA", Placa = "TSN0581", Ano = 2008, Valor = 83955.95m },
                new Veiculo { Proprietario = "Idalino Tobiara", Uf = "AP", Placa = "QAQ7005", Ano = 2017, Valor = 94383.44m },
                new Veiculo { Proprietario = "Marcio Da Costa Batista", Uf = "CE", Placa = "UTN2372", Ano = 2011, Valor = 95936.65m },
                new Veiculo { Proprietario = "Sara Casagrande Barichelo", Uf = "AC", Placa = "SRY3150", Ano = 2008, Valor = 20743.74m },
                new Veiculo { Proprietario = "Rodrigo de Paula Benito", Uf = "RR", Placa = "QEZ1450", Ano = 2010, Valor = 38045.14m },
                new Veiculo { Proprietario = "Nelson Pascoal Aguiar", Uf = "RN", Placa = "WZW8707", Ano = 2020, Valor = 80291.94m },
                new Veiculo { Proprietario = "Agenor Apolinario Dantas", Uf = "RS", Placa = "IMN9818", Ano = 2025, Valor = 62075.20m },
                new Veiculo { Proprietario = "Dafra Topata", Uf = "RN", Placa = "ZXU9197", Ano = 2021, Valor = 79692.24m },
                new Veiculo { Proprietario = "Napoleão Bolivar", Uf = "DF", Placa = "LRY6686", Ano = 2011, Valor = 36480.61m },
                new Veiculo { Proprietario = "Cremilda Tutibona", Uf = "BA", Placa = "XNY1028", Ano = 2021, Valor = 89792.33m },
                new Veiculo { Proprietario = "Reginaldo Antenor TerrAnobre", Uf = "RO", Placa = "RCG4009", Ano = 2019, Valor = 21246.64m }
        };



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string regiao = comboBox1.SelectedItem.ToString().ToLower();



        }

        //recebe os estados -> filtra -> exibe no gridview
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FiltrarRegiao(object sender, EventArgs e)
        {


            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma região para filtrar.");
                return;
            }

            string regiaoAtual = comboBox1.Text.ToLower();
            string[] estados = { };
            List<Veiculo> veiculosFiltrados = new List<Veiculo>();



            switch (regiaoAtual)

            {
                case "norte":
                    estados = new string[] { "AC", "AP", "AM", "PA", "RO", "RR", "TO" };

                    veiculosFiltrados = veiculos.FindAll(i => estados.Contains(i.Uf));
                    dgv_Exibir.DataSource = veiculosFiltrados;
                    break;


                case "nordeste":
                    estados = new string[] { "AL", "BA", "CE", "MA", "PB", "PE", "PI", "RN", "SE" };


                    veiculosFiltrados = veiculos.FindAll(i => estados.Contains(i.Uf));
                    dgv_Exibir.DataSource = veiculosFiltrados;
                    break;



                case "centro-oeste":
                    estados = new string[] { "DF", "GO", "MT", "MS" };

                    veiculosFiltrados = veiculos.FindAll(i => estados.Contains(i.Uf));
                    dgv_Exibir.DataSource = veiculosFiltrados;
                    break;

                case "sudeste":
                    estados = new string[] { "ES", "MG", "RJ", "SP" };

                    veiculosFiltrados = veiculos.FindAll(i => estados.Contains(i.Uf));
                    dgv_Exibir.DataSource = veiculosFiltrados;
                    break;

                case "sul":
                    estados = new string[] { "PR", "SC", "RS" };

                    veiculosFiltrados = veiculos.FindAll(i => estados.Contains(i.Uf));
                    dgv_Exibir.DataSource = veiculosFiltrados;
                    break;

                default:
                    Console.WriteLine("Região inválida!");
                    return;
            }

            Console.WriteLine("Região selecionada: " + regiaoAtual);

        }




        private void ExibirDados(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_calcularImposto(object sender, EventArgs e)
        {

            
         
            // Percorre todos os veículos da lista geral
            var resultadoComImposto = veiculos.Select(v => {
                decimal percentual = 0;
                int idadeLimite = 0;
              
                DateTime data = DateTime.Now;
                int anoAtual = data.Year;
                int idade = anoAtual - v.Ano;


                // Identifica o percentual com base na UF do veículo
                if (new string[] { "PR", "SC", "RS" }.Contains(v.Uf))
                {
                    percentual = 0.035m; // Sul (3,5%)
                    idadeLimite = 12;
                }
                else if (new string[] { "ES", "MG", "RJ", "SP" }.Contains(v.Uf))
                {
                    percentual = 0.045m; // Sudeste (4,5%)
                    idadeLimite = 14;
                }
                else if (new string[] { "DF", "GO", "MT", "MS" }.Contains(v.Uf))
                {
                    percentual = 0.052m; // Centro-Oeste (5,2%)
                    idadeLimite = 16;
                }
                else if (new string[] { "AC", "AP", "AM", "PA", "RO", "RR", "TO" }.Contains(v.Uf))
                {
                    percentual = 0.048m; // Norte (4,8%)
                    idadeLimite = 11;
                }
                else if (new string[] { "AL", "BA", "CE", "MA", "PB", "PE", "PI", "RN", "SE" }.Contains(v.Uf))
                {
                    percentual = 0.049m; // Nordeste (4,9%)
                    idadeLimite = 15;
                }

                // Calcula o valor do imposto (supondo que seu objeto Veiculo tenha uma propriedade 'Valor')
                decimal valorImposto = v.Valor * percentual;

                // Retorna um objeto organizando as colunas (a 6ª será o valor do imposto)
                return new
                {
                    v.Proprietario,   // 1ª Coluna (exemplo)
                    v.Uf,    // 2ª Coluna (exemplo)
                    v.Placa,      // 3ª Coluna (exemplo)
                    v.Ano,       // 4ª Coluna (exemplo)
                    v.Valor,    // 5ª Coluna (exemplo)
                    Imposto = v.Valor <= 20000 ? "Isento" : idade>=idadeLimite ? "Insento":(valorImposto).ToString("C2", new CultureInfo("pt-BR"))
                };
            }).ToList();

            // Joga o resultado no DataGridView
     
            dgv_Exibir.DataSource = resultadoComImposto;
        
    }
    
    
    }

}
