namespace CalculadoraConsole;

public class CalculadoraMetodos
{
	private readonly List<string> _historico;

        public CalculadoraMetodos()
        {
            _historico = new List<string>();
        }

        public double Adicao(double a, double b)
        {
            double resultado = a + b;
            AdicionarAoHistorico($"Adição: {a} + {b} = {resultado}");
            return resultado;
        }

        public double Subtracao(double a, double b)
        {
            double resultado = a - b;
            AdicionarAoHistorico($"Subtração: {a} - {b} = {resultado}");
            return resultado;
        }

        public double Multiplicacao(double a, double b)
        {
            double resultado = a * b;
            AdicionarAoHistorico($"Multiplicação: {a} * {b} = {resultado}");
            return resultado;
        }

        public double Divisao(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Erro: Divisão por zero!");
            }
            double resultado = a / b;
            AdicionarAoHistorico($"Divisão: {a} / {b} = {resultado}");
            return resultado;
        }

        private void AdicionarAoHistorico(string operacao)
        {
            if (_historico.Count == 3)
            {
                _historico.RemoveAt(0);
            }
            _historico.Add(operacao);
        }

        public IEnumerable<string> ObterHistorico()
        {
            return _historico;
        }
}
