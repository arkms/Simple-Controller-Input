# Simple Controller Input - For Unity 3D

A simple XBox Game Controller input manager for your Unity project.

This project aims to simplify accessing an XBOX Controller inputs and using them in your game.
It allows for rapid prototyping and project modularity when dealing with multiple inputs from the keyboard, a mouse and a game controller.
The Demo Scene uses free art from [Kenney](https://www.kenney.nl) and the [Character Controller 2D](https://github.com/prime31/CharacterController2D) from Prime31.

[![Example Image](https://raw.githubusercontent.com/andre-lima/Simple-Controller-Input/master/example_image.PNG)](#features)


## HOW TO SET IT UP

If using this code on a project you already have set up, follow the following instructions:

1. Replace the InputManager.asset in your project folder from the one currently in this project.
    > *Don't worry: The standard inputs are still present, so if you're already using any type of input in your game, it should still work normally with the new file (unless you have made changes to that file, obviously).*
2. (optional) In your project, create an Empty Game Object called "Input Manager".
3. (optional) Drag the InputMapping.cs scripts and drop them on the Input Manager object.
4. (optional) Edit the InputMapping.cs script to better suit your character actions.

### Known Issues

- If you need to use your movement code inside a FixedUpdate(), digital inputs (like a button press) can misbehave, being activated twice on one presse, or not be activated at all.
Please consider using the part of the code that gets the inputs on an Update() method (or send me a message if you know how to fix this!).

- This manager only works with one controller being used at a time.

- Since it was intended to be just an example, some things are not working very well. The Mecanim system is not properly setup, so the animations are very bad. Pressing down and jumping makes the Alien jump really high. The Spaceship has no collision when flying.

## How to Get the Controller Inputs

Your character should have an Character Controller of some sort attached to it, where you get the inputs to perform the movements. 
In this Character Controller, you should add the following code:
```bash
    private InputMapping inputMap;
    void Start () 
    {
        inputMap = GameObject.Find("Input Manager").GetComponent<InputMapping>();
    }
```

If you don't want to use the InputMapping.cs script, you can access the GameControllerInputs variables directly from you Character Controller code, by adding the following code inside it:
```bash
    private GameControllerInputs controllerInput;
    void Start () 
    {
        controllerInput = GameControllerInputs.GetIstance();
    }
```

Edit the InputMapping (or your custom) code and create methods representing actions in the game. Return the value of the input necessary to match the action.

- **Example 1:**
```bash
    public bool GoLeft()
    {
        if (controllerInput.DPad_Left || Input.GetKey(KeyCode.LeftArrow))
            return true;
        else
            return false;
    }
```

Now, from your Character Controller, inside the Update() method, test if the input is active, then proceed to perform the action.

- **Example 2:**
```bash
    if (inputMap.GoLeft())
    {
        transform.Translate(Vector2.left * 0.05f);
    }
```

See that if you need to add 2 or more inputs for the same action, as shown in Example 1, you should all inputs and perform an OR logic between them. 
This way, you can use a keyboard, a mouse and the game controller with ease, only having to call one method from your Character Controller. This makes it easy to 
change the Input Mapping when desired, without having to change the Character Controller code.

### List of Available Inputs
--------------------------------------

As in Example 1, you have to access ***controllerInput.(name of input)*** to check the input's state.
Below, you can find a list of all inputs available:
> *(Check the "Inputs Documentation.pdf" file inside the Assets folder to see the full description of the variables)*

```bash    
 > ANALOG (returns a float):
    LeftDirectional_Horizontal  (returns: 0 to -1 <left>; 0 to 1 <right>)
    LeftDirectional_Vertical    (returns: 0 to -1 <up>; 0 to 1 <down>)
    
    RightDirectional_Horizontal (returns: 0 to -1 <left>; 0 to 1 <right>)
    RightDirectional_Vertical   (returns: 0 to -1 <up>; 0 to 1 <down>)
    
    BothTriggers                (returns: -1 to 1 <depends on the combination of both triggers>)
    LeftTrigger                 (returns: 0 to 1)
    RightTrigger                (returns: 0 to 1)

 > DIGITAL (returns a boolean - true when pressed):
    LeftDirectional_asLeftButton
    LeftDirectional_asRightButton
    LeftDirectional_asUpButton
    LeftDirectional_asDownButton
    
    RightDirectional_asLeftButton
    RightDirectional_asRightButton
    RightDirectional_asUpButton
    RightDirectional_asDownButton
    
    LeftTrigger_asButton
    RightTrigger_asButton
    
    DPad_Left
    DPad_Right
    DPad_Up
    DPad_Down
    
    A_button_hold
    A_button_down
    A_button_up
    
    B_button_hold
    B_button_down
    B_button_up
    
    X_button_hold
    X_button_down
    X_button_up
    
    Y_button_hold
    Y_button_down
    Y_button_up
    
    LB_hold
    LB_down
    LB_up
    
    RB_hold
    RB_down
    RB_up
    
    LeftDir_press_hold
    LeftDir_press_down
    LeftDir_press_up
    
    RightDir_press_hold
    RightDir_press_down
    RightDir_press_up
    
    Start_hold
    Start_down
    Start_up
    
    Back_hold
    Back_down
    Back_up
```
