using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bladeHit : MonoBehaviour
{
    public GameObject weapon;

    void OnCollisionEnter2D(Collision2D collision)
    {
        canDrag = weapon.GetComponent<canDrag>();
    }

    void OnCollisionExit2D(Collision2D collision)
    {
    }
}