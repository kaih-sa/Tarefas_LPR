// Aula 9 andery ex2.cpp 

#include <iostream>
#include<array>
#include<string>
using namespace std;

struct Book {
    string title;
    string author;
    int year;
    int pages;
    int price;
};

int main()
{
    array<Book, 3> library;
    string title;
    string author;
    int year;
    int pages;
    int price;
    int all_prices = 0;
    int all_pages = 0;
    float average;

    for (int p = 0; p < 3; p++)
    {
        cout << "\nWrite the book's title: ";
        cin >> title;
        cout << "Write the author: ";
        cin >> author;
        cout << "Write the year of publication: ";
        cin >> year;
        cout << "Write the amount of pages: ";
        cin >> pages;
        cout << "Write the price: ";
        cin >> price;

        library[p] = { title, author, year, pages, price };
    }

    for (Book book : library)
    {
        all_prices += book.price;
        all_pages += book.pages;
    }
    average = all_pages / library.size();

    cout << "The total price is: " << all_prices << " and the average number of pages is: " << average;
}
