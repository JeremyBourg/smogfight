using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactWithEnemy : MonoBehaviour
{

    public CollisionManager collisionManager;


private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            collisionManager.HandleContact(false, other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            collisionManager.HandleContact(true, other.gameObject);
        }
    }

}
