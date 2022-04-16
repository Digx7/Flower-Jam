using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    public void Start(){
      //SpawnObject(objectToSpawn);
    }

    public GameObject SpawnObject(GameObject obj){
      GameObject spawnedObj = Instantiate(obj, this.transform.position, Quaternion.identity);
      return spawnedObj;
    }
}
