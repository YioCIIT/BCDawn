using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperBehavior : MonoBehaviour
{
    public float restPosition = 0;
    public float pressedPoisition = 45f;
    public float hitStrength = 0;
    public float flipperDamper = 150f;

    public bool isLeftFlipper;

    HingeJoint hinge;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = flipperDamper;

        KeyCode key = isLeftFlipper ? KeyCode.LeftShift : KeyCode.RightShift;

        if (Input.GetKey(key))
        {
            spring.targetPosition = pressedPoisition;
            Debug.Log("Left Shift Pressed");
        }
        else
        {
            spring.targetPosition = restPosition;
        }

        hinge.spring = spring;
        hinge.useLimits = true;
    }
}
