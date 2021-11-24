using System;
using System.ComponentModel;

namespace Heartbeat.Dsp {
    /// <summary>
    /// This is an example of a Digital Sound Processing component you could have in your plugin.
    /// </summary>
    internal sealed class Heart {

        private readonly HeartParameters _parameters;

        public float SampleRate { get; internal set; }

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Heart(HeartParameters parameters) {
            _parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));

            // when the delay time parameter value changes, we like to know about it.
            _parameters.PumpAmtMgr.PropertyChanged += PumpAmtMgr_Changed;
        }

        public (float, float) GetBeatParams() {
            return (_parameters.BeatDivMgr.CurrentValue, _parameters.BeatMultMgr.CurrentValue);
        }

        private void PumpAmtMgr_Changed(object sender, PropertyChangedEventArgs e) {
            if (Object.ReferenceEquals(_parameters.PumpAmtMgr, sender)) {
                // TODO: You can react to the parameter change here
            }
        }

        /// <summary>
        /// Processes the <paramref name="sample"/> using a delay effect.
        /// </summary>
        /// <param name="sample">A single sample.</param>
        /// <returns>Returns the new value for the sample.</returns>
        public float ProcessSample(float sample, float beatProgress) {
            float pumpPercent = _parameters.PumpAmtMgr.CurrentValue / 100f;
            float tension = _parameters.TensionMgr.CurrentValue / 10f;
            bool flip = _parameters.DirectionMgr.CurrentValue > 0.5f;

            float b = MathF.Pow(flip ? 1 - beatProgress : beatProgress, MathF.Pow(MathF.E, tension));

            float output = Lerp(sample, sample * b, pumpPercent);
            return output;
        }

        /// <summary>
        /// Linearly interpolates from <paramref name="v0"/> to <paramref name="v1"/> by <paramref name="t"/>
        /// </summary>
        /// <param name="v0">Left value</param>
        /// <param name="v1">Right value</param>
        /// <param name="t">Blending term</param>
        /// <returns></returns>
        static float Lerp(float v0, float v1, float t) {
            return (1 - t) * v0 + t * v1;
        }
    }
}
