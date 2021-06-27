using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerM : MonoBehaviour
{
    Rigidbody2D rb;
    //to use this for flip player
    SpriteRenderer sprite;
    public float Pspeed;
    float xInput = 0;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();

    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FixedUpdate()
    {


        

        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x < Screen.width / 2)
            {
                xInput = -1.0f;
                FlipPlayer();
            }
            else
            {
                xInput = 1.0f;
                FlipPlayer();
            }


        }
        else
        {
            xInput = 0;
        }
        rb.AddForce(transform.right * Pspeed * xInput);
    }
    void FlipPlayer()
    {
        if (rb.velocity.x < 0)
        {
            sprite.flipX = true;
        }

        else if (rb.velocity.x > 0)
        {
            sprite.flipX = false;
        }
    }
}
