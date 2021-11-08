using Jacobi.Vst.Core;
using Jacobi.Vst.Plugin.Framework;

namespace Heartbeat.Dsp {
    /// <summary>
    /// Encapsulated delay parameters.
    /// </summary>
    internal sealed class HeartParameters {
        private const string ParameterCategoryName = "Gain";

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        /// <summary>
        /// Initializes the paramaters for the Delay component.
        /// </summary>
        /// <param name="parameters"></param>
        public HeartParameters(PluginParameters parameters) {
            Throw.IfArgumentIsNull(parameters, nameof(parameters));

            InitializeParameters(parameters);
        }
#pragma warning restore CS8618

        public VstParameterManager PumpAmtMgr { get; private set; }
        public VstParameterManager TensionMgr { get; private set; }
        public VstParameterManager DirectionMgr { get; private set; }
        public VstParameterManager BeatDivMgr { get; private set; }
        public VstParameterManager BeatMultMgr { get; private set; }

        // This method initializes the plugin parameters this Dsp component owns.
        private void InitializeParameters(PluginParameters parameters) {
            // all parameter definitions are added to a central list.
            VstParameterInfoCollection parameterInfos = parameters.ParameterInfos;

            // retrieve the category for all delay parameters.
            VstParameterCategory paramCategory =
                parameters.GetParameterCategory(ParameterCategoryName);

            // Pump Amount Param
            var paramInfo = new VstParameterInfo {
                Category = paramCategory,
                CanBeAutomated = true,
                Name = "PumpAmt",
                Label = "Percent",
                ShortLabel = "%",
                MinInteger = 0,
                MaxInteger = 100,
                LargeStepInteger = 10,
                StepInteger = 1,
                DefaultValue = 100
            };
            PumpAmtMgr = paramInfo
                .Normalize()
                .ToManager();

            parameterInfos.Add(paramInfo);

            // Tension Param
            paramInfo = new VstParameterInfo {
                Category = paramCategory,
                CanBeAutomated = true,
                Name = "Tension",
                Label = "tens",
                ShortLabel = "t.",
                MinInteger = -20,
                MaxInteger = 30,
                LargeStepInteger = 10,
                StepInteger = 1,
                DefaultValue = 0
            };
            TensionMgr = paramInfo
                .Normalize()
                .ToManager();

            parameterInfos.Add(paramInfo);

            // Direction Param
            paramInfo = new VstParameterInfo {
                Category = paramCategory,
                CanBeAutomated = true,
                Name = "Dirctn",
                Label = "±",
                ShortLabel = "±",
                MinInteger = 0,
                MaxInteger = 1,
                LargeStepInteger = 1,
                StepInteger = 1,
                DefaultValue = 0
            };
            DirectionMgr = paramInfo
                .Normalize()
                .ToManager();

            parameterInfos.Add(paramInfo);

            // Beat Divisor Param
            paramInfo = new VstParameterInfo {
                Category = paramCategory,
                CanBeAutomated = true,
                Name = "BeatDiv",
                Label = "Quarter",
                ShortLabel = "qt.",
                MinInteger = 1,
                MaxInteger = 8,
                LargeStepInteger = 1,
                StepInteger = 1,
                DefaultValue = 1,
            };
            BeatDivMgr = paramInfo
                .Normalize()
                .ToManager();

            parameterInfos.Add(paramInfo);

            // Beat Multiplier Param
            paramInfo = new VstParameterInfo {
                Category = paramCategory,
                CanBeAutomated = true,
                Name = "BeatMult",
                Label = "Quarter",
                ShortLabel = "qt.",
                MinInteger = 1,
                MaxInteger = 8,
                LargeStepInteger = 1,
                StepInteger = 1,
                DefaultValue = 1,
            };
            BeatMultMgr = paramInfo
                .Normalize()
                .ToManager();

            parameterInfos.Add(paramInfo);
        }
    }
}
