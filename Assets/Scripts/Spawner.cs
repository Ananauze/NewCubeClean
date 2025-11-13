using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float divisionFactor = 2f; 

    public Cube SpawnCube(Cube originalCube)
    {
        GameObject newCubeObj = Instantiate(originalCube.gameObject);
        Cube newCube = newCubeObj.GetComponent<Cube>();

        float newDivisionChance = originalCube.DivisionChance / divisionFactor;
        newCube.Initialize(newDivisionChance, originalCube.ScaleFactor);

        newCube.transform.localScale = originalCube.transform.localScale * originalCube.ScaleFactor;
        newCube.transform.position = originalCube.transform.position;

        Renderer renderer = newCube.GetComponent<Renderer>();
        renderer.material.color = new Color(Random.value, Random.value, Random.value);

        return newCube;
    }
}
