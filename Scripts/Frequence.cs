using UnityEngine;
using UnityEngine.UI;

public class Frequence : MonoBehaviour
{
    public SpringJoint2D spring;
    public Slider slider;
    public void onSliderFreq()
    {
        var freq = slider.value;
        spring.frequency = freq;
    }
}
