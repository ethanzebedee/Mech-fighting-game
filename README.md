# 2,000 Tonnes of Steel

## Showcase

2,000 Tonnes of Steel is a Unity mech-combat prototype built around a simple but readable loop: move through a city arena, track a hostile mech, manage incoming damage, and finish the fight before your own machine is destroyed.

This project is an early vertical slice rather than a finished game. The value of the work is in the combat foundation: top-down movement, mouse-driven facing, ranged attacks, enemy pursuit, health and UI feedback, and environmental interaction through destructible buildings.

## Project Snapshot

- Genre: 3D mech combat prototype
- Engine: Unity 2017.3.0f3
- Language: C#
- Platform target: Desktop
- Current content: One playable demo scene

## Core Experience

The prototype drops the player into a contained arena encounter against an enemy mech. The player moves freely, rotates toward the mouse cursor, and fires using a forward raycast weapon. The enemy uses NavMesh pathfinding to chase the player and switches to close-range attacks when in range.

That encounter is supported by UI systems that communicate damage, health, and match outcome, giving the prototype a clear start-to-finish combat flow instead of feeling like a disconnected systems test.

## Highlights

- Mouse-aim mech control with keyboard-driven movement
- Raycast-based ranged combat with shot effects
- Enemy pursuit using Unity NavMesh
- Enemy melee attack behavior with animation trigger support
- Health tracking for both combatants
- On-screen damage feedback and mech-part damage display
- Randomized enemy spawn selection
- Destructible building props that react to collisions
- Win and game-over state presentation in the demo scene

## Controls

- `W`, `A`, `S`, `D`: Move
- Mouse: Aim / face direction
- Left Mouse Button: Fire

## Technical Breakdown

### Player Systems

The player controller combines Rigidbody-based movement with mouse-directed turning. This creates a control scheme that fits mech combat well: movement and aiming are separated, so the player can reposition while keeping pressure on the target.

Combat is handled through a raycast weapon script that applies damage to enemies on hit and drives simple visual feedback through a line renderer and light effect.

### Enemy Systems

The enemy mech uses a NavMeshAgent to continuously pursue the player. When the player enters attack range, the enemy triggers melee damage and attack audio, creating a straightforward pressure loop that forces movement and spacing.

### UI and Feedback

The prototype includes several layers of combat feedback:

- A health slider for the enemy
- A damage flash overlay for the player
- A mech damage panel that tracks damage state by body section
- End-state UI for victory and defeat

### World Interaction

Arena props are not purely decorative. Building objects respond to collisions, play destruction audio, disable visible geometry, and remove themselves from the scene. That small interaction helps sell the scale and impact of the mech theme.

## Project Structure

Key gameplay scripts live in the following folders:

- `2,000 tonnes of Steel/Assets/Scripts/Player`
- `2,000 tonnes of Steel/Assets/Scripts/Enemy`
- `2,000 tonnes of Steel/Assets/Scripts/GameManagement`
- `2,000 tonnes of Steel/Assets/Scripts/Camera`

The current playable content is in the demo scene:

- `2,000 tonnes of Steel/Assets/Scenes/Demo.unity`

## Running The Project

1. Open the project folder `2,000 tonnes of Steel` in Unity.
2. Use Unity 2017.3.0f3 for the closest match to the original setup.
3. Load the Demo scene.
4. Press Play in the Unity editor.
