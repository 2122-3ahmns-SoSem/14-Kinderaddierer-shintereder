using UnityEngine;


[CreateAssetMenu(menuName = "SoRuntimeData")]
public class SORuntimeData : ScriptableObject
{
    public string nameKid;

    private void OnEnable()
    {
        nameKid = " ";
    }
}
