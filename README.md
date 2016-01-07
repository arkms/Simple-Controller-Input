Simple Controller Input - For Unity 3D
==================================================
A simple XBox Game Controller input manager for your Unity project.

This project aims to simplify accessing an XBOX Controller inputs and using them in your game.
It allows for rapid prototyping and modularity when dealing with multiple inputs from the keyboard, a mouse and a game controller.

HOW TO SET IT UP
--------------------------------------
If using this code on a project you already have set up, follow the following instructions:
1. Replace the InputManager.asset in your project folder from the one currently in this project.
    The standard inputs are still present, so if you're already using any type of input in your game, it should work normally with the new file (unless you have made changes to that file, obviously).
2. In your project, create an Empty Game Object called "Input Manager".
3. Drag the GameControllerInputs.cs and the InputMapping.cs scripts and drop them on the Input Manager object.
4. Edit the InputMapping.cs script to better suit your character actions.
    

### How to Get the Controller Inputs

Your character should have an Character Controller of some sort attached to it, and in this Character Controller, you should add the following code:
```bash
    private InputMapping inputMap;
    void Start () 
    {
        inputMap = GameObject.Find("Input Manager").GetComponent<InputMapping>();
    }
```bash

If want to bypass the InputMapping.cs script, you can access the GameControllerInputs variables directly from you Character Controller code, by adding the following code inside it:
```bash
    private GameControllerInputs controllerInput;
    void Start () 
    {
        controllerInput = GetComponent<GameControllerInputs>();
    }
```

Edit the InputMapping (or your custom) code and create methods representing actions in the game. Return the value of the input necessary to match the action.

    Example 1:
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

    Example 2:
```bash
    if (inputMap.GoLeft())
    {
        transform.Translate(Vector2.left * 0.05f);
    }
```bash

See that if you need to add 2 or more inputs for the same action, as shown in Example 1, you should all inputs and perform a logic OR between them. 
This way, you can use a keyboard and the game controller with ease, only having to call one method from your Character Controller. This makes it easy to 
change the Input Mapping when desired, without having to change the Character Controller code.

EXPLAIN THE GCI.cs
-variaveis, hold/up/down, float/digital
EXPLAIN THE INPUTMAPPING.cs
-create your own actions. only needs 1. may not be used if you add the GCI code directly.