using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;            // 5 unit per second
    public float rotationSpeed = 360f;      // 360 degree per second

    CharacterController characterController;

    Camera mainCam;
    public float cameraDistance = 5f;
    Vector3 camNormal = new Vector3(0f, 0.1f, -1f);

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();

        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        camNormal = camNormal.normalized;
        mainCam.transform.position = transform.position + (camNormal * cameraDistance);
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if(direction.sqrMagnitude > 0.01f)
        {
            Vector3 forward = Vector3.Slerp(
                transform.forward,
                direction,
                rotationSpeed * Time.deltaTime / Vector3.Angle(transform.forward, direction)
                );
            transform.LookAt(transform.position + forward);
        }
        characterController.Move(direction * moveSpeed * Time.deltaTime);
    }
}
