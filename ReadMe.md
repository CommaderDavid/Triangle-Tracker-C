# Triangle Tracker C#
#### 3.1.2.1, for Fidgetech
#### Date:8/3/2020  by:_**David Boedigheimer**_
### Description
The user enters in three numbers and then the program tells them whether or not the three numbers create a certain type of triangle. This program was created with C#.
### BDD Process
1. User Inputs 3 numbers
      * **Input**: "2", "4", "3"
      * **Output**: 2, 4, 3
2. If three sides match, Return "Equilateral"
      * **Input**: "8", "8", "8"
      * **Output**: "Your triangle is a Equilateral triangle"
3. If two sides match, Return "Isosceles"
      * **Input**: "4", "4", "7"
      * **Output**: "Your triangle is a Isosceles triangle"
4. If no sides are the same, Return "Scalene"
      * **Input**: "2", "4", "3"
      * **Output**: "Your triangle is a Scalene triangle"
5. If one side is longer that the other 2 combined, it is not a triangle.
      * **Input**: "4" "3" "15"
      * **Output**: "This is not a triangle. Seriously, what is this?"
### Setup
* Click on clone or download
* Copy link to clipboard
* Open your preferred terminal
* Navigate to `$cd Desktop`
* Create a folder to house the copy: `$mkdir "Copy"`
* Paste the link, (this is using github): `$git clone "Link"`
* Navigate to the TriangleTrackerTests folder
* Run `dotnet restore` in the terminal
* Navigate back to the main folder
* Run `dotnet start` and enjoy.
### Contact
Contact me if you have any concerns or questions at stealth259@gmail.com
### Known bugs
There are no know bugs in this program.
### License
This program is lisensed under the MIT license.
Copyright (c) 2020 _**David Boedigheimer**_