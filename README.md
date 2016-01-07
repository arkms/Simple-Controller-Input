# Simple-Controller-Input
A simple XBox Game Controller input manager for every Unity project.

This is a work in progress.
By the end, I want to have every input mapped and available as public accessors to other components.

I will test the API by adding the Xbox controller input to the Prime31 Character Controller 2D project.

    INSTRUCTIONS (temp)
Create an Empty Game Object called "Input Manager".
Drag the GameControllerInputs.cs and your version of the InputMapping.cs scripts and drop them on the Input Manager object.

Make sure your InputMapping.cs has the following code inside:

    private GameControllerInputs controllerInput;
    void Start () 
    {
        controllerInput = GetComponent<GameControllerInputs>();
    }

On the InputMapping code, create methods representing actions in the game, and return the value of the input necessary to match the action.

Example 1:
    public bool GoLeft()
    {
        if (controllerInput.DPad_Left || Input.GetKey(KeyCode.LeftArrow))
            return true;
        else
            return false;
    }

Your character should have an Character Controller of some sort attached to it, and in this Character Controller, you should add the following code:

    private InputMapping inputMap;
    void Start () 
    {
        inputMap = GameObject.Find("Input Manager").GetComponent<InputMapping>();
    }

Now, from your Character Controller, inside the Update() method, test if the input is active, then proceed to perform the action.

Example 2:
    if (inputMap.GoLeft())
    {
        transform.Translate(Vector2.left * 0.05f);
    }

See that if you need to add 2 or more inputs for the same action, as shown in Example 1, you should all inputs and perform a logic OR between them. 
This way, you can use keyboard and game controller with ease, only having to call one method from your Character Controller, and makes it easy to 
change the Input Mapping when desired, without having to change the Character Controller code.

EXPLAIN THE GCI.cs
-variaveis, hold/up/down, float/digital
EXPLAIN THE INPUTMAPPING.cs
-create your own actions. only needs 1. may not be used if you add the GCI code directly.