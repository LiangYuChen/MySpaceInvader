# MySpaceInvader
A space invader clone

Liang Yu Chen, 2024 2/15, version 2

# Overview
It follows the rules of the original game, but it is not a direct copy of it. It is a simplified version.

# Programming Overview
The game is written in Unity Engine (Version: 2022.3.19f1), using C# as the programming language. The game is designed to be a MVC (Model-View-Controller) architecture, with the following components:
1. Model: The game state, including the player, the aliens, the bullets, and the game score.
2. View: The game screen, including the game play view, and a leaderboard view.
3. Controller: The game logic, including the game mechanics, player control and UI control.
4. The game uses the Unity Engine's built-in physics engine for 2D collision detection and movement.
5. The game uses the Unity Engine's UI Toolkit for the game's UI.
6. The game uses the Unity Engine's PlayerPrefs for saving the high scores.
7. The game uses the Unity Engine's Coroutine for the game's respawn mechanism.
8. The game uses the Unity Engine's Input System for player input, currently only supports mouse input.
9. The game play view includes multiple game states, including the start screen, the game play screen, and the game over screen.
10. The player, the aliens and the bullets are implemented using Unity 2D sprites.

# Detailed Game Mechanics And Interactions
1. The player can move left and right using the mouse movement.
2. The player can shoot bullets using the left mouse button.
3. The player has limited ammo supply, and the ammo is displayed on the screen.
4. The player's ammo supply is replenished when the game is restarted.
5. The player's ammo count is some factor multiply by alien count, and the factor is adjustable in code, and the initial value is set to 3.
6. The player can destroy the aliens by shooting them, one hit one kill.
7. The aliens shoot bullets, move left and right and down, and move faster as the game progresses.
8. The aliens move faster as the game progresses, and the speed is adjustable in code, and the initial value is set to 1.
9. The aliens move down when they reach the edge of the screen, and move left and right when they reach the edge of the screen.
10. The aliens shoot bullets at a fixed interval, and the interval is adjustable in code, and the initial value is set to 1.
11. The aliens' bullets are destroyed when they reach the bottom of the screen.
12. The aliens move in a formation, aliens' position is arranged in a grid, and the grid size is adjustable in code, and the initial value is set to 3x5.
12. Successful hits on the aliens are rewarded with points, different aliens have different point values.
13. There are 3 types of aliens, each type has a different point value, and the point values are adjustable in code, and the initial values are set to 10, 20, and 30.
14. The top 10 scores are saved in the PlayerPrefs, and the leaderboard view shows the top 10 scores.
15. The game ends when the aliens reach the bottom of the screen or when the player runs out of ammo or hit by alien bullets.
16. The game has a scoring system, the player's score is displayed on the screen.
17. The game has a start screen, a game play screen, and a game over screen.
18. The game has a restart button on the game over screen, and a leaderboard button on the game over screen, and a back button on the leaderboard view.
19. The game has a respawn mechanism, the aliens respawn when the game is restarted.
20. The game has a leaderboard view, shows the top 10 scores and a restart button.

# Flow Chart Of The Game
The game has a start screen, a game play screen, and a game over screen. The game flow is as follows:
1. The game starts with the start screen, the player can start the game by clicking the start button.
2. The game transitions to the game play screen, the player can play the game.
3. The game ends when the aliens reach the bottom of the screen or when the player runs out of ammo or hit by alien bullets.
4. The game transitions to the game over screen, the player can restart the game by clicking the restart button and view leaderboard by clicking the leaderboard button.
5. The game transitions back to the start screen when the player clicks the restart button.


## Reference

Video Reference On Youtube
: https://www.youtube.com/watch?v=MU4psw3ccUI

Reference On Wikipedia
: https://en.wikipedia.org/wiki/Space_Invaders
