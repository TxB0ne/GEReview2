using UnityEngine;
namespace SqaureSpawn;
public class Square : MonoBehaviour
{
    //Get Refrence to Cube
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
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            increment++;
        }

        if (increment % 2 == 0)
            newCube.GetComponent<Material>().color = new Color(0.5f, 0.2f, 1f, 1f);
        else
            newCube.GetComponent<Material>().color = new Color(1f, 0.2f, 1f, 1f);
        throw new NotImplementedException();
    }
}