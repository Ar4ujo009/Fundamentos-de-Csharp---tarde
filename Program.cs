// //Exercício 1 - Calculando uma compra

// using System.ComponentModel;
// using System.Net;

// Console.WriteLine("Digite o nome do produto: ");
// string nomeProduto = Console.ReadLine();

// Console.WriteLine("Digite o preço do produto: ");
// string valorString = Console.ReadLine();

// if (decimal.TryParse(valorString, out decimal valorProduto))
// {
//     Console.WriteLine("Digite a quantidade do produto: ");
//     string quantidadeString = Console.ReadLine();

//     if (int.TryParse(quantidadeString, out int quantidadeProduto))
//     {
//         decimal totalCompra = valorProduto * quantidadeProduto;
//         Console.WriteLine($"O total da compra de {quantidadeProduto} unidades do produto {nomeProduto} é: R$ {totalCompra}");
//     }
//     else
//     {
//         Console.WriteLine("Quantidade inserida inválida!");
//     }
// }
// else
// {
//     Console.WriteLine("Valor inserido inválido!");
// };

// //Exercício 2 - Classificacao de notas

// Console.WriteLine("Digite o nome do aluno: ");
// string nomeAluno = Console.ReadLine();

// if(!string.IsNullOrWhiteSpace(nomeAluno))
// {
//     Console.WriteLine("Digite a nota do aluno: ");
//     string notaString = Console.ReadLine();

//     if (decimal.TryParse(notaString, out decimal notaAluno))
//     {
//         if (notaAluno >= 7)
//         {
//             Console.WriteLine($"O aluno {nomeAluno} foi aprovado com a nota {notaAluno}!");
//         }
//         else
//         {
//             Console.WriteLine($"O aluno {nomeAluno} foi reprovado com a nota {notaAluno}!");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Nota inserida inválida!");
//     }
// }
// else
// {
//     Console.WriteLine("Nome do aluno inválido!");
// }

// //Exercício 3 - Advinhação de número


// int numeroSecreto = new Random().Next(1, 101);

// int tentativa;

// bool acerto = false;

// while (!acerto)
// {
//     Console.WriteLine("Digite um número entre 1 e 100: ");
//     string tentativaString = Console.ReadLine();
//     if (int.TryParse(tentativaString, out tentativa))
//     {
//         if (tentativa < 1 || tentativa > 100)
//         {
//             Console.WriteLine("Número fora do intervalo permitido!");
//             continue;
//         }

//         if (tentativa == numeroSecreto)
//         {
//             Console.WriteLine("Parabéns! Você acertou o número secreto!");
//             acerto = true;
//         }
//         else if (tentativa < numeroSecreto)
//         {
//             Console.WriteLine("O número secreto é maior. Tente novamente.");
//         }
//         else
//         {
//             Console.WriteLine("O número secreto é menor. Tente novamente.");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Entrada inválida! Por favor, digite um número válido.");
//     }
// }

// // Exercício 4 - Calculadora com metodos

// static decimal Somar(decimal a, decimal b)
// {
//     return a + b;
// }

// static decimal Multiplicar(decimal a, decimal b)
// {
//     return a * b;
// }

// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());

// Somar(a, b);

// int am = int.Parse(Console.ReadLine());
// int bm = int.Parse(Console.ReadLine());

// Multiplicar(am, bm);


//Exercício 5 - Cadastro de notas em um array



decimal[] notas = new decimal[3];

for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"Digite a {i + 1}ª nota do aluno: ");
    string notaString = Console.ReadLine();
    
    if (decimal.TryParse(notaString, out decimal notaArray))
    {
        notas[i] = notaArray;
    }
    else
    {
        Console.WriteLine("Nota inserida inválida! Assumindo o valor 0.");
        notas[i] = 0;
    }
}

for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"Nota {i + 1}: {notas[i]}");
}

decimal somaNotas = 0;

foreach (decimal nota in notas)
{
    somaNotas += nota;
}

decimal media = somaNotas / notas.Length;

Console.WriteLine($"A média do aluno é: {media:F2}");


//Exercício 6 - Lista de produtos

List<string> listaProdutos = new List<string>();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite o nome do {i + 1}º produto: ");
    string nomeProduto = Console.ReadLine();
    
    if (!string.IsNullOrWhiteSpace(nomeProduto))
    {
        listaProdutos.Add(nomeProduto);
    }
    else
    {
        Console.WriteLine("Nome inserido inválido!");
    }
}

foreach (string p in listaProdutos)
{
    Console.WriteLine($"- {p}");
}

Console.WriteLine("Digite um produto para buscar na lista: ");
string produtoBusca = Console.ReadLine();

if (listaProdutos.Contains(produtoBusca))
{
    Console.WriteLine($"O produto '{produtoBusca}' está cadastrado na lista!");
}
else
{
    Console.WriteLine($"O produto '{produtoBusca}' não foi encontrado.");
}

Console.WriteLine("Digite um produto para remover da lista: ");
string produtoRemover = Console.ReadLine();

if (listaProdutos.Remove(produtoRemover))
{
    Console.WriteLine($"O produto '{produtoRemover}' foi removido com sucesso!");
}
else
{
    Console.WriteLine($"O produto '{produtoRemover}' não existe na lista.");
}

if (listaProdutos.Count > 0)
{
    foreach (string p in listaProdutos)
    {
        Console.WriteLine($"- {p}");
    }
}
else
{
    Console.WriteLine("A lista de produtos está vazia.");
}


