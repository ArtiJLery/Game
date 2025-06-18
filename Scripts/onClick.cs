using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public Text ButtonName;
    public void onClick()
    {
        switch (ButtonName.text.ToString())
        {
            case "������":
                SceneManager.LoadScene("Exercises");
                break;
            case "����������":
                SceneManager.LoadScene("Information");
                break;
            case "���������":
                SceneManager.LoadScene("Options");
                break;
            case "�����":
                Application.Quit();
                break;
            case "�����":
                SceneManager.LoadScene("MainMenu");
                break;
            case "��������":
                SceneManager.LoadScene("MechanicExercises");
                break;
            case "�����":
                SceneManager.LoadScene("ThermoExercises");
                break;
            case "���������������":
                SceneManager.LoadScene("ElectoExercises");
                break;
            case "������":
                SceneManager.LoadScene("OpticsExercises");
                break;
            case "���������������":
                SceneManager.LoadScene("OtnosExercises");
                break;
            case "������":
                SceneManager.LoadScene("QuantExercises");
                break;
            case "����������":
                SceneManager.LoadScene("MechTheory");
                break;
            case "��������":
                SceneManager.LoadScene("DinamoTheory");
                break;
            case "�������":
                SceneManager.LoadScene("EnergyTheory");
                break;
            case "�������������":
                SceneManager.LoadScene("ThermoTheory");
                break;
            case "���":
                SceneManager.LoadScene("MKTTheory");
                break;
            case "�����":
                SceneManager.LoadScene("GeomOptTheory");
                break;
            case "��������":
                SceneManager.LoadScene("VolnOptTheory");
                break;
        }
    }
}
