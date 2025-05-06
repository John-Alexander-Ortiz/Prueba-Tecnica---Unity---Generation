using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GameManager : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public int maxSpawn = 10;
    public float timeGenerator= 2f;

    private float minX = -7;
    private float maxX = 7;


    private float minZ = -7;
    private float maxZ = 7;

    public float yHight = 0.5f;

    public List<GameObject> spawnList = new List<GameObject>();

    private void Start()
    {
        StartCoroutine(Loop());
 
    }
    IEnumerator Loop()
    {
        while (true) {

            
            if (spawnList.Count <maxSpawn)
            {
                Vector3 spawnPos = new Vector3(Random.Range(minX,maxX),yHight,Random.Range(minZ,maxZ));

                GameObject newObject = Instantiate(prefabToSpawn,spawnPos, Quaternion.identity);

                spawnList.Add( newObject );
                

               
            }

            yield return new WaitForSeconds(timeGenerator);  
        }

    }
    
    public void RemoveFromList(GameObject obj)
    {
        spawnList.Remove(obj);
    }




}