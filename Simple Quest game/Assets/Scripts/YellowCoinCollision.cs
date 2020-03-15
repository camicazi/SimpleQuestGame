using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCoinCollision: MonoBehaviour
{
    public GameObject YellowCoin;

    public void OnDestroy()
    {
        ScoreCounter.Instance.Score++;
    }

    void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.CompareTag("RightHand"))
        {
            //this.transform.gameObject.GetComponent<Renderer>().material.color = Color.black;
            var localOffset = new Vector3(this.transform.position.x + Rand(Random.Range(0.05f, 0.3f)), Random.Range(0.2f, 1.5f), this.transform.position.z + Rand(Random.Range(0.05f, 0.3f)));
            Instantiate(YellowCoin, localOffset, transform.rotation);
            Destroy(this.gameObject);
        }
        else
        {
            //this.transform.gameObject.GetComponent<Renderer>().material.color = Color.green;
            var localOffset = new Vector3(this.transform.position.x + Rand(Random.Range(0.05f, 0.3f)), Random.Range(0.2f, 1.5f), this.transform.position.z + Rand(Random.Range(0.05f, 0.3f)));
            Instantiate(YellowCoin, localOffset, transform.rotation);
            Destroy(this.gameObject);

        }
    }
    float Rand(float randnum)
    {
        if(Random.Range(0, 100)>=50){
            return randnum;
        }
        else
        {
            return randnum * -1f;
        }
    }
}
