using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    private static State _currentState = new State();
    public static void SetState(bool canChange, State state)
    {
        if(state == null)
        {
            Debug.Log("State null");
            return;
        }
            
        if(canChange && state.Name != _currentState.Name)
        {
            _currentState = state;
            Debug.Log($"new state: {_currentState.Name}");
        }
    }

    public static State GetCurrentState()
    {
        return _currentState;
    }
}
