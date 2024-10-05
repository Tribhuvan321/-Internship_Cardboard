using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class AsyncLoadingScreen : MonoBehaviour
{
    public GameObject LoadingScreen;   // The UI element for the loading screen
    public Image LoadingBarFill;       // The fill image for the loading bar
    public TMP_Text LoadingText;           // Optional: Text to show loading status or percentage

    // Method to start loading a scene
    public void LoadScene(int sceneId)
    {
        StartCoroutine(LoadSceneAsync(sceneId));
    }

    // Coroutine to load the scene asynchronously
    private IEnumerator LoadSceneAsync(int sceneId)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);
        LoadingScreen.SetActive(true);  // Show the loading screen

        float progressValue = 0f; // Initialize progress value

        // While the scene is not fully loaded
        while (!operation.isDone)
        {
            // Calculate the target progress
            float targetProgress = Mathf.Clamp01(operation.progress / 0.9f);

            // Smoothly interpolate the progress value
            progressValue = Mathf.Lerp(progressValue, targetProgress, Time.deltaTime * 2); // Adjust speed with Time.deltaTime

            // Update the fill amount
            LoadingBarFill.fillAmount = progressValue;

            // Optionally update the loading text
            if (LoadingText != null)
            {
                LoadingText.text = $"Loading... {Mathf.Round(progressValue * 100)}%"; // Update text to show percentage
            }

            yield return null; // Wait for the next frame
        }

        // Ensure the loading bar is fully filled
        LoadingBarFill.fillAmount = 1f;
        if (LoadingText != null)
        {
            LoadingText.text = "Loading Complete!"; // Update the loading text when done
        }
    }
}
