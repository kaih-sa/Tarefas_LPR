// Aula 06 andery ex3

#include <iostream>
using namespace std;
int main()
{
    int soma = 0;
    for (int p = 50; p < 500; p+=1)
    {
        if (p % 3 == 0 && p % 2 != 0)
        {
            soma += p;
        }
    }
    cout << soma;
}
