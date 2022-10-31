using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindZoneForPray : MonoBehaviour
{
    [SerializeField] GameObject eButton;
    [SerializeField] GameObject windzone;
    private void Start()
    {
        eButton.SetActive(false);
        windzone.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            eButton.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            eButton.SetActive(false);
    }
    private void Update()
    {
        Pray();
    }
    public void Pray()
    {
        if (Input.GetKeyDown(KeyCode.E))
            windzone.SetActive(true);
    }
}
