using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Plate : MonoBehaviour
{
    public List<string> currentIngredients = new List<string>(); 

    public void AddIngredient(GameObject ingredient)
    {
        currentIngredients.Add(ingredient.GetComponent<IngredientObject>().vegName); 
    }

    public bool IsComplete(MenuItem menuItem)
    {
        if (menuItem == null) 
        {
            Debug.Log("NoMenu");
            return false;
        } 
        // Check if all required ingredients are present on the plate
        return menuItem.requiredIngredients.All(ingredient => currentIngredients.Contains(ingredient));
    }
}

