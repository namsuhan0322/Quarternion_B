using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExCode : MonoBehaviour
{
    public int _int;                // 정수
    public float _float;            // 실수
    public bool _bool;              // 참/거짓
    public string _string;          // 문자열
    public char _char;              // 문자

    [SerializeField] private int __int;         // SerializeField는 private로 선언된 변수를 인스펙터창에 띄운다.
    [HideInInspector] public float __float;     // HideInInspector 인스펙터창에 안보이게 숨긴다.

    public Rigidbody rigidbody;

    private void Start()
    {
        if (!TryGetComponent<Rigidbody>(out rigidbody))
        {
            rigidbody = gameObject.AddComponent<Rigidbody>();
        }
    }
}