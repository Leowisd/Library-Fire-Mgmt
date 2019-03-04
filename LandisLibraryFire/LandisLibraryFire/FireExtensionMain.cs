using Landis.Core;
using Landis.SpatialModeling;

namespace Landis.Library.FireManagement
{
    public abstract class FireExtensionMain: ExtensionMain
    {
        /// <summary>
        /// The extension type for fire extensions.
        /// </summary>
        public static readonly ExtensionType ExtType = new ExtensionType("disturbance:fire");

        public FireExtensionMain(string name)
            : base(name, ExtType)
        {
        }
    }
}
