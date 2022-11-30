using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActionUICanvas : MonoBehaviour
{

    public TMP_Text ActionText;
    Canvas _canvas;


    // Start is called before the first frame update
    void Start()
    {
        _canvas = GetComponent<Canvas>();
        HideCanvas();
    }

    public void ShowCanvas()
    {
        _canvas.enabled = true;
    }

    public void HideCanvas()
    {
        _canvas.enabled = false;
    }

    public void ShowActionText(string message)
    {
        ShowCanvas();
        ActionText.text = message;
    }


}
