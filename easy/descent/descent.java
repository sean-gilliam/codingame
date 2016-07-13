import java.util.*;
import java.io.*;
import java.math.*;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);

        int[] data = new int[8];
        // game loop
        while (true) {
            for (int i = 0; i < 8; i++) {
                data[i] = in.nextInt(); // represents the height of one mountain, from 9 to 0.
            }

            int max = 0;
            for (int i = 1; i < data.length; i++){
               int nbr = data[i];
               if ((nbr > data[max])){
                   max = i;
              }
            }
            // Write an action using System.out.println()
            // To debug: System.err.println("Debug messages...");

            System.out.println(max); // The number of the mountain to fire on.
        }
    }
}
