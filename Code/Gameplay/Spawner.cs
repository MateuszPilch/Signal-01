using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] bitObjects;
    public float cooldownTime, losePerSpawn;
    private float cooldownNow;

    void Update()
    {
        cooldownNow += Time.deltaTime;

        if(cooldownNow >= cooldownTime)
        {
            Instantiate(bitObjects[Random.Range(0,bitObjects.Length)], transform.position, Quaternion.identity);

            if(cooldownTime > 0.375f)
            {
                cooldownTime -= losePerSpawn;
            }
           
            cooldownNow = 0;
        }
    }

}
