# unity-obstacle-course-game
obstacle course game built with Unity. The player must navigate through moving obstacles to reach the finish line. Includes physics-based collisions, failure tracking, and responsive player control.


The player (yellow cube) must reach the finish line while avoiding dynamic obstacles like spinners and rollers. The game includes basic physics interactions, movement logic, and a strike system – touching an obstacle turns the player red and adds a fail count.

## Features
- Third-person player controller
- Physics-based obstacles (spinners, rollers)
- Collision detection and loss logic
- Score / failure tracking
- Modular components for easy extension

## Project Structure
- `Assets/Scripts/Mover.cs` – Player movement and interaction
- `Assets/Scripts/ObjectHit.cs` – Obstacle behavior

## To Run
1. Clone the repo
2. Open in Unity (tested on Unity 2022+)
3. Play the scene "Main" or "SampleScene"

## Notes
This was my first Unity game project, focused on core mechanics and modular design. More levels and UI elements planned for future versions.

