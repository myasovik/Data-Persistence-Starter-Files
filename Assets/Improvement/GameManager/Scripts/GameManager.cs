using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public enum States { Game, Menu, Score}
    public delegate void StateChange(States state);
    public event StateChange OnStateChange;
    private States CurrentState { get; set; }

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

    public void SetState(States state)
    {
        if(CurrentState != state)
        {
            CurrentState = state;
            OnStateChange?.Invoke(CurrentState);
        }
        
    }

}
