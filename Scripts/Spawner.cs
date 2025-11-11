using Unity.Mathematics;
using UnityEngine;
using Random=UnityEngine.Random;
public class Spawner : MonoBehaviour
{
    public GameObject[] Meyveler;

    private float zaman; 

    private float spawnZaman = 3f;
    void Update()
    {
        zaman += Time.deltaTime;

        if(zaman > spawnZaman)  
        {
            RandomSpawn();
            zaman = 0;
        }
    }
    void RandomSpawn()
    {
        int RandomMeyve = Random.Range(0, Meyveler.Length);
        Vector3 SpawnPosition = new Vector3(Random.Range(-8, 7), 8, 0);
        Instantiate(Meyveler[RandomMeyve], SpawnPosition, Quaternion.identity);
    }
}
