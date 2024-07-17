using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class DropPoop : MonoBehaviour
{
    public GameObject[] poopPrefabs; 
    public GameObject[] spawnPoints;
    public float spawnTime = 1f;

    private void Start()
    {
        // 일정 시간마다 CreatePoop 메서드를 반복해서 호출
        InvokeRepeating("CreatePoop", 0f, spawnTime);
    }

    void CreatePoop()
    {
        // 랜덤하게 Poop 종류와 스폰 위치 선택
        int poopIndex = Random.Range(0, poopPrefabs.Length);
        int spawnIndex = Random.Range(0, spawnPoints.Length);

        // 선택한 스폰 포인트의 위치에서 선택한 Poop 생성
        Instantiate(poopPrefabs[poopIndex], spawnPoints[spawnIndex].transform.position, quaternion.identity);
    }
}