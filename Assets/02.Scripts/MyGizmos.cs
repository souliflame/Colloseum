﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGizmos : MonoBehaviour {
    public Color _color = Color.yellow;
    public float _radius = 0.03f;

    private void OnDrawGizmos()
    {
        //기즈모 색상 설정
        Gizmos.color = _color;
        //구체모양의 기즈모 생성. 인자는 (생성 위치, 반지름)
        Gizmos.DrawSphere(transform.position, _radius);
    }
}
