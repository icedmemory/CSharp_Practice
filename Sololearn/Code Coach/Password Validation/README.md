<h1>Password Validation</h1>
You're interviewing to join a security team. They want to see you build a password evaluator for your technical interview to validate the input.

<h2>Task</h2>
Write a program that takes in a string as input and evaluates it as a valid password. The password is valid if it has at a minimum 2 numbers, 2 of the following special characters ('!', '@', '#', '$', '%', '&', '*'), and a length of at least 7 characters.
If the password passes the check, output 'Strong', else output 'Weak'.
<h3>Input Format</h3>
A string representing the password to evaluate.
<h3>Output Format</h3>
A string that says 'Strong' if the input meets the requirements, or 'Weak', if not.
<h3>Sample Input</h3>
Hello@$World19
<h3>Sample Output</h3>
Strong
<h3>Explanation</h3>
The password has 2 numbers, 2 of the defined special characters, and its length is 14, making it valid.
