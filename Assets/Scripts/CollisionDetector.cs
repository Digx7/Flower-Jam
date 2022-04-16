using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionDetector : MonoBehaviour
{
    public UnityEvent collsionDetected;

    public void OnCollisionEnter(Collision Col){
      collsionDetected.Invoke();
    }

    public void OnTriggerEnter(Collider col){
      collsionDetected.Invoke();
    }
}
