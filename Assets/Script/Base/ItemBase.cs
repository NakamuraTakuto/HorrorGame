using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBase : MonoBehaviour
{
    [Header("�A�C�e���̖��O��ݒ肷��"), SerializeField] string _itemName = default;
    public abstract void ItemActive();

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetButtonDown("Fire1"))
        {
            //����gameObject��item�Ȃ�List�ɓ����
            collision.gameObject.GetComponent<PlayerContller>().ItemGet(this.gameObject);
            //����gameObject�������Ȃ��Ƃ���Ɉړ�����
            transform.position = Camera.main.transform.position;
            //����gameObject��collider��off�ɂ���
            GetComponent<Collider2D>().enabled = false;
        }
    }
}
