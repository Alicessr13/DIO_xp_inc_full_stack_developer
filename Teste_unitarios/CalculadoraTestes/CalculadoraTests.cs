using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    //instanciando calculadora
    private CalculadoraImp _calc;

    public CalculadoraTests(){
        _calc = new CalculadoraImp();
    }

    [Fact] //significa que esse código e uma cenario de testes, precisa ter para reconhecer como um teste
    public void DeveSomar5com10eRetornar15() //metodo que valida o teste, deixar nome bem descritivo
    {
        //Arrange, serve para montar o cenario de teste, o que precisa passar par realizar o teste
        int num1 = 5;
        int num2 = 10;

        //Act, serve para executar a ação do teste baseado no cenário (somar)
        int resultado = _calc.Somar(num1, num2); //chamado o somar e retornando na váriavel

        //Assert, valida se o teste tem o resultado esperado
        //resultado esperado = 15;
        Assert.Equal(15, resultado); //compara se o valor esperado é igual ao valor atual(se 15 e igual ao resultado)
    }

    [Fact] //significa que esse código e uma cenario de testes, precisa ter para reconhecer como um teste
    public void DeveSomar10com10eRetornar20() //metodo que valida o teste, deixar nome bem descritivo
    {
        //Arrange, serve para montar o cenario de teste, o que precisa passar par realizar o teste
        int num1 = 10;
        int num2 = 10;

        //Act, serve para executar a ação do teste baseado no cenário (somar)
        int resultado = _calc.Somar(num1, num2); //chamado o somar e retornando na váriavel

        //Assert, valida se o teste tem o resultado esperado
        //resultado esperado = 15;
        Assert.Equal(20, resultado); //compara se o valor esperado é igual ao valor atual(se 20 e igual ao resultado)
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        // Given
        int numero = 4;

        // When
        bool resultado = _calc.EhPar(numero);

        // Then
        Assert.True(resultado); //verifica se é verdadeiro, tem a opção false também
    }

    [Theory] //conjunto de cenarios que vão passar pelo mesmo teste
    [InlineData(new int [] {2, 4})] //passar um inlinedata para cada cenario de teste, 
    //executa o metodo de teste para cada inlinedata com o valor, o retorno precisa ser o mesmo para o teste dar certo
    [InlineData(new int [] {6, 8, 10})] 
    //[InlineData(4)]
    //[InlineData(6)]
    //[InlineData(8)]
    //[InlineData(10)]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int [] numeros) //recebe os valores do inlinedata como parametro
    {
        // Given

        // When
        //bool resultado = _calc.EhPar(numero);
    
        // Then
        //Assert.True(resultado);

        Assert.All(numeros, num => Assert.True(_calc.EhPar(num))); //assert.all = valida todos os elementos do array
        //recebe o parametro o array, e depois a ação, num = elemento atual do laço de repetição, passa o num pelo Ehpar e verifica se é true
    }
}