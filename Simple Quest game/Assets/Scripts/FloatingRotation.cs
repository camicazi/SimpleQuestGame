using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingRotation : MonoBehaviour
{
    public Transform tran;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        tran.Rotate(26.6f*Time.deltaTime, 11.2f*Time.deltaTime, 16f*Time.deltaTime, Space.Self);
    }
}
