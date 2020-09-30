using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject actor;
    Animator anim;
    Command keyQ, keyW, keyE, upArrow;

    // Start is called before the first frame update
    void Start()
    {
        keyQ = new PerformJump();
        keyW = new PerformPunch();
        keyE = new PerformKick();
        upArrow = new MoveForward();
        anim = actor.GetComponent<Animator>();
        Camera.main.GetComponent<CameraFollow360>().player = actor.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            keyQ.Execute(anim);
        }else if (Input.GetKeyDown(KeyCode.W))
        {
            keyW.Execute(anim);
        }else if (Input.GetKeyDown(KeyCode.E))
        {
            keyE.Execute(anim);
        }else if (Input.GetKey(KeyCode.UpArrow))
        {
            upArrow.Execute(anim);
        }
    }
}
