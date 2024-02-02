using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="CharacterB assets")]
public class AssetsSO : ScriptableObject
{
    [Header("Character A")]
    public Mesh[] Hairs_A;
    public Mesh[] Faces_A;
    public Mesh[] Tops_A;
    public Mesh[] Pants_A;
    public Mesh[] Shoes_A;


    public Material[] ShoeMaterials_A;

    [Header("Character B")]
    public Mesh[] Hairs;
    public Mesh[] Faces;
    public Mesh[] Tops;
    public Mesh[] Pants;
    public Mesh[] Shoes;


    public Material[] TopMaterials;
    public Material[] PantMaterials;
    public Material[] ShoeMaterials;

}
