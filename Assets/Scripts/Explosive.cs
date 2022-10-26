using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Damagable"))
        {
            gameObject.GetComponent<PointEffector2D>().enabled = true;
            Invoke("DestroyThisObject", 1);
        }
    }
    void DestroyThisObject()
    {
        Destroy(gameObject);
    }
}
