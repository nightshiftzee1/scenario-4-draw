using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alwaysRotate : MonoBehaviour
{
    //Initialising Variables
    public GameObject blade;
    public float rotateSpeed;

    void Update()
    {
        blade.transform.Rotate(0, 0, rotateSpeed);
    }
}
