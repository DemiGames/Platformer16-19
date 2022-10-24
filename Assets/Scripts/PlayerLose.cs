using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLose : MonoBehaviour
{
    Damaging damaging;
    [SerializeField] GameObject losePanel;
    private void Start()
    {
        losePanel.SetActive(false);
        damaging = GetComponent<Damaging>();
    }
    private void Update()
    {
        if (damaging.isDead)
        {
            losePanel.SetActive(true);
        }
    }
}
