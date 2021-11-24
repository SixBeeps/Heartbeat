using Jacobi.Vst.Plugin.Framework;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Heartbeat.UI {
    public partial class PluginEditorView : UserControl {
        public PluginEditorView() {
            InitializeComponent();
        }

        internal bool InitializeParameters(IList<VstParameterManager> parameters) {
            if (parameters == null || parameters.Count < 5)
                return false;

            BindParameter(parameters[0], null, pumpAmtTbar, pumpAmtUnit);
            BindParameter(parameters[1], null, tensionTbar, null);
            BindParameter(parameters[2], null, directionTbar, null);
            BindParameter(parameters[3], null, beatDivBox, null);
            BindParameter(parameters[4], null, beatMultBox, null);

            return true;
        }

        private void BindParameter(VstParameterManager paramMgr, Label? label, TrackBar trackBar, Label? shortLabel) {
            if (label != null) label.Text = paramMgr.ParameterInfo.Name;
            if (shortLabel != null) shortLabel.Text = paramMgr.ParameterInfo.ShortLabel;

            var factor = InitTrackBar(trackBar, paramMgr.ParameterInfo);
            var paramState = new ParameterControlState(paramMgr, factor);

            // use databinding for VstParameter/Manager changed notifications.
            trackBar.DataBindings.Add("Value", paramState, nameof(ParameterControlState.Value));
            trackBar.ValueChanged += TrackBar_ValueChanged;
            trackBar.Tag = paramState;
        }

        private void BindParameter(VstParameterManager paramMgr, Label? label, NumericUpDown numBox, Label? shortLabel) {
            if (label != null) label.Text = paramMgr.ParameterInfo.Name;
            if (shortLabel != null) shortLabel.Text = paramMgr.ParameterInfo.ShortLabel;

            var factor = InitNumBox(numBox, paramMgr.ParameterInfo);
            var paramState = new ParameterControlState(paramMgr, factor);

            // use databinding for VstParameter/Manager changed notifications.
            numBox.DataBindings.Add("Value", paramState, nameof(ParameterControlState.Value));
            numBox.ValueChanged += NumBox_ValueChanged;
            numBox.Tag = paramState;
        }

        private float InitTrackBar(TrackBar trackBar, VstParameterInfo parameterInfo) {
            // A multiplication factor to convert floats (0.0-1.0) 
            // to an integer range for the TrackBar to work with.
            float factor = 1.0f;

            if (parameterInfo.IsSwitch) {
                trackBar.Minimum = 0;
                trackBar.Maximum = 1;
                trackBar.LargeChange = 1;
                trackBar.SmallChange = 1;
                return factor;
            }

            if (parameterInfo.IsStepIntegerValid) {
                trackBar.LargeChange = parameterInfo.LargeStepInteger;
                trackBar.SmallChange = parameterInfo.StepInteger;
            } else if (parameterInfo.IsStepFloatValid) {
                factor = 1 / parameterInfo.StepFloat;
                trackBar.LargeChange = (int)(parameterInfo.LargeStepFloat * factor);
                trackBar.SmallChange = (int)(parameterInfo.StepFloat * factor);
            }

            if (parameterInfo.IsMinMaxIntegerValid) {
                trackBar.Minimum = (int)(parameterInfo.MinInteger * factor);
                trackBar.Maximum = (int)(parameterInfo.MaxInteger * factor);
            } else {
                trackBar.Minimum = 0;
                trackBar.Maximum = (int)factor;
            }

            return factor;
        }

        private float InitNumBox(NumericUpDown numBox, VstParameterInfo parameterInfo) {
            // A multiplication factor to convert floats (0.0-1.0) 
            // to an integer range for the TrackBar to work with.
            float factor = 1.0f;

            if (parameterInfo.IsSwitch) {
                numBox.Minimum = 0;
                numBox.Maximum = 1;
                numBox.Increment = 1;
                return factor;
            }

            if (parameterInfo.IsStepIntegerValid) {
                numBox.Increment = parameterInfo.LargeStepInteger;
            } else if (parameterInfo.IsStepFloatValid) {
                factor = 1 / parameterInfo.StepFloat;
                numBox.Increment = (int)(parameterInfo.LargeStepFloat * factor);
            }

            if (parameterInfo.IsMinMaxIntegerValid) {
                numBox.Minimum = (int)(parameterInfo.MinInteger * factor);
                numBox.Maximum = (int)(parameterInfo.MaxInteger * factor);
            } else {
                numBox.Minimum = 0;
                numBox.Maximum = (int)factor;
            }

            return factor;
        }

        private void TrackBar_ValueChanged(object? sender, System.EventArgs e) {
            var trackBar = (TrackBar?)sender;
            var paramState = (ParameterControlState?)trackBar?.Tag;

            if (trackBar != null &&
                paramState?.ParameterManager.ActiveParameter != null) {
                paramState.ParameterManager.ActiveParameter.Value =
                    trackBar.Value / paramState.ValueFactor;
            }
        }

        private void NumBox_ValueChanged(object? sender, System.EventArgs e) {
            var numBox = (NumericUpDown?)sender;
            var paramState = (ParameterControlState?)numBox?.Tag;

            if (numBox != null &&
                paramState?.ParameterManager.ActiveParameter != null) {
                paramState.ParameterManager.ActiveParameter.Value =
                    (float)numBox.Value / paramState.ValueFactor;
            }
        }

        internal void ProcessIdle() {
            // TODO: short idle processing here
        }

        /// <summary>
        /// This class converts the parameter value range to a compatible (integer) TrackBar value range.
        /// </summary>
        private sealed class ParameterControlState {
            public ParameterControlState(VstParameterManager parameterManager, float valueFactor) {
                ParameterManager = parameterManager;
                ValueFactor = valueFactor;
            }

            public VstParameterManager ParameterManager { get; }
            public float ValueFactor { get; }

            public int Value {
                get {
                    return (int)(ParameterManager.CurrentValue * ValueFactor);
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {
            // do something when validated
        }

        private void aboutBtn_Click(object sender, System.EventArgs e) {
            MessageBox.Show($"Heartbeat - Volume LFO plugin by SixBeeps\n\nv{Plugin.GetVersion()}", "About Heartbeat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(string.Join(", ", MidiWatch.AllEvents));
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
