using UnityEngine;

public class Arkaplan : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float hareketHizi = 1;

    public void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(hareketHizi * Time.deltaTime, 0f);
    }
}
