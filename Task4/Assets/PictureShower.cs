using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PictureShower : MonoBehaviour
{
    [SerializeField] GameObject image1;
    [SerializeField] GameObject image2;
    [SerializeField] GameObject image3;

    [SerializeField] Button buttonForImg1;

    private void Awake()
    {
        buttonForImg1.onClick.AddListener(ShowImg1);
    }

    private void HideAll()
    {
        image1.SetActive(false);
        image2.SetActive(false);
        image3.SetActive(false);
    }
    private void ShowImg1()
    {
        HideAll();
        image1.SetActive(true);
    }
    public void ShowImg2()
    {
        HideAll();
        image2.SetActive(true);
    }
    public void ShowImg3()
    {
        HideAll();
        image3.SetActive(true);
    }

}
