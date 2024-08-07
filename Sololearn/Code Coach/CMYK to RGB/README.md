<h1>CMYK to RGB</h1>
The CMYK color model is the standard in the printing industry and refers to the primary colors of pigment: Cyan, Magenta, Yellow, and Black. K stands for 'Key' since in 4-color printing the Cyan, Magenta and Yellow printing plates are carefully keyed or aligned with the key of the Black key plate. RGB (Red, Green and Blue) is the color space for digital images.

The combination of RGB light creates white, while the combination of CMYK inks creates black.

A CMYK color can be converted to RGB using the following equations:

R = 255 × (1-C) × (1-K)
G = 255 × (1-M) × (1-K)
B = 255 × (1-Y) × (1-K)
Remember, each component of a RGB color is in the range of [0, 255], so the resulting decimal numbers should be rounded to the nearest integers.

<h2>Task</h2>
Given a color in CMYK format, output the corresponding RGB color.
<h3>Input Format</h3>
4 decimal numbers in the range of [0, 1], representing Cyan, Magenta, Yellow and Black.
<h3>Output Format</h3>
A string, representing the corresponding RGB color, each component separated by commas.
<h3>Sample Input</h3>
0.4<br>
0.49<br>
0.552<br>
0.36<br>
<h3>Sample Output</h3>
98,83,73
<h3>Explanation</h3>
cmyk(0.4, 0.49, 0.552, 0.36) corresponds to rgb(98, 83, 73).
