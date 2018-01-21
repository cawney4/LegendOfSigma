using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour {

    public Image image;

	void fade()
    {
        image.canvasRenderer.SetAlpha(1.0f);
        image.CrossFadeAlpha(0.0f, 3, false);
    }
}
