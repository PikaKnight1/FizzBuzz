#include <iostream>
#include <string>


using namespace std;

int main() {
    for (int i = 1; i <= 30; i++) {
        string result = (i % 3 == 0) ? "fizz" : "";
        result += (i % 5 == 0) ? "buzz" : "";
        result += (result == "") ? to_string(i) : "";

        cout << result << endl;
    }
}
