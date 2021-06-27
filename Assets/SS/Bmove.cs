using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bmove : MonoBehaviour
{
    public Vector3 MOveVelocity;
    public float Speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(MOveVelocity *Speed* Time.deltaTime);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
