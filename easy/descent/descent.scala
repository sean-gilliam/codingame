import math._
import scala.util._

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
object Player extends App {

    val heights = new Array[Integer](8)
    
    // game loop
    while(true) {
        for(i <- 0 until 8) {
            heights(i) = readInt // represents the height of one mountain, from 9 to 0.
        }
        
        // Write an action using println
        // To debug: Console.err.println("Debug messages...")
        var d = heights.indexOf(heights.max)
        
        println(d) // The number of the mountain to fire on.
    }
}