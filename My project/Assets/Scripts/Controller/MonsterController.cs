using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public int Monster_hp = 5;

    public void Mpnster_Damaged(int damage)
    {
        Monster_hp -= damage;

        if(Monster_hp <= 0)
        {
            GameObject temp = this.gameObject;
            Destroy(temp);
        }
    }
}
