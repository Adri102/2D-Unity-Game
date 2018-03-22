using UnityEngine;

public class ChangeScreen : MonoBehaviour
{
    public GameObject active;
    public GameObject desactive;

    public void Activate()
    {
        active.SetActive(true);
        desactive.SetActive(false);
    }
}
