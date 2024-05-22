using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollectableSingle : MonoBehaviour
{
    public LevelInfo levelInfo;
    [SerializeField]
    private Transform handPosition;
    private bool isPickedUp = false;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player") && levelInfo.hasObject == false){
            levelInfo.hasObject = true;
            isPickedUp = true;
        }
    }

    private void Update() {
        if(isPickedUp){
            gameObject.transform.position = handPosition.position;
        }
    }
    
    public void DestroyItem() {
        if(isPickedUp){
            Destroy(gameObject);
        }
    }
}

