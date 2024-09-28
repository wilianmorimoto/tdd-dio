using ProjetoCalculadora;

namespace ProjetoCalculadoraTestes;

public class UnitTest1
{
    public Calculadora ConstruirClasse()
    {
        string data = "02/02/2020";
        Calculadora calc = new(data);

        return calc;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TestSomar(int n1, int n2, int res)
    {
        Calculadora calc = ConstruirClasse();

        int result = calc.Somar(n1, n2);

        Assert.Equal(res, result);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(40, 5, 35)]
    public void TestSubtrair(int n1, int n2, int res)
    {
        Calculadora calc = ConstruirClasse();

        int result = calc.Subtrair(n1, n2);

        Assert.Equal(res, result);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TestMultiplicar(int n1, int n2, int res)
    {
        Calculadora calc = ConstruirClasse();

        int result = calc.Multiplicar(n1, n2);

        Assert.Equal(res, result);
    }

    [Theory]
    [InlineData(4, 2, 2)]
    [InlineData(20, 5, 4)]
    public void TestDividir(int n1, int n2, int res)
    {
        Calculadora calc = ConstruirClasse();

        int result = calc.Dividir(n1, n2);

        Assert.Equal(res, result);
    }

    [Fact]
    public void TestDividirPorZero()
    {
        Calculadora calc = ConstruirClasse();

        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }

    [Fact]
    public void TestHistorico()
    {
        Calculadora calc = ConstruirClasse();

        calc.Somar(1, 2);
        calc.Somar(3, 3);
        calc.Somar(8, 4);
        calc.Somar(7, 5);

        var list = calc.Historico();

        Assert.NotEmpty(list);
        Assert.Equal(3, list.Count());
    }
}