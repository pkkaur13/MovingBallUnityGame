using UnityEngine;

public class WallColorChange2squirtle : MonoBehaviour
{
    private Material wallMaterial;
    private Color originalColor;
    private Color collisionColor = Color.cyan; // Change this to your desired color
    private GameObject pikachuObject;

    private void Start()
    {
        // Get the material of the wall GameObject
        wallMaterial = GetComponent<Renderer>().material;
        originalColor = wallMaterial.color; // Store the original color of the wall

        // Find the object with the tag "pikachu"
        pikachuObject = GameObject.FindGameObjectWithTag("squirtle");

        // Hide the pikachuObject initially
        if (pikachuObject != null)
        {
            pikachuObject.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball")) // Assuming you've tagged the ball as "Ball"
        {
            // Change the wall's color when the ball collides with it
            wallMaterial.color = collisionColor;

            // Show the pikachuObject
            if (pikachuObject != null)
            {
                pikachuObject.SetActive(true);
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Restore the wall's original color when the ball exits the collision
            wallMaterial.color = originalColor;

            // Hide the pikachuObject again
            if (pikachuObject != null)
            {
                pikachuObject.SetActive(false);
            }
        }
    }
}
