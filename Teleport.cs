using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform teleportPoint;
    void OnTriggerEnter(Collider other)
    {
        other.transform.position = teleportPoint.position;   
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        
    }
}
