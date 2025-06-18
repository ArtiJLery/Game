using UnityEngine;
using UnityEngine.UI;

public class ElectroF : MonoBehaviour
{
    public GameObject Electron;
    public Slider slider;
    int moveDistance = 10;

    public void Update()
    {
        Electron.transform.position = new Vector3(slider.value * moveDistance + 500, Electron.transform.position.y);
    }
}
