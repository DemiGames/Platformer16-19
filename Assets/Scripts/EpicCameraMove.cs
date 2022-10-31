using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpicCameraMove : MonoBehaviour
{
    CinemachineVirtualCamera cvcCamera;
    PlayerInput player;
    float smoothing = 1;
    Vector3 playerPos;
    private void Awake()
    {
        cvcCamera = GetComponent<CinemachineVirtualCamera>();
        player = FindObjectOfType<PlayerInput>();
    }
    private void Start()
    {
        playerPos = player.transform.position;
        transform.position = Vector3.Lerp(transform.position, playerPos, smoothing * Time.deltaTime);
        Invoke(nameof(StartFollow), 3);
    }
    void StartFollow()
    {
        // cvcCamera.Follow = player.transform;
    }
}
