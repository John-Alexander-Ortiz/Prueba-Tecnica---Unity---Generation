using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject objectPrefab;
    public int poolSize;
    [SerializeField] List<GameObject> pooledObjects = new List<GameObject>();
    void Start()
    {
        AddToPool(poolSize);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void AddToPool(int poolSize)
    {
        for (int i=0; i < poolSize; i++)
        {
            GameObject prefabObject;
            prefabObject = Instantiate (objectPrefab, Vector3.zero, Quaternion.identity);
            prefabObject.SetActive(false);

        }
    }
    public GameObject FirstDeactivate()
    {
        for (int i=0; i<pooledObjects.Count; i++)
        {
            if(!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        AddToPool(1);
        return pooledObjects.Last<GameObject>();
    }
}
