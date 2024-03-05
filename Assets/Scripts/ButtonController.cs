using UnityEngine;


public class ButtonController : MonoBehaviour
{
    public GameObject gameObject1; // GameObject que se activará al presionar el botón
    public GameObject gameObject2; // GameObject que se desactivará al presionar el botón

    private int contador = 0; // Contador para alternar entre activar/desactivar GameObjects

    // Método que se ejecutará cuando se haga clic en el botón
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
