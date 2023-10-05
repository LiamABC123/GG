using UnityEngine;
using System.Collections;

public class CarFreeze : MonoBehaviour
{
    [Header("Car settings")]
    public float driftFactor = 0.2f;
    public float accelerationFactor = 2f;
    public float turnFactor = 3f;
    public float maxSpeed = 5;

    private bool canMove = true;

    private void Start()
    {
        StartCoroutine(FreezeControlsForSeconds(5f));
    }

    private void Update()
    {
        if (canMove)
        {
            // Your normal car movement logic here
            // Example: Move the car based on player input
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            // Apply your car movement logic here using the settings variables
        }
    }

    private IEnumerator FreezeControlsForSeconds(float seconds)
    {
        canMove = false;

        yield return new WaitForSeconds(seconds);

        canMove = true;
        // Reset the control values to their defaults or any other desired values
        driftFactor = 0.2f;
        accelerationFactor = 2f;
        turnFactor = 3f;
        maxSpeed = 5;
    }
}
