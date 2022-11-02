using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao08
{
    internal class Banco_
    {
        private double _valorInvestido;
        private double _taxaJuros;
        private double _valorAtual;
        private double _mes;
        private double _rendimentoMensal;
        private double _resgate;
        private double _rendaLiquida;

        public Banco_(double valor, double taxa)
        {
            _valorInvestido = valor;
            _taxaJuros = taxa;
            _valorAtual = _valorInvestido;
        }

        public void RendeMes()
        {
            _mes++;
            CalculaRendimento();
        }

        public void RendePeriodo(double dias)
        {
            double periodo = dias / 30;
            _valorAtual *= Math.Pow((1 + (_taxaJuros / 100)),periodo);
            _rendimentoMensal = _valorAtual - _valorInvestido - _rendaLiquida;
            _rendaLiquida += _rendimentoMensal;
            _mes += periodo;
            Console.WriteLine(this);
        }
        private void CalculaRendimento() 
        {
            _valorAtual *= (1 + (_taxaJuros / 100));
            _rendimentoMensal = _valorAtual - _valorInvestido - _rendaLiquida;
            _rendaLiquida += _rendimentoMensal;
            if (_mes == 5) 
            {
                _resgate = _rendimentoMensal;
                _valorAtual -= _resgate;
                _rendaLiquida -= _resgate;
            }
            Console.WriteLine(this);
            _resgate = 0.0;
        }

        public void PrintaTabela() 
        {
            Console.WriteLine(" ____________________________________________________________________________________________________________________________________");
            Console.WriteLine("| valor Investido | Taxa de Juros   | Periodo(a.m)    |  Valor Atual       | Rendimento(a.m)  |  Resgate        |  RendaL(a.m)       |");
            Console.WriteLine("|_________________|_________________|_________________|____________________|__________________|_________________|____________________|");

        }
        public override string ToString()
        {
            return
                "|______"
                 + _valorInvestido.ToString("#,##")
                 + "______|______ "
                 + _taxaJuros.ToString("F2", CultureInfo.InvariantCulture)
                 + "%______|______ "
                 + _mes.ToString("F2", CultureInfo.InvariantCulture)
                 + "______|______ "
                 + _valorAtual.ToString("F2", CultureInfo.InvariantCulture)
                 + "______|______ "
                 + _rendimentoMensal.ToString("F2", CultureInfo.InvariantCulture)
                 + "______|______ "
                 + _resgate.ToString("F2", CultureInfo.InvariantCulture) 
                 + "______|______ "
                 + _rendaLiquida.ToString("F2", CultureInfo.InvariantCulture)
                 + "______|"
                 +  " ";
        }



    }
}
