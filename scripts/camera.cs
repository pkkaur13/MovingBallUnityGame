using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float forwardMovementSpeed = 10.0f;  // Speed for moving forward
    public float backwardMovementSpeed = 5.0f; // Speed for moving backward
    public float rotationSpeed = 7.0f;

    void Update()
    {
        // Get input for camera movement
        float horizontalInput = Input.GetAxis("CameraHorizontal");
        float verticalInput = Input.GetAxis("CameraVertical");
        
        // Calculate the new position for the camera
        float adjustedSpeed = verticalInput > 0 ? forwardMovementSpeed : backwardMovementSpeed;
        Vector3 movement = new Vector3(0.0f, 0.0f, verticalInput * adjustedSpeed) * Time.deltaTime;

        // Update the camera's position
        transform.Translate(movement);

        // Calculate the new rotation for the camera
        float rotationAmount = horizontalInput * rotationSpeed * Time.deltaTime;
        Vector3 newRotation = transform.rotation.eulerAngles + new Vector3(0.0f, rotationAmount, 0.0f);

        // Update the camera's rotation only in the horizontal direction
        transform.rotation = Quaternion.Euler(newRotation.x, newRotation.y, newRotation.z);
    }
}