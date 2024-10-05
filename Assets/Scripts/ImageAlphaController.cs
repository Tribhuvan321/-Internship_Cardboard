using UnityEngine;
using UnityEngine.UI;

public class ImageAlphaController : MonoBehaviour
{
    public Image image;
    public float duration = 3f;

    private float elapsedTime;
    private bool isFadingIn = true;

    void Update()
    {
        if (image == null) return;

        float halfDuration = duration / 2f;

        elapsedTime += Time.deltaTime;

        if (isFadingIn)
        {
            SetImageAlpha(elapsedTime / halfDuration);

            if (elapsedTime >= halfDuration)
            {
                elapsedTime = 0f;
                isFadingIn = false;
            }
        }
        else
        {
            SetImageAlpha(1 - (elapsedTime / halfDuration));

            if (elapsedTime >= halfDuration)
            {
                elapsedTime = 0f;
                isFadingIn = true;
            }
        }
    }

    private void SetImageAlpha(float alpha)
    {
        Color color = image.color;
        color.a = Mathf.Clamp01(alpha);
        image.color = color;
    }
}
