using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectBase : MonoBehaviour
{
    public abstract void Activete();

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(this.gameObject.tag == "Object")
        {
            //����gameObject�̏��Player���ړ���������
            collision.gameObject.transform.position = this.gameObject.transform.position;
        }
        else if (this.gameObject.tag == "item")
        {
            //����gameObject��item�Ȃ�List�ɓ����
            collision.gameObject.GetComponent<PlayerContller>().ItemGet(this);
            //����gameObject�������Ȃ��Ƃ���Ɉړ�����
            this.transform.position = Camera.main.transform.position;
            //����gameObject��collider��off�ɂ���
            GetComponent<Collider2D>().enabled = false;
        }
    }
}
