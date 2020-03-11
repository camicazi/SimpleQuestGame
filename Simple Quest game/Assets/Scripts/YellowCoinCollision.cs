using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCoinCollision: MonoBehaviour
{
    public GameObject YellowCoin;
    void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.CompareTag("RightHand"))
        {
            float innerRadius = 0.3f;
            float outerRadius = 2f;

           // this.transform.gameObject.GetComponent<Renderer>().material.color = Color.black;
            var localOffset = new Vector3(Random.Range(-10f, 10f), Random.Range(0f, 10f), Random.Range(-10f, 10f));
            var wordOffset = transform.rotation * localOffset;
            var position = transform.position + wordOffset;
            Instantiate(YellowCoin, position, transform.rotation);
            FindObjectOfType<ScoreCounter>().Score++;
            Destroy(this.gameObject);
        }
        else
        {
            this.transform.gameObject.GetComponent<Renderer>().material.color = Color.green;
            var localOffset = new Vector3(Random.Range(-10f, 10f), Random.Range(0f, 10f), Random.Range(-10f, 10f));
            var wordOffset = transform.rotation * localOffset;
            var position = transform.position + wordOffset;
            Instantiate(YellowCoin, position, transform.rotation);
            Destroy(this.gameObject);


        }
    }
}
