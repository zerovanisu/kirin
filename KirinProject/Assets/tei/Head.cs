using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    private Vector3 Mouse;
    private Vector3 Player_Head;
    void Update()
    {
        Mouse = Input.mousePosition;
        Player_Head = Camera.main.ScreenToWorldPoint(new Vector3(Mouse.x, Mouse.y, 10));
        this.transform.position = Player_Head;
    }
}
