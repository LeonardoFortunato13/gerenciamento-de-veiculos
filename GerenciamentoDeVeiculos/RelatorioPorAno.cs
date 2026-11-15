using System.Collections.Generic;

namespace GerenciamentoDeVeiculos
{
    // Resolve os itens 3 e 4 do enunciado (consultas pelo ano de fabricação).
    // A classe só calcula e RETORNA os dados; quem exibe é a tela (Form1).
    public class RelatorioPorAno
    {
        // a lista fica private: só esta classe mexe nela
        private List<Veiculo> veiculos;

        // recebe a lista de veículos uma vez, na criação do objeto
        public RelatorioPorAno(List<Veiculo> veiculos)
        {
            this.veiculos = veiculos;
        }

        // 3) Lista os registros de um determinado ano
        public List<Veiculo> FiltrarPorAno(int ano)
        {
            List<Veiculo> resultado = new List<Veiculo>();
            foreach (Veiculo v in veiculos)
            {
                if (v.Ano == ano) resultado.Add(v);   // é do ano pedido? entra no resultado
            }
            return resultado;
        }

        // 4.1) Ano do carro mais novo (o maior ano)
        public int AnoMaisNovo()
        {
            int maisNovo = veiculos[0].Ano;            // começa supondo que o 1º é o mais novo
            foreach (Veiculo v in veiculos)
            {
                if (v.Ano > maisNovo) maisNovo = v.Ano;   // achou um ano maior? vira o novo recorde
            }
            return maisNovo;
        }

        // 4.2) Ano do carro mais velho (o menor ano)
        public int AnoMaisVelho()
        {
            int maisVelho = veiculos[0].Ano;
            foreach (Veiculo v in veiculos)
            {
                if (v.Ano < maisVelho) maisVelho = v.Ano;  // achou um ano menor? vira o novo recorde
            }
            return maisVelho;
        }

        // 4.3) Usando 4.1 e 4.2, conta quantos carros foram fabricados em cada ano,
        //      do mais velho ao mais novo (anos sem nenhum carro aparecem com 0)
        public List<FrequenciaAno> FrequenciaPorAno()
        {
            int maisVelho = AnoMaisVelho();
            int maisNovo = AnoMaisNovo();

            List<FrequenciaAno> relatorio = new List<FrequenciaAno>();

            for (int ano = maisVelho; ano <= maisNovo; ano++)   // passa por cada ano do intervalo
            {
                int quantidade = 0;
                foreach (Veiculo v in veiculos)
                {
                    if (v.Ano == ano) quantidade++;              // carro deste ano? soma 1
                }
                relatorio.Add(new FrequenciaAno(ano, quantidade));
            }

            return relatorio;
        }
    }

    // Uma linha do relatório de frequência (4.3): o ano e a quantidade de carros.
    // É uma classe (e não um Dictionary) para poder ser exibida direto no DataGridView.
    public class FrequenciaAno
    {
        public int Ano { get; set; }
        public int Quantidade { get; set; }

        public FrequenciaAno(int ano, int quantidade)
        {
            Ano = ano;
            Quantidade = quantidade;
        }
    }
}
