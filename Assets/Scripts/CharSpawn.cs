using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CharSpawn : MonoBehaviour
{
    public GameObject crab, octo, tort;
    private readonly string charSelected = "charSelected";

    private void Start()
    {
        
        
        int getChar;
        getChar = PlayerPrefs.GetInt(charSelected);
        switch (getChar)
        {
            case 1:
                Instantiate(octo, new Vector3(-8.9f, -3.94f, 1), Quaternion.identity);

                break;
            case 2:
                Instantiate(tort, new Vector3(-8.9f, -3.94f, 1), Quaternion.identity);
                break;
            case 3:
                Instantiate(crab, new Vector3(-8.9f, -3.94f, 1), Quaternion.identity);
                break;
            default:
                Instantiate(crab, new Vector3(-8.9f, -3.94f, 1), Quaternion.identity);
                break;
        }
    }
}

