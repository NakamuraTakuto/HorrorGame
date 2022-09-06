using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectBase : MonoBehaviour
{
    /// <summary>Player�̈ʒu���擾����ׂ̕ϐ�</summary>
    Vector3 _position;
    public abstract void Activete();

    //collider���ڐG���Ă��違���v���C���[�����N���b�N�������ɍs����������
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Fire1") && collision.gameObject.tag == "Player")
        {
            if (gameObject.tag == "Object" && Input.GetButtonDown("Fire2"))
            {
                //����gameObject�̏��Player���ړ���������
                _position = collision.gameObject.transform.parent.position;
                //collision.gameObject.transform.parent.position = _position;
                collision.gameObject.transform.position = gameObject.transform.parent.position + Vector3.up;
            }
        }
    }
}
