#include <bits/stdc++.h>
using namespace std;
const int MAX = 5;
vector<int> prefixSum(MAX); // Global array C++ এ নিজে থেকেই 0 দিয়ে ভরা থাকে
int main()
{
    int n;
    cin >> n;
    vector<int> a(n);
    for (int i = 0; i < n; i++)
    {
        cin >> a[i];
    }
    for (int i = 0; i < n; i++)
    {
        prefixSum[i+1] = prefixSum[i] + a[i];
    }
    for (int i = 0; i <= n; i++)
    {
        cout << prefixSum[i] << " ";
    }
}