using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] CharacterController charec;
    [SerializeField] PhotonView view;
    [SerializeField] Camera cam;

    private void Start()
    {
        charec = GetComponent<CharacterController>();
        view = GetComponent<PhotonView>();
        if (!view.IsMine)
        {
            cam.enabled = false;
        }
    }


    void Update()
    {
        if (view.IsMine)
        {
            Moving();
        }

    }
    void move(float speedInputX = 0, float speedInputZ = 0)
    {
        Vector3 movmente = new Vector3(speedInputX, -0.5f, speedInputZ);
        charec.Move(movmente);
    }

    void Moving()
    {
        float hori = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (hori > 0) move(speed);
        if (hori < 0) move(-speed);
        if (vertical < 0) move(0, -speed);
        if (vertical > 0) move(0, speed);

    }

}
