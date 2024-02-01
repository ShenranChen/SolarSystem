using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class AmmoControl : MonoBehaviour
{
    public int maxAmmo = 10;  // Set the maximum ammo count
    public TextMeshProUGUI ammoText;     // Reference to the UI text displaying ammo count

    [SerializeField]
    public GameObject bullet;

    private int currentAmmo;   // Current ammo count

    // Start is called before the first frame update
    void Start()
    {
        currentAmmo = maxAmmo;
        Update();

    }

    // Update is called once per frame
    void Update()
    {
        if (ammoText != null)
        {
            ammoText.text = "Ammo: " + currentAmmo.ToString();
        }
    }

    public void Shoot()
    {
        if (currentAmmo > 0)
        {
            Debug.Log("here!");
            GameObject bulletInstance = Instantiate(bullet, transform.position + .5f * transform.forward, Quaternion.identity);

            //transform.position + .5f * transform.forward, Quaternion.identity

            // Example: Apply force to the bullet (customize according to your needs)
            bulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * 10f, ForceMode.Impulse);

            Debug.Log("Fire!");
            currentAmmo--;
            Update();
        }
        else
        {
            Debug.Log("Out of ammo!");
        }
    }

    public void Reload()
    {
        currentAmmo = maxAmmo;
        Update();
    }
}
