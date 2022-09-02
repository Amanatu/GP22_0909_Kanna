using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
<<<<<<< HEAD
    Rigidbody2D rb_item;
    [SerializeField]
    float wide = 0;
    [SerializeField]
    float up = 4;

    float interval = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb_item = GetComponent<Rigidbody2D>();
=======
    Rigidbody2D item_rb;
    [SerializeField]
    public float hight = 5; //‚‚³
    [SerializeField]
    public float wide = 10; //‰¡
    // Start is called before the first frame update
    void Start()
    {
        
>>>>>>> ccd8182ada5c219a0989020816320350e9141446
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        interval -= Time.deltaTime;
        if(interval == 0)
        {
            interval = 3.0f;
            //ƒAƒCƒeƒ€‚Ì¶¬
            
            rb_item.AddForce()
        }
=======
        
>>>>>>> ccd8182ada5c219a0989020816320350e9141446
    }
}
