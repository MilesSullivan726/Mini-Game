# Another Asteroids Clone

This game is a simple top down shooter inspired by asteroids. Control a small ship and blast asteroids to score points, all the while avoiding said asteroids to prevent a game over!

**Controls**

- Arrow keys to move
- Space bar to shoot

**How to Play**

Shoot asteroids to score points. The smaller and faster the asteroid, the more points you earn. Move around to dodge asteroids, and see how many points you can get before you game over!

**Game Features**

- Controllable player character that moves up, down, left, and right using the arrow keys and fires projectiles with spacebar. Player is destroyed on contact with an asteroid. Bounds are set to prevent player from moving off screen. Fire rate cap is also set to 0.3 seconds between shots to prevent spam.
- Asteroid spawners that instantiate small, medium, and large asteroids randomly and in a random range.
- Asteroid obstacles that move forward after being spawned by adding force to them. Can be destroyed with a projectile, adding points, or hit the player ending the game. Different sized asteroids have different speeds and point values.
- Points system that tracks total points earned and displays them to the player. Small asteroids are 3 points, medium are 2, and big are 1.
- Game over screen that stops the game when the player dies and displays the final amount of points earned.
- Off-screen "despawners" to catch any missed projectiles and asteroids that simply destroy anything that collides with them.

**Assets**

All game objects and materials are Unity primatives and modified default materials. Unity's Create with Code units 1 and 2 were used as reference for some scripts.
