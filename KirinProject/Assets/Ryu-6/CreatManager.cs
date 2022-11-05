using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatManager : MonoBehaviour
{
    [Header("�v���C���[")]
    [SerializeField]
    GameObject Player;

    [Header("�A�C�e��")]
    [SerializeField]
    GameObject Item;

    [Header("�G")]
    [SerializeField]
    GameObject Enemy;

    [Header("��������܂ł̎���(A�`B�̊�)")]
    [SerializeField]
    float Time_A, Time_B;

    [Header("�����͈�")]
    [SerializeField]
    float CreateVec_x, CreateVec_yl, CreateVec_yr;

    [Header("��������鋗��")]
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
