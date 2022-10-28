using System.Globalization;

namespace CCT.MetodosExtensao.App
{
    public static class PtBrExtensions
    {
        public static string ToStringPtBr(this DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }

        public static string ToStringPtBr(this double value)
        {
            return value.ToString(new CultureInfo("pt-BR"));
        }
    }
}
