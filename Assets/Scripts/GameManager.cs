using UnityEditorInternal;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private PlayerInput playerInput;

    public int levelNumber;
    public float timer;


    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;
    }

    public void LockPlayerInput()
    {
        playerInput.enabled = false;
    }
    public void UnlockPlayerInput()
    {
        playerInput.enabled = true;
    }
}
