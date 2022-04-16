using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TowerManager : MonoBehaviour
{
    public float towerHeight = 0.0f;
    public Vector3 locationOfTowerBase;
    public float topTowerMoveSpeed = 10000;
    public float objectMoveSpeed;
    public GameObject currentFallingObject;
    public StackableObjectList stackableObjectList;
    public ObjectSpawner objectSpawner;

    public FloatEvent heightChanged;

    public List<GameObject> DroppedObjects;

    public void DropNewObject(){
      GameObject objToDrop = stackableObjectList.GetRandomObject();
      currentFallingObject = objectSpawner.SpawnObject(objToDrop);
      currentFallingObject.GetComponent<CollisionDetector>().collsionDetected.AddListener(delegate{AddObjectToDroppedObjects(currentFallingObject);});
      currentFallingObject.GetComponent<CollisionDetector>().collsionDetected.AddListener(DropNewObject);
    }

    public void MoveFallingObject(Vector2 input){
      Vector3 trueDirection = new Vector3();
      trueDirection.x = input.x;
      trueDirection.z = input.y;
      trueDirection= trueDirection * objectMoveSpeed * Time.deltaTime;

      currentFallingObject.GetComponent<Rigidbody>().AddForce(trueDirection);
    }

    public void AddObjectToDroppedObjects(GameObject input){
      DroppedObjects.Add(input);
      FindTowerHeight();
    }

    public float GetTowerHeight(){
      return towerHeight;
    }

    private void Update(){
      MoveTowerManager(towerHeight);
    }

    private void FindTowerHeight(){
      towerHeight = 0.0f;
      for(int i =0; i < DroppedObjects.Count;i++){
        if(DroppedObjects[i].transform.position.y > towerHeight) towerHeight = DroppedObjects[i].transform.position.y;
      }
      heightChanged.Invoke(towerHeight);
    }

    private void MoveTowerManager(float input){
      Vector3 target = new Vector3();
      target.y = input;
      Vector3 movement = Vector3.MoveTowards(this.transform.position, target, topTowerMoveSpeed * Time.deltaTime);

      transform.position = movement;
    }
}
