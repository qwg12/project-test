using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControlles : MonoBehaviour
{
    public float speed = 5.0f;

    private Rigidbody rb;           //Rigidbody ����
    private Transform player;       //�÷��̾� ��ġ �������� ���� ����

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(player.position , transform.position) > 1.0f)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
        }
    }
}
