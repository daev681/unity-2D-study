using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{

    private float moveSpead = 5.0f;
    private Vector3 moveDirection = Vector3.zero;


    private void Update() {
       // Negative left , a : -1
       // Positive right , d : 1
       // Non : 0
        float x = Input.GetAxisRaw("Horizontal"); // 좌우 이동
       // Negative donw , s : -1
       // Positive up , w : 1
       // Non : 0
        float y = Input.GetAxisRaw("Vertical"); // 위아래 이동

   
        moveDirection = new Vector3(x,y,0);

        transform.position += moveDirection * moveSpead * Time.deltaTime;

        


        // 현재 위치 + (방향 * 속도)
        //transform.position = transform.position + new Vector3(1,0,0) * 1;
        // Time.deltaTime -> 컴퓨터 사양때문에 거리 조절 하는 ,컴퓨터 사양에따라 update 호출 횟수가 다르다

         //  transform.position += Vector3.right * 1 * Time.deltaTime;
    }

}
