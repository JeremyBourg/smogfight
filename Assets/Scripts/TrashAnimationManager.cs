using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class TrashAnimationManager : MonoBehaviour
{
    private Animator anim;

    [SerializeField]
    private LevelInfo levelInfo;
    private void Start(){
       anim = gameObject.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") && levelInfo.hasObject) {
            anim.SetTrigger("Open");
        }
    }
        private void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player") && levelInfo.hasObject) {
            anim.SetTrigger("Close");
        }
    }

    public void CloseTrashCan() {
        anim.SetTrigger("Close");
    }
}
