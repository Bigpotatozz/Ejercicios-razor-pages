using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EjerciciosRazorPages.Pages
{
    public class IMCModel : PageModel
    {

        [BindProperty]
        public string peso { get; set; } = "";
        [BindProperty]
        public string altura { get; set; } = "";

        public float imc = 0;
        public void OnPost(){

            var weight = float.Parse(peso);
            var height = float.Parse(altura);

            float peso1 = weight * 100;
            float altura1 = height * 100;

            imc = peso1 / (altura1 * altura1) * 100;


            ModelState.Clear();


        }
    }
}
