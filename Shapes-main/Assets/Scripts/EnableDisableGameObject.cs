using UnityEngine;

public class EnableDisableGameObject : MonoBehaviour
{
    public GameObject objectToToggle;

    // Start is called before the first frame update
    void Start()
    {
        // Set the GameObject to inactive when the scene starts
        if (objectToToggle != null)
        {
            objectToToggle.SetActive(false);
        }
        else
        {
            Debug.LogWarning("No GameObject assigned to toggle!");
        }
    }

    // Function to enable the GameObject
    public void EnableObject()
    {
        if (objectToToggle != null)
        {
            objectToToggle.SetActive(true);
        }
        else
        {
            Debug.LogWarning("No GameObject assigned to enable!");
        }
    }

    // Function to disable the GameObject
    public void DisableObject()
    {
        if (objectToToggle != null)
        {
            objectToToggle.SetActive(false);
        }
        else
        {
            Debug.LogWarning("No GameObject assigned to disable!");
        }
    }
}
