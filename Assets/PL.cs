using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PL : MonoBehaviour
{
    [SerializeField]
    public float speed = 10; //�ړ����x
    [SerializeField]
    public float jump = 10; //�W�����v
    //�d��
    Rigidbody2D rb_pl;
    private bool isGround;�@//�n�ʔ���

    void Start()
    {
        //rb�̎擾
        rb_pl = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //�E�ړ�
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed, 0, 0);
        }
        //���ړ�
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed, 0, 0);
        }
        //�W�����v�͒n�ʂɂ���Ƃ�����
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rb_pl.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }

    }

    //�n�ʂƂ̐ڐG����ɂ��bool
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "ground") 
        {
            isGround = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "ground")
        {
            isGround = false;
        }
    }
}
