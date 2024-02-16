I.R.S. (CS Game Design Competition - Group 3)

Ethan Largent, Riley Elwell, Connor Olsen

CS46X - CS Capstone

Product Requirements Document (PRD)

[[Problem Description]{.underline}](#problem-description)

> [[Scope]{.underline}](#scope)
>
> [[Use Cases]{.underline}](#use-cases)

[[Purpose and Vision
(Background)]{.underline}](#purpose-and-vision-background)

[[Stakeholders]{.underline}](#stakeholders)

[[Preliminary Context]{.underline}](#preliminary-context)

> [[Assumptions]{.underline}](#assumptions)
>
> [[Constraints]{.underline}](#constraints)
>
> [[Dependencies]{.underline}](#dependencies)

[[Market Assessment and Competition
Analysis]{.underline}](#market-assessment-and-competition-analysis)

[[Target Demographics (User
Persona)]{.underline}](#target-demographics-user-persona)

[[Requirements]{.underline}](#requirements)

> [[User Stories and Features (Functional
> Requirements)]{.underline}](#user-stories-and-features-functional-requirements)
>
> [[Non-Functional
> Requirements]{.underline}](#non-functional-requirements)
>
> [[Data Requirements]{.underline}](#data-requirements)
>
> [[Integration Requirements]{.underline}](#integration-requirements)
>
> [[User Interaction and
> Design]{.underline}](#user-interaction-and-design)

[[Milestones and Timeline]{.underline}](#milestones-and-timeline)

[[Goals and Success Metrics]{.underline}](#goals-and-success-metrics)

[[Open Questions]{.underline}](#open-questions)

[[Out of Scope]{.underline}](#out-of-scope)

# **Problem Description**

Learning to drive on the road has been easier for some people due to
driving simulators. Driving simulators are able to help people
understand how a car operates as if they were behind the wheel. However,
many of today's driving simulators are becoming outdated and fail to
offer all of the functions that all of our newer models of cars offer.
We need a driving simulator that can realistically demonstrate how cars
function in today's world.

Driving simulators are very fun to play and race in.

## **Scope**

The scope for our project is limited to driving traditional modern
vehicles in accurate-to-reality settings. Our settings are to only have
roads, traffic signs, non-player vehicles, and buildings (or at the very
least at a minimum). Our realism will be focused on the physics and ADAS
operations of the car. Stretch goals include extra realism in the
graphics, multiple maps based on real locations, a tutorial/learning
option, car customization, multiplayer support, driving wheel/pedal
support, and improvements to the minimum qualifications for the game
(improved non-player vehicle AI, more elements in the setting, improved
traffic systems).

Our market is towards both reckless gamers and those genuinely learning
to drive.

## **Use Cases**

For the following use cases, we will assume each user will start the
game and be brought to a isometric, birds eye view of a city, they then
select a vehicle and begin playing as that vehicle in the simulator.

The user will avoid accidents and obey traffic laws. The user continues
playing and can pause the game to take a break whenever needed.

The user does not obey traffic laws and attempts to avoid accidents but
fails to do so frequently. Each accident brings them to continue
retrying until they are tired and return to the menu.

The user plays the game for a while and does well. As they play and earn
achievements, they unlock new vehicles/maps/customization options. They
continue to play until they unlock a vehicle they were wanting. Once
they do they pause, return to the menu, and select their desired vehicle
and play on a new map. (We may only have one map and have different
starting points instead).

The user plays the game and leaves it without pausing the game. Vehicles
on the road get backed up behind them up to a point. After a certain
amount of time being idle, the user is automatically returned to the
game menu.

The user pauses the game as soon as it loads to go through the settings
and set everything to their liking. Once to their liking they select to
save their settings and now their current and future playthroughs will
use those settings until altered again.

# **Purpose and Vision (Background)**

Our purpose is to create a driving simulator game that provides users
with a realistic, modern driving experience that can be used for both a
user's enjoyment and/or education.

For the most part, past driving simulators have delivered an unrealistic
experience in a variety of ways. Over the top physics, unrealistic
colors and effects, lowered traffic risks, and failure to keep up with
modern vehicles. All things that we strive to avoid.

We want to provide a true to the modern world driving simulator game
that users can play feeling as if they were driving in the real world.
Something that can prove useful for those in driving education and
racing games.

# **Stakeholders**

Potential Employers -- no updates, no decisions

Competition Judges -- no updates, no decisions

Project Partner -- weekly updates, advice based off of our need

Project Groupmates -- weekly updates, equal say in all decisions for the
project and needs to be fully up to date with everything going on in the
group

Project TA -- weekly updates, guidance based off of our progress and
goals

Expo Users -- no updates, take note of desires for the project

Driving Instructors -- request feedback after version releases, take
note of desires for project

Driving Students -- request feedback after version releases, take note
of desires for project

For Enjoyment Users -- request feedback after version releases, take
note of desires for project

# **Preliminary Context**

## **Assumptions**

The game will run on Unreal Engine

We are free to use any tools we wish as long as it isn't a nearly
complete version of our project

We have at least 6 months dedicated to coding the project

The workload is split amongst three people

The game will be single player and doesn't need internet access for any
essential features

The game is for PC at a minimum and further ports may be stretch goals

The game is first person for realism

The game wants all non-player characters to avoid collisions at any cost

## **Constraints**

We are not to use paid tools not provided by OSU

The game is to run on an average PC

We have 6 months for the project

We have 3 people working on the project

Our group members each have at least 3 years of college experience

## **Dependencies**

We need our workplace and tools setup on each group member's machine
before we can begin development

We need a functional prototype before we can implement advanced features

We need our MVP complete before we can work towards our stretch goals

# **Market Assessment and Competition Analysis**

Forza: The game looks very realistic and the driving controls feel
realistic, however the game is also very forgiving with mistakes, has no
new modern vehicle features, focuses on racing rather than real life
driving practice and it makes itself feels like a videogame.

BeamNG.drive: The game does well to focus on driving in the real world
and abiding by traffic laws. It also does well with having realistic
visuals, driving controls, and collision physics. However, the game can
exaggerate its collisions and it fails to demonstrate the ADAS features
that new modern vehicles have.

iRacing: The game looks and feels very realistic, the driving controls
feel realistic, the mistakes are unforgiving. However, the game has no
new modern vehicle features, focuses on racing rather than real life
driving practice, and there is a subscription based payment to play the
game.

City Skylines: A great example of vehicle and traffic AI. However, this
game is a city builder and doesn't do well with player controlled
vehicles or much else from a drivers point of view.

Mario Kart: The game does well to create an enjoyable experience.
However, the driving controls are very unrealistic, mistakes are
horribly unforgiving, it makes itself feel very much like a video game,
and it fails to demonstrate any of today\'s ADAS features realistically.

Grand Theft Auto: Provides a free roam driving experience with
realistically stupid AI drivers. The driving physics is floaty and
geared more towards fun than simulation.

Many game engines have quality physics systems and other tools that have
no reason not to be used for our project.

# **Target Demographics (User Persona)**

Archibald and Barthalamult are first year OSU students checking out the
engineering expo. They are wanting to find a cool project to have fun
with.

Chris and Debbie are employers looking to hire game developers at the
OSU engineering expo.

In addition to the above examples, we have potential categories we could
group users into:

Enjoyment vs Education

Racing vs Law Abiding

Casual vs Competitive

Platform (PC)

# **Requirements**

## **User Stories and Features (Functional Requirements)**

  -----------------------------------------------------------------------------------------
  **User Story**                 **Feature**   **Priority**   **GitHub   **Dependencies**
                                                              Issue**    
  ------------------------------ ------------- -------------- ---------- ------------------
  As a driving student, I want   TBD           Must Have      TBD        N/A
  to learn to drive at home, so                                          
  that I can continue to learn                                           
  even when I'm not in a car.                                            

  As a driving student, I want   TBD           Should Have    TBD        N/A
  to have fun while learning to                                          
  drive, so that I stay                                                  
  motivated with my learning.                                            

  As a driving student, I want   TBD           Should Have    TBD        N/A
  to practice driving cars                                               
  before I get one, so that I                                            
  can know what kind of car I                                            
  should get and if I should get                                         
  one.                                                                   

  As a car buyer, I want to      TBD           Should Have    TBD        N/A
  practice driving a variety of                                          
  cars, so that I know what                                              
  kinds of vehicles I prefer.                                            

  As a driving instructor, I     TBD           Must Have      TBD        N/A
  want to give my students an                                            
  opportunity to learn with no                                           
  risks, so that they can stay                                           
  safe when they learn to drive.                                         

  As a driving instructor I want TBD           Could Have     TBD        N/A
  to give my students good                                               
  un-proctored study material,                                           
  so that I don't have to spend                                          
  as much time teaching.                                                 

  As a new gamer, I want to see  TBD           Must Have      TBD        N/A
  what driving simulator games                                           
  are all about, so that I can                                           
  know if I like them or not.                                            

  As a gamer, I want to have a   TBD           Should Have    TBD        N/A
  realistic driving experience                                           
  in a game, so that I can have                                          
  fun and immerse myself.                                                

  As a gamer, I want to see how  TBD           Could Have     TBD        N/A
  reckless I can drive without                                           
  getting in an accident, so                                             
  that I can vent my reckless                                            
  driving intrusive thoughts.                                            

  As a gamer, I want to have a   TBD           Could Have     TBD        N/A
  change of pace and drive                                               
  leisurely, so that I can have                                          
  a low stress driving                                                   
  experience in my games.                                                

  As an experienced gamer, I     TBD           Could Have     TBD        N/A
  want to earn all of the                                                
  achievements in a realistic                                            
  driving simulator, so that my                                          
  friends all think I'm cool.                                            

  As a student at the expo, I    TBD           Should Have    TBD        N/A
  want to find a project that                                            
  peaks my interest, so that I                                           
  can become inspired in my                                              
  education goals.                                                       

  As an employer at the expo, I  TBD           Should Have    TBD        N/A
  want to see an impressive                                              
  representation of a student\'s                                         
  skills, so that I'm confident                                          
  in their ability as an                                                 
  employee.                                                              

  As a judge for the game design TBD           Will Have      TBD        N/A
  competition, I want to find a                                          
  realistic driving simulator                                            
  with ADAS, so that I can have                                          
  a winner for the competition.                                          
  -----------------------------------------------------------------------------------------

## **Non-Functional Requirements**

The quicker the response time the better, but it must feel fluid/be
playable

The game should be stable with minimal bugs and no crashes

The game should have minimal frame drops

The game should run spectacularly acceptably on an average grade of PC

## **Data Requirements**

Game\
- Player player\
- NonPlayers nonplayers\[\]\
- Map currentmap\
- Map maps\[\]\
- Vehicle currentvehicle\
- Vehicles vehicles\[\]\
- Achievement achievements\[\]

Player\
- string name\
- float playtime (Any other statistics to record)\
- int brightness\
- float sensitivity (Any other settings to include)

Non-player\
- string name\
- Vehicle vehicle

Map (consist of obj files with physics and interactions for each kind of
object)\
- objects: roads (bridges, tunnels, etc.), signs (stop, yield, etc.),
traffic lights, buildings, nature

Vehicle\
- objects: parts of the vehicles\
- string name\
- int currentspeed\
- int topspeed (Any other vehicle behavior variables)\
- bool functional

## **Integration Requirements**

The game will likely be fully developed using Unreal Engine 5

## **User Interaction and Design**

Startup: Opening the game brings the user to a menu screen that gives
the user 5 options from there: Play, Select Map, Select Vehicle,
Achievements, and Settings. Each brings the user to the corresponding
menu.

Play: Brings the user to a screen showing their selected vehicle in
first person view on the selected map ready to be controlled with player
input. The world around them will change close to how it does in the
real world. Pressing escape brings the player to the Pause Menu and
freezes all interactions on the map (Play may also bring users to a game
mode screen that could change how the game plays before they are brought
to the core of the game).

Pause Menu: Brings the user to a pause menu giving them 6 options:
Resume, Save, Load, Restart, Settings, Return to Menu. Resume will bring
the user back to Play. Save will save the current game environment. Load
will bring the user back to their most recent save (or to select a
save). Restart will reset the entire map from the beginning of their
session. Settings brings the user to Settings. Return to Menu returns
the user to the Startup screen.

Select Map: Brings the user to a list of all the maps (or locations)
they have unlocked and all of their locked maps. Each locked map will
tell the user the achievement they need to complete in order to unlock
it. When viewing a map that the user has unlocked, they can select it
which will bring them back to the menu with that map selected.

Select Vehicle: Brings the user to a list of all the vehicles they have
unlocked and all of their locked vehicles. Each locked vehicle will tell
the user the achievement they need to complete in order to unlock it.
When viewing a vehicle that the user has unlocked, they can select it
which will bring them back to the menu with that vehicle selected.

Achievements: Brings the user to a list of all the different
achievements the user can try to complete. Each achievement will display
its name, requirements, and what it unlocks. Exiting brings the user
back to the menu.

Settings: Brings the user to a screen displaying all of the alterable
settings in the game as well as a save button and a cancel button.
Pressing save will change the users' settings to reflect what they set
them to and send where they came from. Pressing cancel will send them to
where they came from without saving their changes.

(Mockup sketches after group discussion)

![](media/image3.png){width="6.83451990376203in"
height="4.249617235345582in"}![](media/image4.png){width="3.029061679790026in"
height="2.1249956255468065in"}

![](media/image1.png){width="5.0in" height="2.447952755905512in"}

# **Milestones and Timeline**

> 1\. Create Workspace
>
> 2\. Learn UE5
>
> 3\. Create a rough prototype -- requires 1 and 2
>
> a\. Basic graphics
>
> b\. Basic map -- requires a
>
> c\. Basic vehicle behavior
>
> d\. Basic traffic system
>
> e\. Basic controls -- requires b and c
>
> f\. Basic non-player AI -- requires b, c and d
>
> 4\. Update vehicle behavior -- requires 3
>
> 5\. Update player control -- requires 4
>
> 6\. Develop non-player vehicle AI -- requires 4
>
> 7\. Complete a map layout -- requires 3
>
> 8\. Update map graphics -- requires 7
>
> 9\. Implement full traffic system -- requires 7
>
> 10\. Update vehicle graphics -- requires 3
>
> 11\. Update physics -- requires 3
>
> 12\. Create Menu/Settings/Pause Screens

# **Goals and Success Metrics**

  -----------------------------------------------------------------------------
  **Goal**         **Metric**        **Baseline**   **Target**     **Tracking
                                                                   Method**
  ---------------- ----------------- -------------- -------------- ------------
  Increase user    Decrease in       TBD            TBD            Plausible
  performance      collisions over                                 Analytics
                   time                                            

  Increase player  Average active    TBD            TBD            Plausible
  base             players                                         Analytics

  Decrease bug     Number of         TBD            TBD            Player
  occurrences      reported                                        Reports
                   occurrences                                     

  Product-market   How would you     TBD            TBD            Survey
  fit              feel if you                                     
                   couldn't play the                               
                   game?                                           
  -----------------------------------------------------------------------------

# **Open Questions**

Q: Will we port the game to other consoles/controller schemes?

Q: What will each of our group members be focusing on?

Q: Are we planning to take this project beyond the class?

# **Out of Scope**

No non-player humans involved in traffic systems

No custom advanced water physics or lighting

No focus put on racing

No multiplayer or cross-save
