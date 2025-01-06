using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwicth : MonoBehaviour
{
    public GameObject CharacterCamera;
    public GameObject RocketCamera;

    // Start is called before the first frame update
    void Start()
    {
        CharacterCamera.SetActive(true);
        RocketCamera.SetActive(false);
    }

    public void SwitchToRocketCamera()
    {
        CharacterCamera.SetActive(false);
        RocketCamera.SetActive(true);
    }
}
