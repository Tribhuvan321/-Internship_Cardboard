using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  // For scene management

public class InstantiateCards : MonoBehaviour
{
    public GameObject cardTemplate;  // Card prefab template
    public GameObject parent;        // Parent object to hold the instantiated card
    public int childIndex;           // Index of the image in the child hierarchy
    public int superChildIndex;      // Index of the image component inside the card
    public Sprite[] images;          // Array of images the user can choose from
    public AsyncLoadingScreen asl;
    //public GameObject text;


    void Start()
    {
        // Check if an image was previously selected
        int savedImageIndex = PlayerPrefs.GetInt("SelectedSpriteIndex", -1);

        // If an image was selected, instantiate the card and set the image
        if (savedImageIndex >= 0)
        {
            InstantiateCard();
            SetImage(savedImageIndex);
        }
    }

    // Method to set the sprite on the card based on the image index
    private void SetImage(int imageIndex)
    {
        if (parent.transform.childCount > 0)
        {
            Transform child = parent.transform.GetChild(0).GetChild(childIndex).GetChild(superChildIndex);
            if (imageIndex >= 0 && imageIndex < images.Length)
            {
                child.GetComponent<Image>().sprite = images[imageIndex];
            }
            else
            {
                Debug.Log("Image index out of range.");
            }
        }
    }

    // Method called when user selects an image (e.g., via a button)
    public void SelectImage(int imageIndex)
    {
        PlayerPrefs.SetInt("SelectedSpriteIndex", imageIndex);  // Save the image index
        PlayerPrefs.Save();                                     // Ensure the data is saved
    }

    // Method to instantiate the card under the parent
    public void InstantiateCard()
    {
        GameObject instantiatedCard = Instantiate(cardTemplate, parent.transform);
    }

    // Method to switch scenes after the user presses the "Create" button
    public void CreateCardAndGoToNextScene(int sceneId)
    {
        // Instantiate the card before changing the scene
        InstantiateCard();
        //text.SetActive(false);
        //SceneManager.LoadScene(sceneId);
        asl.LoadScene(sceneId);
    }

    // Button method for selecting the basket image
    public void OnBasketImageSelected()
    {
        SelectImage(0);  // Save the index for the basket image
    }

    // Button method for selecting the boxer image
    public void OnBoxerImageSelected()
    {
        SelectImage(1);  // Save the index for the boxer image
    }

    // Button method for selecting the shooter image
    public void OnShooterImageSelected()
    {
        SelectImage(2);  // Save the index for the shooter image
    }

    // Button method for creating the card and changing the scene
    public void OnCreateButtonPressed(int sceneId)
    {
        CreateCardAndGoToNextScene(sceneId); // Replace with the actual scene name
    }


}
