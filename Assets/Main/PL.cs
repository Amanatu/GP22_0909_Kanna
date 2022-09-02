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

    [SerializeField]
    public static int score = 0;

    void Start()
    {
        //rb�̎擾
        rb_pl = GetComponent<Rigidbody2D>();
        score = 0;
    }

    void Update()
    {
        //�E�ړ� �E��D
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0, 0);
        }
        //���ړ��@����A
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
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
