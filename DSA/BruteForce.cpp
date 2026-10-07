// #include <bits/stdc++.h>
// using namespace std;
// int main()
// {
//     int n;
//     cin >> n;
//     vector<int> a(n);
//     for (int i = 0; i < n; i++)
//     {
//         cin >> a[i];
//     }
//     int target;
//     cin >> target;
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = i; j < n; j++)
//         {
//             int sum = 0;
//             for (int k = i; k <= j; k++)
//             {
//                 sum += a[k];
//             }
//             cout << sum << " ";
//         }
//         cout << endl;
//     }
//     return 0;
// }
#include <bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    vector<int> a(n);
    for (int i = 0; i < n; i++)
    {
        cin >> a[i];
    }

    int total = accumulate(a.begin(), a.end(), 0);
    int index = -1, right = 0;
    for (int i = n - 1; i >= 0; i--)
    {
        int x = right + a[i];
        if (right == total - x)
        {
            index = i;
        }
        right += a[i];
    }
    cout << index << endl;

    return 0;
}
