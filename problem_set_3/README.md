# Problem Set 2: Valid Parentheses

## Problem Description
Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid. An input string is valid if:
1.	Open brackets must be closed by the same type of brackets.
2.	Open brackets must be closed in the correct order.

## Solution Overview
1. To initialize, we can create:
	a. A Key-Value pair of Closing and Opening Parenthesis;
	b. An array of allowed characters (for easier checking);
	c. And a String to store current value to be processed (lets call it `forProcessing`).
2. When processing the data, we can loop through the elements of the string, then:
	a. Check if the current character in the string is Closing:
		i. If Closing, then get the last character in the `forProcessing` variable, compare it if it is the correct opening parenthesis, then remove it after processing.
		ii. If Opening, Append the character to the `forProcessing` variable.
	b. The process returns false if:
		i. Current character is not allowed (not the parenthesis characters, as indicated above).
		ii. There is a Closing parenthesis and no Opening parenthesis;
		iii. There is an Opening parenthesis and no Closing parenthesis;
		iv. Mismatch between the Opening and Closing parenthesis, based on Stack (Last in, first out).

## Instructions to Run the Code
1. Inside the `Program.cs` file, modify the `testData` variable (at line 6) to list the parenthesis data to be processed.
2. Run the Program as is.
