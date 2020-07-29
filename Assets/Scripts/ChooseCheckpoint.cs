using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class ChooseCheckpoint : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject Checkpoint;
    public Vector3 currentPosition;
    public Vector3 focusPosition;
    Camera cam;
    bool isChosen;
    public GameObject[] objToHide;
    Transform hide;




    private void Start()
    {
        
        cam = mainCam.GetComponent<Camera>();
        currentPosition = mainCam.transform.localPosition;
        focusPosition = transform.localPosition;
    }
    private void OnMouseDown()
    {
        isChosen = true;
        focusPosition.z = -10f;
        mainCam.transform.position = focusPosition;
        cam.orthographicSize = 3;
    }

    private void ZoomOut()
    {
        mainCam.transform.position = currentPosition;
        cam.orthographicSize = 5;
    }
}
