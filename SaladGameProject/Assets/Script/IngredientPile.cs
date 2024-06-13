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
    private Plate platescript;
    private AudioManager audioManager;


    private void Awake()
    {

        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    void Start()
    {

        Plate = GameObject.Find("Plate"); // Find the Plate GameObject in the scene
        if (Plate != null)
        {
            platescript = Plate.GetComponent<Plate>(); // Get the Plate script component
        }
        else
        {
            Debug.LogError("Plate GameObject not found");
        }
    }

    private void OnMouseDown()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;
        if(isPlatefull == false )
        {
            audioManager.PlaySFX(audioManager._clickSound);
            GameObject newIngredient = Instantiate(Veggie, Plateposition.position, Quaternion.identity);
            platescript.AddIngredient(newIngredient);
            isPlatefull = true;
           
        }
        else
        {
            Debug.Log("Plateisfull");
        }
    }

    

    

    

}
