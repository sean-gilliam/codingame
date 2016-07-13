/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/

var inputs = readline().split(' ');
var lightX = parseInt(inputs[0]); // the X position of the light of power
var lightY = parseInt(inputs[1]); // the Y position of the light of power
var initialTX = parseInt(inputs[2]); // Thor's starting X position
var initialTY = parseInt(inputs[3]); // Thor's starting Y position

var tx = initialTX;
var ty = initialTY;
        
// game loop
while (true) {
    var remainingTurns = parseInt(readline()); // The remaining amount of turns Thor can move. Do not remove this line.

    // Write an action using print()
    // To debug: printErr('Debug messages...');


     var direction = "N";
    // A single line providing the move to be made: N NE E SE S SW W or NW
    if(lightX == tx && lightY < ty){ direction = "N";  ty--; }
    else if( lightX > tx && lightY < ty){ direction = "NE"; tx++; ty--; }
    else if( lightX > tx && lightY == ty){ direction = "E"; tx++; }
    else if( lightX > tx && lightY > ty){ direction = "SE"; tx++; ty++; }
    else if( lightX == tx && lightY > ty){ direction = "S"; ty++; }
    else if( lightX < tx && lightY > ty){ direction = "SW"; tx--; ty++;}
    else if( lightX < tx && lightY == ty){ direction = "W"; tx--; }
    else if( lightX < tx && lightY < ty){ direction = "NW"; tx--; ty--;}

    print(direction);
}
