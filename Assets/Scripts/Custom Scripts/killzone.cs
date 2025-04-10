using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killzone : MonoBehaviour
{
    //Destroy cricles on collision
    private void OnCollisionEnter2D(Collision2D collision) {
        Destroy(collision.gameObject);
    }
}
