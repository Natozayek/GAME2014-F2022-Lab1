using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float x, y;
    public float speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        y = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;

        transform.position = new Vector2(transform.position.x + x , transform.position.y + y);
    }
}
