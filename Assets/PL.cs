using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PL : MonoBehaviour
{
    [SerializeField]
    public float speed = 10; //移動速度
    [SerializeField]
    public float jump = 10; //ジャンプ
    //重力
    Rigidbody2D rb_pl;
    private bool isGround;　//地面判定

    void Start()
    {
        //rbの取得
        rb_pl = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //右移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed, 0, 0);
        }
        //左移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed, 0, 0);
        }
        //ジャンプは地面にいるときだけ
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rb_pl.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }

    }

    //地面との接触判定によるbool
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
