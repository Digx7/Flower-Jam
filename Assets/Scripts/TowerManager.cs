using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public float towerHeight;
    public GameObject currentFallingObject;
    public StackableObjectList stackableObjectList;
    public ObjectSpawner objectSpawner;

    public void DropNewObject(){
      GameObject objToDrop = stackableObjectList.GetRandomObject();
      currentFallingObject = objectSpawner.SpawnObject(objToDrop);
      currentFallingObject.GetComponent<CollisionDetector>().collsionDetected.AddListener(DropNewObject);
    }
}
