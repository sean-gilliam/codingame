import 'dart:io';

void main() {

    // game loop
    while (true) {
        String enemy1 = stdin.readLineSync(); // name of enemy 1
        int dist1 = int.parse(stdin.readLineSync()); // distance to enemy 1
        String enemy2 = stdin.readLineSync(); // name of enemy 2
        int dist2 = int.parse(stdin.readLineSync()); // distance to enemy 2

        // Write an action using print()

        // Enter the code here

        if (dist1 < dist2) {
            print(enemy1);
        } else {
            print(enemy2);
        }
    }
}
