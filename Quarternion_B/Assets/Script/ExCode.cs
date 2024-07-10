using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExCode : MonoBehaviour
{
    public int _int;                // ����
    public float _float;            // �Ǽ�
    public bool _bool;              // ��/����
    public string _string;          // ���ڿ�
    public char _char;              // ����

    [SerializeField] private int __int;         // SerializeField�� private�� ����� ������ �ν�����â�� ����.
    [HideInInspector] public float __float;     // HideInInspector �ν�����â�� �Ⱥ��̰� �����.

    public Rigidbody rigidbody;

    private void Start()
    {
        if (!TryGetComponent<Rigidbody>(out rigidbody))
        {
            rigidbody = gameObject.AddComponent<Rigidbody>();
        }
    }
}