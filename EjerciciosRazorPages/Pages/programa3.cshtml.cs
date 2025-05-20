using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EjerciciosRazorPages.Pages
{
    public class programa3Model : PageModel
    {
        [BindProperty]
        public string A { get; set; } = "";
        [BindProperty]
        public string B { get; set; } = "";
        [BindProperty]
        public string X { get; set; } = "";
        [BindProperty]
        public string Y { get; set; } = "";
        [BindProperty]
        public string N { get; set; } = "";

        public double Resultado1 { get; set; } = 0.0f;
        public double Resultado2 { get; set; } = 0.0f;
        public double Resultado3 { get; set; } = 0.0f;

        public void OnPost() {
            int a = int.Parse(A);
            int b = int.Parse(B);
            int x = int.Parse(X);
            int y = int.Parse(Y);
            int n = int.Parse(N);

            Resultado1 = Math.Pow((a * x) + (b * y), n);

            Resultado2 = Factorial(n);

            Resultado3 = 0;
            for (int k = 0; k <= n; k++)
            {
                Resultado3 += Factorial(n) / (Factorial(k) * Factorial(n - k));
            }

        }


        public float Factorial(int n)
        {
            float result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

    }
}
