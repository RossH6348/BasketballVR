using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballSummon : MonoBehaviour
{

    [SerializeField] private GameObject basketballTemplate;
    private GameObject basketballSummon = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(basketballSummon == null)
        {
            //Spawn a new basketball.
            GameObject basketball = Instantiate(basketballTemplate,gameObject.transform);
            basketball.transform.localPosition = new Vector3(0.0f, 1.0f, 0.0f);
            basketball.transform.localScale *= (2.0f / 3.0f);
            basketball.SetActive(true);
            basketballSummon = basketball;
        }

    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Basketball") && !basketballs.Contains(other.gameObject))
            basketballs.Add(other.gameObject);
    }*/

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == basketballSummon)
            basketballSummon = null;
    }
}
