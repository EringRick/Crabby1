using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerChange : MonoBehaviour
{
    public GameObject crab;
    public GameObject octo;
    public GameObject turt;

    private Vector3 charPosition;
    private Vector3 charOutside;

    private readonly string charSelected = "charSelected";
    public int charNum = 1;
    private SpriteRenderer crabRend, octoRend, turtRend;
    private void Awake()
    {
        charPosition = crab.transform.position;
        charOutside = octo.transform.position;

        crabRend = crab.GetComponent<SpriteRenderer>();
        octoRend = octo.GetComponent<SpriteRenderer>();
        turtRend = turt.GetComponent<SpriteRenderer>();


    }
    private void Start()
    {

    }
    public void Next()
    {
        switch (charNum)
        {
            case 1:
                PlayerPrefs.SetInt(charSelected, 1);
                crabRend.enabled = false;
                crab.transform.position = charOutside;
                octo.transform.position = charPosition;
                octoRend.enabled = true;
                charNum++;
                break;
            case 2:
                PlayerPrefs.SetInt(charSelected, 2);
                octoRend.enabled = false;
                octo.transform.position = charOutside;
                turt.transform.position = charPosition;
                turtRend.enabled = true;
                charNum++;
                break;
            case 3:
                PlayerPrefs.SetInt(charSelected, 3);
                turtRend.enabled = false;
                turt.transform.position = charOutside;
                crab.transform.position = charPosition;
                crabRend.enabled = true;
                charNum++;
                Loop();
                break;
            default:
                Loop();
                break;
        }
    }
    public void Prev()
    {
        switch (charNum)
        {
            case 1:
                PlayerPrefs.SetInt(charSelected, 2);
                crabRend.enabled = false;
                crab.transform.position = charOutside;
                turt.transform.position = charPosition;
                turtRend.enabled = true;
                charNum--;
                Loop();
                break;
            case 2:
                PlayerPrefs.SetInt(charSelected, 3);
                octoRend.enabled = false;
                octo.transform.position = charOutside;
                crab.transform.position = charPosition;
                crabRend.enabled = true;
                charNum--;
                break;
            case 3:
                PlayerPrefs.SetInt(charSelected, 1);
                turtRend.enabled = false;
                turt.transform.position = charOutside;
                octo.transform.position = charPosition;
                octoRend.enabled = true;
                charNum--;
                break;
            default:
                Loop();
                break;
        }
    }
    private void Loop()
    {
        if (charNum >= 3)
        {
            charNum = 1;
        }
        else
        {
            charNum = 3;
        }
    }
    
}
