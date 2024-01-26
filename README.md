# Welcome to the Mini Solar System

## Week 2
Used spheres to create planets <br />
Used cylinder to form Saturn's ring <br />
Added a plane of stars for the atmosphere <br />
Uploaded images to create the individual material for each planet <br />
Each planet rotates around the sun <br />
Has two C# scripts (one that rotates the planet to mimic day, second that rotates around the sun to simulate year)

## Week 3
Created a star-shaped character using proBuilder tool <br />
Integrated character physics: changed friction <br />
Implemented movement and jump through input system: had an additional check to make sure the character can only jump on ground <br />
Added additional mechanic, dash <br />
When the R key is pressed, the player dashes forward for .5 seconds <br />

**Steps:**
1. Set R on the keyboard to be the activator
1. In Update(), there is a timer which increments by deltaTime, and when the timer has passed the cooldown time, canDash is set to true
1. In OnDash(), I first checked for canDash. If true, then the velocity is changed (timer is set to 0 and canDash is false). Dash stops after .5 seconds by calling the StopDash function, which sets velocity back to zero.
