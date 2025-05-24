using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charPick : MonoBehaviour
{
    public string buttonTag = "startButton";
    private UnityEngine.UI.Button pickButton;

    public int character = 1;
    public int curCharacter = 0;

    void Start()
    {
       
        GameObject buttonObject = GameObject.FindGameObjectWithTag(buttonTag);
        if (buttonObject != null)
        {
            
            pickButton = buttonObject.GetComponent<UnityEngine.UI.Button>();
        
        }
    }

    void Update()
    {
        character++;

        if (character < 0)
            character = 5;
        if (character > 9)
            character = 1;

        if (curCharacter == character)
        {
            curCharacter = character - 1;
        }
    }

    public void PickRandomCharacter()
    {
        character = Random.Range(1, 10); // Random number between 1 and 9

        if (curCharacter == character)
        {
            curCharacter = character - 1;
        }
    }
}