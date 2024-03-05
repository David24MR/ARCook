using UnityEngine;


public class ButtonController : MonoBehaviour
{
    public GameObject gameObject1; // GameObject que se activar� al presionar el bot�n
    public GameObject gameObject2; // GameObject que se desactivar� al presionar el bot�n

    private int contador = 0; // Contador para alternar entre activar/desactivar GameObjects

    // M�todo que se ejecutar� cuando se haga clic en el bot�n
    public void OnButtonClicked()
    {
        // Alternar entre activar/desactivar GameObjects basado en el contador
        if (contador == 0)
        {
            gameObject1.SetActive(true);
            gameObject2.SetActive(false);
            contador = 1;
        }
        else
        {
            gameObject1.SetActive(false);
            gameObject2.SetActive(true);
            contador = 0;
        }
    }
}
