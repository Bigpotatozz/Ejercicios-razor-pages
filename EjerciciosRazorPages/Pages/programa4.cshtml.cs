using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EjerciciosRazorPages.Pages
{
    public class programa4Model : PageModel
    {

        public double Suma { get; set; } = 0;
        public double Media { get; set; } = 0;
        public double Moda { get; set; } = 0;
        public double Mediana { get; set; } = 0;
        public double[] Arreglo { get; set; } = new double[20];
        public void OnGet()
        {

            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                Arreglo[i] = random.Next(100);
            }

            foreach (var item in Arreglo)
            {
                Suma += item;


            }

            Media = Arreglo.Average();
            Mediana = Suma / Arreglo.Length;
            Moda = Arreglo.GroupBy(x => x).OrderByDescending(g => g.Count()).First().Key;


        }
    }
}
