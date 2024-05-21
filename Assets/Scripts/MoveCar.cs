using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{

   private float speed = 25;
   
   public GameEvent carCollisionEvent;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(transform.position.x>100||transform.position.x<-100){
            Destroy(gameObject);
        }
    }
}
