using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiButton : MonoBehaviour
{
    [SerializeField] private Button shoesColorButton;
    [SerializeField] private CharacterCustomizer characterCustomizer;

    private void Awake()
    {
        shoesColorButton.onClick.AddListener(() =>
        {
            Debug.Log("Shoes Button");
            characterCustomizer.ChangeShoeColor();
        });
    }
}
