using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BSPaletteAssembler
{
    /// <summary>
    /// Custom AutoComplete Behavior that matches anywhere instead of just the beginning
    /// Adapted from https://stackoverflow.com/a/43847970 to use DataSource
    /// </summary>
    class PaletteIndexAutoCompleteBehavior
    {
        private readonly ComboBox comboBox;
        private string previousSearchTerm;
        private string[] AllPalettesIndexes;

        public PaletteIndexAutoCompleteBehavior(ComboBox initComboBox) {
            comboBox = initComboBox;
            comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox.TextChanged += ComboBoxTextChanged;
            comboBox.KeyPress += ComboBoxKeyPress;
            comboBox.SelectionChangeCommitted += ComboBoxSelectionChangeCommitted;
        }

        public void ChangeList(List<string> palettesIndexes) {
            AllPalettesIndexes = palettesIndexes.ToArray();
            comboBox.DataSource = palettesIndexes;
        }

        private void ComboBoxSelectionChangeCommitted(object sender, EventArgs e) {
            try {
                if (comboBox.SelectedItem == null) {
                    return;
                }

                var sel = comboBox.SelectedItem;
                ResetCompletionList();
                comboBox.SelectedItem = sel;
            }
            catch (Exception ex) {
                Debug.Print(ex.Message);
            }
        }

        private void ComboBoxKeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '\r' || e.KeyChar == '\n') {
                e.Handled = true;
                if (comboBox.SelectedIndex == -1 && comboBox.Items.Count > 0
                    && comboBox.Items[0].ToString().ToLowerInvariant().StartsWith(comboBox.Text.ToLowerInvariant())) {
                    comboBox.Text = comboBox.Items[0].ToString();
                }

                comboBox.DroppedDown = false;

                // Guardclause when detecting any enter keypresses to avoid a glitch which was selecting an item by means of down arrow key followed by enter to wipe out the text within
                return;
            }

            // Its crucial that we use begininvoke because we need the changes to sink into the textfield  Omitting begininvoke would cause the searchterm to lag behind by one character  That is the last character that got typed in
            comboBox.BeginInvoke(new Action(ReevaluateCompletionList));
        }

        private void ComboBoxTextChanged(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(comboBox.Text) || !comboBox.Visible || !comboBox.Enabled) {
                return;
            }
            ResetCompletionList();
        }

        private void ResetCompletionList() {
            previousSearchTerm = null;
            try {
                comboBox.SuspendLayout();

                if (comboBox.Items.Count == AllPalettesIndexes.Length) {
                    return;
                }

                comboBox.DataSource = AllPalettesIndexes.ToList();
            }
            finally {
                comboBox.ResumeLayout(true);
            }
        }

        private void ReevaluateCompletionList() {
            var currentSearchTerm = comboBox.Text.ToLowerInvariant();
            if (currentSearchTerm == previousSearchTerm) {
                return;
            }
            if (string.IsNullOrEmpty(previousSearchTerm) && currentSearchTerm == AllPalettesIndexes[0].ToLowerInvariant()) {
                currentSearchTerm = "";
            }

            previousSearchTerm = currentSearchTerm;
            try {
                comboBox.SuspendLayout();

                List<string> newList;
                if (string.IsNullOrEmpty(currentSearchTerm)) {
                    if (comboBox.Items.Count == AllPalettesIndexes.Length) {
                        return;
                    }
                    newList = AllPalettesIndexes.ToList();
                }
                else {
                    newList = AllPalettesIndexes.Where(x => x.ToLowerInvariant().Contains(currentSearchTerm)).ToList();
                }

                comboBox.DataSource = newList; // reset list
            }
            catch (Exception ex) {
                Debug.Print(ex.Message);
            }
            finally {
                try {
                    if (currentSearchTerm.Length > 0 && !comboBox.DroppedDown) {
                        comboBox.DroppedDown = true; // if the current searchterm is empty we leave the dropdown list to whatever state it already had
                    }
                    Cursor.Current = Cursors.Default; // workaround for the fact the cursor disappears due to droppeddown=true  This is a known bu.g plaguing combobox which microsoft denies to fix for years now
                    comboBox.Text = currentSearchTerm; // Another workaround for a glitch which causes all text to be selected when there is a matching entry which starts with the exact text being typed in
                    comboBox.Select(currentSearchTerm.Length, 0);
                }
                catch (Exception ex) { Debug.Print(ex.Message); }

                comboBox.ResumeLayout(true);
            }
        }
    }
}
