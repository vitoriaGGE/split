using System.Globalization;

Console.WriteLine("Informe aqui seu nome, sexo, idade e altura respectivamente: ");

/* O Split irá dividir os vetores a cada caractere que estiver informado entre as aspas simples, que no caso agora é o espaço em branco */

string[] vet = Console.ReadLine().Split(' ');

string nome = vet[0];
char sexo = char.Parse(vet[1]);
int idade = int.Parse(vet[2]);
double altura = double.Parse(vet[3]);

Console.WriteLine(" Seu nome é: {0} \r\n Você é do sexo: {1} \r\n Você tem {2} anos de idade \r\n Você tem {3} metros de altura ", nome, sexo, idade, altura);