using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientPile : MonoBehaviour
{
    [SerializeField]private GameObject Veggie;
    Vector2 difference = Vector2.zero;
    private Vector2 originalposition;
    private bool isDragging;
    private GameObject draggingObj;
    private bool isActive = true;


    void Awake()
    {
        originalposition = transform.position;
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
        transform.position = originalposition;
        isDragging = false;

        
    }

    

}
