using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public class botones : MonoBehaviour
    {
        public AudioClip clickSound;
        private AudioSource audioSource;

        private void Start()
        {
            // Obtener o añadir un AudioSource al objeto que tenga este script
            audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }
        }

        private void ReproducirSonido()
        {
            if (clickSound != null)
            {
                audioSource.PlayOneShot(clickSound);
            }
        }
        public void Quit()
        {
            ReproducirSonido();
            Application.Quit();
        }
        public void ClickToMenu()
        {
            ReproducirSonido();
            SceneManager.LoadScene(0);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        public void CargarEsena(string scene)
        {
            ReproducirSonido();
            SceneManager.LoadScene(scene);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

    }
}
