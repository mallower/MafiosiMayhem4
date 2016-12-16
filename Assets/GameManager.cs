using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public characterswitch Character1;
    public characterswitch Character2;

    private static GameManager manager = null;
    public static GameManager Manager
    {
        get { return manager; }
    }

    void Awake()
    {
        GetThisGameManager();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.N))
        {

            Character1.Activate();
            Character2.Deactivate();
        }

        if (Input.GetKey(KeyCode.B))
        {

            Character2.Activate();
            Character1.Deactivate();
        }

    }

    void GetThisGameManager()
    {
        if (manager != null && manager != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            manager = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}