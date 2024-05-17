using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Plate : MonoBehaviour
{
    private List<string> currentIngredients = new List<string>(); // List of current ingredient names or tags on the plate

    public void AddIngredient(GameObject ingredient)
    {
        currentIngredients.Add(ingredient.tag); // Use tag or name depending on your setup
    }

    public bool IsComplete(MenuItem menuItem)
    {
        if (menuItem == null) return false;

        // Check if all required ingredients are present on the plate
        return menuItem.requiredIngredients.All(ingredient => currentIngredients.Contains(ingredient));
    }
}

