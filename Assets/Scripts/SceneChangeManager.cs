using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChangeManager : MonoBehaviour
{
    public void WorldMapLoad()
    {
        SceneManager.LoadScene(1);
    }
    public void CharInfoLoad()
    {
        SceneManager.LoadScene(2);
    }
    public void ToChoice()
    {
        SceneManager.LoadScene(0);
    }
}
