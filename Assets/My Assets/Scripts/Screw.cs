using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screw : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        
        PlayerInventory inventory = other.GetComponent<PlayerInventory>();

        if (inventory != null)
        {
            inventory.ScrewCollected();
            gameObject.SetActive(false);
        }
    }
}
