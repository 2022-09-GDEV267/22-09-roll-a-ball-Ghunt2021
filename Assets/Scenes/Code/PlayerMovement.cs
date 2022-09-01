using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        private Rigidbody rb; 
        rb = GetComponent <Rigidbody> ; 

    }

    void OnMove(InputValue movementValue) 
    {

        (rb.AddForce)movementVector;


        Vector2 movementVector = movementValue.get < Vector2 > ; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//Additional Notes: 
//Next, let's start to write the code for adding force. 
//In the function body, add the code rb.AddForce, inside open and closed brackets, type movementVector and then end that line with a semicolon. 
//You'll probably see in your script editor that there is an error on this line. 
//There are two reasons for this. 
//Firstly, the variable you are trying to use is a Vector2 and you need to give this method a vector3 variable. 
//Vector3 variables store data across three axes, x, y, and z. 
//These values will determine the direction of the force you add to the ball. 
//If you head back to the editor and look at the global gizmo, you can see the arrows also indicate this. 
//To resolve this issue, you need to create two new variables for the individual input directions. 
//Underneath the Rigidbody variable you created, add two more variables called movementX and movementY. 
//These should be private like the previous variable, float type, which is short for floating point or decimal point value. 
//These give you more precision than a whole number or integer value. 
//You can then reference these values inside of OnMove and assign these values of movement vectors X and Y. 
//In OnMove, add the following two lines of code. 
//movementX equals movementVector.X; 
//movementY equals movementVector.Y; 
//Excellent. 
//The second reason you were getting an error is because the movement vector variable was created inside of OnMove. 
//That means it's what's called nonexistent in the current context, as it was inside another method. 
//To fix this, you can combine the movement floats you just created inside of FixedUpdate to create a vector3 variable. 
//This will take zero as the y value because the ball needs to move along the x and z axis in 3D space. 
//In the FixedUpdate function, add a new line at the top of the function and write Vector3 movement equals new Vector3, open brackets, movementX, 0.0f, movementY close brackets and then a semicolon. 
//The f after the value signifies that this is a float value. 
//Next, use the new Vector3 variable, movement, to Add Force to the Rigidbody of the player sphere. 
//Revise the second line of code in FixedUpdate to rb.AddForce ; 
//Let's save the script and then return to the Unity editor to give it a try. 
//Use the Play button to enter play mode and test. 
//It works! But the player is moving really slowly. 
//Leave Play mode to stop testing. 
//In the next video, you'll adjust the script to fix this.