using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSelectionUI : MonoBehaviour
{
    [SerializeField] private GameObject rightArrowBtn;
    [SerializeField] private GameObject leftArrowBtn;
    [SerializeField] private GameObject selectBtn;
    private int index = 0;
    private const int redCarIndex = 0;
    private const int blueCarIndex = 1;
    private const int greenVanIndex = 2;
    private const int blueBusIndex = 3;
    private const int armourCarIndex = 4;

    public void ViewNextVehicle()
    {
        if (SelectionCamController.Instance.IsMoving()) return;

        if (index == blueBusIndex)
        {
            rightArrowBtn.SetActive(false);
        } 
        else if (index == redCarIndex)
        {
            leftArrowBtn.SetActive(true);
        } 
        else if (index == armourCarIndex)
        {
            return;
        }
        SelectionCamController.Instance.MoveRight();
        index++;
    }

    public void ViewPreviousVehicle()
    {
        if (SelectionCamController.Instance.IsMoving()) return;

        if (index == blueCarIndex)
        {
            leftArrowBtn.SetActive(false);
        } 
        else if (index == armourCarIndex)
        {
            rightArrowBtn.SetActive(true);
        }
        else if (index == redCarIndex)
        {
            return;
        }
        SelectionCamController.Instance.MoveLeft();
        index--;
    }

    public void SelectVehicle()
    {
        SaveSelection(index);
        SceneManager.LoadScene("GamePlay");
    }

    private void SaveSelection(int _index)
    {
        PlayerPrefs.SetInt("index", _index);
    }

}
