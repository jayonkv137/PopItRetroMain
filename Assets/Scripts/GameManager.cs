using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    int Players; //0 is AI, 1 is player1, 2 is player2
    [SerializeField]
    GameObject Character0; // AI
    [SerializeField]
    GameObject Character1; // Player1
    [SerializeField]
    GameObject Character2; // Player2
    [SerializeField]
    GameObject Character3; // AI




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player player0 = new Player();
        Player player1 = new Player();
        Player player2 = new Player();
        Player player3 = new Player();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
