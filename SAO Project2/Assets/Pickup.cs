using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("JFK"))
        {
            Debug.Log("Cube triggered JFK object.");
            other.gameObject.SetActive(false);
        }
    }
}
