using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 
public class ImageFade : MonoBehaviour {
 
    // the image you want to fade, assign in inspector
    public Image img;
    public RawImage logo;

    private void Start()
    {
        StartCoroutine(FadeImage(true));
    }

    
    IEnumerator FadeImage(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 2.5f; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                logo.color = new Color(1, 1, 1, i);
                img.color = new Color(1, 1, 1, i);
                yield return null;
                
            }
        }

        Destroy(img);
        Destroy(logo);
    
    }
}