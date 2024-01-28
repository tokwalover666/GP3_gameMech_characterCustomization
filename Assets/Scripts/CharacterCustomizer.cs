using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustomizer : MonoBehaviour
{
    [SerializeField] private SkinnedMeshRenderer skinnedMeshRenderer;
    [SerializeField] private Mesh[] meshArray;

    public void ChangeShoeColor()
    {
        int meshIndex = System.Array.IndexOf(meshArray, skinnedMeshRenderer.sharedMesh);
        skinnedMeshRenderer.sharedMesh = meshArray[(meshIndex + 1) % meshArray.Length];
    }
}
