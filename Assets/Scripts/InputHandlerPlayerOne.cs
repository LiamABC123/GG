using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandlerPlayerOne : MonoBehaviour
{
    // Components
    CarController CarController;

    // Awake is called when the script instance is being loaded.
    void Awake()
    {
        CarController = GetComponent<CarController>();
    }

    // Update is called once per frame and is frame dependent
    void Update()
    {
        Vector2 inputVector = Vector2.zero;

        // Get input from Unity's input system.
        inputVector.x = Input.GetKey(KeyCode.D) ? 1.0f : Input.GetKey(KeyCode.A) ? -1.0f : 0.0f;
        inputVector.y = Input.GetKey(KeyCode.W) ? 1.0f : Input.GetKey(KeyCode.S) ? -1.0f : 0.0f;

        // Send the input to the car controller.
        CarController.SetInputVector(inputVector);
    }
}
