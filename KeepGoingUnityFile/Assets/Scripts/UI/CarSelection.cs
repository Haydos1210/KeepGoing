using Unity.VisualScripting;
using UnityEngine;

public class CarSelection : MonoBehaviour
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
        if (index == blueCarIndex)
        {
            leftArrowBtn.SetActive(false);
            return;
        } 
        else if (index == armourCarIndex)
        {
            rightArrowBtn.SetActive(true);
        }
        else if (index == redCarIndex)
        {
            return;
        }
        SelectionCamController.Instance.MoveRight();
        index--;
    }

    public void SelectVehicle()
    {
        switch (index)
        {
            case redCarIndex:
                VehicleStatsController.Instance.SetCarStats(new BasicCarStats());
                break;
            //case blueCarIndex:
            //    VehicleStatsController2.Instance.SetCarStats(new 
        }
    }
}
