using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burret : MonoBehaviour
{
    private void Start()
    {
        //3秒後に自身を削除
        Destroy(this.gameObject, 1f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
