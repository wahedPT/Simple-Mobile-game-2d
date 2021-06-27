using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsta : MonoBehaviour
{
    public float obsSpeed;
    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, obsSpeed));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
           
            Destroy(collision.gameObject);
            
            GameManager.instance.isGameOver = true;
            EnemySpawn.FindObjectOfType<EnemySpawn>().StopSpawn();



        }
        else
        {
            if(collision.gameObject.tag=="Ground")
            {
                GameManager.instance.IncrementScore();
                gameObject.SetActive(false);
                Destroy(gameObject, 3f);
               
            }
        }
    }
}
