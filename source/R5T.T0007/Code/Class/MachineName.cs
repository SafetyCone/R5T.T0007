using System;

using R5T.Stagira;


namespace R5T.T0007
{
    public class MachineName : TypedString
    {
        #region Static

        public static MachineName From(string value)
        {
            var machineName = new MachineName(value);
            return machineName;
        }

        #endregion


        public MachineName(string value)
            : base(value)
        {
        }
    }
}
