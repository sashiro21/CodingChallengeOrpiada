# Problem Set 2: Longest Increasing Subsequence

## Problem Description
The "Longest Increasing Subsequence" is a common problem in computer science and dynamic programming. In the context of an array of integers, the goal is to find the length of the longest subsequence of a given array such that all elements of the subsequence are sorted in increasing order.

## Solution Overview
1. Create a variable to store the valid starting sequences.
2. Create a for loop to iterate over the number set.
3. For each number, we will loop into the starting sequences if the current number is larger than the last item in that sequence. If valid, we will create a new list with the same items, and the number at end. (e.g.)
The sequence [2,5,7] will create:
2
[2,5]     - Currrent input is 5, then we loop to current items if 5 is valid to be appended
5
[2,7]     - Current input is 7, then we loop to current items if 7 is valid to be appended
[2,5,7]
[5,7]
7

4. After looping, we will loop into the generated valid sequence to check for longest sequence

## Instructions to Run the Code
1. Inside the `Program.cs` file, modify the `set` variable (at line 6) to list the parenthesis data to be processed.
2. Run the Program as is.
