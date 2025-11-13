using UnityEngine;
using System;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private int mouseButton = 0;

    public event Action<Vector3> MouseClick;

    private void Update()
    {
        if (Input.GetMouseButtonDown(mouseButton))
        {
            MouseClick?.Invoke(Input.mousePosition);
        }
    }
}
