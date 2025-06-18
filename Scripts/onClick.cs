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
            case "Задачи":
                SceneManager.LoadScene("Exercises");
                break;
            case "Справочник":
                SceneManager.LoadScene("Information");
                break;
            case "Настройки":
                SceneManager.LoadScene("Options");
                break;
            case "Выход":
                Application.Quit();
                break;
            case "Назад":
                SceneManager.LoadScene("MainMenu");
                break;
            case "Механика":
                SceneManager.LoadScene("MechanicExercises");
                break;
            case "Терма":
                SceneManager.LoadScene("ThermoExercises");
                break;
            case "Электродинамика":
                SceneManager.LoadScene("ElectoExercises");
                break;
            case "Оптика":
                SceneManager.LoadScene("OpticsExercises");
                break;
            case "Относительность":
                SceneManager.LoadScene("OtnosExercises");
                break;
            case "Кванты":
                SceneManager.LoadScene("QuantExercises");
                break;
            case "Кинематика":
                SceneManager.LoadScene("MechTheory");
                break;
            case "Динамика":
                SceneManager.LoadScene("DinamoTheory");
                break;
            case "Энергия":
                SceneManager.LoadScene("EnergyTheory");
                break;
            case "Термодинамика":
                SceneManager.LoadScene("ThermoTheory");
                break;
            case "МКТ":
                SceneManager.LoadScene("MKTTheory");
                break;
            case "Геома":
                SceneManager.LoadScene("GeomOptTheory");
                break;
            case "Волновка":
                SceneManager.LoadScene("VolnOptTheory");
                break;
        }
    }
}
