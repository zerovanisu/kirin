using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neck : MonoBehaviour
{
    public GameObject bar;//オブジェクト
    public GameObject pivot;//回転軸、barの親、空のゲームオブジェクト


    Vector3 m_mouseDownPosition = Vector3.zero;
    public GameObject Body;

    private void Update()
    {
        Vector3 BodyPos = Body.transform.position;
        float X = BodyPos.x;
        float Y = BodyPos.y;
        float Z = BodyPos.z;

        Vector3 Body_Transform = new Vector3(-X, Y, -Z);


        // マウスクリックした場所をワールド座標に変化して、
        Vector3 inputPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(inputPosition);//*マウスに向けて伸びる

        // 初期位置とマウスクリック位置の中間にオブジェクトを配置。
        Vector3 mediumPos = (mousePos - Body_Transform) / 2.0f;
        float dist = Vector3.Distance(mousePos, Body_Transform);

        // オブジェクトのスケールを初期位置とマウスクリックの距離に。
        // オブジェクトの向きをマウスクリックした位置に。
        transform.position = mediumPos;
        transform.localScale = new Vector3(0.5f, 0.5f, dist);//*サイズ変更
        transform.LookAt(mousePos);
    }
}
