using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroBehaviour : MonoBehaviour
{
    
    public Vector3 initialPos;
    public Vector3 finallPos;
    public Vector3 deltalPos;

    public Vector3 initialRot;
    public Vector3 finallRot;
    public Vector3 deltalRot;

    public float currentTime;
    public float easingTime;

    public bool intro;
    public Transform logo;

    void Start ()
    {
        initialPos = logo.position;
        initialRot = logo.rotation.eulerAngles;
		deltalPos = finallPos - initialPos;
        deltalRot = finallRot - initialRot;
        intro = false;
    }

    void Update()
    {


        if(currentTime < easingTime)
        {
            currentTime += Time.deltaTime;

            logo.position = new Vector3(Easing.ExpoEaseInOut(currentTime, initialPos.x, deltalPos.x, easingTime),
                Easing.ExpoEaseInOut(currentTime, initialPos.y, deltalPos.y, easingTime),
                Easing.ExpoEaseInOut(currentTime, initialPos.z, deltalPos.z, easingTime));

            logo.localRotation = Quaternion.EulerAngles(Easing.ExpoEaseInOut(currentTime, initialPos.x, deltalPos.x, easingTime),
                Easing.ExpoEaseInOut(currentTime, initialPos.y, deltalPos.y, easingTime),
                Easing.ExpoEaseInOut(currentTime, initialPos.z, deltalPos.z, easingTime));

        }
        else
        {
            currentTime = 0;
            intro = !intro;
            Vector3 initP = initialPos;
            initialPos = finallPos;
            finallPos = initP;
            deltalPos = finallPos - initialPos;

            Vector3 initR = initialPos;
            initialRot = finallRot;
            finallRot = initR;
            deltalRot = finallRot - initialRot;
        }
	}
}