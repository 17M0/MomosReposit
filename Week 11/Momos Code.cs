Momo's code for Trap

public class FunnyTrap : MonoBehaviour
{
    public GameObject objectToAppear;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectToAppear.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            objectToAppear.SetActive(true);
        }
    }
}
