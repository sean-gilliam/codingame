import java.util.*;
import java.io.*;
import java.math.*;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Player {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        int lightX = in.nextInt(); // the X position of the light of power
        int lightY = in.nextInt(); // the Y position of the light of power
        int initialTX = in.nextInt(); // Thor's starting X position
        int initialTY = in.nextInt(); // Thor's starting Y position

        int tx = initialTX;
        int ty = initialTY;
        
        // game loop
        while (true) {
            int remainingTurns = in.nextInt(); // The remaining amount of turns Thor can move. Do not remove this line.

            // Write an action using System.out.println()
            // To debug: System.err.println("Debug messages...");

            String direction = "N";
            // A single line providing the move to be made: N NE E SE S SW W or NW
            if(lightX == tx && lightY < ty){ direction = "N";  ty--; }
            else if( lightX > tx && lightY < ty){ direction = "NE"; tx++; ty--; }
            else if( lightX > tx && lightY == ty){ direction = "E"; tx++; }
            else if( lightX > tx && lightY > ty){ direction = "SE"; tx++; ty++; }
            else if( lightX == tx && lightY > ty){ direction = "S"; ty++; }
            else if( lightX < tx && lightY > ty){ direction = "SW"; tx--; ty++;}
            else if( lightX < tx && lightY == ty){ direction = "W"; tx--; }
            else if( lightX < tx && lightY < ty){ direction = "NW"; tx--; ty--;}

            System.out.println(direction);
        }
    }
}
