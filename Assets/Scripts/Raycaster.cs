using UnityEngine;

public class Raycaster : MonoBehaviour
{
    public Cube GetCubeUnderCursor(Vector3 mousePosition)
    {
        Ray ray = Camera.main.ScreenPointToRay(mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Cube cube = hit.collider.GetComponent<Cube>();
            return cube;
        }
        return null;
    }
}
