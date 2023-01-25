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

