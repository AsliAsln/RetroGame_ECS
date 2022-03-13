using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using Entitas;
public class GameController : MonoBehaviour
{
    private Systems _systems;


    void Start()
    {
        _systems = new Feature("Systems")
            .Add(new InitializeGameSystem(Contexts.sharedInstance))
            .Add(new EnemyMocementSystem(Contexts.sharedInstance))
            ;


        _systems.Initialize();

    }


 
   private void Update()
    {
        _systems.Execute();
        _systems.Cleanup();

    }
    private void OnDestroy()
    {
        _systems.TearDown();
    }
}
