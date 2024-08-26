<h1>Credit Card Validator</h1>
You need to verify if the given credit card number is valid. For that you need to use the Luhn test.<br>
<br>
Here is the Luhn formula:
<ol>
<li>Reverse the number.</li>
<li>Multiple every second digit by 2.</li>
<li>Subtract 9 from all numbers higher than 9.</li>
<li>Add all the digits together.</li>
<li>Modulo 10 of that sum should be equal to 0.</li>
</ol>

<h2>Task</h2>
Given a credit card number, validate that it is valid using the Luhn test. Also, all valid cards must have exactly 16 digits.
<h3>Input Format</h3>
A string containing the credit card number you need to verify.
<h3>Output Format</h3>
A string: 'valid' in case the input is a valid credit card number (passes the Luhn test and is 16 digits long), or 'not valid', if it's not.
<h3>Sample Input</h3>
4091131560563988
<h3>Sample Output</h3>
valid
<h3>Explanation</h3>
Let's run the Luhn test for our input:<br>
<br>
Reverse: 8893650651311904<br>
Multiplying the even positions by 2: 8 16 9 6 6 10 0 12 5 2 3 2 1 18 0 8<br>
Subtract 9 from >9: 8 7 9 6 6 1 0 3 5 2 3 2 1 9 0 8<br>
The sum: 70<br>
70 Modulo 10 is 0.<br>
The input passed the Luhn test and contains 16 digits, making it a valid credit card number.
