using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehavior : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ChangeRendererColor(ColorID obj)
    {
        spriteRenderer.color = obj.value;
    }
    public void ChangeRendererColor(ColorIDDataList obj)
    {
        obj.SetCurrentColorRandomoly();
        spriteRenderer.color = obj.currentColor.value;
    }
}
