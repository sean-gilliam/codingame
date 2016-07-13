#include <stdlib.h>
#include <stdio.h>
#include <string.h>

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
int main()
{
    int heights[8];
    
    // game loop
    while (1) {
        for (int i = 0; i < 8; i++) {
            scanf("%d", &heights[i]);// represents the height of one mountain, from 9 to 0.
        }

        int k = 0;
        int max = heights[k];
        
        for (int i = 0; i < 8; ++i) {
            if (heights[i] > max) {
                max = heights[i];
                k = i;
            }
        }
        // Write an action using printf(). DON'T FORGET THE TRAILING \n
        // To debug: fprintf(stderr, "Debug messages...\n");

        printf("%d\n", k); // The number of the mountain to fire on.
    }

    return 0;
}