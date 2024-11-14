using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject MainMenuCanvas;
    [SerializeField] private GameObject ItemsMenuCanvas;
    [SerializeField] private GameObject ARPositionsCanvas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.instance.OnMainMenu += ActivateMainMenu;
        GameManager.instance.OnItemsMenu += ActivateItemsMenu;
        GameManager.instance.OnARpositionMenu += ActivateARpositionMenu;
    }

    private void ActivateMainMenu()
    {
        MainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1,1,1), 0.3f);
        MainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1,1,1), 0.3f);
        MainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1,1,1), 0.3f);

        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0,0,0), 0.5f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0,0,0), 0.3f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ARPositionsCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0,0,0), 0.3f);
        ARPositionsCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0,0,0), 0.3f);
    }

    private void ActivateItemsMenu()
    {
        MainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0,0,0), 0.3f);
        MainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0,0,0), 0.3f);
        MainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0,0,0), 0.3f);

        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1,1,1), 0.5f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1,1,1), 0.3f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);
    }

    private void ActivateARpositionMenu()
    {
        MainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0,0,0), 0.3f);
        MainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0,0,0), 0.3f);
        MainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0,0,0), 0.3f);

        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0,0,0), 0.5f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0,0,0), 0.3f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ARPositionsCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1,1,1), 0.3f);
        ARPositionsCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1,1,1), 0.3f);
    }
}
