using UnityEngine;

namespace SquareWindowsPlugin;

public class Plugin : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] private Transform spawnPos;
    private int increment;
    private bool isPurple;
    private GameObject newCube;
    private void Start()
    {
        //prints a message to 
        print("Spawning Cube");
        
        //spawns a new cube into the scene
        newCube = Instantiate(cube, spawnPos.position, Quaternion.identity);
        newCube.GetComponent<Material>().color = new Color(0.5f, 0.2f, 1f, 1f);
        newCube.GetComponent<Material>().color = new Color(1f, 0.2f, 1f, 1f);
    }
}