using UnityEngine;

public class Item : MonoBehaviour
{
    public enum Type { Ammo, Coin, Greade, Heart, Weapon };
    public Type type;
    public int value;

    void Update()
    {
        transform.Rotate(Vector3.up * 30 * Time.deltaTime);
    }
}
