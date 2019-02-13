using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    private int xPos;
    private int yPos;
    private int charId;//character

    public Tile(int xPosition, int yPosition) { xPos = xPosition; yPos = yPosition; }

    public Tile(int xPosition, int yPosition, int characterId) { xPos = xPosition; yPos = yPosition; charId = characterId; }

    public int[] getInfo()
    {
        int[] arr = { xPos, yPos, charId };
        return arr;
    }
}
