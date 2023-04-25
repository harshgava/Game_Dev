using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorer : MonoBehaviour
{
    int hits = -1;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "hit")
        {

            hits = hits + 1;
            Debug.Log("You have bumped into a thing this many times : " + hits);
        }
    }
}
