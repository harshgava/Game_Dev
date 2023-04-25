using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{   [SerializeField] float x = 0;
    [SerializeField] float y = 0.5f;
    [SerializeField] float z = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x, y, z);
    }
}
