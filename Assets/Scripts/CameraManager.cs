using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform cam;
    public Transform targetB;
    public Transform rotateB;
    public Transform targetA;
    public Transform rotateA;

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
    public GameObject backButton;

    private bool chooseLeo = false;
    private bool chooseRei = false;
    private bool switchLeo = false;
    private bool switchRei = false;

    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private void Start()
    {
        backButton.SetActive(false);
        originalPosition = cam.position;
        originalRotation = cam.rotation;

        InitializeUI();
    }

    public void OnBackButtonClick()
    {
        ResetCamera();
        backButton.SetActive(false);
    }
    public void ResetCamera()
    {
        cam.position = originalPosition;
        cam.rotation = originalRotation;

        InitializeUI();
    }

    private void InitializeUI()
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

    private void Update()
    {
        if (chooseLeo)
            MoveCamera(targetB, rotateB, ref chooseLeo);

        if (chooseRei)
            MoveCamera(targetA, rotateA, ref chooseRei);

        if (switchLeo)
            MoveCamera(targetB, rotateB, ref switchLeo);

        if (switchRei)
            MoveCamera(targetA, rotateA, ref switchRei);
    }

    private void MoveCamera(Transform target, Transform rotateTarget, ref bool flag)
    {
        cam.position = Vector3.MoveTowards(cam.position, target.position, speed * Time.deltaTime);

        if (cam.position == target.position)
        {
            flag = false;
        }

        Vector3 direction = rotateTarget.position - cam.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        cam.rotation = rotation;
    }

    public void ChooseLeo()
    {
        SetUIForLeo();
        chooseLeo = true;
    }

    public void ChooseRei()
    {
        SetUIForRei();
        chooseRei = true;
    }

    public void SwitchLeo()
    {
        SetUIForLeo();
        switchLeo = true;
    }

    public void SwitchRei()
    {
        SetUIForRei();
        switchRei = true;
    }

    private void SetUIForLeo()
    {
        buttonB.SetActive(true);
        buttonA.SetActive(false);
        switchToRei.SetActive(true);
        switchToLeo.SetActive(false);
        nametagRei.SetActive(false);
        nametagLeo.SetActive(false);
        leo.SetActive(true);
        rei.SetActive(false);
        backButton.SetActive(true);
    }

    private void SetUIForRei()
    {
        buttonA.SetActive(true);
        buttonB.SetActive(false);
        switchToLeo.SetActive(true);
        switchToRei.SetActive(false);
        nametagRei.SetActive(false);
        nametagLeo.SetActive(false);
        rei.SetActive(true);
        leo.SetActive(false);
        backButton.SetActive(true);
    }
}
