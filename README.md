# _Word Counter_

#### _The website consists of three applications: Word Counter, Scrabble Points Counter and Palindrome Checker._
##### _Word Counter - Takes a user inputted word and sentence and checks to see how many times the word is in the sentence._ #####
##### _Scrabble Points Calculator - Takes a user inputted word and calculates how much that word would be worth in a Scrabble game._ #####
##### _Palindrome Checker - Takes a user inputted word and checks to see if it is a palindrome or not._ #####

#### By _**Alex Williams**_

## Description

_The program starts by asking the user to input a word. The word is set to a string. The program then asks the user to input a sentence which is also set to a string._

_After the user inputs both, the program then checks to see how many times the word is contained within the sentence_

_**Word Counter Example:**_

_User Word Input: "Dog"_

_User Word Sentence: "The Dog went to the Dog House to play with some Dogs and Doggies."_

_Expected Output: "The word Dog is used within the sentence 'The Dog went to the Dog House to play with some Dogs and Doggies.' 2 times._


## Specs

1. [_**Input: "a" and "a"- Expected Output: "1 Match"**_] User inputs the simplest string possible, in this case "a", and the program outputs that it matches once in the given string.
    
2. [_**Input: "a" and "a a" - Expected Output: "2 Matches"**_] User inputs the simplest string possible "a" and a string containing two a's, "a a". The program then outputs it has two matches.

3. [_**Input "dog" and "the dog likes to run in the dog park" - Expected Output: "2 Matches"**_] User inputs a string "dog" and a string containing multiple words containing multiple instances of the word "dog." The program then cycles through the string and finds two instances of the word "dog" and outputs that it has two matches.

4. [_**Input "cat" and "The cat likes to run with the other cats on the cathedral" - Expected Output: "1 Match"**_] User inputs a string "cat" and a string containing multiple words containing only one instance of the word "cat" but with other words CONTAINING the string "cat". Due to the way the program runs, only matching complete full word matches, the program should not match "cat" with either "cats" or "cathedral" and should only output that there is one match.

_**Scrabble Point Calculator Example:**_

_User Word Input: "dog"_

_Expected Output: "Your word "dog" is worth 4 scrabble points!._


## Specs

1. [_**Input: "a" - Expected Output: "1 Point"**_] User inputs the simplest string possible, in this case "a", and the program outputs that it is worth one point.
    
2. [_**Input: "aa" - Expected Output: "2 Points"**_] User inputs a simple string  "aa". The program then outputs it is worth 2 points.

_**Palindrome Checker Example:**_

_User Word Input: "racecar"_

_Expected Output: "Your word "racecar" is a palindrome!!._

## Specs

1. [_**Input: "racecar" - Expected Output: "True"**_] User inputs a string, the program checks if it is a palindrome and returns that it is indeed a palindrome.
    
2. [_**Input: "dog" - Expected Output: "False""**_] User inputs a string, the program checks if it is a palindrome and returns that it is not a palindrome.

## Setup/Installation Requirements

Download .NET Core 2.1.3 SDK and .NET Core Runtime 2.0.9 and install them. 
Download Mono and Install it.
1. Clone this repository: 
    - $git clone https://github.com/Zizzs/WordCounter.Solution
2. Change into the work directory: 
    - $cd WordCounter.Solution
3. Open the project in your preferred text editor to modify the files.
4. To run the program, navigate to WordCounter.Solution/WordCounter and use $dotnet build to build the project, and then $dotnet run to start the server that the project will be held.
5. Navigate to localhost:5000 in your browser to view the splashpage.

Github Repo:
https://github.com/Zizzs/WordCounter.Solution

_.NET is Required for this project to function._

## Known Bugs

_No known bugs._

## Support and contact details

_If you have any questions, or suggestions, please email me at Zizzs17@gmail.com or visit my Github repository at https://github.com/Zizzs_

## Technologies Used

_C# , HTML , CSS , SVG and .NET_

### License

*MIT License*

Copyright (c) 2018 **_Alex Williams_**