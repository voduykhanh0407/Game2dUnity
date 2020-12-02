using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (CharacterSelection.idCharacter == 2)
            gameObject.SetActive(true);
        else
            gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
