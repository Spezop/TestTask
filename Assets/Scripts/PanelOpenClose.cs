using UnityEngine;

public class PanelOpenClose : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    public void OpenClose()
    {
        if (panel != null)
        {
            bool isPanelOpen = panel.activeSelf;

            panel.SetActive(!isPanelOpen);
        }
    }
}