using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollectableSingle : MonoBehaviour
{

    [SerializeField]
    private CollectableObjects pickUpItemType;

    public GameEvent pickUpObjectEvent;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            Debug.Log("Bravo!");
            pickUpObjectEvent.Raise();
        }
    }
}

