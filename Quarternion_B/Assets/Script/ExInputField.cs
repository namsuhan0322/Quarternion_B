using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExInputField : MonoBehaviour
{
    public TMP_InputField inputField;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"�Էµ� ���ڿ� : {GetStringFromInputField(inputField)}");
        }
    }

    public string GetStringFromInputField(TMP_InputField inputField)
    {
        // inputField�� ����ְų� ���ڿ��� ������� ���
        if (inputField == null || inputField.text == null || inputField.text == "")
        {
            // Debug.LogWarning("inputField�� �̹��ְų� ���ڿ��� ����ֽ��ϴ�.")
            return null;
        }

        return inputField.text;
    }
}
