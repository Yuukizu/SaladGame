using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text menuItemText; // Text UI to display the current menu item and ingredients

    public void DisplayMenuItem(MenuItem menuItem)
    {
        menuItemText.text = "Menu Item: " + menuItem.itemName + "\nIngredients:\n";
        foreach (string ingredient in menuItem.requiredIngredients)
        {
            menuItemText.text += "- " + ingredient + "\n";
        }
    }
}

