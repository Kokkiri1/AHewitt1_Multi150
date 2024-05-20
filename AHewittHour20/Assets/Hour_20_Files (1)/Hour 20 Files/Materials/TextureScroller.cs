using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public float animationSpeed = 1.0f;

    private Material material;

    private void Start()
    { material = GetComponent<Material>();
    }

    private void Update()
    {
        float offset = (Mathf.PingPong(Time.deltaTime, 1.0f) - 0.5f) * animationSpeed;
        
        material.mainTextureOffset = new Vector2(0, Mathf.Clamp(offset, 0.0f, 1.0f));
    }
}
