using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {

    private float h = 0.0f;
    private float v = 0.0f;

    //접근해야하는 컴포넌트는 반드시 변수에 할당 후 사용
    //[SerializeField]는 private 속성은 유지한 채, Inspector View에 노출되도록 하는 것
    [SerializeField] private Transform tr;
    //이동 속도 변수(public으로 선언되면 Inspector view에 노출)
    private float moveSpeed = 7.0f;

	// Use this for initialization
	void Start () {

        //스크립트 실행된 후 처음 수행되는 Start 함수에서 Transform 컴포넌트를 할당
        tr = GetComponent<Transform>();

        /*
         * 아래 세가지는 모두 동일하게 작동한다.
        tr = GetComponent<Transform>();
        tr = this.gameObject.GetComponent<Transform>(); // 이 스크립트가 포함된 게임오브젝트가 가진 컴포넌트 중에서 Transform 컴포넌트를 추출해서 tr변수에 대입
        tr = GetComponent("Transform") as Transform;
        tr = (Transform)GetComponent(typeof(Transform));
        */

	}
	
	// Update is called once per frame
	void Update () {
        
        // h에는 Horizontal 값, v에는 vertical 값을 받는다
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        //전후좌우 이동 방향 벡터 계산
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        //이동, 벡터(그리고 normalized로 정규화) * 이동속도변수 * 시간으로 계산(이것을 하지 않으면 frame별로 이동하게 된다)
        //Space.Self는 기준을 로컬로 둔다는 뜻
        tr.Translate(moveDir.normalized * moveSpeed * Time.deltaTime, Space.Self);
        
        Debug.Log("h = " + h.ToString());
        Debug.Log("v = " + v.ToString());
	}
}
