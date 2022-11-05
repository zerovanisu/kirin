using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatManager : MonoBehaviour
{
    [Header("プレイヤー")]
    [SerializeField]
    GameObject Player;

    [Header("アイテム")]
    [SerializeField]
    GameObject Item;

    [Header("敵")]
    [SerializeField]
    GameObject Enemy;

    [Header("生成するまでの時間(A～Bの間)")]
    [SerializeField]
    float Time_A, Time_B;

    [Header("生成範囲")]
    [SerializeField]
    float CreateVec_x, CreateVec_yl, CreateVec_yr;

    [Header("生成される距離")]
    [SerializeField]
    float Dstance;

    Vector3 CreateVec;

    float CoolTime;

    void Start()
    {
        CoolTime = Random.Range(Time_A,Time_B);
    }

    void Update()
    {
        CoolTime -= Time.deltaTime;

        if(CoolTime <= 0)
        {
            int a = Random.Range(0, 2);
            switch(a)
            {
                case 0:
                    ItemCreate();
                    break;

                case 1:
                    EnemyCreate();
                    break;
            }

            CoolTime = Random.Range(-Time_A,Time_B);
        }
    }

    void ItemCreate()
    {
        float x = Random.Range(-CreateVec_x, CreateVec_x);
        float y = Random.Range(CreateVec_yl, CreateVec_yr);

        CreateVec = new Vector3(x, y, Player.transform.position.z + Dstance);

        Instantiate(Item, CreateVec, Quaternion.identity);
    }

    void EnemyCreate()
    {
        float x = Random.Range(-CreateVec_x, CreateVec_x);

        CreateVec = new Vector3(x, Player.transform.position.y, Player.transform.position.z + Dstance);

        Instantiate(Enemy, CreateVec, Quaternion.identity);
    }
}
