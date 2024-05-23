using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{

    [SerializeField]
    private GameObject player;
    public FirstPersonController firstPersonController;
    private Vector3 initialPosition;
    public GameEvent contactWithEnemyEvent;
    void Start()
    {
        initialPosition = player.transform.position;
    }
    [SerializeField]
    private AudioSource cough;
    [SerializeField]
    private AudioSource carCrash;
    
    public void HandleContact(bool car, GameObject other)
    {
        firstPersonController.enabled = false;
        contactWithEnemyEvent.Raise(null, other);
        player.transform.position = initialPosition;
        StartCoroutine(ReenableScriptAfterDelay(1f));

        if(car){
            Destroy(other);
            carCrash.Play();
        }
        else{
            cough.Play();
        }
    }

    private System.Collections.IEnumerator ReenableScriptAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        firstPersonController.enabled = true;
    }
}
