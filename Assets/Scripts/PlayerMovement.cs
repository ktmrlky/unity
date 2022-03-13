using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5; // define a variable that can be changeable from unity
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 pos = transform.position; // get the position of object and...

        pos.x += h * speed * Time.deltaTime; //change x position of object in seconds from the last frame to the current one
        pos.y += v * speed * Time.deltaTime; //change y position of object in seconds from the last frame to the current one

        transform.position = pos; //so we changed the position
    }
}
