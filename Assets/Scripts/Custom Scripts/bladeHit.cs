using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bladeHit : MonoBehaviour
{
    public int coins = 0;
    public GameObject collideWith;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Clash"))
        {
            coins = coins + 5;
            Debug.Log("Coins: " + coins);
        }
    }
}