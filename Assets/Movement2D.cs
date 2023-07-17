using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{

    private float moveSpead = 5.0f;
    private Vector3 moveDirection = Vector3.zero;
    private Rigidbody2D rigid2D;

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();

    }


    private void Update() {
       // !
       // Negative left , a : -1
       // Positive right , d : 1
       // Non : 0
        float x = Input.GetAxisRaw("Horizontal"); // 좌우 이동
       // Negative donw , s : -1
       // Positive up , w : 1
       // Non : 0
        float y = Input.GetAxisRaw("Vertical"); // 위아래 이동

   
       // moveDirection = new Vector3(x,y,0);

       // transform.position += moveDirection * moveSpead * Time.deltaTime;

        


        // 현재 위치 + (방향 * 속도)
        //transform.position = transform.position + new Vector3(1,0,0) * 1;
        // Time.deltaTime -> 컴퓨터 사양때문에 거리 조절 하는 ,컴퓨터 사양에따라 update 호출 횟수가 다르다

         //  transform.position += Vector3.right * 1 * Time.deltaTime;

        // 클래스 내부에서 이동 관련 함수 작동
        rigid2D.velocity = new Vector3(x, y, 0) * moveSpead;
    }


    private void OnCollisionEnter2D(Collision2D collision) // 충돌 일어날 경우
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)  // 충돌이 유지
    {
        
    }
    private void OnCollisionExit2D(Collision2D collision) // 충돌이 종료
    {
        
    }

}
