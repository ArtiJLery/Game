using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Reflect : MonoBehaviour
{
    public Slider slider;
    public GameObject light;
    public GameObject reflection;

    public void Angle()
    {
        light.transform.Rotate(0, 0, slider.value / 30);
        reflection.transform.Rotate(0, 0, -slider.value / 30);
        float transX = 10 * slider.value / 15;
        float transY = 80 * slider.value / 30;
        light.transform.position = new Vector3(transX + 800, 500, 0);
        reflection.transform.position = new Vector3(transX + 800, transY + 500, 0);
    }
}
