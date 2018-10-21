#include <iostream> //cout
#include <string> 
#include <bitset>

int main(){

//int x = 100001001001011100100;//max19
	
	//int to bin/str
	//std::string s = std::bitset<256>(x).to_string();	
	
	//remove leading 0s;
	//s = s.erase(0, s.find_first_not_of('0'));
	
	//std::string s = std::to_string(x);
	std::string s = "10001001001011100100";
	//std::cout << s;
	
	int max = 0;
	int l = 0;
	for(int i = 1 ; i<s.length(); i++){//starting on 1 as 0 will never be 0
		if(s[i] == '0'){
			l++;
		}else{
				if(l > max){
					max = l;
					l=0;
				}
				l=0;
			}
		}
	std::cout << "\n Max: " << max;
}
