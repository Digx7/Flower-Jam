using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionDetector : MonoBehaviour
{
    public UnityEvent collsionDetected;
    public bool oneTimeOnly = true;

    private bool hasCollided = false;

    public void OnCollisionEnter(Collision Col){
      if(oneTimeOnly && !hasCollided) {
        hasCollided = true;
        collsionDetected.Invoke();
      }
      if(!oneTimeOnly) collsionDetected.Invoke();
    }

    public void OnTriggerEnter(Collider col){
      if(oneTimeOnly && !hasCollided) {
        hasCollided = true;
        collsionDetected.Invoke();
      }
    }
}
