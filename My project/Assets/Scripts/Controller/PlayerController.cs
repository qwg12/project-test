using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1.0f;                              //이동 속도 변수 선언
    public GameObject PlayerPivot;                              //플레이어 피봇 선언
    Camera viewCamera;                                          //카메라 정보 값을 가져오기 위해 선언
    Vector3 velocity;                                           //이동 방향 벡터 값 선언
    public ProjectileController projectileController;           //발사 컨트롤 클래스 접근

    public int Monster_hp = 20;

    public void Player_Damaged(int damage)
    {
        Monster_hp -= damage;

        if (Monster_hp <= 0)
        {
            GameObject temp = this.gameObject;
            Destroy(temp);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        viewCamera = Camera.main;                               //주 사용 카메라 입력
    }

    // Update is called once per frame
    void Update()
    {
        //모니터 2D -> 인게임 3D  좌표 변환 (마우스가 3D 상에 어디에 있는지)
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
        //바라볼 위치를 계산하기 위해서 오브젝트 y축 좌표를 설정 (바닥은 x,z축)
        Vector3 targetPosition = new Vector3(mousePos.x, transform.position.y, mousePos.z);

        PlayerPivot.transform.LookAt(targetPosition, Vector3.up);

        velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * moveSpeed;

        if(Input.GetMouseButtonDown(0))
        {
            projectileController.FireProjectile();
        }
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + velocity * Time.fixedDeltaTime);
    }
}
