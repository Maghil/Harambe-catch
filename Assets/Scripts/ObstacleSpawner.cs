using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public int minCount=1;    //the min score after which obsatcle should spawn   
    public float timeBetweenWaves = 1f;
    public GameObject warningSign;

    private bool flag;       //flag to check if min count is reached
    private float timeToSpawn = 2f;

    // Update is called once per frame
    void Update()
    {
        if(flag){
            SpawnObstacle();
        }
        else
        {
            int i = FindObjectOfType<GameManager>().Score;
            if (i >= minCount)
            {
                flag = true;
            }
        }        
    }

    private void SpawnObstacle()
    {
        if (Time.time >= timeToSpawn) //function to keep track of time
        {
            float i = Random.Range(-1.3f, 1.3f);
            timeToSpawn = Time.time + timeBetweenWaves;
            Instantiate(warningSign, new Vector2(i, 3.5f), Quaternion.identity);
        }
    }
}
