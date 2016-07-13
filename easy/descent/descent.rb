STDOUT.sync = true # DO NOT REMOVE
# Auto-generated code below aims at helping you parse
# the standard input according to the problem statement.


array = Array.new(8)

# game loop
loop do
    8.times do |i|
        array[i] = gets.to_i # represents the height of one mountain, from 9 to 0.
    end
    
    m = array.rindex(array.max)
    # Write an action using puts
    # To debug: STDERR.puts "Debug messages..."
    
    puts m # The number of the mountain to fire on.
end
