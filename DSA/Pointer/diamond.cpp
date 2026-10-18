#include <bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    int stars = 1;
    int spaces = n - 1;
    for (int i = 1; i <= n; i++)
    {
        for (int j = spaces; j >= 1; j--)
        {
            cout << " ";
        }
        for (int k = 1; k <= stars; k++)
        {
            cout << "*";
        }
        cout << endl;
        stars += 2;
        spaces--;
    }
    int st = ((n - 1) * 2) - 1;
    int sp = 1;
    for (int i = 1; i <= n - 1; i++)
    {
        for (int j = 1; j <= sp; j++)
        {
            cout << " ";
        }
        for (int k = 1; k <= st; k++)
        {
            cout << "*";
        }
        cout << endl;
        st -= 2;
        sp++;
    }
}