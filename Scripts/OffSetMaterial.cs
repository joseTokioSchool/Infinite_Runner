using UnityEngine;

public class OffSetMaterial : MonoBehaviour
{
    [SerializeField] MeshRenderer myRenderer;
    [SerializeField] private float scrollSpeed;
    void Update()
    {
        float offset = Time.time * scrollSpeed;
        myRenderer.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}
