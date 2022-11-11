using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    [SerializeField]
    public float speed;
    private float Move_X;
    Rigidbody Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move_X = Input.GetAxis("Horizontal") * speed;
        Vector3 Player_Body = new Vector3(Move_X, 0, 0);
    }

    private void FixedUpdate()
    {
        Rigidbody.velocity = new Vector3(Move_X, 0, 0);
    }
}
