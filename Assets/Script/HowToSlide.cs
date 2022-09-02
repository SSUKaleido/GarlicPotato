using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToSlide : MonoBehaviour
{
    public Animator anim;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1)/*Input.GetMouseButtonDown(1)*/) //��Ŭ�� Ȧ��
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("PotatoRun"))   //run ������ ���� �����̵�� ��ȯ
            {
                anim.SetTrigger("toSlide");

            }

        }

        if (Input.GetMouseButtonUp(1)) // Ȧ�� ������ 
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("PotatoSlide"))   //�����̵� ���¿��� �� ���·� ��ȯ
            {
                anim.SetTrigger("toRun");

            }
        }
    }
}
