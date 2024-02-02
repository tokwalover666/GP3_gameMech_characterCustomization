using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public AssetsSO Assets;
    [Header("A")]
    public SkinnedMeshRenderer Hairs_A;
    public SkinnedMeshRenderer Faces_A;
    public SkinnedMeshRenderer Tops_A;
    public SkinnedMeshRenderer Pants_A;
    public SkinnedMeshRenderer Shoes_A;

    private int currentHairIndex_A = 0;
    private int currentFaceIndex_A = 0;
    private int currentTopIndex_A = 0;
    private int currentPantsIndex_A = 0;
    private int currentShoeMaterialIndex_A = 0;

    [Header("B")]
    public SkinnedMeshRenderer Hairs;
    public SkinnedMeshRenderer Faces;
    public MeshRenderer Tops;
    public SkinnedMeshRenderer Pants;
    public SkinnedMeshRenderer Shoes;


    private int currentHairIndex = 0;
    private int currentFaceIndex = 0;
    private int currentTopMaterialIndex = 0;
    private int currentPantMaterialIndex = 0;
    private int currentShoeMaterialIndex = 0;

    public void ChangeHairA()
    {
        currentHairIndex_A = (currentHairIndex_A + 1) % Assets.Hairs_A.Length;
        Debug.Log("Current Hair A Index" + currentHairIndex_A);
        Hairs_A.sharedMesh = Assets.Hairs_A[currentHairIndex_A];
    }

    public void ChangeFaceA()
    {
        currentFaceIndex_A = (currentFaceIndex_A + 1) % Assets.Faces_A.Length;
        Debug.Log("Current Face _A Index" + currentFaceIndex_A);
        Faces_A.sharedMesh = Assets.Faces_A[currentFaceIndex_A];
    }

    public void ChangeTopA()
    {
        currentTopIndex_A = (currentTopIndex_A + 1) % Assets.Tops_A.Length;
        Debug.Log("CurrentTops _A Index" + currentTopIndex_A);
        Tops_A.sharedMesh = Assets.Tops_A[currentTopIndex_A];
    }
    public void ChangePantsA()
    {
        currentPantsIndex_A = (currentPantsIndex_A + 1) % Assets.Pants_A.Length;
        Debug.Log("Current Pants _A Index" + currentPantsIndex_A);
        Pants_A.sharedMesh = Assets.Pants_A[currentPantsIndex_A];
    }
    public void ChangeShoesA()
    {
        currentShoeMaterialIndex_A = (currentShoeMaterialIndex_A + 1) % Assets.ShoeMaterials_A.Length;
        Debug.Log("Current Shoe Material Index: " + currentShoeMaterialIndex_A);
        Shoes_A.material = Assets.ShoeMaterials_A[currentShoeMaterialIndex_A];
    }

    //-----------------------------------------------------------------------------------------------//
    public void ChangeHair()
    {
        currentHairIndex = (currentHairIndex + 1) % Assets.Hairs.Length;
        Debug.Log("Current Hair Index" +  currentHairIndex);
        Hairs.sharedMesh = Assets.Hairs[currentHairIndex];
    }


    public void ChangeFace()
    {
        currentFaceIndex = (currentFaceIndex + 1) % Assets.Faces.Length;
        Debug.Log("Current Face Index" + currentFaceIndex);
        Faces.sharedMesh = Assets.Faces[currentFaceIndex];
    }
    public void ChangeTop()
    {
        currentTopMaterialIndex = (currentTopMaterialIndex + 1) % Assets.TopMaterials.Length;
        Debug.Log("Current Top Material Index: " + currentTopMaterialIndex);
        Tops.material = Assets.TopMaterials[currentTopMaterialIndex];
    }

    public void ChangePants()
    {
        currentPantMaterialIndex = (currentPantMaterialIndex + 1) % Assets.PantMaterials.Length;
        Debug.Log("Current Pant Material Index: " + currentPantMaterialIndex);
        Pants.material = Assets.PantMaterials[currentPantMaterialIndex];
    }

    public void ChangeShoes()
    {
        currentShoeMaterialIndex = (currentShoeMaterialIndex + 1) % Assets.ShoeMaterials.Length;
        Debug.Log("Current Shoe Material Index: " + currentShoeMaterialIndex);
        Shoes.material = Assets.ShoeMaterials[currentShoeMaterialIndex];
    }
}
