using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventFunctionTest : MonoBehaviour
{

    // Awake() -> onEnable() -> Start()
    // Update() -> LateUpdate()
    private void Awake() {
        Debug.Log("오브젝트 활성화 되어있을때 , 1회 호출 , 데이터 초기화  Awake() ");
    }


    private void Start() {
        Debug.Log("현재 씬에서 게임오브젝트 , 컴포넌트 모두 활성화 되어있을때 , 첫번재 업데이트 함수가 실행되기 직전 Start()");
    }

    private void OnEnable() {
           Debug.Log("컴포넌트가 비활성화 되었다가 활성화 될때 1회 호출 onEnbale()");
    }

    private void OnDisable() {
           Debug.Log("컴포넌트가 활성화 되었다가 비활성화 될때 1회 호출 OnDisable()");
    }
    
    private void Update() {
         Debug.Log("매 프레임마다 계혹 호출 upDate()");
    }

 // ex) 플레이어가 캐릭터 update 이횽해 움직인 이후 카메라는 LateUpdate의 플레이 위치를 바탕으로 이동
    private void LateUpdate() {
         Debug.Log("현재 씬에 존재하는 모든 게임 오브젝트의 UPDATE() 함수가 1회 실행된후 실행 LateUpdate()");
    }

     private void FixedUpdate() {
         Debug.Log("프레임 영향 받지 않음 ixedUpdate()");
     }

      private void OnDestory() {
         Debug.Log("게임 오브젝트 파괴될때 1회 호출 , 씬이 변경되거나 게임이 종료 될때 OnDestory()");
     }

      private void OnApplicationQuit() {
         Debug.Log("플레이 종료 OnApplicationQuit()");
      }
}
