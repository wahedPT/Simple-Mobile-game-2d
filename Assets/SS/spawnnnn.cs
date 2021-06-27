using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnnnn : MonoBehaviour
{
    public GameObject Enemy;

    void Start()
    {
        Spn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spn()
    {
        if (Random.Range(0, 100) < 5)
        {
            Instantiate(Enemy, transform.position + new Vector3(Random.Range(-2.6f, 2.6f), 0, 0), Quaternion.identity);
            //float Xval = Random.Range(-Xposi, Xposi);
            //Vector2 Spnpos = new Vector2(Xval, transform.position.y);
            //Instantiate(Enemy, Spnpos, Quaternion.identity);
        }
    //void StSpn()
    //{
    //    InvokeRepeating("Spn", 1f, 2f);

    }
  
}
