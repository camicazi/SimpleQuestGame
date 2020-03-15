using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCoinCollision: MonoBehaviour
{
    public GameObject YellowCoin;
    List<string> HandTags = new List<string>() { "LeftHand", "RightHand" };
    //When object is desotryed because of collision, increase score by one
    public void OnDestroy()
    {
        ScoreCounter.Instance.Score++;
    }

    //On collision, instantiate another one in a new position with minimum distance 5cm and maximum 30cm from former position
    //lastly destroy the old instannce
    void OnCollisionEnter(Collision other)
    {
        if ( HandTags.Contains(other.gameObject.tag))
        {
            var position = new Vector3(this.transform.position.x + Rand(Random.Range(0.05f, 0.3f)), Random.Range(0.2f, 1.5f), this.transform.position.z + Rand(Random.Range(0.05f, 0.3f)));
            Instantiate(YellowCoin, position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
    // Set 50% chance the random range will be negative in order to not have the object move only in positive directions during instantiation.
    float Rand(float randnum)
    {
        if(Random.Range(0, 100)>=50)
        {
            return randnum;
        }
        else
        {
            return randnum * -1f;
        }
    }
}
