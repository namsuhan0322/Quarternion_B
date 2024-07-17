using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poop : MonoBehaviour
{
    public PoopObj poopObj;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("땅!");

            // 일반 Poop이 땅에 닿으면 점수 추가
            if (poopObj.poopType == PoopObj.PoopType.Poop)
            {
                GameManager.instance.AddScore(1);
            }

            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            if (poopObj.poopType == PoopObj.PoopType.GoldPoop)
            {
                GameManager.instance.AddScore(1);
                Debug.Log("황금!");
            }
            
            Destroy(gameObject);
        }

    }
}