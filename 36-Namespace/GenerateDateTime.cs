using System;

namespace MOliveira.Util.Funcoes
{
    public static class GenerateDate
    {
        public static DateTime GenerateDateTime()
        {
            return DateTime.Now.ToLocalTime();
        }
    }
}
