using System.Collections.Concurrent;
using Primeiro_contato.Models;

string apresentacao = "Olá seja Bem Vindo";
int quantidade = 1;
double altura = 1.80; // Doblou ignora zero apos a virgula, por isso não utilizamos para representar dinheiro mesmo ele servindo para imprimir numeros decimais
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine($"Valor da variável quantidade: {quantidade}");
Console.WriteLine($"Valor da variável altura: {altura.ToString("0.00")}");// para o double não ignorar o zero após a virgula é necessario fazer um tratamento manual utilizando o metodo to string
Console.WriteLine($"Valor da variável preço: {preco}");
Console.WriteLine($"Valor da variável condição: {condicao}");

// Pessoa pessoa1 = new Pessoa(); //Isso é uma váriavel em C# que está construindo o objeto pessoa()

// //Passando dados para meu objeto
// pessoa1.Nome = "Guilherme";
// pessoa1.Idade = 19;

// //Chamando metodo do objeto
// pessoa1.apresentar();
