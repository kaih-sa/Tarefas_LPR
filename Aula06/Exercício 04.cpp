// Aula 06 andery ex4

#include <iostream>
using namespace std;
int main()
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
		cout << soma_do_resto;
}