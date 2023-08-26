using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int spawnsLeft;
    public float counter;
    public GameObject enemy;


    // Start is called before the first frame update
    void Start()
    {
        Spawn();
        ResetCounter();
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnsLeft > 0)
        {
            counter -= Time.deltaTime;
            if (counter <= 0f)
            {
                Spawn();
                ResetCounter();
            }
        }
    }

    public void Spawn()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
        spawnsLeft--;
    }

    public void ResetCounter()
    {
        counter = Random.Range(3.0f, 5.0f);
    }
}
