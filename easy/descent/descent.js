/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/

var heights = new Array(8);

// game loop
while (true) {
    for (var i = 0; i < 8; i++) {
        //var mountainH = parseInt(readline()); // represents the height of one mountain, from 9 to 0.
        heights[i] = parseInt(readline()); // represents the height of one mountain, from 9 to 0.
    }

    var i = heights.indexOf(Math.max(...heights));
    // Write an action using print()
    // To debug: printErr('Debug messages...');

    print(i); // The number of the mountain to fire on.
}
