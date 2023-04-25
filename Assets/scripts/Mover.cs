using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //[SerializeField] float y = 0f; ***
    // Start is called before the first frame update
    [SerializeField] float movespeed = 10f;

    void Start()
    {
        instructions();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal")*Time.deltaTime* movespeed;
        float z = Input.GetAxis("Vertical")*Time.deltaTime * movespeed;
        transform.Translate(x, 0, z);
    }


    void instructions()
    {
        Debug.Log("Welcome to the lulli game.");
        Debug.Log("Move your player with WASD or arrow keys.");
        Debug.Log("Don't hit the walls!");
    }

   
}
