using UnityEngine;

public class Customer : MonoBehaviour
{
    private MenuItem menuItem; // The menu item required by this customer
    private PlayerHP player; // Reference to the player

    void Start()
    {
        player = GameObject.FindObjectOfType<PlayerHP>(); // Find the Player script in the scene
    }

    public void SetMenuItem(MenuItem item)
    {
        menuItem = item;
    }

    public MenuItem GetMenuItem()
    {
        return menuItem;
    }

    public void OnClick()
    {
        Plate plateScript = GameObject.Find("Plate").GetComponent<Plate>(); // Assuming the plate is named "Plate"
        if (plateScript != null)
        {
            if (plateScript.IsComplete(menuItem))
            {
                ServePlate();
            }
            else
            {
                HandleIncorrectPlate();
            }
        }
    }

    void ServePlate()
    {
        // Handle serving the plate to the customer
        Debug.Log("Plate served to the customer!");
        // Add your logic here (e.g., increase score, remove plate, etc.)
        Destroy(gameObject); // Example: Destroy the customer GameObject
    }

    void HandleIncorrectPlate()
    {
        Debug.Log("Incorrect ingredients! The customer is leaving.");
        player.DecreaseHealth();
        // Add logic for customer leaving (e.g., destroy customer, move them away, etc.)
        Destroy(gameObject); // Example: Destroy the customer GameObject
    }
}

