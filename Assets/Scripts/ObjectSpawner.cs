using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Vector2 objectSpawnRangeX;
    public Vector2 objectSpawnRangeZ;

    private Vector3 trueRange;

    public void Start(){
      //SpawnObject(objectToSpawn);
    }

    public GameObject SpawnObject(GameObject obj){
      trueRange = this.transform.position;
      trueRange.x += Random.Range(objectSpawnRangeX.x, objectSpawnRangeX.y);
      trueRange.z+= Random.Range(objectSpawnRangeZ.x, objectSpawnRangeZ.y);

      GameObject spawnedObj = Instantiate(obj, trueRange, Quaternion.identity);
      return spawnedObj;
    }
}
