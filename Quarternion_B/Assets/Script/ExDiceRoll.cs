using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ExDiceRoll : MonoBehaviour
{
    public enum Side        // 몇 면체인지
    {
        Six,
        Twenty
    }

    public List<Side> dice = new List<Side>();

    public TMP_InputField side_Input;
    public TMP_InputField amount_Input;

    public Text totalNumText;

    public void RollingDice()
    {
        // 총 합계를 저장할 변수
        int totalNum = 0;  

        for (int i = 0; i < dice.Count; i++)
        {
            // 주사위를 굴렸을때 나온 숫자를 저장할 변수
            int diceNum = 0;
            if (dice[i] == Side.Six)    // dice[i]가 6면체일 때
            {
                diceNum = Random.Range(1, 7);   // diceNum을 1 ~ 6 사이의 랜덤한 숫자를 지정
                Debug.Log($"6면체 : {diceNum}");
            }
            else if (dice[i] == Side.Twenty)    /// dice[i]가 20면체일 때
            {
                diceNum = Random.Range(1, 21);  // diceNum을 1 ~ 20 사이의 랜덤한 숫자를 지정
                Debug.Log($"20면체 : {diceNum}");
            }
            totalNum += diceNum;    // 총합계에 굴려서 나온 숫자를 더함
        }

        totalNumText.text = $"총 합계: {totalNum}";
        //Debug.Log("총 합계: " + totalNum);
    }

    public void AddDice()                                               // 주사위를 추가하는 함수
    {
        if (!IsInputIsRight()) return;                                  // INputField가 잘 입력되어있는지 확인하고 아닐경우 함수 종료

        int side = int.Parse(side_Input.text);                          // 몇 면체인지 받아옴
        int amount = int.Parse(amount_Input.text);                      // 몇 개인지

        if (dice.Count >= 3 || amount + dice.Count > 3)                // 지금 가지고 있는 주사위의 갯수가 3개 이상이거나 추가했더니 3개를 넘을경우
        {
            Debug.LogError("3개 이상 주사위를 가질 수 없습니다.");      // 경고 메세지 출력
            return;
        }

        for (int i = 0; i < amount; i++)                                // 추가하는 양 만큼 반복
        {
            if (side == 6)                                              // 6면제
            {
                dice.Add(Side.Six);
            }
            else                                                        // 20면체일 경우 (6, 20 이 아니면 실행X)
            {
                dice.Add(Side.Twenty);
            }
        }

        side_Input.text = string.Empty;                                 // InputField 초기화
        amount_Input.text = string.Empty;                               // InputField 초기화

        ShowMyDIce();                                                   // 가지고 있는 주사위 출력
    }

    public void ResetDIce()                                             // 주사위 리스트 초기화
    {
        dice = new List<Side>();
    }

    public bool IsInputIsRight()                                        // 잘 기입 되어있는지 확인하는 함수
    {
        int side, amount;                                               // TryParse out값 받기 위해서

        // int로 변환이 되지 않을 경우
        if (!int.TryParse(side_Input.text, out side) || !int.TryParse(amount_Input.text, out amount))
        {
            Debug.LogError("숫자만 기입해주세요");
            return false;       // 거짓 반환
        }

        // 6, 20 을 입력하지 않은 경우
        if (side != 6 && side != 20)
        {
            Debug.LogError("6 또는 20을 입력해주세요");
            return false;       // 거짓 반환
        }

        return true;       // 잘못된것이 없기 때문에 참 반환
    }

    public void ShowMyDIce()                // 지금 가지고 있는 주사위를 출력하는 함수
    {
        string text = "";
        int sixSideAmount = 0;
        int twentySideAmount = 0;

        if (dice.Count <= 0)
        {
            Debug.Log("주사위가 없습니다.");
            return;
        }

        for (int i = 0; i < dice.Count; i++)
        {
            if (dice[i] == Side.Six)
            {
                text += $"{i + 1}번 주사위 6면체 \n";
                sixSideAmount++;
            }
            else
            {
                text += $"{i + 1}번 주사위 20면체 \n";
                twentySideAmount++;
            }
        }

        Debug.Log(text);
        Debug.Log("6면체 개수 : " + sixSideAmount.ToString());
        Debug.Log("20면체 개수 : " + twentySideAmount.ToString());
    }
}
