using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingRotation : MonoBehaviour
{
    public Transform tran;

    // Makes object rotate slowly in the air without moving 
    void Update()
    {
        tran.Rotate(26.6f*Time.deltaTime, 11.2f*Time.deltaTime, 16f*Time.deltaTime, Space.Self);
    }
}
