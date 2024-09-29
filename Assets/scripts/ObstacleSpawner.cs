using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public Transform spawnPoint;

    private float spawnInterval = 1.0f;
    public float objectLifetime = 5.0f;

    void Start()
    {

        InvokeRepeating("SpawnObject", 0f, spawnInterval);
    }

    void SpawnObject()
    {
        GameObject spawnedObject = ObjectPool.SharedInstance.GetPooledObject();

        if (spawnedObject != null)
        {
            
            float randomX = Random.Range(8.3f, 12.0f); 
            Vector3 spawnPosition = new Vector3(randomX, spawnPoint.position.y, spawnPoint.position.z);

            spawnedObject.transform.position = spawnPosition;
            spawnedObject.transform.rotation = Quaternion.identity;
            spawnedObject.SetActive(true);

            StartCoroutine(DeactivateObject(spawnedObject));
        }
    }


    IEnumerator DeactivateObject(GameObject objToDeactivate)
    {
        yield return new WaitForSeconds(objectLifetime);


        objToDeactivate.SetActive(false);
    }


}

