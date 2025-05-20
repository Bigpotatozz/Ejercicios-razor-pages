using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EjerciciosRazorPages.Pages
{
    public class codificadorModel : PageModel
    {
        [BindProperty]
        public int n { get; set; } = 0;
        [BindProperty]
        public string Mensaje { get; set; } = "";
        [BindProperty]
        public string MensajeCodificado { get; set; } = "";

        private string Abecedario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public void OnPost() {

            var mensajeUpper = Mensaje.ToUpper();
            string mensajeCodificado = "";

            foreach(char letra in mensajeUpper)
            {
                int indice = Abecedario.IndexOf(letra);

                var indiceCodificado = indice + n;

                if (indiceCodificado >= Abecedario.Length)
                {
                    indiceCodificado = indiceCodificado - Abecedario.Length;
                }

                mensajeCodificado += Abecedario[indiceCodificado];

            }
            MensajeCodificado = mensajeCodificado;

            ModelState.Clear();

        }



        [BindProperty]
        public string MensajeD { get; set; } = "";
        public void OnPostDecodificar() {
            var mensajeUpper = MensajeCodificado.ToUpper();
            string mensajeDecodificado = "";

            foreach (char letra in mensajeUpper)
            {
                int indice = Abecedario.IndexOf(letra);

                var indiceDecodificado = indice - n;

                if (indiceDecodificado < 0)
                {
                    indiceDecodificado = indiceDecodificado + Abecedario.Length;
                }

                mensajeDecodificado += Abecedario[indiceDecodificado];

            }


            MensajeD = mensajeDecodificado;

            ModelState.Clear();


        }
    }
}
