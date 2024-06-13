// Aula 8 exercicio 2.cpp 
#include <iostream>
#include <array>
using namespace std;
int main()
{
	array<int, 10> vetor;
	array<int, 10> seu = {0};
	int escolha;
	bool vari;
	int conta = 0;
	for(int p = 0; p < 10; p++)
	{
		cout << "Digite o valor: ";
		cin >> vetor[p];

	}

	cout << "Digite:";
	cin >> escolha;
	for (int p = 0; p < 10; p++)
	{ 
		if (escolha == vetor[p])
		{
			seu[p] = vetor[p];
		}
	}
	
	for (int p = 0; p < 10; p++)
	{
		
		
			if (seu[p] == 0)
			{
				vari = false;
			}			
			else
			{ 
				vari = true;
				cout << p << ",";
				conta = conta + 1;
			}
		
	}
	if (vari == true)
	{
		cout << escolha << " sao as posicoes do numero no vetor, e as vezes que aparece é: " << conta ;
	}
	else cout << "Este numero nã esta presente no vetor";
}

