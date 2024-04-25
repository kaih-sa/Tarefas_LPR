

#include <iostream>
using namespace std;

static int inverter(int a)
{
    int soma = 0;
    while (a > 0) 
    {
        int resto = a % 10;
        soma = soma * 10 + resto;
        a /= 10;
    }
        return soma;

}


int main()
{
    int resposta;
    cout << "Digite um número: ";
    cin >> resposta;

    int resultado = inverter(resposta);
    cout << resultado << endl;

}
