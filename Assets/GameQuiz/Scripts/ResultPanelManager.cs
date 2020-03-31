using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultPanelManager : MonoBehaviour
{
    public GameObject ResultPanel;


    //public void HidePanel()
    //{
    //    if (ResultPanel == null)
    //    {
    //        bool isActive = ResultPanel.activeSelf;

    //        ResultPanel.gameObject.SetActive(isActive);
    //    }
    //}

    public void ShowPanel()
    {
        if (ResultPanel != null)
        {
            bool isActive = ResultPanel.activeSelf;

            ResultPanel.gameObject.SetActive(!isActive);
        }
    }


}
