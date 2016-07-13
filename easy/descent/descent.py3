import sys
import math

# Auto-generated code below aims at helping you parse
# the standard input according to the problem statement.

a = [0] * 8

# game loop
while True:
    for i in range(8):
        a[i] = int(input())  # represents the height of one mountain, from 9 to 0.

    m = a.index(max(a))
    # Write an action using print
    # To debug: print("Debug messages...", file=sys.stderr)

    # The number of the mountain to fire on.
    print(m)
