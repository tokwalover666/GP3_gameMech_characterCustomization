using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiButton : MonoBehaviour
{
    [Header("Character A")]
    private Button Rei;
    [SerializeField] private Button changeHairA;
    [SerializeField] private Button changeFaceA;
    [SerializeField] private Button changeTopA;
    [SerializeField] private Button changePantsA;
    [SerializeField] private Button changeShoesA;


    [Header("Character B")]
    [SerializeField] private Button Leo;
    [SerializeField] private Button changeHair;
    [SerializeField] private Button changeFace;
    [SerializeField] private Button changeTop;
    [SerializeField] private Button changePants;
    [SerializeField] private Button changeShoes;

    [SerializeField] private GameManager gameManager;


    private void Start()
    {

    }

    private void Awake()
    {

        changeHair.onClick.AddListener(() =>
        {
            Debug.Log("change hair");
            gameManager.ChangeHair();
        });
        changeFace.onClick.AddListener(() =>
        {
            Debug.Log("change face");
            gameManager.ChangeFace();
        });
        changeTop.onClick.AddListener(() =>
        {
            Debug.Log("change top");
            gameManager.ChangeTop();
        });
        changePants.onClick.AddListener(() =>
        {
            Debug.Log("change pants");
            gameManager.ChangePants();
        });
        changeShoes.onClick.AddListener(() =>
        {
            Debug.Log("change shoes");
            gameManager.ChangeShoes();
        });

        /////---------------------////
        changeHairA.onClick.AddListener(() =>
        {
            Debug.Log("change hair a");
            gameManager.ChangeHairA();
        });
        changeFaceA.onClick.AddListener(() =>
        {
            Debug.Log("change face a");
            gameManager.ChangeFaceA();
        });
        changeTopA.onClick.AddListener(() =>
        {
            Debug.Log("change top a");
            gameManager.ChangeTopA();
        });
        changePantsA.onClick.AddListener(() =>
        {
            Debug.Log("change pants a");
            gameManager.ChangePantsA();
        });
        changeShoesA.onClick.AddListener(() =>
        {
            Debug.Log("change sho a");
            gameManager.ChangeShoesA();
        });
    }
}
