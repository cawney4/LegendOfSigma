# Legend Of Sigma
### Connie Chang
#### PennApps XVII Project

Game Overview
------------------------
You are testing a new time travel machine, created by the Sigma Corporation. Hooray, the machine works! But... you travelled too far into the future, and landed in a post-apocalytic era! To make matters worse, the time machine used up all its power. Now, you need to collect batteries to restore power to the machine and head back home!  

Legend of Sigma is a top-down 2D game with a roguelike feel. Navigate through a randomly generated dungeon and search for batteries while avoiding enemies to restore the time machine!  


Technical Overview
------------------------
This game was created with Unity3D, version 2017.1.1f1.  

I programmed player movement, a simple enemy AI, and item pickup. Player movement simply reads the keyboard input every frame and moves the player in the corresponding direction at a set speed. The enemy AI has the enemy walk in a random direction. If the enemy hits an object of any kind, its velocity reverses, making it walk in the opposite direction. For item pickup, the items were marked as triggers so Unity could automatically detect when the player collided with an item and execute my pickup code. In addition, I created the background image for the beginning and end scenes, which is just the letter Sigma.  

The remaining game logic and art were free assets from the Unity Asset Store. 

Dialog boxes were made with RPGTalk (https://www.assetstore.unity3d.com/en/#!/content/73392). It reads text from a .txt file and displays it nicely in a dialog box. It also handles input to move the dialog forward.  

To create a randomly generated dungeon, I used scripts from 2D Roguelike (https://www.assetstore.unity3d.com/en/#!/content/29825), which is a Unity tutorial. They use random number generators to create differently sized rooms, connected with corridors from random directions. Their demo scene also included some artwork that I borrowed, as I am not an artist at all. The player, enemies, floor, and wall sprites all come from 2D Roguelike.  

Other art (the spaceship and battery sprites) came from Simple Spaceships by 3dJeebs (https://www.assetstore.unity3d.com/en/#!/content/81051). 
