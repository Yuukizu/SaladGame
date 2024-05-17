using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public List<MenuItem> menuItems; // List of all menu items

    void Awake()
    {
        // Manually define the menu items and their required ingredients
        menuItems = new List<MenuItem>
        {
            new MenuItem
            {
                itemName = "Salad1",
                requiredIngredients = new List<string> { "Tomato", "Lettuce" }
            },
            new MenuItem
            {
                itemName = "Salad2",
                requiredIngredients = new List<string> { "Lettuce", "Tomato", "Cucumber", }
            },
            new MenuItem
            {
                itemName = "Salad3",
                requiredIngredients = new List<string> { "Lettuce", "Tomato", "Cucumber", "Corn" }
            }
            // Add more menu items as needed
        };
    }
}



