using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeMovePLayer : MonoBehaviour
{
    public float Speed;
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Mhorizontal = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        transform.Translate(Mhorizontal, 0, 0);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }
        
    }
}
