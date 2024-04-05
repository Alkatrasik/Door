using UnityEngine;
using System.Collections.Generic;


public class ObjectSpawner : MonoBehaviour
{
    public List<GameObject> objectsToSpawn = new List<GameObject>(); // ���� ��������, ������� �� ������ �������� 
    public List<Transform> spawnPoints = new List<Transform>();     // ���� ����� ������ 
    private void Start()
    {
        SpawnRandomObject();
    }

    void SpawnRandomObject()
    {
        
        foreach (GameObject obj in objectsToSpawn )
        {
            // �������� ��������� ����� ������ 
             int randomSpawnPointIndex = Random.Range(0, spawnPoints.Count);
            Transform spawnPoint = spawnPoints[randomSpawnPointIndex];

            // �������� ��������� ������ ��� ������ 
             int randomObjectIndex = Random.Range(0, objectsToSpawn.Count);
            GameObject objectToSpawn = objectsToSpawn[randomObjectIndex];

            // ������� ������ �� ��������� ����� ������ 
            Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);

            spawnPoints.Remove(spawnPoint);
            objectsToSpawn.Remove(objectToSpawn);
            
        }

    }

}