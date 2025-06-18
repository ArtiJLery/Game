using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsButton : MonoBehaviour
{
    public void OpenOptions()
    {
        SceneManager.LoadScene("Options");
    }
}
