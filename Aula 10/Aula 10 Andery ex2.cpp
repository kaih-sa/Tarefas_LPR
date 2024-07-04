// Aula 10 Andery ex2.cpp 
//

#include <iostream>
#include <list>
using namespace std;

int main()
{
    list<int> numbers;
  //  list<int> to_erase;
    for (int p = 0; p < 100; p++)
    {
        numbers.push_back(rand());
    }

    numbers.sort();

    auto it = numbers.begin();
    for (int element : numbers)
    {
        if (element % 2 == 0)
        {
            numbers.remove(element);

        }
        
       
    }

    for (int ele : numbers)
    {
        cout << ele << ", ";
    }
}
