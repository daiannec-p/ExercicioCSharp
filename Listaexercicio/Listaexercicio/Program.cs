// Daianne Coelho Pinheiro

#region Exercicios
//Lista de Exercícios de C# 
//    1. Soma de dois números
//        Solicite dois números inteiros e exiba a soma. 
//        Exemplo 
//            Entrada: 10 15 
//            Saída: A soma é 25. 

//    2. Antecessor e sucessor
//        Leia um número inteiro e mostre:
//            ● Antecessor ● Número informado ● Sucessor 

//    3. Área de um retângulo 
//        Solicite:
//            ● Base ● Altura Calcule: ● Área ● Perímetro 

//    4. Conversor de moedas 
//        Leia um valor em reais e a cotação do dólar. 
//        Mostre quanto esse valor representa em dólares. 

//    5. Calculadora simples 
//        Solicite dois números e mostre:
//            ● Soma ● Subtração ● Multiplicação ● Divisão 

//    6. Contagem crescente 
//        Mostre os números de 1 até 100. 

//    7. Contagem regressiva 
//        Mostre os números de 50 até 1. 

//    8. Tabuada 
//        Solicite um número e exiba sua tabuada de 1 a 10. 

//    9. Soma dos números pares 
//        Calcule a soma de todos os números pares entre 1 e 100. 

//    10. Login simples 
//        Solicite usuário e senha. 
//        Enquanto a senha estiver incorreta, peça novamente. 

//    11. Soma até digitar zero 
//        Leia números inteiros. 
//        Quando o usuário digitar zero, encerre o programa mostrando a soma dos valores digitados. 

//    12. Contador de caracteres 
//        Leia um nome e informe quantos caracteres ele possui. 

//    13. Verificador de senha 
//        Solicite uma senha. 
//        Informe se ela possui pelo menos 8 caracteres. 

//    14. Maior elemento 
//        Leia 10 números e informe: 
//            ● Maior valor ● Posição em que ele aparece 

//    15. Média de um vetor 
//        Leia 8 notas e calcule a média. 

//    16. Contagem de pares 
//        Leia 20 números e informe quantos são pares. 

//    17. Ordem inversa 
//        Leia 10 números e exiba-os na ordem inversa. 

//    18. Jogo da senha Gere um número aleatório entre 1 e 100.
//        Informe ao usuário se o número digitado é maior ou menor que o número sorteado até que ele acerte. 

//    19. Caixa eletrônico Solicite um valor para saque. 
//        Informe quantas notas serão entregues considerando: 
//            ● R$100 ● R$50 ● R$20 ● R$10 ● R$5 ● R$2 
#endregion

#region 1. Soma de dois números
// Soma de dois números || Solicite dois números inteiros e exiba a soma. 

//Console.WriteLine("\n===== SOMA DE DOIS NÚMEROS =====");
//Console.WriteLine("Digite o primeiro número INTEIRO: ");
//var valordig01 = Console.ReadLine();
//Console.WriteLine("Digite o segundo número INTEIRO: ");
//var valordig02 = Console.ReadLine();

//if (!int.TryParse(valordig01, out int valor1))
//{
//    Console.WriteLine($"Número INválido: {valordig01}");
//    Console.ReadKey();
//    return;
//}
//if (!int.TryParse(valordig02, out int valor2))
//{
//    Console.WriteLine($"Número INválido: {valordig02}");
//    Console.ReadKey();
//    return;
//}
//Console.WriteLine($"O primeiro numero digitado foi: {valordig01}");
//Console.WriteLine($"O primeiro numero digitado foi: {valordig02}");
//Console.WriteLine($"A soma é: {valor1 + valor2}");
//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");
#endregion

#region 2. Antecessor e sucessor
//        Leia um número inteiro e mostre:
//            ● Antecessor ● Número informado ● Sucessor 

//Console.WriteLine("\n===== ANTECESSOR e SUCESSOR =====");

//Console.WriteLine("Digite UM número INTEIRO: ");
//var valordig01 = Console.ReadLine();

//if (!int.TryParse(valordig01, out int valor1))
//{
//    Console.WriteLine($"Número Inteiro INválido: {valordig01}");
//    Console.ReadKey();
//    return;
//}

//Console.WriteLine($"O Numero digitado foi: {valor1}");
//Console.WriteLine($"O ANTECESSOR do número digitado é: {valor1 - 1}");
//Console.WriteLine($"O SUCESSOR do número digitado é: {valor1 + 1}");
//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");

#endregion

#region 3. Área de um retângulo 
////Área de um retângulo | Solicite: ● Base ● Altura | Calcule: ● Área ● Perímetro 

//Console.WriteLine("\n===== ÁREA E PERÍMETRO DE UM RETÂNGULO =====");
//Console.WriteLine("Digite o valor da base em centímetros: ");
//string baseretangulo = Console.ReadLine();
//Console.WriteLine("Digite o valor da altura em centímetros: ");
//string alturaretangulo = Console.ReadLine();

//if (!double.TryParse(baseretangulo, out double baseretangulo01))
//{
//    Console.WriteLine("Valor da base inválido.");
//    return;
//}

//if (!double.TryParse(alturaretangulo, out double alturaretangulo01))
//{
//    Console.WriteLine("Valor da altura inválido.");
//    return;
//}

//Console.WriteLine($"O calculo da área é: {baseretangulo01 * alturaretangulo01}");
//Console.WriteLine($"O cálculo do perímetro é: {(baseretangulo01 * 2) + (alturaretangulo01 * 2)}");
//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");
#endregion

#region 4. Conversor de moedas 
// Leia um valor em reais e a cotação do dólar. 
// Mostre quanto esse valor representa em dólares. 

//Console.WriteLine("\n===== CONVERSOR DE MOEDAS =====");

//Console.WriteLine("Digite o valor em reais (R$):");
//string valorReais = Console.ReadLine();

//Console.WriteLine("Digite a cotação do dólar:");
//string cotacaoDolar = Console.ReadLine();

//if (!double.TryParse(valorReais, out double reais))
//{
//    Console.WriteLine("Valor em reais inválido.");
//    return;
//}

//if (!double.TryParse(cotacaoDolar, out double cotacao))
//{
//    Console.WriteLine("Cotação do dólar inválida.");
//    return;
//}

//double valorEmDolares = reais / cotacao;

//Console.WriteLine($"R$ {reais:F2} equivalem a US$ {valorEmDolares:F2}");
//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");

#endregion

#region 5. Calculadora simples
// 5. Calculadora simples || Solicite dois números e mostre: ● Soma ● Subtração ● Multiplicação ● Divisão 

//Console.WriteLine("\n===== CALCULADORA SIMPLES =====");
//Console.WriteLine("Digite o primeiro número INTEIRO: ");
////var valor1 = Convert.ToInt32(Console.ReadLine());
//var valordig01 = Console.ReadLine();
//Console.WriteLine("Digite o segundo número INTEIRO: ");
//var valordig02 = Console.ReadLine();

//if (!int.TryParse(valordig01, out int valor1)) 
//{
//    Console.WriteLine($"Número INválido: {valor1}");
//    Console.ReadKey();
//    return;
//}
//if (!int.TryParse(valordig02, out int valor2)) 
//{ 
//Console.WriteLine($"Número INválido: {valor2}");
//    Console.ReadKey();
//    return;
//}

//Console.WriteLine($"A soma é: {valor1 + valor2}");
//Console.WriteLine($"A subtração é: {valor1 - valor2}");
//Console.WriteLine($"A multiplicação é: {valor1 * valor2}");
//if (valor2 != 0)
//{
//    Console.WriteLine($"A divisão é: {valor1 / valor2}");
//}
//else
//{
//    Console.WriteLine("Não é possível dividir por zero.");
//}   
//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");
#endregion

#region 6. Contagem crescente 
//Mostre os números de 1 até 100.

//Console.WriteLine("\n===== CONTAGEM CRESCENTE DE 1 ATÉ 100 =====");

//for (int i = 1; i <= 100; i++)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");
#endregion

#region 7. Contagem regressiva 
// Mostre os números de 50 até 1.

//Console.WriteLine("\n===== CONTAGEM REGRESSIVA DE 1 ATÉ 50 =====");

//for (int i = 50; i >= 1; i--)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");
#endregion

#region 8. Tabuada
// Solicite um número e exiba sua tabuada de 1 a 10. 

//Console.WriteLine("\n===== TABUADA DE 0 A 10 =====");
//Console.WriteLine("Digite um número: ");
//string numero01 = Console.ReadLine();

//if (!double.TryParse(numero01, out double numero02))
//{
//    Console.WriteLine("Valor digitado inválido.");
//    return;
//}
//Console.WriteLine($"Tabuada do número {numero02}:");
//Console.WriteLine($"===============================");
//Console.WriteLine($"| {numero02} x 0 = {numero02 * 0} |");
//Console.WriteLine($"| {numero02} x 1 = {numero02 * 1} |");
//Console.WriteLine($"| {numero02} x 2 = {numero02 * 2} |");
//Console.WriteLine($"| {numero02} x 3 = {numero02 * 3} |");
//Console.WriteLine($"| {numero02} x 4 = {numero02 * 4} |");
//Console.WriteLine($"| {numero02} x 5 = {numero02 * 5} |");
//Console.WriteLine($"| {numero02} x 6 = {numero02 * 6} |");
//Console.WriteLine($"| {numero02} x 7 = {numero02 * 7} |");
//Console.WriteLine($"| {numero02} x 8 = {numero02 * 8} |");
//Console.WriteLine($"| {numero02} x 9 = {numero02 * 9} |");
//Console.WriteLine($"| {numero02} x 10 = {numero02 * 10} |");

//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");

#endregion

#region 9. Soma dos números pares 
// Calcule a soma de todos os números pares entre 1 e 100. 

//Console.WriteLine("\n===== SOMA DOS NÚMEROS PARES DE 1 ATÉ 100 =====");

//int soma = 0;
//    for (int i = 2; i <= 100; i += 2)
//    {
//    soma += i;
//    }
//Console.WriteLine($"A soma dos números pares de 1 até 100 é: {soma}");
//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");

#endregion

#region 10. Login simples 
// Solicite usuário e senha. 
// Enquanto a senha estiver incorreta, peça novamente.

//Console.WriteLine("===== LOGIN SIMPLES =====");

//Console.Write("Usuário: ");
//string usuario = Console.ReadLine();

//string senhaCorreta = "1234";
//string senha;

//Console.Write("Senha: ");
//senha = Console.ReadLine();

//while (senha != senhaCorreta)
//{
//    Console.WriteLine("Senha incorreta! Tente novamente.");
//    Console.Write("Senha: ");
//    senha = Console.ReadLine();
//}

//Console.WriteLine($"Bem-vindo, {usuario}!");
//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");

#endregion

#region 11. Soma até digitar zero 
// Leia números inteiros. 
// Quando o usuário digitar zero, encerre o programa mostrando a soma dos valores digitados. 

//Console.WriteLine("===== SOMA ATÉ DIGITAR ZERO (0) =====");

//int numero;
//int soma = 0;

//do
//{
//    Console.Write("Digite um número (0 para encerrar): ");

//    while (!int.TryParse(Console.ReadLine(), out numero))
//    {
//        Console.WriteLine("Opção inválida! Digite um número.");
//        Console.Write("Digite um número (0 para encerrar): ");
//    }

//    soma += numero;

//} while (numero != 0);

//Console.WriteLine($"A soma dos valores digitados é: {soma}");
//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");

#endregion

#region 12. Contador de caracteres
// Leia um nome e informe quantos caracteres ele possui. 
//Console.WriteLine("===== CONTADOR DE CARACTERES =====");

//Console.Write("Digite um nome: ");
//string nome = Console.ReadLine();

//int quantidade = nome.Replace(" ", "").Length;

//Console.WriteLine($"O nome possui {quantidade} caracteres, sem contar os espaços.");

//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");
#endregion

#region 13. Verificador de senha
// Solicite uma senha. 
// Informe se ela possui pelo menos 8 caracteres.
//Console.WriteLine("===== VERIFICADOR DE SENHA =====");

//Console.Write("Digite uma senha: ");
//string senha = Console.ReadLine();

//if (senha.Length >= 8)
//{
//    Console.WriteLine("Senha válida! A senha possui pelo menos 8 caracteres.");
//}
//else
//{
//    Console.WriteLine("Senha inválida! A senha deve possuir pelo menos 8 caracteres.");
//}

//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");

#endregion

#region 14. Maior elemento
// Leia 10 números e informe: ● Maior valor ● Posição em que ele aparece 
//Console.WriteLine("===== MAIOR ELEMENTO =====");
//Console.WriteLine("------------------------------");
//Console.WriteLine("Por gentileza, digite 10 números aleatórios.");

//int[] numeros = new int[10];
//int maior = 0;
//int posicao = 0;

//for (int i = 0; i < 10; i++)
//{
//    Console.Write($"Digite o {i + 1}º número: ");

//    while (!int.TryParse(Console.ReadLine(), out numeros[i]))
//    {
//        Console.WriteLine("Opção inválida! Digite um número.");
//        Console.Write($"Digite o {i + 1}º número: ");
//    }

//    if (i == 0 || numeros[i] > maior)
//    {
//        maior = numeros[i];
//        posicao = i;
//    }
//}

//Console.WriteLine($"\nMaior valor: {maior}");
//Console.WriteLine($"Posição: {posicao + 1}");

//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");

#endregion

#region 15. Média de um vetor 
// Leia 8 notas e calcule a média. 

//Console.WriteLine("===== MÉDIA DE UM VETOR =====");

//Console.WriteLine("------------------------------");
//Console.WriteLine("Serão solicitados 8 notas e ao final será exibido a média dessas notas.");
//Console.WriteLine("------------------------------");
//double[] notas = new double[8];
//double soma = 0;

//for (int i = 0; i < 8; i++)
//{
//    Console.Write($"Digite a {i + 1}ª nota: ");

//    while (!double.TryParse(Console.ReadLine(), out notas[i]))
//    {
//        Console.WriteLine("Valor inválido! Digite uma nota válida.");
//        Console.Write($"Digite a {i + 1}ª nota: ");
//    }

//    soma += notas[i];
//}

//double media = soma / 8;

//Console.WriteLine($"\nMédia das notas: {media:F2}");
//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");
#endregion

#region 16. Contagem de pares 
// Leia 20 números e informe quantos são pares. 
//Console.WriteLine("===== CONTAGEM DE PARES =====");

//Console.WriteLine("------------------------------");
//Console.WriteLine("Serão solicitados 20 números e ao final será exibido quantos são pares.");
//Console.WriteLine("------------------------------");

//int numero;
//int quantidadePares = 0;

//for (int i = 0; i < 20; i++)
//{
//    Console.Write($"Digite o {i + 1}º número: ");

//    while (!int.TryParse(Console.ReadLine(), out numero))
//    {
//        Console.WriteLine("Valor inválido! Digite um número inteiro.");
//        Console.Write($"Digite o {i + 1}º número: ");
//    }

//    if (numero % 2 == 0)
//    {
//        quantidadePares++;
//    }
//}

//Console.WriteLine($"\nQuantidade de números pares: {quantidadePares}");
//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");

#endregion

#region 17. Ordem inversa
// Leia 10 números e exiba-os na ordem inversa. 
//Console.WriteLine("===== ORDEM INVERSA =====");

//Console.WriteLine("------------------------------");
//Console.WriteLine("Serão solicitados 10 números e ao final será exibido na ordem inversa.");
//Console.WriteLine("------------------------------");


//int[] numeros = new int[10];

//for (int i = 0; i < 10; i++)
//{
//    Console.Write($"Digite o {i + 1}º número: ");

//    while (!int.TryParse(Console.ReadLine(), out numeros[i]))
//    {
//        Console.WriteLine("Valor inválido! Digite um número inteiro.");
//        Console.Write($"Digite o {i + 1}º número: ");
//    }
//}

//Console.WriteLine("\nNúmeros na ordem inversa:");

//for (int i = 9; i >= 0; i--)
//{
//    Console.WriteLine(numeros[i]);
//}

//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");
#endregion

#region 18. Jogo da senha Gere um número aleatório entre 1 e 100.
// Informe ao usuário se o número digitado é maior ou menor que o número sorteado até que ele acerte. 
//Console.WriteLine("===== JOGO DA SENHA =====");

//Console.WriteLine("-----------------------------");
//Console.WriteLine(" TENTE ADIVINHAR O NUMERO ACOMPANHANDO MINHAS PISTAS!!");
//Console.WriteLine("-----------------------------");

//Random random = new Random();
//int numeroSorteado = random.Next(1, 101); // 1 a 100

//int palpite;

//do
//{
//    Console.Write("Digite um número entre 1 e 100: ");

//    while (!int.TryParse(Console.ReadLine(), out palpite))
//    {
//        Console.WriteLine("Valor inválido! Digite um número inteiro.");
//        Console.Write("Digite um número entre 1 e 100: ");
//    }

//    if (palpite < numeroSorteado)
//    {
//        Console.WriteLine("O número sorteado é MAIOR.");
//    }
//    else if (palpite > numeroSorteado)
//    {
//        Console.WriteLine("O número sorteado é MENOR.");
//    }

//} while (palpite != numeroSorteado);

//Console.WriteLine($"\nParabéns! Você acertou o número {numeroSorteado}!");
//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");

#endregion

#region 19. Caixa eletrônico Solicite um valor para saque. 
// Informe quantas notas serão entregues considerando: ● R$100 ● R$50 ● R$20 ● R$10 ● R$5 ● R$2 

//Console.WriteLine("===== CAIXA ELETRÔNICO =====");

//int valor;

//Console.Write("Digite o valor do saque: ");

//while (!int.TryParse(Console.ReadLine(), out valor) || valor < 2)
//{
//    Console.WriteLine("Valor inválido! Disponivel apenas as notas abaixo:");
//    Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = =");
//    Console.WriteLine("● R$100 ● R$50 ● R$20 ● R$10 ● R$5 ● R$2");
//    Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = =");
//    Console.WriteLine("Digite um valor maior ou igual a R$2.");
//    Console.Write("Digite o valor do saque: ");
//}

//int notas100 = valor / 100;
//valor %= 100;

//int notas50 = valor / 50;
//valor %= 50;

//int notas20 = valor / 20;
//valor %= 20;

//int notas10 = valor / 10;
//valor %= 10;

//int notas5 = valor / 5;
//valor %= 5;

//int notas2 = valor / 2;
//valor %= 2;

//Console.WriteLine("\nNotas entregues:");
//Console.WriteLine($"R$100: {notas100}");
//Console.WriteLine($"R$50 : {notas50}");
//Console.WriteLine($"R$20 : {notas20}");
//Console.WriteLine($"R$10 : {notas10}");
//Console.WriteLine($"R$5 : {notas5}");
//Console.WriteLine($"R$2 : {notas2}");

//if (valor > 0)
//{
//    Console.WriteLine($"\nNão é possível sacar os R${valor} restantes com as notas disponíveis.");
//}

//Console.WriteLine("\n===== OBRIGADA E VOLTE SEMPRE =====");
#endregion