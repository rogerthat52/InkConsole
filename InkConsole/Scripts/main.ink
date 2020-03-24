Welcome to William Worm: Escape from Bug York! Can you help William escape?
+ [yes]
    -> startgame
+ [no]
    -> END

=== startgame ===
* ->
George W. Bug is dead. You are William Worm, stuck in the middle of Bug York. You are currently in the hospital with secret service swarming you. You must survive.
+ {startgame > 1} ->
This is the room you started in.
- (hallway)
<> There is a hallway that leads out of the room and goes left or right. What do you do?
* [piss]
    You piss on George W. Bug's body. That will teach your dad.
    -> startgame
+ [left] ->
    -> fight ->
    You come along a hallway that is going out to the right. Along the wall to your left is a door that is cracked slightly ajar. Which way do you go?
    A.Forward   B.Into the Right Hallway   C.Check Out the door   D.Go back to the starting room
    ** [A]
    ** [B]
    ** [C]
    ** [D]
        -> startgame
    -- -> END
+ [right]
    You see a sign that says Floor 3 and arrive at an intersection of two hallways. Which way do you go?
    A. The hall continuing straight
    B.
    **   [A]
    **   [B]
    -- -> END
+ [items]
    <- startgame
    <- items
    -> DONE

=== fight ===
Two Bugs appear in front of you! Prepare to fight!
>> ENTER (not yet implemented) (requires the player to press enter to continue)
>> FIGHT (not yet implemented) (brings the player to an entirely different UI for a fight system)
->->

=== items ===
>>> ITEMS
-> DONE