using UnityEngine;

public class Customer : MonoBehaviour
{
    private MenuItem menuItem; // The menu item required by this customer
    private SeneManagement managerS;

    void Start()
    {
        
    }

    public void SetMenuItem(MenuItem item)
    {
        menuItem = item;
    }

    public MenuItem GetMenuItem()
    {
        return menuItem;
    }

    public void OnMouseDown()
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
        else
        {
            Debug.Log("NOO");
        }
    }

    void ServePlate()
    {
        
        Debug.Log("Plate served to the customer!");
        MoneyGenerate();
        Destroy(gameObject); 
    }

    void HandleIncorrectPlate()
    {
        Debug.Log("Incorrect ingredients! The customer is leaving.");
        FailServed();
        
        Destroy(gameObject); // Example: Destroy the customer GameObject
    }

    public void MoneyGenerate()
    {
        SeneManagement.instance.Money += 1;

    }
    public void FailServed()
    {
        SeneManagement.instance.Money -= 1;

    }

}

