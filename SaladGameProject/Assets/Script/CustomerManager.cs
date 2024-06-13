using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    public Menu menu; // Reference to the Menu script
    public GameObject customerPrefab; // Prefab for the customer
    public Transform spawnPoint; // Spawn point for new customers

    public void SpawnCustomer(int menuItemIndex)
    {
        GameObject newCustomer = Instantiate(customerPrefab, spawnPoint.position, Quaternion.identity);
        Customer customerScript = newCustomer.GetComponent<Customer>();
            MenuItem assignedMenuItem = menu.menuItems[menuItemIndex];
            customerScript.SetMenuItem(assignedMenuItem);
            DisplayMenuItem(assignedMenuItem); 
    }

    void DisplayMenuItem(MenuItem menuItem)
    {
        UIManager uiManager = GameObject.FindObjectOfType<UIManager>(); 
        uiManager.DisplayMenuItem(menuItem);
    }
}

