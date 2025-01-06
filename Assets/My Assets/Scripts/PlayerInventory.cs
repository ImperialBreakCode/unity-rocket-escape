using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfScrews { get; private set; }

    public UnityEvent<PlayerInventory> OnScrewCollected;

    public void ScrewCollected()
    {
        NumberOfScrews++;
        OnScrewCollected.Invoke(this);
    }
}
