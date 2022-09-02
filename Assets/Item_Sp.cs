using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Sp : MonoBehaviour
{
    //�����Ƒł��o�����X�|�i�[�ł��
    [SerializeField]
    Item[] items;

    [SerializeField]
    Vector2 force_max = new Vector2(15.0f, 10.0f);

    //����
    [SerializeField]
    float item_sp_time_max = 3.0f;
    float item_sp_time;
    float item_sp_timer = 0;

    void Start()
    {
        item_sp_timer = item_sp_time_max;
    }

    void Update()
    {
        item_sp_timer -= Time.deltaTime;
        if(item_sp_timer <= 0)
        {
            var nam = Random.Range(0, 100);
            if(nam == 100) //���u���@������������else if����
            {
                //�m�[�}���A�C�e���̐���
                Item normal = Instantiate(items[0]);
                normal.name = "normal_item";
                var wide = Random.Range(-force_max.x, force_max.x);
                normal.GetComponent<Rigidbody2D>().AddForce(new Vector2(force_max.x, force_max.y), ForceMode2D.Impulse);
            }
            //���ԃ����_��
            item_sp_timer = Random.Range(0.1f,item_sp_time_max);
        }

    }
}
