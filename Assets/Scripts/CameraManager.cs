using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class CameraManager : MonoBehaviour
{
    public Transform cam;
    public Transform TargetB;
    public Transform RotateB;
    public Transform TargetA;
    public Transform RotateA;

    public float rotateSpeed = 1f;
    public float speed = 1f;

    public GameObject buttonB;
    public GameObject buttonA;
    public GameObject switchToRei;
    public GameObject switchToLeo;
    public GameObject nametagRei;
    public GameObject nametagLeo;
    public GameObject leo;
    public GameObject rei;

    public bool chooseleo = false;
    public bool chooserei = false;
    public bool switchleo = false;
    public bool switchrei = false;
    public bool boolReset = false;

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
        if (chooseleo == true)
        {
            
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, TargetB.position, speed * Time.deltaTime);

            Vector3 direction = RotateB.position - cam.transform.position;
            Quaternion rotatToB = Quaternion.LookRotation(direction);
            cam.transform.rotation = rotatToB;


        }
        if (chooserei == true)
        {
            
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, TargetA.position, speed * Time.deltaTime);

            Vector3 direction = RotateA.position - cam.transform.position;
            Quaternion rotateToA = Quaternion.LookRotation(direction);
            cam.transform.rotation = rotateToA;


        }
        if (switchleo == true)
        {
            
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, TargetB.position, speed * Time.deltaTime);

            Vector3 direction = RotateB.position - cam.transform.position;
            Quaternion rotateToB = Quaternion.LookRotation(direction);
            cam.transform.rotation = rotateToB;

        }
        if (switchrei == true)
        {
            
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, TargetA.position, speed * Time.deltaTime);

            Vector3 direction = RotateA.position - cam.transform.position;
            Quaternion rotateToA = Quaternion.LookRotation(direction);
            cam.transform.rotation = rotateToA;

        }


    }
    public void ChooseLeo()
    {
        buttonB.SetActive(true);
        buttonA.SetActive(false);
        switchToRei.SetActive(true);
        nametagRei.SetActive(false);
        nametagLeo.SetActive(false) ;
        leo.SetActive(true);

        chooseleo = true;
    }

    public void ChooseRei()
    {
        buttonA.SetActive(true);
        buttonB.SetActive(false);
        switchToLeo.SetActive(true);
        nametagRei.SetActive(false);
        nametagLeo.SetActive(false);
        rei.SetActive(true);

        chooserei = true;

    }
    public void SwitchLeo()
    {
        buttonB.SetActive(true);
        buttonA.SetActive(false);
        switchToRei.SetActive(true);
        switchToLeo.SetActive(false);
        nametagRei.SetActive(false);
        nametagLeo.SetActive(false);
        leo.SetActive(true);
        rei.SetActive(false);

        switchleo = true;
    }

    public void SwitchRei()
    {
        buttonA.SetActive(true);
        buttonB.SetActive(false);
        switchToLeo.SetActive(true);
        switchToRei.SetActive(false);
        nametagRei.SetActive(false);
        nametagLeo.SetActive(false);
        rei.SetActive(true);
        leo.SetActive(false);

        switchrei = true;
    }

}
