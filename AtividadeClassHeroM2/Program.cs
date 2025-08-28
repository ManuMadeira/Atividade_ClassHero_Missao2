///Corrija os erros no seguinte bloco de código: 
/// string nome = 'João';
/// int valorProduto = 29,99; 
/// char resposta = /// "S". 
/// Explique as correções feitas e exiba os valores no console.
internal class Program
{
    private static void Main(string[] args)
    {
        string nome ="João"; // Troquei as aspas simples por aspar duplas
        float valorProduto = 29.99f; // <-- trocar int pra float pois nao e um numero inteiro, tem um nome especifico pra isso mas nao lembro no momento
        char resposta = 'S'; // Troquei as aspara duplas por simples

        Console.WriteLine("Nome: "+ nome);
        Console.WriteLine("Valor do produto:"+ valorProduto);
        Console.WriteLine("Resposta: "+ resposta);
    }
}