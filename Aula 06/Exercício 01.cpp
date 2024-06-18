// Aula 06 andery ex1

#include <iostream>
using namespace std;
int main()
{
	int quantidade_numeros;
	int limite = 0;
	int numero;
	double soma = 0;
	int qtd = 0;
	double media;
	cout << "Escreva a quantidade de números: ";
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
	cout << "A média é " << media;
}
