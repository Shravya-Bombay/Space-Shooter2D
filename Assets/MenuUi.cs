using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuUi : MonoBehaviour
{
    [SerializeField] private string gameplaySceneName = "Gameplay";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
     public void StartGame()
    {
        SceneManager.LoadScene(gameplaySceneName);
    }
}
