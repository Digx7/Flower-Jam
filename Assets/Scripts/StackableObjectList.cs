using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackableObjectList : MonoBehaviour
{
    public List<GameObject> stackableObjects;

    public GameObject GetRandomObject(){
      int randomIndex = Random.Range(0, stackableObjects.Count);
      return GetObjectAtIndex(randomIndex);
    }

    public GameObject GetObjectAtIndex(int index){
      if(index > stackableObjects.Count) return null;

      return stackableObjects[index];
    }
}
