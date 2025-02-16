using UnityEngine;

public class Magnet : MonoBehaviour 
{
    [SerializeField] GameObject _magnet;
    [SerializeField] GameObject _repel;

    public void Switch()
    {
        if(_magnet.activeSelf == true)
        {
            _magnet.SetActive(false);
            _repel.SetActive(true);
        }
        else
        {
            _magnet.SetActive(true);
            _repel.SetActive(false);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Switch();
        }
    }

    

}
