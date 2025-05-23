using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bladeHit : MonoBehaviour
{
    public int coins = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Clash"))
        {
            coins = coins + 5;
            Debug.Log("Coins: " + coins);
        }
    }
}