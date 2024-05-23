using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    private Animator anim;

    [SerializeField]
    private LevelInfo levelInfo;

    public GameEvent trashItemEvent;
    [SerializeField]
    private AudioSource ding;
    private void Start(){
       anim = gameObject.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player") && levelInfo.hasObject){
            levelInfo.hasObject = false;
            trashItemEvent.Raise();
            ding.Play();
        }
    }
}
