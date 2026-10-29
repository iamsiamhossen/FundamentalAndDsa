#include <bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    int spaces = n - 1;
    int space2 = 2;
    int x = 2;
    for (int i = 1; i <= n; i++)
    {
        for (int j = spaces; j > 0; j--)
        {
            cout << " ";
        }
        cout << 1;
        if (i > 1)
        {
            for (int k = 1; k <= 2; k++)
            {
                cout << " ";
            }
            if (i > 2)
            {
                cout << x;
                x++;
            }

            for (int k =2; k <= space2; k++)
            {
                cout << " ";
            }
            space2 += 2;
            cout << 1;
        }
        cout << endl;
        spaces--;
    }
}