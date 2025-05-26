using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canDrag : MonoBehaviour
{
    //Initialising Variables
    Vector3 mousePositionOffset;
    public GameObject weapon;
    public GameObject blade;
    public float rotateSpeed;

    public bool draggable = true;

    private Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        //Get mouse position offset
        mousePositionOffset = weapon.transform.position - GetMouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        if (draggable)
        {
            weapon.transform.position = GetMouseWorldPosition() + mousePositionOffset;
        }
        else
        {
            //Do nothing
        }

        blade.transform.Rotate(0, 0, rotateSpeed);
    }

    public void stopDrag()
    {
        rotateSpeed = rotateSpeed + 1;
    }
}