using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;            // 5 unit per second
    public float rotationSpeed = 360f;      // 360 degree per second

    Camera mainCam;
    public Transform characterModel;
    public Transform cameraArm;


    float camOffset;
    public float minCamOffset = 1f;
    public float maxCamOffset = 10f;

    Vector3 offsetHeight = new Vector3(0f, 0.1f, 0f);

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
        camOffset = mainCam.transform.localPosition.magnitude;
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CamControl();
        Move();
        SkillUse();
    }

    void Move()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        bool isMove = direction.magnitude != 0;

        Debug.DrawRay(cameraArm.position, new Vector3(cameraArm.forward.x, 0f, cameraArm.forward.z).normalized, Color.red);
        if(isMove)
        {
            animator.SetBool("isMove", true);
            Vector3 lookForward = new Vector3(cameraArm.forward.x, 0f, cameraArm.forward.z).normalized;
            Vector3 lookRight = new Vector3(cameraArm.right.x, 0f, cameraArm.right.z).normalized;
            Vector3 moveDir = lookForward * direction.z + lookRight * direction.x;

            characterModel.forward = moveDir;

            transform.position += moveDir * Time.deltaTime * moveSpeed;
        }
        else
            animator.SetBool("isMove", false);

    }

    void CamControl()
    {
        if(Input.GetMouseButton(1))     // 0 : left button , 1 : right button
        {
            Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            Vector3 camAngle = cameraArm.rotation.eulerAngles;

            float x = camAngle.x - mouseDelta.y;
            // cam ????????????
            if (x < 180f)
            {

                x = Mathf.Clamp(x, -1f, 70f);
                camAngle.x = x;

            }
            else
            {

                x = Mathf.Clamp(x, 335f, 361f);
                camAngle.x = x;
            }

            cameraArm.rotation = Quaternion.Euler(camAngle.x - mouseDelta.y,
                                                    camAngle.y + mouseDelta.x,
                                                    camAngle.z);

        }
        float wheelinput = Input.GetAxis("Mouse ScrollWheel");
        if(wheelinput != 0)
        {
            camOffset -= wheelinput;
            Mathf.Clamp(camOffset, minCamOffset, maxCamOffset);
            Vector3 direction = mainCam.transform.position - (characterModel.position);

            mainCam.transform.position = cameraArm.position + direction.normalized * camOffset;
            
        }
        
    }
    void SkillUse()
    {
        if (animator.GetBool("isSkill"))
            return;

        if(Input.GetKeyDown("1"))
        {
            Debug.Log("Use 1");
            animator.SetBool("isSkill", true);
        }
        else if (Input.GetKeyDown("2"))
        {
            Debug.Log("Use 2");
            animator.SetBool("isSkill", true);
        }
        else if (Input.GetKeyDown("3"))
        {
            Debug.Log("Use 3");
            animator.SetBool("isSkill", true);
        }
        else if (Input.GetKeyDown("4"))
        {
            Debug.Log("Use 4");
            animator.SetBool("isSkill", true);
        }

    }
}
