using UnityEngine;

public class score : MonoBehaviour
{

    private int Puan;

    public void PuanArtma(int deger)
    {
        Puan += deger;
        Debug.Log(Puan);

    }
    
    public void PuanAzaltma(int deger)
    {
        Puan -= deger;
        Debug.Log(Puan);
    }
}
