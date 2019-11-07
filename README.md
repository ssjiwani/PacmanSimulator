# PacmanSimulator

###### Solution Package
1. Command File – commands.txt
2. Solution

###### File Format - commands.txt

PLACE 0,0,NORTH

MOVE

REPORT

LEFT

RIGHT

A combination of above commands in any order

###### Solution
Solution contains two below projects:
1. PacmanSimulator
2. PacmanSimulatorUnitTest

###### PacmanSimulator
The solution is a .Net Console Application for determining location of Pacman by taking placement, move and rotate commands in a text file targeting .Net Framework 4.6.1.

Run Instructions:
1. Application takes 1 command line argument which is commands file url. For example: C:\Users\User\Desktop\commands.txt
2. If argument is not provided, program will run test command file which is placed in solution bin\Debug folder.
3. If running on Visual Studio, project properties ->Debug tab -> add argument.
4. If running on CMD, append command line argument after .exe name.
5. Run the application via CMD or through visual studio.

###### PacmanSimulatorUnitTest
Unit Test Project for testing Pacman Simulator project targeting .Net Framework 4.6.1 for testing placement, move and rotate functions.

Run Instructions:
1. Open solution on visual studio
2. Go to Test -> Run - > All Tests
3. View results in Output and Test Explorer window
