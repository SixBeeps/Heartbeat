using Jacobi.Vst.Core;
using Jacobi.Vst.Plugin.Framework;
using Jacobi.Vst.Plugin.Framework.Plugin;
using Microsoft.Extensions.DependencyInjection;

namespace Heartbeat {
    /// <summary>
    /// The Plugin root object.
    /// </summary>
    internal sealed class Plugin : VstPluginWithServices {
        /// <summary>
        /// TODO: assign a unique plugin id.
        /// </summary>
        private static readonly int UniquePluginId = new FourCharacterCode("6969").ToInt32();
        /// <summary>
        /// TODO: assign a plugin name.
        /// </summary>
        private const string PluginName = "Heartbeat";
        /// <summary>
        /// TODO: assign a product name.
        /// </summary>
        private const string ProductName = "Heartbeat";
        /// <summary>
        /// TODO: assign a vendor name.
        /// </summary>
        private const string VendorName = "SixBeeps";
        /// <summary>
        /// TODO: assign a plugin version.
        /// </summary>
        private const int PluginVersion = 0003;
        /// <summary>
        /// TODO: what type of plugin are your making?
        /// </summary>
        private const VstPluginCategory PluginCategory = VstPluginCategory.Effect;
        /// <summary>
        /// TODO: what can your plugin do?
        /// </summary>
        private const VstPluginCapabilities PluginCapabilities = VstPluginCapabilities.ReceiveTimeInfo;
        /// <summary>
        /// The number of samples your plugin lags behind.
        /// </summary>
        private const int InitialDelayInSamples = 0;

        /// <summary>
        /// Initializes the one an only instance of the Plugin root object.
        /// </summary>
        public Plugin()
            : base(PluginName, UniquePluginId,
                new VstProductInfo(ProductName, VendorName, PluginVersion),
                PluginCategory, InitialDelayInSamples, PluginCapabilities) { }

        /// <summary>
        /// Called once to get all the plugin components.
        /// Add components for the IVstXxxx interfaces you want to support.
        /// </summary>
        /// <param name="services">Is never null.</param>
        protected override void ConfigureServices(IServiceCollection services) {
            services.AddSingleton<PluginParameters>()
                .AddSingletonAll<PluginPrograms>()
                .AddSingletonAll<AudioProcessor>()
                .AddSingletonAll<PluginEditor>()
                .AddSingletonAll<MidiWatch>();
        }

        public static int GetVersion() {
            return PluginVersion;
        }
    }
}
