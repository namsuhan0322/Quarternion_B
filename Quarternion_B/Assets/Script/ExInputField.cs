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
            Debug.Log($"입력된 문자열 : {GetStringFromInputField(inputField)}");
        }
    }

    public string GetStringFromInputField(TMP_InputField inputField)
    {
        // inputField가 비어있거나 문자열이 비어있을 경우
        if (inputField == null || inputField.text == null || inputField.text == "")
        {
            // Debug.LogWarning("inputField가 이버있거나 문자열이 비어있습니다.")
            return null;
        }

        return inputField.text;
    }
}
