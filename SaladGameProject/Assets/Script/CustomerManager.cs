using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    public Menu menu; // Reference to the Menu script
    public GameObject customerPrefab; // Prefab for the customer
    public Transform spawnPoint; // Spawn point for new customers

    public void SpawnCustomer(int menuItemIndex)
    {
        GameObject newCustomer = Instantiate(customerPrefab, spawnPoint.position, spawnPoint.rotation);
        Customer customerScript = newCustomer.GetComponent<Customer>();
        if (menuItemIndex >= 0 && menuItemIndex < menu.menuItems.Count)
        {
            MenuItem assignedMenuItem = menu.menuItems[menuItemIndex];
            customerScript.SetMenuItem(assignedMenuItem);
            DisplayMenuItem(assignedMenuItem); // Update the UI to show the assigned menu item
        }
    }

    void DisplayMenuItem(MenuItem menuItem)
    {
        UIManager uiManager = GameObject.FindObjectOfType<UIManager>(); // Find the UIManager script in the scene
        uiManager.DisplayMenuItem(menuItem);
    }
}

