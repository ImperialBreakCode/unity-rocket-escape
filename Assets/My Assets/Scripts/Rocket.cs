using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Rocket : MonoBehaviour
{
    private bool _isNearRocket = false;
    private bool _isWithFullInventory = false;
    private bool _rockedIsLuanched = false;

    public UnityEvent<Rocket> OnRocketEnterWithCollected;
    public UnityEvent<Rocket> OnRocketEnter;
    public UnityEvent<Rocket> OnRocketExit;

    public UnityEvent<Rocket> OnRocketLaunch;

    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory inventory = other.GetComponent<PlayerInventory>();

        if (inventory != null)
        {
            _isNearRocket = true;
            if (inventory.NumberOfScrews == 3)
            {
                _isWithFullInventory = true;
                OnRocketEnterWithCollected.Invoke(this);
            }
            else
            {
                OnRocketEnter.Invoke(this);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _isNearRocket = false;
        OnRocketExit.Invoke(this);
    }

    private void Update()
    {
        if (_isNearRocket && _isWithFullInventory && Input.GetKeyDown(KeyCode.F))
        {
            _rockedIsLuanched = true;
            OnRocketLaunch.Invoke(this);
        }

        if (_rockedIsLuanched)
        {
            transform.position += new Vector3(0f, 5f, 0f) * Time.deltaTime;
        }
    }
}
