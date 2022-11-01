using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpicCameraMove : MonoBehaviour
{
    CinemachineVirtualCamera cvcCamera;
    public Transform player;
    float smoothing = 475;
    PlayerInput playerInput;
    Vector3 velocity = Vector3.zero;
    private void Awake()
    {
        cvcCamera = GetComponent<CinemachineVirtualCamera>();
        playerInput = FindObjectOfType<PlayerInput>();
        cvcCamera.Follow = null;
    }
    private void Start()
    {
        playerInput.canMove = false;
        Invoke(nameof(StartFollow), 5f);
    }
    private void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, player.position, ref velocity, smoothing * Time.deltaTime);
    }
    void StartFollow()
    {
        cvcCamera.Follow = player;
        playerInput.canMove = true;
    }
}
