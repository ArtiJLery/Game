using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Input_Field : MonoBehaviour
{
    public bool RightAnswer = false;
    [SerializeField] InputField field;

    public void onEnd()
    {
        string inputText = field.text;
        if (inputText == "0.5")
        {
            RightAnswer = true;
        }
        if (RightAnswer) SceneManager.LoadScene("MainMenu");
    }
}
