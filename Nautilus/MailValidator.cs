using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace Nautilus
{
    public static class MailValidator
    {
        static Regex EmailValido = CrearRegexMailValido();

        private static Regex CrearRegexMailValido()
        {
            string PatronMailCorrecto = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(PatronMailCorrecto, RegexOptions.IgnoreCase);
        }

        internal static bool EmailEsValido(string DireccionCorreo)
        {
            bool esValido = EmailValido.IsMatch(DireccionCorreo);
            return esValido;
        }

    }
}
