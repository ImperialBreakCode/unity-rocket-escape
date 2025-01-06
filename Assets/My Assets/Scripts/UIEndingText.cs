using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEndingText : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void ShowEndText()
    {
        gameObject.SetActive(true);
    }
}
