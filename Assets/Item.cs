using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
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
    }

    // Update is called once per frame
    void Update()
    {
        interval -= Time.deltaTime;
        if(interval == 0)
        {
            interval = 3.0f;
            //ÉAÉCÉeÉÄÇÃê∂ê¨
            
            rb_item.AddForce()
        }
    }
}
