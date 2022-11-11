using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neck : MonoBehaviour
{
    public GameObject bar;//�I�u�W�F�N�g
    public GameObject pivot;//��]���Abar�̐e�A��̃Q�[���I�u�W�F�N�g


    Vector3 m_mouseDownPosition = Vector3.zero;
    public GameObject Body;

    private void Update()
    {
        Vector3 BodyPos = Body.transform.position;
        float X = BodyPos.x;
        float Y = BodyPos.y;
        float Z = BodyPos.z;

        Vector3 Body_Transform = new Vector3(-X, Y, -Z);


        // �}�E�X�N���b�N�����ꏊ�����[���h���W�ɕω����āA
        Vector3 inputPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(inputPosition);//*�}�E�X�Ɍ����ĐL�т�

        // �����ʒu�ƃ}�E�X�N���b�N�ʒu�̒��ԂɃI�u�W�F�N�g��z�u�B
        Vector3 mediumPos = (mousePos - Body_Transform) / 2.0f;
        float dist = Vector3.Distance(mousePos, Body_Transform);

        // �I�u�W�F�N�g�̃X�P�[���������ʒu�ƃ}�E�X�N���b�N�̋����ɁB
        // �I�u�W�F�N�g�̌������}�E�X�N���b�N�����ʒu�ɁB
        transform.position = mediumPos;
        transform.localScale = new Vector3(0.5f, 0.5f, dist);//*�T�C�Y�ύX
        transform.LookAt(mousePos);
    }
}
