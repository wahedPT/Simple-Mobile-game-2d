using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    public float Xposi;
    
    // Start is called before the first frame update
    void Start()
    {
        startSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        float randomX = Random.Range(-Xposi, Xposi);
        Vector2 spawnPos = new Vector2(randomX, transform.position.y);
        Instantiate(Enemy, spawnPos, Quaternion.identity);
    }
    public void startSpawn()
    {
        if(GameManager.instance.isGameOver==false)
        {
            InvokeRepeating("SpawnEnemy", 1f, 2f);
        }
      
       
    }
    public void StopSpawn()
    {
      CancelInvoke("SpawnEnemy");
    }
   //public void StopSpawn()
   // {
       
        
   //         CancelInvoke("SpawnEnemy");
   //        print("hi");
       
       
   // }
}
