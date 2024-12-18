# Problem Set 1: Palindrome Pairs

## Problem Description
Given a list of words, find all pairs of distinct indices [i,j] such that the concatenation of the words in the ith and jth element in the array forms a palindrome.

## Solution Overview
1. We create a loop to process the pair of words.
2. For the palindrome checker, from the first(left) and last(right) letter, we check if they are a letter. Then, we compare. If they are the same, we move towards the center of the word, comparing if they are the same and if so, we return it as true.

## Instructions to Run the Code
1. Inside the `Program.cs` file, modify the `words` variable (at line 9) to contain the words to be processed.
2. Run the Program as is.
