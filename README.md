# Control work

## Task

Write a program that filters out all the string values which lengths are equal to or less than 3 and puts them into a new array. It's better not to use collections.

## Things to do

1. Create a Github repository
2. Draw a block-scheme for my algorithm or method
3. Make a README.md file that contains information about how I have accomplished things
4. Write a program that does the required action
5. Use git during the process

## Process

They say it's better not to use collections, which is gonna make the task a little bit more difficult, since I could've just used lists and have no trouble with not knowing the length of the resulting array.

So, the things we'll need in the algorithm are:

- To find out the size of the array we will return
- To create this array
- To fill it with corresponding values
- Return the resulting array

It's said to draw a block-scheme first, so let's get to draw.io and make it.

### Block-scheme creation

'Right, partner, now we need to get our array we're going to get the values from, let's put it into our input field AKA parallelogram.

![getting the array](input.png)

The next step is to find out the size of the array we're going to return. For that I need make a new variable "size" = 0 and to go through the entire "elements" array using for loop (from 0 to elements.Length with increment) and increment "size" every time the element length is less than or equal to three.

![finding size](find_amount_of_elms.png)

Next I need to create the resulting array using "size" and I will need a variable "index" which is going to define in which place to put the needed element (it will be incremented every time we find and put the needed element)

![filling array](fill_array.png)

The block scheme is almost finished, the only thing left is to return "result" and end the algorithm.

![last steps](finish_algo.png)

The result block-scheme looks like this:

![block-scheme](algo_block_scheme.png)

### Creating README

This is what I'm basically doing now and you see it all. I don't see a point to explain what's happening here.

### Writing a program

Since I already have a block-scheme it will be really easy to write it. All you need to do is simply implement block-scheme into the language you use.