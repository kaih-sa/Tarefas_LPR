#include <iostream>
using namespace std;
int main()
{
    int numero;
    cout << "Digite um numero inteiro: ";
    cin >> numero;
    if (numero % 2 == 0)
    {
        cout << "Numero par";
     }
    else
    {
        cout << "Numero impar";
    }
    return 0;
}