using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]GameObject pickUpParticle;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.AddCoin();
            Instantiate(pickUpParticle, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
