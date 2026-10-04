#include <bits/stdc++.h>
using namespace std;
const int MAX = 1e5 + 5;
long long prefixSum[MAX], suffixSum[MAX]; // Global array C++ এ নিজে থেকেই 0 দিয়ে ভরা থাকে
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
        prefixSum[i + 1] = prefixSum[i] + a[i];
    }
    for (int i = n - 1; i >= 0; i--)
    {
        suffixSum[i] = suffixSum[i + 1] + a[i];
    }
    for (int i = 0; i <= n; i++)
    {
        cout << prefixSum[i] << " ";
    }
    cout << endl;
    for (int i = 0; i <= n; i++)
    {
        cout << suffixSum[i] << " ";
    }
    cout << endl;
    int sufsum = prefixSum[n] - prefixSum[3];
    int presum = suffixSum[0] - suffixSum[3];
    cout << sufsum << " " << presum;
    cout<< endl;
    for (int i = 0; i <= n; i++)
        cout << prefixSum[i] << " + " << suffixSum[i]
             << " = " << prefixSum[i] + suffixSum[i] << "\n";
}