#include<bits/stdc++.h>
using namespace std;
int main(){
	ios_base::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);
	int size;
	cin>>size;
	int arr[size];
	for(int i=0;i<size;i++){
		cin>>arr[i];
	}
	sort(arr,arr+size);
	for(int i=0;i<size;i++){
		cout<<arr[i]<<" ";
	}
	return 0;
}
