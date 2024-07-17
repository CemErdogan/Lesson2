using UnityEngine;

[System.Serializable]
public struct TileData
{
    public int id;
    public Vector3 position;
    public string character;
    public int[] children;
}
