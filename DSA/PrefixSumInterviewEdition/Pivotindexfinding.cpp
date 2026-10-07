/**
 * Author: iamsiamhossen
 * Created: 07-10-2026 19:38:36
 **/
#include <bits/stdc++.h>
using namespace std;
// fastread
#define fastread() (ios_base::sync_with_stdio(0), cin.tie(0))
// Shortcut
#define endl "\n"
// #define int long long
#define float double
#define all(X) (X).begin(), (X).end()
#define Reverse(X) reverse(All(X))
#define Unique(X) (X).erase(unique((X).begin(), (X).end()), (X).end())
#define YES cout << "YES\n"
#define NO cout << "NO\n"
#define Yes cout << "Yes\n"
#define No cout << "No\n"
// MOD
#define EPS 1e-9
#define PI 3.1415926535897932384626433832795
#define MOD 1000000007
#define INF 1001001001
// int dx[4] = {-1, 1, -1, 1}, dy[4] = {-1, -1, 1, 1};
const int MAX = 1e6 + 5;
int pref[MAX], suff[MAX];
void solve()
{
    int n;
    cin >> n;
    vector<int> a(n);
    for (int i = 0; i < n; i++)
    {
        cin >> a[i];
    }
    pref[0] = 0;
    for (int i = 0; i < n; i++)
    {
        pref[i + 1] = pref[i] + a[i];
    }
    suff[n] = 0;
    for (int i = n - 1; i >= 0; i--)
    {
        suff[i] = suff[i + 1] + a[i];
    }
    for (int i = 0; i < n; i++)
    {
        int leftSum = pref[i];
        int rightSum = suff[i + 1];
        if (leftSum == rightSum)
        {
            cout << i << endl;
            return;
        }
    }
    cout << -1 << endl;
}
int32_t main()
{
    fastread();
    int tc = 1;
    // cin >> tc;
    for (int t = 1; t <= tc; t++)
    {
        // cout << "Case " << t << ": ";
        solve();
    }
    return 0;
}