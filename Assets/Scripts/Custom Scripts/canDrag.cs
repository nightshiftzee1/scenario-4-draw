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
        weapon.transform.position = GetMouseWorldPosition() + mousePositionOffset;

        blade.transform.Rotate(0, 0, rotateSpeed);
    }
}