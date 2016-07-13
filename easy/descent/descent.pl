use strict;
use warnings;
#use diagnostics;
use 5.20.1;

select(STDOUT); $| = 1; # DO NOT REMOVE

# Auto-generated code below aims at helping you parse
# the standard input according to the problem statement.

my @data; $data[8] =0;

# game loop
while (1) {
    for my $i (0..7) {
        chomp(my $input = <STDIN>); # represents the height of one mountain, from 9 to 0.
        $data[$i] = $input;
    }
    
    my $l = $#data;
    my $max = $l;
    $max = $data[$l] > $data[$max] ? $l : $max while $l--;
    # Write an action using print
    # To debug: print STDERR "Debug messages...\n";

    print "$max\n"; # The number of the mountain to fire on.
}
