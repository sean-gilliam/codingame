#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
int main()
{

    int heights[8];
    const int N = sizeof(heights) / sizeof(int);
    
    // game loop
    while (1) {
        for (int i = 0; i < 8; i++) {
            cin >> heights[i]; cin.ignore();// represents the height of one mountain, from 9 to 0.
        }

        int d = distance(heights, max_element(heights, heights + N));
        // Write an action using cout. DON'T FORGET THE "<< endl"
        // To debug: cerr << "Debug messages..." << endl;

        cout << d << endl; // The number of the mountain to fire on.
    }
}