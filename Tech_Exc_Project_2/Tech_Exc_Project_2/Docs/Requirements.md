# Cannon Game

## Given
- I have agame that presents a user with a target with x,y coordinates between 1 and 10

## Then
- I am told if I hit my target
### And
- If I didn't hit my target I get to take another shot
### And
- If I did hit the target it tells me how many shots it took

The maths to figure out if an angle and velocity hit a target is to first determine the degrees from an angle (Angle * (Math.Pi/180)).

The x and y coordinates of the shot are figured out by:
- X = Math.Cos(Degrees) * Velocity and
- Y = Math.Sin(Degrees) * Velocity

## Further Enhancements
- Enhance the game to collect a username at the start and then to record the top 5 usernames/scores/timestamps in a file.
- It will display the top 5 scores and also the user's score at the end of the game

- Enhance the game to allow a second type of shot to be chosen, it is called a mortar
- This shot doesn't need to be so accurate. If the location is within 1 of the actual position then it is considered to be a hit, e.g, target at (7, 7) and shot lands at (6, 7)
then this is a hit.
- However, the angle can only be provided in increments of 5
