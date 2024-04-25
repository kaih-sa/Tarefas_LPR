// Aula 7 andery ex2


#include <iostream>
using namespace std;

static double exercicioum()
{
	int quantidade_numeros;
	int limite = 0;
	int numero;
	double soma = 0;
	int qtd = 0;
	double media;
	cout << "Escreva a quantidade de números a serem digitados: ";
	cin >> quantidade_numeros;

	while (limite < quantidade_numeros)
	{
		cout << "Escreva o número par: ";
		cin >> numero;

		if (numero % 2 == 0)
		{
			soma += numero;
			qtd++;
		}
		limite++;
	}
	media = soma / qtd;
	return media;

}

static int exerciciotres()
{
	int soma = 0;
	for (int p = 50; p < 500; p += 1)
	{
		if (p % 3 == 0 && p % 2 != 0)
		{
			soma += p;
		}
	}
	return soma;

}
static int exercicioquatro()
{
	int numero;
	int quadrado;
	int numero_partido;
	int resto;
	int soma_do_resto = 0;
	cout << "Escreva o número: ";
	cin >> numero;
	quadrado = numero * numero;

	numero_partido = quadrado / 10;
	resto = quadrado % 10;

	do {
		soma_do_resto = soma_do_resto + resto;
		resto = numero_partido % 10;
		numero_partido = numero_partido / 10;

	} while (numero_partido > 0);

	soma_do_resto = soma_do_resto + resto;
	return soma_do_resto;

}


int main()
{

		int resposta;
		cout << "Digite o número referente a sua escolha:\n 1. Exercíco 1\n 2. Exercíco 3\n 3. Exercíco 4" << endl;
		cin >> resposta;
		switch (resposta)
		{
		case 1:

			cout << exercicioum();

			break;
		case 2:

			cout << exerciciotres();

			break;
		case 3:

			cout << exercicioquatro();

			break;

		}
	
}

