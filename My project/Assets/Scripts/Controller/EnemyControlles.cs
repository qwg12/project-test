using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControlles : MonoBehaviour
{
    public float speed = 5.0f;              //적의 속도 선언
    public float rotationSpeed = 1.0f;

    public GameObject bulletPrefab;
    public GameObject enemyPiovt;

    public Transform firePoint;
    public float fireRate = 1.0f;
    public float nextFireTime;

    private Rigidbody rb;           //Rigidbody 선언
    private Transform player;       //플레이어 위치 가져오기 위해 선언

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(player !=null)
        {
            if (Vector3.Distance(player.position, transform.position) > 3.0f)
            {
                Vector3 direction = (player.position - transform.position).normalized;
                rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
            }
        }
      
        //포탑회전
        Vector3 targetDirection = (player.position - enemyPiovt.transform.position).normalized;
        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        enemyPiovt.transform.rotation = Quaternion.Lerp(enemyPiovt.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        if(Time.time > nextFireTime)
        {
            nextFireTime = Time.time + 1.0f / fireRate;
            GameObject temp = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            temp.GetComponent<ProjectileMove>().launchDirection = firePoint.localRotation * Vector3.forward;
            temp.GetComponent<ProjectileMove>().bulletType = ProjectileMove.BULLETTYPE.ENEMY;
        }
    }
}
