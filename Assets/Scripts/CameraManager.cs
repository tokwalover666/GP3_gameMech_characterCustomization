using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class CameraManager : MonoBehaviour
{
    public Transform OrigPos;
    public Transform TargetB;
    public Transform RotateB;
    public Transform TargetA;
    public Transform RotateA;

    public float rotateSpeed;
    public float smoothSpeed = 2f;

    public GameObject buttonB;
    public GameObject buttonA;
    public GameObject switchToRei;
    public GameObject switchToLeo;
    public GameObject nametagRei;
    public GameObject nametagLeo;
    public GameObject leo;
    public GameObject rei;

    void Start()
    {
        buttonA.SetActive(false);
        buttonB.SetActive(false);
        switchToLeo.SetActive(false);
        switchToRei.SetActive(false);
        nametagRei.SetActive(true);
        nametagLeo.SetActive(true);
        leo.SetActive(false);
        rei.SetActive(false);
        


    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void ChooseLeo()
    {
        buttonB.SetActive(true);
        buttonA.SetActive(false);
        switchToRei.SetActive(true);
        nametagRei.SetActive(false);
        nametagLeo.SetActive(false) ;
        leo.SetActive(true);

        transform.position = Vector3.Lerp(transform.position, TargetB.position, smoothSpeed * Time.deltaTime);

        // Smoothly rotate towards RotateA
        Vector3 direction = RotateA.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, smoothSpeed * Time.deltaTime);

    }

    public void ChooseRei()
    {
        buttonA.SetActive(true);
        buttonB.SetActive(false);
        switchToLeo.SetActive(true);
        nametagRei.SetActive(false);
        nametagLeo.SetActive(false);
        rei.SetActive(true);

        Vector3 smoothedPosition = Vector3.Lerp(OrigPos.position, TargetA.position, smoothSpeed * Time.deltaTime);


    }
    public void SwitchLeo()
    {
        buttonB.SetActive(true);
        buttonA.SetActive(false);
        switchToRei.SetActive(true);
        nametagRei.SetActive(false);
        nametagLeo.SetActive(false);
        leo.SetActive(true);
        rei.SetActive(false);

        Vector3 smoothedPosition = Vector3.Lerp(TargetA.position, TargetB.position, smoothSpeed);
        transform.position = smoothedPosition;


    }

    public void SwitchRei()
    {
        buttonA.SetActive(true);
        buttonB.SetActive(false);
        switchToLeo.SetActive(true);
        nametagRei.SetActive(false);
        nametagLeo.SetActive(false);
        rei.SetActive(true);
        leo.SetActive(false);

        Vector3 smoothedPosition = Vector3.Lerp(TargetB.position, TargetA.position, smoothSpeed * Time.deltaTime);


    }
}
