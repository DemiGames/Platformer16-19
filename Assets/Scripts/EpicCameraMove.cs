using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpicCameraMove : MonoBehaviour
{
    CinemachineVirtualCamera cvcCamera;
    public Transform player;
    float smoothing = 85f;
    Vector3 velocity = Vector3.zero;
    private void Awake()
    {
        cvcCamera = GetComponent<CinemachineVirtualCamera>();
        cvcCamera.Follow = null;
    }
    private void Start()
    {
        Invoke(nameof(StartFollow), 5f);
    }
    private void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, player.position, ref velocity, smoothing * Time.deltaTime);
    }
    void StartFollow()
    {
        cvcCamera.Follow = player;
    }
}
