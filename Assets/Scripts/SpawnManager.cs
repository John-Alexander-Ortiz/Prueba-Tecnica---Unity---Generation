using UnityEngine;

public class SpawnManager : MonoBehaviour
{
     public GameObject spherePrefab;
     private float spawnRange = 9.0f;
     private float starDelay = 2.0f;
    private float spawnInterval = 2.0f;
    public int sphereCount;

    void Start()
    {
        InvokeRepeating("SpawnSphereWave", starDelay, spawnInterval);
    }

    
    void Update()
    {
         sphereCount = FindObjectsByType<Sphere>(FindObjectsSortMode.None).Length;
        if(sphereCount == 10)
        {
            CancelInvoke ("SpawnSphereWave");
        }
        if(sphereCount < 10)
        {
            
        }
    }
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange,spawnRange);
        float spawnPosZ = Random.Range(-spawnRange,spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX,0.5f,spawnPosZ);
        return randomPos;
    }
    void SpawnSphereWave ()
    {
        
        
          Instantiate(spherePrefab, GenerateSpawnPosition(),spherePrefab.transform.rotation);
        
    }
}
