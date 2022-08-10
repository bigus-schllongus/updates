using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject benis;

    [SerializeField]
    private GameObject bigbenis;


    [SerializeField]
    private float benisInterval=3.5f;

    [SerializeField]
    private float bigbenisInterval=10f;

    
    void Start()
    {
        StartCoroutine(spawnEn(benisInterval, benis));
        StartCoroutine(spawnEn(bigbenisInterval, bigbenis));
        
    }

    
    private IEnumerator spawnEn(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy=Instantiate(enemy,new Vector3(Random.Range(-5f,5), Random.Range(-6f,6f),0), Quaternion.identity);
        StartCoroutine(spawnEn(interval,enemy));
        if(enemy==bigbenis){
            Debug.Log("boss spawned");
        }
    }



}
