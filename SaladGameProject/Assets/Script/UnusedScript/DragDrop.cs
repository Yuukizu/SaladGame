using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    [SerializeField] private GameObject TodraggObject;
    [SerializeField] private GameObject ObjectDragPos;

    [SerializeField] private float dropDistance;
    private bool isLocked;

    Vector2 ObjectinitPos;
    // Start is called before the first frame update
    void Start()
    {
        ObjectinitPos =TodraggObject.transform.position;
    }

    public void DragObject()
    {
        if (!isLocked)
        {
            TodraggObject.transform.position = Input.mousePosition;
        }

    }
    public void DropObject()
    {
        float Distance = Vector3.Distance(TodraggObject.transform.position, ObjectDragPos.transform.position);
        if (Distance < dropDistance)
        {
            isLocked = true;
            TodraggObject.transform.position = ObjectDragPos.transform.position;
        }
        else
        {
            TodraggObject.transform.position = ObjectinitPos;
        }
    }
}
