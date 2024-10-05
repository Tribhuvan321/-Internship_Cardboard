/*using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Start()
    {
        // This is where you'd trigger scene loading (e.g., via a button or event)
        SceneManager.LoadScene("HelloCardboard"); // Replace with the name of your XR Scene
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Check if the loaded scene is the XR scene
        if (scene.name == "HelloCardboard")
        {
            // Find the XRManager in the loaded scene
            XRManager xrManager = FindObjectOfType<XRManager>();

            if (xrManager != null)
            {
                // Start XR when XRManager is found
                xrManager.StartXR();
            }
            else
            {
                Debug.LogError("XRManager not found in XRScene.");
            }
        }
    }

    void OnEnable()
    {
        // Subscribe to the sceneLoaded event
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        // Unsubscribe from the sceneLoaded event
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
*/