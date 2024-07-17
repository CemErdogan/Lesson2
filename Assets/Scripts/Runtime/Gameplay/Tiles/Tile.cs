using UnityEngine;

public class Tile : MonoBehaviour, ITouchable
{
    TileData _tileData;
    
    public void Prepare(TileData tileData)
    {
        _tileData = tileData;
        gameObject.name = $"Tile_{_tileData.id}_{_tileData.character}";
    }
}
