using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    [SerializeField] GameObject boomPrefab;
    Vector3 offset = new Vector3(0, 0.5f, 0);
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.GetComponent<PointEffector2D>().enabled = true;
            Invoke("DestroyThisObject", 0.2f);
        }
    }
    void DestroyThisObject()
    {
        Destroy(gameObject);
        Instantiate(boomPrefab, transform.position + offset, transform.rotation);
    }
}
