using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bladeHit : MonoBehaviour
{
    public GameObject weapon;

    canDrag canDragRef;

    void OnCollisionEnter2D(Collision2D collision)
    {
        canDragRef = weapon.GetComponent<canDrag>();
        canDragRef.stopDrag();
    }

    void OnCollisionExit2D(Collision2D collision)
    {
    }
}