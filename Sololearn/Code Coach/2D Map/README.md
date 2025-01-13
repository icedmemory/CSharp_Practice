<h1>2D Map</h1>
You're given a representation of a 5x5 2D map, and if you can only move left, right, up, or down, determine how many moves you would have to make to get between two points on the map.

<h2>Task</h2>
Determine the total number of moves that are needed between two points on a map. The points that you move between are marked with a P and the spaces in between are marked with X.

<h3>Input Format</h3>
A string that represents the 2D space starting at the top left. Each level from top to bottom is separated by a comma.

<h3>Output Format</h3>
An integer that represents the total number of moves that you had to make.

<h3>Sample Input</h3>
XPXXX,XXXXX,XXXXX,XXXPX,XXXXX

<h3>Sample Output</h3>
5

<h3>Explanation</h3>
The map looks as:<br>
<br>
XPXXX<br>
XXXXX<br>
XXXXX<br>
XXXPX<br>
XXXXX<br>
<br>
You had to move right 2 spaces, then down 3 spaces for a total of 5 moves.
