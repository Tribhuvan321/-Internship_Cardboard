using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform VRPlayer;
    public float lookDownAngle = 25f;
    private CharacterController cc;
    public float speed = 3.0f;
    private bool moveForward;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (VRPlayer.eulerAngles.x > lookDownAngle && VRPlayer.eulerAngles.x < 90.0f)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }

        if (moveForward == true)
        {
            Vector3 forword = VRPlayer.TransformDirection(Vector3.forward);
            cc.SimpleMove(forword);
        }
    }
}
