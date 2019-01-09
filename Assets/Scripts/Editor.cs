using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Editor : MonoBehaviour
{
    [SerializeField] InputField editText;
    [SerializeField] TextMeshProUGUI previewText;

    public void OnValueChange()
    {
        previewText.text = editText.text;
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
