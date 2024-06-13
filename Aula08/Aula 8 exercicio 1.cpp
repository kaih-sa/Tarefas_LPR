// Aula 8 exercicio 1.cpp 
#include <iostream>
#include <array>
using namespace std;

int main()
{
    array<int, 10> numeros;
    array<int, 10> par = { 0 };
    array<int, 10> impar = { 0 };
    bool var;
    for (int p = 0; p < 10; p++)
    {
        cout << "Digite o número:";
        cin >> numeros[p];
       

            if (numeros[p] % 2 == 0)
            {
                par[p] = numeros[p];
            }
            else
            {
                impar[p] = numeros[p];
            }
       
      /*  for (int p = 0; p < 10; p++)
        {
            cout << impar[p] << ";" << endl;
        }*/


    }
    for (int p = 0; p < 10; p++)
    {
        if (impar[p] == 0 )
        {
            var = false;
        }
        else
        {
            cout << impar[p] << "; ";
            var = true;
        }
    }
    if (var == true)
    {
        cout << "sao os pares";
    }
    else cout << "sao os impares.";
}
  

