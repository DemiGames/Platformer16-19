using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLose : MonoBehaviour
{
    public GameObject losePanel;
    private void Start()
    {
        losePanel.SetActive(false);
    }
}
