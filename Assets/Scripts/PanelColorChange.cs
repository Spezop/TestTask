using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PanelColorChange : MonoBehaviour
{
    [SerializeField] private GameObject panelTop, panelBottom;

    [SerializeField] private TMP_Text textTop, textBottom;

    [SerializeField] private Color newColor;

    public void ChangeColor()
    {
        panelTop.GetComponent<Image>().color = newColor;
        panelBottom.GetComponent<Image>().color = newColor;

        if (newColor == Color.black)
        {
            textTop.color = Color.white;
            textBottom.color = Color.white;
        }
        else
        {
            textTop.color = Color.black;
            textBottom.color = Color.black;
        }
    }
}