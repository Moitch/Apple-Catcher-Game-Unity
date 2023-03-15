# Apple-Catcher-Game-Unity
Exercise 2 in Unity.
Mitchell Foley
COMP-4478
![image](https://user-images.githubusercontent.com/55286115/225471023-78cedaa4-8a58-4667-a1bd-b9c612831267.png)

**AppleMoveScript.cs**

Initializes the movement speed (moveSpeed) varaible for the apples as well as the deadzone (deadZone) where the apples are 
far enough off the screen to be destroyed.

Within the update function, the position of the apple is constantly being updated using the moveSpeed variable and Time.deltaTime
to create a smoother movement. It also checks to see if the y value of the apple is less than the deadzone (y = -6.5), if it is then destroy 
the apple.

**-------------------------------------------------------------------------------------------------------**

**AppleSpawnerScript.cs**

Initializes Two pre-fab game objects, goodApple and badApple.
heightOffset is a float that is used to offset the location of where apples can spawn from.

spawnGoodApple() is the method for spawning red apples.
First it creates a left (leftMax) and right (rightMax) maximum x value where the apples can spawn, then using
the Instantiate function it creates a new goodApple object with a random x value between leftMax & rightMax.

spawnBadApple() is the method for spawning rotten apples, it is a clone of spawnGoodApple() but for badApple.

These functions are called using the InvokeRepeating function with the Start() function.

**-------------------------------------------------------------------------------------------------------**

**BasketScript.js**

Initializes variables to determine if game is running, the speed of the basket, logic behind the game, sprites, and sound effects.

Within the Start() function, it looks for a game object with the tag "Logic" to give the logic variable a value.
In Unity, LogicScript.cs was tagged with "Logic" because it is used to access many useful things.

The Update() function is used to get inputs from the player and update the sprite. It checks if the left or right arrow keys were pressed
or being held down and moves accordingly. It also runs updateSprite() every frame to make sure the sprite is up to date.

OnTriggerEnter2D() checks for collision with the basket and the apples. It does this by checking if it collided with an object on layer 3 or layer 6.
Within Unity the goodApple is on layer 3 and the badApple is on layer 6.

UpdateSprite() updates the basket sprite whenever the player reaches a score of 5, 10, and 15.

**-------------------------------------------------------------------------------------------------------**

**BoundariesScript.cs**

Initializes the screenBounds variable that is then called in Start() to get the current boundaries of the screen.

In LateUpdate(), using the Mathf.Clamp function we can calculate the boundaries for x & y of the Vector3 variable viewPos.
Using the viewPos variable, we prevent the basket from leaving the boundaries of the Vector3.

**-------------------------------------------------------------------------------------------------------**

**LogicScript.cs**

Initializes the int variabel playerScore to keep track of the players current score, the scoreText text object to update the UI, the gameOverScreen object which contains a Text object and a Button object.

addScore(int scoreToAdd) takes in the score to add, in this case it is usually 1 but can be changed easily. It adds the passed score to the current score
and then updates the scoreText object using playerScore.ToString().

restartGame() loads the game scene again and sets the timeScale to 1 to start the flow of time again within the game.

gameOver() sets the gameOverScreen to active as it is hidden usually. It also sets the timeScale to 0 so the flow of time in the game stops, this includes the
movement of the player and the movement of the apples.

![image](https://user-images.githubusercontent.com/55286115/225471295-12f121dc-253b-4c22-8346-0ac627b8585e.png)

