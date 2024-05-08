using Unity.VisualScripting;
using UnityEngine;
 
public class SpawnCars : MonoBehaviour
{
    public GameObject[] carPrefabs;
    public Transform[] spawnPoints;
 
    void Start(){
        InvokeRepeating("InstantiateCar", Random.Range(0.5f, 2f), Random.Range(0.5f, 3f));
    }
    void InstantiateCar()
    {
            Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            GameObject randomCar = carPrefabs[Random.Range(0, carPrefabs.Length)];
 
            GameObject instantiated = GameObject.Instantiate(randomCar);
            instantiated.transform.position = randomPoint.position;
            instantiated.transform.rotation = randomPoint.rotation;
    }
}