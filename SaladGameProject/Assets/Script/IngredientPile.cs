using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IngredientPile : MonoBehaviour
{
    [SerializeField]private GameObject Veggie;
    [SerializeField] private GameObject Plate;
    [SerializeField] private Transform Plateposition;
    Vector2 difference = Vector2.zero;
    private Vector2 originalposition;
    private bool isDragging;
    private GameObject draggingObj;
    private bool isActive = true;
    private bool isPlatefull = false;




    void Awake()
    {
        
    }

    
    

    private void Update()
    {
       
    }

    private void OnMouseDown()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;
        if(isPlatefull == false )
        {
            draggingObj = Instantiate(Veggie, Plateposition.position, Quaternion.identity);
            isPlatefull = true;
        }
        else
        {
            Debug.Log("Plateisfull");
        }
    }

    private void OnMouseDrag()
    {

        
        //if (draggingObj != null)
        //{
        //    var screenPos = Input.mousePosition;
        //    screenPos.z = 10f;
        //    draggingObj.transform.position = Camera.main.ScreenToWorldPoint(screenPos);
        //}
    }

    

    

}
