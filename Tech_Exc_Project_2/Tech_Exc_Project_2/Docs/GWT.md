# User Acceptance Criteria

## Responsibilities
- CommandLineEntry
- InputValidator
- ShotCalculator
- TargetJudge
- FinalShotCounter
- TargetGenerator

### CommandLine
Given the program requires an angles from the user
When the command line object is called
Then it will print out "Please enter an angle between 1 and 90"

Given the program requires a velocity from the user
When the command line object is called
Then it will print out "Please enter a velocity between 1 and 20"

Given the user has entered an angle of 5
When the command line object is called
Then it will return "5"

Given the user has entered a velocity of 5
When the command line object is called
Then it will return "5"

Given the user has hit the target after 5 attempts
When the command line object is called
Then it will print out "Well done. You hit the target after 5 attempts"

Given the user has not hit the target
When the command line object is called
Then it will print out "You did not hit the target. Please try again"


### InputValidator
Given the user inputs an angle of 100
When the input validator is called
Then an exception is thrown

Given the user inputs an angle of 1
When the input validator is called
Then no exception is thrown

Given the user inputs an angle of 90
When the input validator is called
Then no exception is thrown

Given the user inputs an angle of 0
When the input validator is called
Then an exception is thrown

Given the user inputs an angle of -1
When the input validator is called
Then an exception is thrown

Given the user inputs a velocity of 1
When the input validator is called
Then no exception is thrown

Given the user inputs a velocity of 20
When the input validator is called
Then no exception is thrown

### ShotCalculator (Round down if real result is 0.49 or below, Round up if 0.5 or above)
Given an angle of 30 and a velocity of 5
When the shot calculator is called
Then it will return the x,y co-ordinates (4, 3) 

Given an angle of 90 and a velocity of 20
When the shot calculator is called
Then it will return the x,y co-ordinates (0, 20)

Given an angle of 1 and a velocity of 1
When the shot calculator is called
Then it will return the x,y co-ordinates (1, 0)

Given an angle of 10 and a velocity of 45
When the shot calculator is called
Then it will return the x,y co-ordinates (1, 0)

### TargetGenerator
Given the map has a width of 10 and a heigth of 10
When the target generator is called
Then it will return a random x,y coordinate between 0 and 10 for both x and y

### TargetJudge
Given the x,y coordinates of the target is (2, 2) and ShotCalculator returns (2, 2)
When the target judge is called
Then return True

Given the x,y coordinates of the target is (2, 2) and ShotCalculator returns (2, 1)
When the target judge is called
Then return False

### FinalShotCounter
Given the user has not hit the target on their first attempt
When the final shot counter is called
Then the counter should increase from 0 to 1

Given the user has not hit the target on their third attempt
When the final shot counter is called
Then the counter should increase from 2 to 3