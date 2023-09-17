using UnityEngine;
using UnityEngine.SceneManagement;

public class changescenes: MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Check if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Call a function to switch to the desired scene
            SwitchToTargetScene();
        }
    }

    // Function to switch to the desired scene
    void SwitchToTargetScene()
    {
        // Specify the name of the scene you want to switch to
        string targetSceneName = "menu";

        // Use SceneManager.LoadScene to load the target scene
        SceneManager.LoadScene(targetSceneName);
    }
}
