using CalculadoraConsole;
using Xunit;

namespace Calculadora.Tests;
public class CalculadoraTests

{
    private readonly CalculadoraMetodos _calculadora;

        public CalculadoraTests()
        {
            _calculadora = new CalculadoraMetodos();
        }

        [Fact]
        public void Adicao_DeveRetornarResultadoCorreto()
        {
            double resultado = _calculadora.Adicao(5, 3);
            Assert.Equal(8, resultado);
        }

        [Fact]
        public void Subtracao_DeveRetornarResultadoCorreto()
        {
            double resultado = _calculadora.Subtracao(5, 3);
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Multiplicacao_DeveRetornarResultadoCorreto()
        {
            double resultado = _calculadora.Multiplicacao(5, 3);
            Assert.Equal(15, resultado);
        }

        [Fact]
        public void Divisao_DeveRetornarResultadoCorreto()
        {
            double resultado = _calculadora.Divisao(6, 3);
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Divisao_DivisaoPorZero_DeveLancarExcecao()
        {
            Assert.Throws<DivideByZeroException>(() => _calculadora.Divisao(6, 0));
        }

        [Fact]
        public void Historico_DeveConterApenasUltimasTresOperacoes()
        {
            _calculadora.Adicao(1, 1);
            _calculadora.Subtracao(2, 1);
            _calculadora.Multiplicacao(2, 2);
            _calculadora.Divisao(4, 2);

            var historico = _calculadora.ObterHistorico().ToList();

            Assert.Equal(3, historico.Count);
            Assert.DoesNotContain("Adição: 1 + 1 = 2", historico);
        }
    }