using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject mainScene;

    public void setupGame()
    {
        startMenu.SetActive(false);
        mainScene.SetActive(true);
    }
}
