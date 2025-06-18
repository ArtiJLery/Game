using UnityEngine;
using UnityEngine.UI;

public class SquareMass : MonoBehaviour
{
    public Rigidbody2D body;
    public Slider slider;
    public void onSlideMass()
    {
        var mass = slider.value;
        body.mass = mass;
    }
}
