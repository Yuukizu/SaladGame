using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientPile : MonoBehaviour
{
    [SerializeField] private GameObject Veggie;
    Vector2 difference = Vector2.zero;
    private bool isLocked;

    

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;
        draggingObj = Instantiate(Veggie, Camera.main.ScreenToWorldPoint(mousePos), Quaternion.identity );
    }

    private void OnMouseDrag()
    {

        
        if (draggingObj != null)
        {
            var screenPos = Input.mousePosition;
            screenPos.z = 10f;
            draggingObj.transform.position = Camera.main.ScreenToWorldPoint(screenPos);
        }
    }

    private void OnMouseUp()
    {
        if (draggingObj != null)
        {
            var screenPos = Input.mousePosition;
        }
    }
}
