
using UnityEngine;

public class MainSceneUIManager : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            GameManager.Instance.SetState(GameManager.States.Menu);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            GameManager.Instance.SetState(GameManager.States.Game);
        }
    }

}
