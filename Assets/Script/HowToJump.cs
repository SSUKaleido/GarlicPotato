using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToJump : MonoBehaviour
{
    public Animator anim;
    Rigidbody2D rb;

    public float jumpForce;
    int jumpStack = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (jumpStack < 1)
            {   //slide���°� �ƴϰ� ���������� 2ȸ���� ���� ��
                anim.SetTrigger("toJump");
                rb.velocity = Vector2.up * jumpForce;
                jumpStack += 1;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)   //���̺�� �浹���� �� ���� ( ���߿��� ���������� �����ϰ� �ִϸ��̼���ȯ )
    {
        if (col.gameObject.tag == "Ground")   //collider �̸��� Ground �� ��ü�� �ε��� �� ����
        {
            //Debug.Log("OnCollision worked");
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("PotatoJump"))
            { //���� ���¿��� �ٴڿ� ������ �� ���������� 0���� �ٲٰ� �ִϸ��̼ǵ� run���� ����
                jumpStack = 0;
                anim.SetTrigger("toRun");
            }
        }
    }
}
