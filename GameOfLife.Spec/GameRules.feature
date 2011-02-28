Feature: Game Of Life Rules
	In order to demonstrate that comple* patterns can emerge from a simple set of rules
	As a geek
	I want to play the game of life by the rules

Scenario: A live cell with no neighbours dies
	Given a game of life grid 
	|0|1|
	|*| |
	| | |
	When the next generation
	Then the grid should be
	|0|1|
	| | |
	| | | 

Scenario: A live cell with one neighbour dies
	Given a game of life grid 
	|0|1|
	|*|*|
	| | |
	When the next generation
	Then the grid should be
	|0|1|
	| | |
	| | | 

Scenario: A live cell with two live neighbours survives
	Given a game of life grid 
	|0|1|2|
	|*| | | 
	| |*| | 
	| | |*|
	When the next generation
	Then the grid should be
	|0|1|2|
	| | | | 
	| |*| | 
	| | | | 

Scenario: A live cell with three live neighbours survives
	Given a game of life grid 
	|0|1|
	|*|*|
	|*|*|
	When the next generation
	Then the grid should be
	|0|1|
	|*|*|
	|*|*| 

Scenario: A live cell with more than three live neighbours dies
	Given a game of life grid 
	|0|1|2|
	|*| | |
	|*|*|*|
	|*| | |
	When the next generation
	Then the grid should be
	|0|1|2|
	|*| | |
	|*| | |
	|*| | |

Scenario: A dead cell with exactly three live neighbours becomes a live cell
	Given a game of life grid 
	|0|1|2|
	| | | |
	| |*|*|
	| |*| |
	When the next generation
	Then the grid should be
	|0|1|2|
	| | | |
	| |*|*|
	| |*|*|