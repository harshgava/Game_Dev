using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{

    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float x = 3f;
   
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidbody.useGravity = false;





    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > x)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
            
        }
    }
}
