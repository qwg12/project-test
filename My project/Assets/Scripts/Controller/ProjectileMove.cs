using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 launchDirection;

    private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;
        transform.Translate(launchDirection * moveAmount);
    }
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log(collision.gameObject.name);

            if (collision.gameObject.name == "wall")
            {
                GameObject temp = this.gameObject;
                Destroy(temp);
            }

            if (collision.gameObject.name == "Monster")
            {
                collision.gameObject.GetComponent<MonsterController>().Mpnster_Damaged(1);
                GameObject temp = this.gameObject;
                Destroy(temp);
            }
        
    }   
}

