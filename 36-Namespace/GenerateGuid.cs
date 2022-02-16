using System;

namespace MOliveira.Util.Funcoes
{
    public static class GenerateGuid
    {
        public static string NewGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
