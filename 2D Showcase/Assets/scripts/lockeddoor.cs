using UnityEngine;

public class lockeddoor : MonoBehaviour
{
    public GameObject enemycounter;
    public float _totalenemies = 0;
    public float _requiredenemies = 0;
    private void Update()
    {
        _totalenemies = enemycounter.GetComponent<enemycounter>()._EnemyNum;

        if (_totalenemies <= _requiredenemies)
        {
            Destroy(gameObject);
        }

    }
}
