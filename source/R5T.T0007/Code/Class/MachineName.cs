using System;

using R5T.Stagira;

using R5T.T0150;


namespace R5T.T0007
{
    [StrongTypeMarker]
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
