using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public Button resetButton;

    void Start()
    {
        resetButton = GetComponent<Button>();
        resetButton.onClick.AddListener(ResetScene);
    }

    void ResetScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}