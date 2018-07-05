The "Agent Interact" Controller is a new component in version 0.95
that allows agents to interact with any tagged object and fire custom functions
on both the agent and the object using Unity's SendMessage.

The demo in this folder shows one use-case of this new feature: 
Automatically opening doors.

*****
This demo requires the tag, Door, to run properly!
*****

ABOUT THIS DEMO SCENE:

Door models are tagged as "Door" with an attached script that
opens the door.  The door will only open if its function, Open(), is called.

The NPC has the Agent Interact component attached.  Here, no other
settings are needed except the CUSTOM RULES area with 1 rule added:

Tag: Door
Function on Object: Open

What this does:  When the agent detects an object tagged "Door" in front of it,
it will call the function Open() on that door object.

ABOUT "AGENT INTERACT" COMPONENT:
Interact Mode: Forward Detect (only detect objects in front)
or Radial Detect (detects objects 360 deg around agent)

Forward Detect Position: The position from which to detect objects.

Interact Dist: The distance to interact with an object. So if it's 3 and a 
door is 3 distance away, it will open the door.