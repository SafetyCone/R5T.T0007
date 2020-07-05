using System;


namespace R5T.T0007
{
    public static class StringExtensions
    {
        public static MachineName AsMachineName(this string value)
        {
            var machineName = new MachineName(value);
            return machineName;
        }
    }
}
