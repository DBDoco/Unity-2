using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HSPanel : MonoBehaviour
{
    [SerializeField] GameObject panel;
   
    public void ShowHSPanel() 
    {
        panel.SetActive(true);
    }

    public void HideHSPanel()
    {
        panel.SetActive(false);
    }
}
