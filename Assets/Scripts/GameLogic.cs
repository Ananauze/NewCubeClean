using UnityEngine;
using System.Collections.Generic;

public class GameLogic : MonoBehaviour
{
    [SerializeField] private InputHandler _inputHandler;
    [SerializeField] private Raycaster _raycaster;
    [SerializeField] private Spawner _spawner;
    [SerializeField] private Exploder _exploder;

    private void OnEnable()
    {
        _inputHandler.MouseClick += HandleClick;
    }

    private void OnDisable()
    {
        _inputHandler.MouseClick -= HandleClick;
    }

    private void HandleClick(Vector3 mousePosition)
    {
        Cube clickedCube = _raycaster.GetCubeUnderCursor(mousePosition);
        if (clickedCube == null) return;

        // проверка деления
        if (Random.value <= clickedCube.DivisionChance)
        {
            List<Rigidbody> newRigidbodies = new List<Rigidbody>();

            int count = Random.Range(2, 7);
            for (int i = 0; i < count; i++)
            {
                Cube newCube = _spawner.SpawnCube(clickedCube);
                newRigidbodies.Add(newCube.RigidbodyComponent);
            }

            _exploder.Explode(newRigidbodies);
        }

        Destroy(clickedCube.gameObject);
    }
}
