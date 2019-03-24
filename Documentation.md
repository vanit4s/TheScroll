

F454 Computing Project

A2 Computing OCR – F454


By Szymon Kowalski

9/3/2015


Stockton Sixth Form College


 
Table of Contents
Contents
Table of Contents	1
Section 1 – Definition, investigation and analysis	4
Problem Definition	4
Existing Documentation	7
Initial Plan of Action	8
Investigation	9
Client Interview (WILL BE FILLED OUT ON PAPER)	9
Initial Interview	10
Observations in the current system	12
Second Interview (WILL BE FILLED OUT ON PAPER)	12
Second Interview results	14
User Group aim	16
Analysis	16
Data Dictionary	16
Data Dictionary Gameplay Controls	17
Data Sinks and Sources	18
Data Flow Diagram	19
Existing System: Structure Diagram	20
Existing System: Problem	21
Justification of Information Collection methods	22
Requirements Specification	23
Input Requirements	24
Output Requirements	25
Processing Requirements	26
Alternative choices	27
Estimating File Sizes	30
Software and Hardware requirements	31
Scope	32
Design and Test Strategy	33
System Objectives	33
New System: Structure Diagram	35
Login Form	35
Register Form	36
Main Menu	37
Game Launch	38
Data Structures and Validation	39
HCI Design	40
Main Menu	40
Play Menu	42
Login	44
Register	46
Scoreboard	48
Game Form	49
Data Structure Design	50
Game Form	50
Login Form	52
Register Form	53
Test Strategy: Test plan	54










Section 1 – Definition, investigation and analysis

Problem Definition
In this project I will be developing a game in Visual Basic 2008 without the use of an engine. The game will be made for everyone interested in such tastes however it will specifically be made for my client. The game will fit under the ‘platform’ genre of games meaning that the character(s) will be placed and manoeuvre on platforms. Platform games (usually referred to as platformers) originated in the early 1980s. The game allows the user to control a character with the use of a keyboard; directing the character. Once the character makes its way through a mass of obstacles it will precede to a higher, much difficult level. Some of the obstacles will be much unexpected and can change depending on the amount of tries to pass the level. The amount of lives at the end of each chapter will add up and give a general score, at the very end of the game when the player finished all of the chapters all of the scores are added up.
My client is Anthony Jones; he is also a programmer however he looks for people in order to promote their games. In this case the project is supposed to go back in history and make a game with age. Platformer games were one of the first game types to actually be classified as games. Anthony came up with an idea for a project but was not able to finish it. The project landed on my hands and is supposed to bring back the history of gaming to the modern, advanced, world of gaming. He will promote my project as he thinks it’s a good way to get people to familiarize themselves with the history of gaming. The project itself is supposed to be fairly simple and create good impressions with the features that would be different to other platform games.
 
(Mockup game by a user on deviantArt)
The general idea of the project is to improve the features of the game to make them more modern, fitting the ‘realm’ of advanced gaming. In most versions of platform games the objective is to reach a certain point, some being easy and some being more difficult. I plan on implementing extra features that will make the experience better. One of those features will be surprises hidden around the built levels which will ask questions to the user – if the question will be answered correctly the player will be able to pass, if not… the level restarts. The questions will be regarding other versions of platformers or older generations of games to again emphasize the point of making the project.
The customer is an individual person who contacts developers such as me to make them a project and in exchange he will promote me and my company. He has contacted me on a forum where I have advertised my skills as well as my free time and he is very open on other ideas. The project in general will be a game in which the player will control the character with a set of keys. The character will have a set of skills that will apply to certain in-game events. The amount of skills will be limited due to the size of the project but my customer strongly agreed. My customer asked me whether I can create some scenarios that would fit in with the game’s feel and environment, making it a better experience. 
The main objective is to move the character to a certain point at which the player is able to progress to further levels (if any). Throughout the gameplay the player might choose to take certain paths to check if it is possible. The platform usually includes many obstacles which restart the level immediately. There might be objects called boosters or objects which cause a certain outcome on the level, this might be absolutely random – for example a block with a quiz, if answered right the person is able to progress. In a game such as The Super Mario Bros the player finished the game by dropping through a pipe which leads the player into a further level. The levels are whole of surprises such as deadly obstacles or objects of interactions such as the quizzes mentioned above. To keep the game more competitive either locally (LAN) or over WAN (Wide Area Network) there should be a scoreboard.
The game will be saved at each level, later on in the development I plan to increment difficulty levels which only allow players to save each number of levels, chapters or without being able to save for the length of the game.
 
(Screenshot of a platform game; Super Mario Bros)

Existing Documentation
 

Initial Plan of Action

I have prepared an interview with my client, alongside the specific question I will have to ask in order to gain information. I will ask my client about the details of the game, the style and specific features. The following are the questions I intend to ask:
•	Have you ever played a platform game? If so, how many variations?
•	What should be included in the system?
•	What features did you enjoy?
•	What features did you dislike?
•	What are the features you would like to see in a new version of the game?
•	Should there be a colour pattern within the game?
•	Should the user be able to modify the settings within the game such as graphics, sound and others?
•	Should there be any ways of making the difficulty easier for the player?














Investigation
Client Interview (WILL BE FILLED OUT ON PAPER)

Initially I have received expected answers to my questions. My client had played a few different variations of the genre; he also had a few problems with the previous versions. My client pointed out that the game type is very enjoyable however might get less amusing further on the progression. 
1.	Have you ever played a platform game?
___________________________________________________________________________________________________________________________________________________________________.
2.	How many different variations of the said game have you played?
______________________________________________________________________________.
3.	What features did you enjoy?
_____________________________________________________________________________________________________________________________________________________________.
4.	What features did you dislike?
_____________________________________________________________________________________________________________________________________________________________.
5.	What new features would you like to see in the new version of the game?
__________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________.



6.	What should be included in the system?
___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________.
7.	How could the game be made harder?
_____________________________________________________________________________________________________________________________________________________________________________________________________.
8.	How should the score be summed up? Should it be visible to everyone, should the player have a choice?
__________________________________________________________________________________________________________________________________________________________________________________________________________.
9.	Should there be any special features allowing the player for shortcuts?
_______________________________________________________________________________________________________________________________.










Initial Interview

I have interviewed my client as well as a couple of other people fitting into my criteria allowing me to further understand the system from different perspectives. I now understand how the system might be improved and what features are almost required in the new version. I asked questions generally about their experiences with the game type, what they liked, disliked and what would be interesting as an addition in my version of the game. As the answers show many different variations of platform games I can now go deeper into research to base my project on. The answers show that different, more sophisticated features would be very welcome as an addition to my project; this didn’t come as a surprise as the people answering my questions have all played a version of a platform game before.
1.	Have you ever played a platform game?
Yes, I have played many platform games before such as Super Mario Bros, Jetpack, Shinobi and many more.
2.	How many different variations of the said game have you played?
Probably around 10 different version, as I said one of the best ones are Super Mario Bros, Jetpack, Shinobi and some modern versions.

Based on the results of my initial interview I have considered a few requirements with the consideration of the compatibility of features in the game:
	Static Requirements:
1.	The game restarts/ends at a point where the controllable object falls out of the map.
2.	The game restarts/ends at a point where the controllable object collides with a special, ‘deadly’ obstacle.
3.	Player is able to change the direction of travel.
4.	The player is able to avoid obstacles through provided controls.
Variable features:
1.	Player progresses through levels of difficulty which are incremented at every higher level.
2.	Player is allowed to choose the level he wants to play with the use of a save, proving that the player has previously unlocked the level.
3.	At each incremented level the speed and environment of the gameplay might change, depending on the difficulty.


Observations in the current system
Most of the current systems are very alike with very little choice to the player. Although more versions start to emerge with many unique ideas I thought of implementing into my project. Most games operate using the same controls and storing the information in a similar way; some platform games don’t have a scoreboard or any options allowing saving the game’s progress. Also most games have some sort of progression with incrementing difficulty levels but there is no mention of special abilities which could in fact affect the difficulty of the game’s progression. The older games didn’t have much means of saving progress (early 1980s) until systems with saving cards were developed. Only recently the games have become more and more dynamic, meaning that the gameplay becomes faster.

Second Interview (WILL BE FILLED OUT ON PAPER)
I needed to prepare a second interview in order to find more specific requirements and settings that would fit for every user. I need to satisfy my user’s requirements and to decide the changes of the incremented difficulty levels; their lengths, duration, speed and other features. I also need to obtain specific information on the design of my game, specifically the character and its surroundings. The following questions will be asked:
1.	What’s the resolution of the window that would satisfy you?
640x480	400x400	900x900	Other
☐
☐
☐


2.	Should the length of the platform be incremented at each difficulty level or should it be speed?
Length	Speed	Other
☐
☐


3.	Approximately how large should the controlled object be? (In pixels)
5x5	10x10	Other
☐
☐


4.	Should the game have a quick increment of difficulty levels – i.e. should it be shallow, medium or steep? All of the above increase in 10ms.
Shallow	Medium	Steep
☐
☐
☐


5.	Should there be a large variety of levels?
__________________________________________________________________________________________________________________.


6.	How should the levels be chosen? Should it be a separate window?
_____________________________________________________________________________________________.

7.	Should there be a specific colour scheme?
_______________________________________________________________________.

8.	Should there be other ways of controlling the character? (Keyboard wise)
_______________________________________________________________________________________.

9.	How many levels should there actually be?
__________________________________________________________________________________________________________.

10.	Should the controlled object stay the same size and have the same design throughout the game?
__________________________________________________________________________________________.

11.	Are you generally happy with the features listed?
Yes	No
☐
☐


12.	How many levels in total should there be?
_____________________________________________________________________________________________.

13.	Should there be any cheats allowing to modify the game?
_______________________________________________________________________________________________________.







Second Interview results

From the interview’s results I can deduce that that the resolution chosen for the project will be 640x480 but the user will be able to go full screen. My client asked me to keep the colour scheme fairly simple; this means I will stick to a blue gradient with some generic background, probably brighter than my platform. The difficulty of the level should be increased by the amount of obstacles or difficult moves the player has to make. Controlled object should be big enough to be able to see it fairly well; this will also contrast with the controllable character. 
The difficulty increment curve should go up in medium increments. The game should keep to a low amount of levels for the beginning since they should be increasingly hard. Chapters might be incremented later allowing the player to get the full experience in a single chapter. There should be enough levels to prove difficult, this means there should be around 10 levels. The controlled character should remain the same size and design throughout the game not to bring up any confusion. My client was generally happy with the features I listed; he also said the implementation of my features will definitely improve the game experience.
1.	What’s the resolution of the window that would satisfy you?
My client has chosen the size of 640x480 but it should be variable, meaning that the player should be able to maximize the game. This is because some computers have different sized monitors; this issue could cause a big problem in the experience. The client has also asked whether it’s possible for the player to be able to choose the resolution within the settings menu.
2.	Should the length of the platform be incremented at each difficulty level or should it be speed?
The difficulty should increment the amount of deadly objects and tricky ways to get past obstacles. There might be a change in the speed of the movement of the character depending on the situation. Generally the main change with the difficulty should be the location of obstacles and the strategy of allowing the player to choose their path.
3.	Approximately how large should the controlled object be? (In pixels)
The character should be large enough to be able to be seen within the environment and the surrounding, therefore it should be as big as possible depending on the scaling of the level. This would probably be the 25x25px option.
4.	Should the game have a quick increment of difficulty levels – i.e. should it be shallow, medium or steep?
The increase should be medium. Depending on how the difficulty levels will be constructed they will increase fairly quickly but not too quick. 

5.	Should there be a large variety of levels?
There should be enough levels to allow for the difficulty system to work. There shouldn’t be a large variety, for example 20-40 levels. In the means of the variations of designs, all of the levels will be different in ways of object locations. In the future the chapters (packs of levels) could have different designs to emphasize how close the player is to winning the game.
6.	How should the levels be chosen? Should it be a separate window?
The levels should be chosen after the player loads their save. This will allow keeping everything tidy and will prevent cheating. This will make the game more competitive as players will have to achieve something in order to progress.
7.	Should there be a specific colour scheme?
There should be a difference to the environment, which will be clear to the player. The controllable character will be a gradient of blue while the background (probably a sky) will be brighter to easily contrast.
8.	Should there be other ways of controlling the character? (Keyboard wise)
The character should be controlled with the simple and basic controls of UP, DOWN, LEFT and RIGHT. The idea of sprinting is very unique but should be limited to certain scenarios or by a counter which doesn’t allow the player to speed up too often. This will also be useful in order to pass certain obstacles.
9.	How many levels should there actually be?
As said in one of the points above, there should be a couple of levels. I’d say the amount of levels should be limited to around 10-15 allowing the difficulty level to kick in.
10.	Should the controlled object stay the same size and have the same design throughout the game?
It should remain constant no to create any confusion. There might be some transitions and animations but the size shouldn’t generally be changed.
11.	Are you generally happy with the features listed?
Yes.
12.	How many levels in total should there be?
There should be around 1-15.
13.	Should there be any cheats allowing to modify the game?
We should keep the game simple; however this is a very good concept.
User Group aim

The user group will be anyone who will want to play the game, mostly people at college age. Because of this I will need to base my requirements on the needs of teenagers and feed it back during the development. There are many extra features that could be added to a platform game, such as special ‘powers’ allowing to travel faster, modify the gravity or even allow the player to go through the next met colliding block. There also could be different difficulty levels, this will depend on the progression of the player through levels; each of the levels being harder and harder. In order to discover the features that the players of the game will desire I need to develop a requirements specification that I shall conduct through a series of interviews on teenagers fitting the criteria.
Analysis
Data Dictionary

Login Form:
Field Name	Data Type	Length	Example	Justification
Username	String	15	Astronaut	Defines the user’s nickname.
Password	String	20	Apple223	Defines the user’s password
UserID	Integer	4	3498	Defines user’s ID.
Group	Boolean	1	User/Administator (Moderator)	Defines user’s group and permissions.
Score	Integer	4	561	Shows the general score of the player.
Level	String	15	Level: 20	Defines the player level.






Register Form:
Field Name	Data Type	Length	Example	Justification
Username
	String	15	Astronaut	Defines the user’s nickname.
Password	String	20	Apple223	Defines the user’s password.
PasswordRep	String	20	Apple223	Validates/Confirms the password.
Email	String	15	Astronaut@gmail.com	Defines the email of the user.
Age	Date & Time		22	Defines the user’s age for validation.

Data Dictionary Gameplay Controls
The controls in my project will be very similar to the ones in previous versions of the game not to confuse anyone. I will add a feature allowing the player to change the controls in the settings which will be a bit of a challenge. I am however adding additional features to the gameplay requiring other controls than for basic movement.
Button	Action	Event
RIGHT (Right Arrow)	The character moves in the right direction with a default speed of “+3”.	Every 10ms there is a validation checking whether the character is within the bounds of an object. (Collision)
LEFT (Left Arrow)	The character moves in the left direction with a default speed of “-3”.	Every 10ms there is a validation checking whether the character is within the bounds of an object. (Collision)
SPACE	The character is being triggered up for a certain amount of time (Artificial Physics); in other words the character jumps up in the air.	The collision event takes place when the timer which allows the movement downwards is turned on (enabled/true) so that the character doesn’t fall off the platform whenever it touches the ground object. Also there is a function which doesn’t allow the character to clip in the ground object with the same principle.
SHIFT	The character moves in the specified direction (in this case only left and right since increasing the speed of the jump is pointless as it remains uniform throughout). The speed of the movement increases by 2 for a short period of time specified in one of the labels within the game form.	Modifies the value of the previously specified speed of movement (only applied to directional movement in this case left and right) by 2, upon releasing the button the speed is decreased by 2 again to make the movement return to its former velocity.
ESCAPE	Brings up the menu allowing the user to get help, simply pause the gameplay, change settings or get out of the game form.	-


Data Sinks and Sources

Entity	Source or Sink	Data	Data Details
User	Source	Enter login/register details.	Login: username, password

Register: username, password, email, age.
Database/Moderator	Sink	Read/Write Details	Username, password, email, age, group
User	Source	Scoring points	Change the level and add score.
Database/Moderator	Sink	Read/Write Scores	Write/Read scored to or from the Database
User	Sink	Read Scores from Scoreboard	Read Scores from Scoreboard.







Data Flow Diagram
 
Existing System: Structure Diagram

 

Existing System: Problem

•	The main problem of all old systems is the lack of features which keeps the user interested and engaged in continuing to use the system. The oldest systems didn’t have a save system and it had very basic controls without many extra events that could potentially engage the player further. The features are basic, the movements and sometimes an odd surprise to the player to keep them engaged. My plat former will be more modernized and will challenge the player at every aspect during the gameplay which results in more engagement. Most of the games nowadays have to paid for which is a big setback for getting larger audiences to get interested in the project. Therefore my application will be absolutely free and potential players will be able to download the application online.

•	Not many people are engaged into the old games such as the type of my project. The main aim of the project is to engage more people to the history of games and initially engage them into the community of gamers. Because the games got incrementally less interesting the users would rather pick more developed and modern versions of games. 

•	The security of the system might be questionable therefore my system will have security to the best of my ability, it will be a priority. Even though the system won’t store much sensitive information apart from the email, I will make sure that the system won’t get to the wrong hands. This will be done by basic actions such as validation and verification although the database will be stored securely. 

•	Most of the platform games don’t have a scoreboard which doesn’t allow for the extra engagement from the player as it doesn’t allow him to compete with others. Competing with scores might allow for more engagement not only during the gameplay but when the player decides he cannot complete the level he is progressing through and ask other people for help. This might mean creation of forums for the gaming community interested in old types of games such as this one turned more modern. The lack of engagement caused the old games to get lost in history as new; better sequels come out every single year.

•	Simple/limited controls (UP, DOWN, LEFT, RIGHT); usually the simpler the controls the easier the gameplay. In most cases there are no controls allowing the user to speed up their movement for a certain period of time to go through the more difficult obstacles throughout the game levels. There might be no extra controls allowing for interaction with certain objects or environment.



Justification of Information Collection methods

Method	Explanation	Justification
Interview	The analysis stage was to be started off with an initial interview with my client, Anthony. The interview allowed me to get a firm idea on the system and what can possibly be change from the existing systems.	The interview allowed me to discover more about how existing systems work. I also got enough knowledge on the history of games such as the project and the client might have a few ideas with his knowledge. The interview definitely allowed me to get much more personal with my client, get the real feeling for the project. The interview allowed for improvised open questions, allowing my client to openly and descriptively talk about the project.
Follow up Interview	Shortly after the first interview I decided to make a second interview which would allow me to ask more technical and specific questions. Following up on the first interview allowed me to clear some confusion and mistakes during the first interview.	Following up to the first interview allowed me to ask more specific questions regarding the future system. It also allowed me to create some figures for future testing or even implementation. I now know the required data to be collected, where it should be stored and how and who it should be displayed to.
Observation	I had to carry out an observation so that I got an idea about the system. I have shown the project to my client, Anthony, which liked it very much. I wanted to get opinions on the new system compared to the existing one with an experienced user.	The observation was very valuable as it allowed me to establish user requirements for my system. I know how other systems were handled by users. The information also allowed me to build a better system including many extra features.
Requirements Specification

The player should experience something else compared to the old version of the system. This is why special features will be included in its new version. Through information collection I am able to establish the following user requirements:
User Requirements:
1)	Design requirements
a.	The screen size should be medium – (640x480 pixels)
b.	The colour of the character will be a blue gradient
c.	The colour of the platform will be metal colours – silver etc.
d.	The colour of the background will be light blue – a skybox.
e.	The size of the character should be large – (around 25x25 pixels)
f.	The limit of levels should be around 10-15
g.	There should be different colours for harder levels – darker, brighter etc.
h.	Each level should have a different layout of objects.
i.	The menu should have the same colours as some levels.

2)	Input requirements
a.	The player is able to choose which level he wants to play granted, he has unlocked the level during gameplay.
b.	The player is able to control the character in two directions – RIGHT and LEFT
c.	Additional button for sprinting is added – SHIFT

3)	Processing requirements
a.	Each level will have a harder difficulty
b.	Each difficulty level will have more obstacles and special objects
c.	The coordinates of the character’s movement should be checked each second to see whether the player has fell out the world and consequently failed the level.
d.	The collision with objects should be done any time the bounds of the character are touched by an object/obstacle.






Input Requirements
There will be certain input and output requirements for my project. I have decided on the size of each field so that they are easier to validate for the system and the moderators which sometimes will check on certain details.
Login/Register Forms:
Field Name	Purpose	Data Type	Field Size	Example
Player
UserID	To store the user ID of the account.	Integer	4	3682
Username	To store the username of the user.	String	15	Astronaut
Password	To store the password of the user.	String	30	Astronaut7788
PasswordRep	Validation variable to check on user’s password during login.	String	30	Astronaut7788
Moderator/Database Check
UserGroup	Determines a user group of the player.	String	10	Administrator/Moderator/
User

Gameplay:
There are also certain playability inputs;
Key	Purpose	Explanation
RIGHT ARROW	Allows the user to move in the right direction, also sets the directional flag meaning that the object will be facing the direction of input.	Without the direction of input the controllable object would move in an unknown direction (probably not at all).
LEFT ARROW	Allows the user to move in the left direction, also sets the directional flag meaning that the object will be facing the direction of input.	
SPACE BAR	The player is ejected into the air, falls down due to gravitation.	The user must jump over obstacles.

Output Requirements

Everything will be displayed in a Graphical User Interface meaning there will be buttons and mouse control over the choices. The GUI will include images, icons, menus, windows or even command-like interface. A GUI is a most useful design and will help the user to interact with the choices he has to make in my system.
I’m required to make a GUI design that will be comfortable for everyone. Important settings and help should be located in a visible location at any time. The system will require basic skills such as the use of a keyboard and a mouse to navigate through the menus and control the character in game. I have to make sure that the menus are responsive and easy to understand so the first impression upon loading the program will be a professional design. In this case all of the environment on each level will be created through picture boxes in VB.net. The design will mainly be the game environment and a couple of extra settings based on the preference of the user. I will use labels to display scores and update them separately depending on the requirement; for example a score will be updated for how quick the player has managed to finish the level or avoiding obstacles.
The scoreboard will be presented as a separate design; it will have the same colours and will fit within the general theme. The scores will be displayed through different categories such as the TOP 10, TOP 100, and TOP from each country. The menus will be easy to choose, after passing each level the player will have a chance to store his score in a database which then is moved to the separate scoreboard system. This will be somewhat of a report; it will only display certain information; the username the player has chosen when prompted, level and his best score which then is compared with the score pool.
The main menu itself will have a help button or the so called FAQ (Frequently Asked Questions), settings for preferences, scoreboard and the Play button. The player will be able to pause the game during gameplay using the ESCAPE button. Upon pressing the ESCAPE button a menu will appear with the following options: 
i.	Resume
ii.	Options
iii.	Help
iv.	Restart Level
v.	Save Game
vi.	Load Game
vii.	Exit – The level currently chosen will be closed and the game-state will return to the main menu.



Processing Requirements

Navigation
Upon running the program the user will be presented with a menu from which he has to choose whether to load a level, start a new game, change options or in case he is completely new to the game, check the help button. Once the user choses their option it is very possible that there will be many sub choices which have to be made. Moderators will be able to modify certain things on the system such as inappropriate nicknames; such users will be banned from using the scoreboard system. In future systems the user might have to log in through a website to manage his account a bit more thoroughly.
Game Form
Each level has unlimited time to accomplish the tasks. The player can take his time in completing the levels to find the location of obstacles. The game form will change when progressing from a level to a level. This will also change if the user decides to quit the form to visit the main menu to maybe load a different save. The score will be kept from the previous level to allow better calculation at the end of the game when the scores are added up to the scoreboard and the database.  The scores will update every time the character progresses throughout the level; this means the score system will be based on how well the player found his way through the level and bonus points will be added to how quickly it was done.
Administration Panel
The administration panel will allow the administrators to manage cheated scores, inappropriate language and mistakes in the system. They will also be able to add new levels and modify previous ones for future updates. The administration panel will generally allow for maintenance on the system. In general every question by the player will be answered by a moderator or an administrator. This means the system will be easy to manage especially with many bugs at early stages. At some point in the future the system might have a ticket system allowing the user to write a question or submit a bug to the management to solve it. Each administrator would be assigned with a ticket to solve overtime and would have to contact the player who submitted the ticket.






Alternative choices

In this chapter I will be looking into alternatives of choice to my system that my client could possibly use. The alternatives might have different criteria to the features my client will require for his system. I’m using VB.net to create by program, but the alternative choices might have been made in different environments which might have the same functionality but might be more professional.
Super Mario Bros:
The first example of a free software package that was initially commercially available 20 years ago (1980s) is ‘Super Mario Bros’. Super Mario Bros is now available for free, however when it first came out it would have had a price. This piece of software circles the internet and can be downloaded anywhere. The main purpose of the game is similar to mine, where you control a character (or a bunch of characters) to reach a certain point to progress levels.
 
This system is very similar to mine and could in fact be used by my client. However Super Mario Bros is an example of history, one of the first games to be famous as a Platform Game. The game has similar system I will implement into my game such as scoring, levels, time and even special items collected (gems). The system requirements might somewhat match but many features are implemented in my system to fit the more modernized version of the game. Super Mario Bros is initially my platform to start the project on; it has the idea and the logic. You cannot create account for your scores however it’s saved locally in the first version of the software. The game also includes blocks that are unknown – similar to my idea, these block can initially reset the level as the pool will be randomized. 


The Impossible Game:
The second example is almost identical to my idea. It is free and playable online, which means there is absolutely no costs. My criteria might fit with the game’s features, however not all of them. This would be a great alternative to my system that is already existing. A big disadvantage is that you must have an internet connection in order to play the game.
 
There is a scoreboard, levels and difficulty increases similar to my system. The functionality of the game is really close to my system. The game is freeware, meaning that nobody has to pay in order to play. The main point of this game is how frustrating it can get, getting increasingly harder with many invisible obstacles usually surprising the players completely. This can happen many times in a row where a player might forget of certain obstacles in order to pass further obstacles. The main catch of the game is that it’s hard and very frustrating. This in some way makes the game interesting and very competitive which means that there has to be a scoreboard which allows players to compete.
Once you are able to connect to the website offering this game, you can go straight into the gameplay by clicking the button. There will also be a menu consisting of top scores and others. Once the game has started you have infinite number of attempts at passing a level. The design is pretty simple, a blue to black gradient, orange object and black objects of collision.



Visual Studio:
Visual Studio is an IDE used to make programs such as mine; it uses VB.net as its main programming language. The URL to download is: http://www.microsoft.com/visualstudio/eng/downloads. This environment allows programmers to create their own software by using a large variety of programming languages. Some of them are C, C+, C++, C#, VB.net and many others. 
The main advantages to this software are:
•	Customisable UI allows changing of the initial design to make options more easily accessible.
•	Can include usernames and passwords of users stored in a database.
•	Visual Studio can save files in different file types.
•	I am very familiar with this software and the languages it provides, especially C# and VB.net.
The main disadvantages are:
•	It is only compatible on a Windows OS. This mean the user is only able to develop applications if he has a Windows machine. I will be creating the system on college computers which all have Windows 7.
•	User can only make changes with a help of a professional knowing programming languages.

 

Estimating File Sizes

User Database
Record	Data Type	File Size
UserID	Integer	4 bytes
Username	String	20 bytes
Password	String	20 bytes
Email	String	20 bytes
UserGroup	String	15 bytes
Score	Integer	8 bytes
Level	Integer	4 bytes

Approximation for 25 players:
Record Size: 91
Number of records: 25
Size: (20+20+20+15+4+4+8) * 25 = 2.275 = 2.7 Kilobytes
Total size: Size + 10% overheads = 2.275 + 0.2275 = 2502.5 Bytes

Scoreboard
Record	Data Type	File Size
UserID	Integer	4 bytes
Username	String	20 bytes
Score	Integer	8 bytes
Level	Integer	4 bytes

Record Size: 36
Approximate number of scoreboards: 5
Size: (20+8+4+4) * 5 = 180 = 0.0180
Total size: 180 + 0.0180 = 180.018 bytes

Total estimate will be around 10-30 kB.

Software and Hardware requirements

Software Requirements	Justification
Microsoft Windows 98 or higher operating system.	An operating system is required to run Visual Basic and the application made in the said program.
.NET Framework 4.0 
Previous version may work	Software required to run the .exe version of the game.
Microsoft Access Database Engine 2010 “ACE”	In order to access the Microsoft Access database.

Hardware Requirements	Justification
A processor running at 1.6 GHz	The process will require SOME processing power, this is for any overheads.
256mb of RAM or higher	The application might be resource heavy, 256mb should be enough.
Around 200mb of hard disk space	Should be sufficient to store the game’s contents.
Intel on-board graphics or AMD equivalent VGA	To allow the processing of the application’s graphics.
Peripherals: QWERTY Keyboard	Keyboard will be used to control the character’s movement.
Monitor	To view the content of the program.









Scope

•	The system needs to be fully working and compatible on the machines currently used to make the game and within the college environment. This means all machines need to have a certain version of Windows so that the IDE packages will work as well as Frameworks. College cannot afford machines with better hardware for my system to work even better on.
•	It is very unlikely that I will be making a special system for the deaf or blind as I don’t have the budget or the time.
•	Due to the limitation, the system will only be suitable for certain groups of people which might not have a great interest.
•	Some personal details might be taken to register for the system. They won’t be sensitive; it will only be Usernames, passwords and emails. This way the system can stay safe and the data will be secured.
•	This project will aim at a certain user group which might limit the game in a way of interest.
•	Some of the details within the project documentation will not be implemented into the system due to a short amount of time. These are predictions if the project will ever continue to exist or be developed further with the use of the same IDE as VB.net or different programs to make a more advanced system.
•	Some of the planned extras might never be implemented due to the fact of lacking a game engine (it might be overwhelming for the system without the use of an engine).















Design and Test Strategy
System Objectives

Validation must be done on every level of input to the system to make sure there are no errors to correct for the administration. There also needs to be some security in place, even though the database won’t store sensitive information, I require everyone to register with an email in case of contact. The administrator needs to be able to override certain settings, once contacted for example to change a password. There should be two-step security for the administrators as they will be able to modify anything within the game system including the permissions of users and administrators themselves.
1.	Validation must be done to all input in any form to eliminate any errors for the future.
2.	A user can only view others’ scores in a scoreboard, not including the details they registered with, for example their email. 
3.	The scores should be easily visible on every stage of the game.
4.	The administrator should have a two-step security login to make sure nobody breaches through and modifies player or administrator data.
5.	On the main menu and throughout the gameplay, the player should be able to get help with a button.
6.	All of the information about scores and players will be stored in a database to make sure everything stays organized and ready to be displayed on a scoreboard. 
7.	The system must be able to quickly calculate the scores to insert them into the database to be displayed in the scoreboard.
8.	All of the information about the system, including the FAQ or help, must be visible to the user and contrast with the colour scheme of the system. This must be done throughout every form in the system to stay consistent. 
9.	The colour scheme will be kept the same throughout all menus to allow the contrast to apply to all of the information labels to be clearly visible.








New System: Structure Diagram
Login Form
 

Register Form

 



Main Menu  


Game Launch

 
Data Structures and Validation

Field Name	Form	Example Data	Data Validation	Error Message
UserID	Register	15	Presence Check- Makes sure that the ID number has been created.
Format Check – The ID should only contain numbers.
Length Check – Should be up to 5 numbers long	 Null
Username	Register/Login	Astronaut	Presence Check – Makes sure that the Username has been input.
Length Check – Should be up to 20 characters long.	“The Username field is empty!”
Password	Register/Login	Atrounautspassword15	Presence Check – Makes sure that the password has been input.
Length Check – Should be up to 20 characters long.	“The Password field is empty!”
PasswordRep	Register	Atrounautspassword15	Presence Check – Makes sure that the repeated password has been input.
Verification – Makes sure that the field has the same value as Password.
	“The Repeat Password field is empty!”
Age	Register	18	Range Check – to check whether the input age is greater than 18	“You must be over 18!”
Email	Register	Astrounaut@nasa.com
Presence Check – Makes sure that the field has been filled.
Verification – Make sure the email is on a trusted domain (blacklisting the fake email services).	“The Email field is empty!”







HCI Design
Main Menu

 
Object Event Task Table:
Object	Event	Task	Name
lblMarquee	-	-	-
btnPlay	On Click	Opens the “frmPlayMenu” form so that the player can choose to start a new game o load an existing save. The “frmMainMenu” form remains open until an option is chosen.	Play
btnScoreboard	On Click	Opens the “frmScoreboard” from displaying the saved scoreboards.	DisplayScoreboard
btnFAQ	On Click	Opens the “frmFAQ” form, allowing the user to choose the category of their problem and to look for further help.	DisplayFAQ
btnSettings	On Click	Opens the “frmMenuSettings” form, allowing the user to modify controls and graphic settings.	OptionsMenu
btnExit	On Click	Closes the application.	Exit

The label lblMarquee is animated, therefore taking more space than usual. Its task is to move across the page from the right to the left in an infinite loop. 
 
 
Main Menu Form

Object	Property	Setting
formLoadingScreen	Form.FormBorderStyle	Borderless
	Maximize Box	False
	Minimise Box	False
formMainMenu	BackgroundColor	Gray (#d3d3d3)
	MaximiseBox	False
cmdPlay	ButtonStyle	Flat
	formPlayMenu.Show()	
cmdFAQ	ButtonStyle	Flat
	formFAQ.Show()	
cmdScoreboard	ButtonStyle	Flat
	formScoreboard.Show()	
cmdSettings	ButtonStyle	Flat
	formSettingsMenu.Show()	
cmdExit	ButtonStyle	Flat
	FormMainMenu.Hide()	






Play Menu

 
Object Event Task Table:
Object	Event	Task	Name
btnNewGame	On Click	Opens the “GameForm” form which includes the game content, the player starts on a fresh first level.	NewGame
btnLoadGame	On Click	Opens the “frmLoadGame” form, which has a list of previously written files that can be read as save files. After the user loads a save file, they will start from the point at which the game has stopped previously.	LoadGame
btnBack	On Click	Closes the form “frmPlayMenu” and goes back to the Main Menu form (reason for not closing it after launching the menu). Without control boxes the only way to get out of this form is by clicking on this button.	Back










Play Menu

Object	Property	Setting
frmPlaySubmenu	Form.FormBorderStyle	Borderless
	Maximize Box	False
	Minimise Box	False
cmdNewGame	FlatStyle	FlatStyle.Flat (True)
	frmGameForm.Show()	
cmdLoadGame	FlatStyle	FlatStyle.Flat (True)
	frmLoadGame.Show()	
cmdExit	ButtonStyle	Flat
	FormPlaySubmenu.Hide()	









Login
 
Object Event Task Table:
Object	Event	Task	Name
lblUsername	-	-	-
lblPassword	-	-	-
txtUsername	-	-	-
txtPassword	-	-	-
btnLogin	On Click	Checks against the database whether the input is correct, if it’s not the user has 3 chances (apart from the one they have already used) to login; otherwise they cannot login until their account is unlocked. If the input credentials are correct with the database, it opens a form “MainMenu”.	Login
lblRegister	On Click	Opens up the “frmRegister” form, allowing the user to register the account and to login in the future.	Register
btnExit	On Click	Closes the application.	Exit

 
 
Login

Object	Property	Setting
frmLogin	Form.FormBorderStyle	Border + control box
	Maximize Box	False
	Minimise Box	True
txtUsername	Textbox	Empty
txtPassword	Textbox	Empty
lblRegister	Label (onClick)	Load frmRegister
cmdLogin	ButtonStyle	Flat
cmdExit	ButtonStyle	Flat
	frmLogin.Hide()	









Register
 
Object Event Task Table:
Object	Event	Task	Name
lblTitle	-	-	-
lblUsername	-	-	-
txtUsername	-	-	-
lblPassword	-	-	-
txtPassword	-	-	-
lblRepPassword	-	-	-
txtRepPassword	-	-	-
lblEmail	-	-	-
txtEmail	-	-	-
lblAge	-	-	-
txtAge	-	-	-
btnSubmit	On Click	Validates the information for all of the input in the form. After the validation is successful and there are no problems in the input, the information will be written directly into a database which will be used in the login. The validation and verification happens on each of the fields, each of them having different types of validation. If at least one of the fields has not been filled correctly it will bring up an error and tell the user to reenter the information.	Verification, WriteToDatabase




Register

Object	Property	Setting
frmRegister	Form.FormBorderStyle	Border + control box
	Maximize Box	False
	Minimise Box	True
txtUsername	Textbox	Empty
txtPassword	Textbox	Empty
txtRepPassword	Textbox	Empty
txtEmail	Textbox	Empty
txtAge	Textbox	Empty
btnRegister	ButtonStyle	Flat
Validation()		







 Scoreboard
 
Object Event Task Table:
Object	Event	Task	Name
lblTitle	-	-	-
lblTop10	-	-	-
lblTopTime	-	-	-
lblTopCountry	-	-	-
lblTop10Display	-	-	-
lblTopTimeDisplay	-	-	-
lblTopCountryDisplay	-	-	-













Game Form

Object Event Task Table:
Object	Event	Task	Name
lblScoreTXT	-	-	-
lblScore	On Colision	Update score	Value Change
PictureBoxes			

Game Form

Object	Property	Setting
frmGameForm	Form.FormBorderStyle	Border + control box
	Maximize Box	False
	Minimise Box	True
frmEscMenu	Form.FormBorderStyle	Borderless
btnResume	Textbox	Empty
btnFAQ	frmFAQ.Show()	
btnSettings	frmSettings.Show()	
txtAge	Textbox	Empty
btnRegister	ButtonStyle	Flat
Validation		






Data Structure Design
Game Form

There will only be a single file which the program will make use of to make sure of the security; the database. The database will be made in an outside program called Access and will be secured. The program itself however will make use of variables which will store information on a local and global level. There is a couple of modules which will store variables, concerning different functions within the program.
Collisions (CheckCollisions function):
Variable Name	Type	Size	Description	Example Value	Validation
bCollisions	Boolean	1	Tells the collision whether the object collides with an obstacle.	True	If bCollisions = True then object collides, else it doesn’t.
pbCols	PictureBox	1-10	Holds all the obstacles within an array.	pbBox1	N/A
sDirection	String	5	Direction flag; determines which direction the object is facing.	“right”	If = “right” object facing right, else left for collision.
sCrashDirection	String	5	Collision flag; determines which face is against the colliding block.	“left”	If = “right” object facing right, else left for collision.

Camera Movement (CameraMovement function):
Variable Name	Type	Size	Description	Example Value	Validation
objects	PictureBox	1-15	Holds all the picture boxes within an array.	pbBox1 (all objects)	N/A
sDirection	String	5	Direction flag; determines which direction the object is facing.	“right”	If = “right” object facing right, else left for collision.
sCrashDirection	String	5	Collision flag; determines which face is against the colliding block.	“left”	If = “right” object facing right, else left for collision.


Scoring system (Scoring function):
Variable Name	Type	Size	Description	Example Value	Validation
Gems	PictureBox	1-10	Holds all the gems within an array.	pbGem	N/A
pbGem	-	1-10	Used for the For Each loop to describe each object within the array.	pbGem2	N/A
Score	Integer	5	Stores the numerical score value.	20	N/A

Timer (Falling):
Variable Name	Type	Size	Description	Example Value	Validation
gbOnTopOfCol	Boolean	1	Determines whether the controllable object is on top of an object within either of the arrays.	False	If gbOnTopOfCol = true, object is on top of an obstacle, else it’s not.
pbObstacles	PictureBox	1-10	Control Array to hold all of the obstacles within the level.	pbBox2	N/A
pbGround	PictureBox	2	Control Array to hold the collision objects of the ground platforms.	pbGround	N/A
bJump	Boolean	1	Determines whether the controllable object is allowed to jump, this allows to dismiss the possibility to jump twice in the air.	True	If bJump = true the player is allowed to jump, otherwise he’s not.






Login Form

Database Connection (SQL):
Variable Name	Type	Size	Description	Example Value	Validation
sProvider	-	-	The provider of the connection (in this case the ACE engine).	-	N/A
sSource	-	-	The source of the Access Database file.	-	N/A
Con	-	-	Establishes the connection through the string and provider.	-	N/A
sSQL	-	-	The variable feeds the information in SQL into the database.	Select * From UserBase Where Username = '"	Validation within the database.
Da	-	-	Data Adapter, allows for connecting.	-	N/A
sName	String	20	Holds the value of the username within the Username field.	Adam15	Presence, existence.
sPass	String	20	Holds the value of the password within the Password field.	Clowns8	Presence, existence.

Login:
Variable Name	Type	Size	Description	Example Value	Validation
sName	String	20	Holds the value of the username within the Username field.	Adam15	Presence, existence.
sPassword	String	20	Holds the value of the password within the Password field.	Clowns8	Presence, existence.
attempt	Integer	2	Attempts allow the users to stay secure as the account will be blocked if the attempts value reaches 3.	2	If attempt = 3, block account and clear the fields.s


Register Form

Register:
Variable Name	Type	Size	Description	Example Value	Validation
sUsername	String	20	Stores the username within the username field, writes it into the database.	Adam15	Has to have at least 6 characters.
sPassword	String	20	Stores the password within the username field, writes it into the database.	Clowns8	Has to have at least 6 characters.
sPasswordRep	String	20	Stores the password, or the repeated version of it for extra security.	Clowns8	Has to be equal to the sPassword variable.
sEmail	String	15	Stores the email within the field.	Adam15@gmail.com	Has to be from a known source (whitelist).
iAge	Integer	3	Stores the age of the user.	17	Has to be over 13.
SQL Connection Variables					











Test Strategy: Test plan

In the testing of my platform game I will be carrying out white-box testing using dry runs to carry out the design algorithms further on. I will also carry out black box texting on the finished version of the program using a test plan that I have prepared. I will use the feedback from the program to fix the issues accordingly as presented in the plan. At the very end of this procedure I will give the program to my user group allowing them to test it, possibly resulting in many changes of the program. The testing includes all of the login and register forms where input of text is required, therefore there should be no extreme data involved.
Tested Function	Method of Input	Input	Expected Result
Login Form	Test 1: If all of the information is input correctly, the program allows the user to continue on their way to the further parts of the program.

Test 2: If some/all information is input incorrectly, the program should not allow the user to pass through the security check – this will be repeated 3 times, then the account will be locked for a period of time (cool down).	Login: Admin
Password: admin	The form allows the user to progress through the forms of the program. This will be checked against the database in which all of the information is stored from the registration phase (or manual insertion in this case).
		Login: Admin
Password: 	Even though a single credential is correct, the validation requires both of the details to pass through the login check. If the user doesn’t include a password, he won’t log in.
		Login: Adam1515
Password: squirrel	The form doesn’t allow the user to progress through the forms of the program as the input credentials do not match with the database. This means the user already had a single chance to input the password, now the chances are down to two before the account is locked for the cool down period.
Tested Function	Method of Input	Input	Expected Result
Register Form	Test 1: The user inputs all of the details up to standard allowing the user to register their account into the database. This will allow the user to log in in the future.

Test 2: The user inputs all of the required details however they are not met by the requirement of validation.

Test 3: The fields are left completely blank.	Username: Maths
Password: 3366121224
Email: maths@maths.com
Gender: M
Age: 9000	The user is allowed to be registered as all of the fields are met by the validation. The information is written into the database. The information can now be removed from the panel within the application from the administrative panel. The account is active straight away and the user is allowed to log in and progress through the application.
		Username: s
Password: snakes1555
Email: snakes@snakes.com
Gender: M
Age: 15	The user is not allowed to log in as the username is too short, the validation requires a set amount of letters/numbers. The program doesn’t reach the interaction of the database as the validation is not met. The account is not registered and the user will have to take his time to input more detail into the form in order to pass the validation checks. There will be no trace of the account anywhere.
		Username:
Password:
Email:
Gender:
Age:	The validation doesn’t get far enough to even interact with the database. The fields are checked for presence, therefore if there isn’t any information within the fields the user will be simply rejected. There is no trace of the interaction.
Tested function	Method of Input	Input	Expected Result
Player movement	Test 1: Pressing a button corresponding to changing the direction and allowing for movement as the game form has loaded.	Right Arrow	The controllable object should start moving to the right as soon as the player presses the right arrow button. The movement will continue unless the player stops pressing the directional button.
		Left Arrow	The controllable object should start moving to the left as soon as the player presses the left arrow button. The movement will continue unless the player stops pressing the directional button.
		Space Bar	The controllable object should be ejected some pixels into space, activating the timer responsible for gravitation. This means the controllable object should head upwards and then gradually return to the object of collision.
Tested function	Method of Input	Input	Expected Result
Ground Collision	Test 1: Controllable objects spawns and collides with the ground object, depending on the location of spawn (usually only the ground).

Test 2: Does the controllable object clip through the ground as it moves through the platform?	-NONE-	The controllable object should collide with the ground object and go no further. It should be allowed to move in any direction.
		Right Arrow or Left Arrow or Jump	The controllable object should remain level with the outside boundary of the object’s collision. The controllable object should never go below the level of collision (the outside boundary).
Tested function	Method of Input	Input	Expected Result
Obstacle Collision	Test 1: Controllable object collides with the right side of the obstacle as it travels on the ground platform (or any that it’s on top of).

Test 2: Controllable object collides with the left side of the obstacle as it travels on the ground platform (or any that it’s on top of).

Test 3: Controllable object collides with the top of an object (other than the ground platform).	Any of the directional controls (Right or Left)	The object collides with the right side of the obstacle and it stops from moving that direction, the only direction it can go is left or to jump in the air to get onto the obstacle applying different logic to the collision.
			The object collides with the left side of the obstacle and it stops from moving that direction, the only direction it can go is left or to jump in the air to get onto the obstacle applying different logic to the collision.
			The object collides with the top of an object and the controllable object is able to move along the surface of the collision. But the movement is only allowed to the sides while being on top of the object, the player is able to jump also but will not clip through the top of the obstacle the object is on.
Tested function	Method of Input	Input	Expected Result
Collision with Gems	Test 1: The controllable object collides with a Gem, increasing the score by a set increment.

Test 2: The controllable object collides with the Gem while doing a jump (being in the air).	Right, Left arrows and space bar.	Upon collision the score is increased by a set increment (10) and displayed in a label on the upper area of the window.
			Upon collision with the Gem the score is increased as normal collision on a ground level.
Level Advancement	Test 1: Once the controllable object has reached the exclamation point (the object signifying the end of the level) they should move up a level and the score should be kept.	N/A.	Each level is incremented in difficulty and could prove more frustrating. The location of gems will be different and they might be harder to reach at each increment (only goes up to 10).
Display Instructions	Test 1: The instructions should be displayed once the played reached a certain point in the game, this will usually be the first few levels.	N/A.	Displays a separate form.


