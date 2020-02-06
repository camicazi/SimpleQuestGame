using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("YellowCoin"))
        {
            Debug.Log("We hit the yellow coin");
        }
        else {
            Debug.Log("We hit something");
            
        }
    }
}
