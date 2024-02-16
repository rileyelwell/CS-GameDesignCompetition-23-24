# Software Design & Architecture

## Introduction

This document outlines the architecture for a 3D driving-based
simulation/game that uses ADAS heavily. The chosen architecture needs to
ensure stability, performance, pseudorealism, realistic physics, and the
ability to demonstrate creativity. It should also allow us to create our
application for multiple operating systems (Windows, Linux, Mac).

## Architectural Goals and Principles

The architecture should allow for:

-   Integration with other program files (3D models, animations,
    scripts, etc.)

-   Performance/Stability that allows the application to run at 30+ FPS
    on a typical machine

-   Flexibility in features to allow for more design choices and
    scalability

-   A great physics system will enable us to have collision physics in
    our simulation

-   Good graphic capabilities to make realistic-looking vehicles and
    environments

## System Overview

Our system will store our assets (models, art, graphics) and scripts
(code) for the project inside of Unreal Engine 5. The game engine will
mainly handle the connections, only requiring us to import and export
necessary files. In terms of code specifically, we want to structure
using OOP (in C++) to enhance readability, stability, and inheritance
qualities.

## Architectural Patterns

We would likely use a layered architecture for our project; these layers
include:

-   Presentation layer:

> Handles rendering of graphics, user interface, and input processing.
> Provides the visual and interactive aspects of the game (including
> audio), ensuring a responsive and immersive experience for players

-   Game logic layer:

> Handles core game logic, such as physics simulation, vehicle behavior,
> and mission scripting. Ensures mechanics are consistent and player
> actions have the desired effects

-   AI drivers:

> The AI system will take in the world around it and use the vehicle I/O
> to control vehicles the same way a player would

-   ADAS systems:

> Built on top of the vehicle I/O, adas features will be able to read
> information about a vehicle and adjust the vehicle's behavior
> accordingly

-   Vehicle I/O (controlling vehicles):

> All vehicles will have a base system for controlling them (gas %,
> brake steering angle, gear shift, and special ADAS inputs & outputs)

-   RPM

-   Speed

-   Gear

```{=html}
<!-- -->
```
-   Vehicle logic

    -   All mechanical logic behind vehicles

    -   Torque & horsepower curves over RPM

    -   Revving behavior (redline)

    -   Drivetrain (RWD/FWD/AWD)

    -   Transmission gearing (ratios)

-   Physics:

> The logic of physics within the game world

-   Data access layer (optional):

> Handles saving and loading game progress, player profiles, and other
> data. This would be needed if we decided we wanted a structured
> database to hold this type of information (or multiplayer).

-   Network layer (optional):

> Handles the interaction between players and servers for multiplayer
> capabilities

## Component Descriptions

-   User Interface: Handles user interactions, displays data (vehicle
    speed, current objective, etc.), and provides navigation to other
    screens.

-   Game Engine: Unreal Engine processes all requests the game requires
    for running automatically, allowing us to focus on the gameplay
    logic in our scripts and the graphical presentation we choose to
    use.

-   Database/Serves: If we pursue multiplayer, we will likely need a
    server to handle the connections and a database to hold data for
    each user.

## Data Management

This section does not apply to our project. We should not need a
database to store user information inside the game. Unless we decide to
implement a user-saved game system, multiplayer, or some other save
mechanic, the game engine handles most of the work for us.

## Interface Design

Unreal Engine provides many of the tools necessary to make UI production
fairly simple. Once we decide on an actual design, we can use these
tools to test designs on the current product without deploying or
needing third-party services. We aim to keep the interface clean,
utilize as little space as possible, and always be informative to the
user (without distracting from the actual simulation).

## Considerations

## Security

Regarding our code, we will need to use good coding practices to avoid
exposing important variables to the user. Also, we need to ensure our
.gitignore file is set with the correct files, so nothing private gets
leaked on GitHub, as it is a public repository. There may also be more
security measures that need to take place. More security measures will
be necessary if the game gets multiplayer, as P2P connections are
generally insecure.

## Performance

We want the performance of the actual game to be at least 30 frames per
second, and this comes down to mainly the architecture (but also our
utilization of the software and how many polygons our models contain).
We want to ensure the game's necessary storage capacity is reasonable,
assuming we decide to make it into an executable (local storage). We
would also need server space to accomplish this if we pursue
multiplayer.

## Maintenance and Support

Future maintenance on this project would only likely be performed by our
current team members. This project is changed every year, and teams
start from scratch. Based on our overall vision for the end product, we
will likely end development at the end of the year. However, if we were
to provide updates later on, we would focus on new ideas for mechanics,
bug fixes, or requested features from users who have tested the game for
us.

## Deployment Strategy

This section only somewhat applies to us because we have been told to
focus on our own local machines. Our product will not be deployed
anywhere else besides our own computers and will be demoed in this state
at the Expo. Therefore, it seems that each environment will be
essentially the same in our game engine or as an executable we are
testing. Regarding the deployment strategy, we want a couple of releases
each term, with new features, bug fixes, or patches. With these
releases, we can also have users test the functions and gain feedback on
the program.

## Testing Strategy

As mentioned above, we will likely never ship our product past our local
environments, unless we desire to. This means our testing will be done
locally inside Unreal Engine or Windows computers. The testing results
may differ depending on our machines, which will help us compare
benchmarks for potential users.

## Glossary

ADAS - Advanced Driver Assistance System

UE5 - Unreal Engine 5

UI - User Interface

FPS - Frames Per Second

OOP - Object-Oriented Programming

PRD - Products Requirements Document

SDP - Software Development Process

SDA - Software Design and Architecture

P2P - Peer to Peer
