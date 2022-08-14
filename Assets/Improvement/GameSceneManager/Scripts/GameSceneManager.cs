using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{

    public static GameSceneManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        GameManager.Instance.OnStateChange += StateChange;
    }

    void StateChange(GameManager.States state)
    {
        switch (state)
        {
            case GameManager.States.Game:
                SceneManager.LoadScene("Main");
                break;
            case GameManager.States.Menu:
                SceneManager.LoadScene("Menu");
                break;
        }
    }

}
