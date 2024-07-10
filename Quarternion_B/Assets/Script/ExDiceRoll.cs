using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;   

public class ExDiceRoll : MonoBehaviour
{
    public enum Side        // �� ��ü����
    {
        Six,
        Twenty
    }

    public List<Side> dice = new List<Side>();

    public TMP_InputField side_Input;
    public TMP_InputField amount_Input;

    public void RollingDice()
    {
        // �ֻ��� ������ ��ư�� ������ �������� ���ڰ� �߰� �� ������ ���� ����׷� ���.
        int sixDiceNum = Random.Range(1, 6);
        int twnetyDiceNum = Random.Range(1, 20);
    }

    public void AddDice()                                               // �ֻ����� �߰��ϴ� �Լ�
    {
        if (!IsInputIsRight()) return;                                  // INputField�� �� �ԷµǾ��ִ��� Ȯ���ϰ� �ƴҰ�� �Լ� ����

        int side = int.Parse(side_Input.text);                          // �� ��ü���� �޾ƿ�
        int amount = int.Parse(amount_Input.text);                      // �� ������

        if (dice.Count >= 3 || amount + dice.Count > 3)                // ���� ������ �ִ� �ֻ����� ������ 3�� �̻��̰ų� �߰��ߴ��� 3���� �������
        {
            Debug.LogError("3�� �̻� �ֻ����� ���� �� �����ϴ�.");      // ��� �޼��� ���
            return;
        }

        for (int i = 0; i < amount; i++)                                // �߰��ϴ� �� ��ŭ �ݺ�
        {
            if (side == 6)                                              // 6����
            {
                dice.Add(Side.Six);
            }
            else                                                        // 20��ü�� ��� (6, 20 �� �ƴϸ� ����X)
            {
                dice.Add(Side.Twenty);
            }
        }

        side_Input.text = string.Empty;                                 // InputField �ʱ�ȭ
        amount_Input.text = string.Empty;                               // InputField �ʱ�ȭ

        ShowMyDIce();                                                   // ������ �ִ� �ֻ��� ���
    }

    public void ResetDIce()                                             // �ֻ��� ����Ʈ �ʱ�ȭ
    {
        dice = new List<Side>();
    }

    public bool IsInputIsRight()                                        // �� ���� �Ǿ��ִ��� Ȯ���ϴ� �Լ�
    {
        int side, amount;                                               // TryParse out�� �ޱ� ���ؼ�

        // int�� ��ȯ�� ���� ���� ���
        if (!int.TryParse(side_Input.text, out side) || !int.TryParse(amount_Input.text, out amount))
        {
            Debug.LogError("���ڸ� �������ּ���");
            return false;       // ���� ��ȯ
        }

        // 6, 20 �� �Է����� ���� ���
        if (side != 6 && side != 20)
        {
            Debug.LogError("6 �Ǵ� 20�� �Է����ּ���");
            return false;       // ���� ��ȯ
        }

        return true;       // �߸��Ȱ��� ���� ������ �� ��ȯ
    }

    public void ShowMyDIce()                // ���� ������ �ִ� �ֻ����� ����ϴ� �Լ�
    {
        string text = "";
        int sixSideAmount = 0;
        int twentySideAmount = 0;

        if (dice.Count <= 0)
        {
            Debug.Log("�ֻ����� �����ϴ�.");
            return;
        }

        for (int i = 0; i < dice.Count; i++)
        {
            if (dice[i] == Side.Six)
            {
                text += $"{i + 1}�� �ֻ��� 6��ü \n";
                sixSideAmount++;
            }
            else
            {
                text += $"{i + 1}�� �ֻ��� 20��ü \n";
                twentySideAmount++;
            }
        }

        Debug.Log(text);
        Debug.Log("6��ü ���� : " + sixSideAmount.ToString());
        Debug.Log("20��ü ���� : " + twentySideAmount.ToString());
    }
}
