<h1>Snowballing Numbers</h1>
You are given a list of numbers in a particular order. You need to check to see if each number is greater than the sum of all the previous number of the list. If they are, you have created successful snowball numbers.

<h2>Task</h2>
Create a program that takes in an array of numbers, check if each number is greater than the sum of all previous numbers, and output true if the condition is met, and false, if not.
<h3>Input Format</h3>
The first input denotes the length of the list (N). The next N lines contain the list elements as integers.
<h3>Output Format</h3>
A string, true or false.
<h3>Sample Input</h3>
4<br>
1<br>
3<br>
7<br>
58
<h3>Sample Output</h3>
true
<h3>Explanation</h3>
Each number in the input list is greater than the sum of the previous numbers: 3>1, 7>3+1, 58>7+3+1
