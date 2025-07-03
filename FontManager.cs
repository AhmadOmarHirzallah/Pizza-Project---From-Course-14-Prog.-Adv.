using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PizzaProject
{
    public static class FontManager
    {
        // Default fonts for the application
        public static readonly Font DefaultFont = new Font("Segoe UI", 12, FontStyle.Regular);
        public static readonly Font TitleFont = new Font("Segoe UI", 23, FontStyle.Bold);
        public static readonly Font SmallFont = new Font("Segoe UI", 14, FontStyle.Regular);
        public static readonly Font LargeFont = new Font("Segoe UI", 24, FontStyle.Regular);

        /// <summary>
        /// Applies fonts to all controls in a form recursively
        /// </summary>
        /// <param name="form">The form to apply fonts to</param>
        /// <param name="defaultFont">The default font to apply (optional, uses DefaultFont if null)</param>
        public static void ApplyFontsToForm(Form form, Font defaultFont = null)
        {
            if (defaultFont == null)
                defaultFont = DefaultFont;

            ApplyFontsRecursive(form.Controls, defaultFont);
        }

        /// <summary>
        /// Applies fonts to a specific control collection recursively
        /// </summary>
        /// <param name="controls">The control collection to apply fonts to</param>
        /// <param name="defaultFont">The default font to apply</param>
        public static void ApplyFontsRecursive(Control.ControlCollection controls, Font defaultFont)
        {
            foreach (Control ctrl in controls)
            {
                ApplyFontToControl(ctrl, defaultFont);

                // Recursively apply to child controls
                if (ctrl.HasChildren)
                {
                    ApplyFontsRecursive(ctrl.Controls, defaultFont);
                }
            }
        }

        /// <summary>
        /// Applies appropriate font to a single control based on its type and name
        /// </summary>
        /// <param name="ctrl">The control to apply font to</param>
        /// <param name="defaultFont">The default font to use</param>
        private static void ApplyFontToControl(Control ctrl, Font defaultFont)
        {
            try
            {
                // Special handling for title labels
                if (ctrl.Name.Contains("Title") || ctrl.Name.Contains("title") || ctrl.Name == "lblTitle")
                {
                    ctrl.Font = TitleFont;
                    return;
                }

                // Check if it's a Guna2 control first (since they inherit from standard controls)
                if (ctrl.GetType().Namespace == "Guna.UI2.WinForms")
                {
                    ctrl.Font = defaultFont;
                    return;
                }

                // Handle standard Windows Forms controls
                switch (ctrl)
                {
                    case Label label:
                    case Button button:
                    case TextBox textBox:
                    case ComboBox comboBox:
                    case CheckBox checkBox:
                    case RadioButton radioButton:
                    case ListBox listBox:
                    case ListView listView:
                    case TreeView treeView:
                    case GroupBox groupBox:
                    case Panel panel:
                        ctrl.Font = defaultFont;
                        break;

                    // For any other control that has a Font property
                    default:
                        if (ctrl.GetType().GetProperty("Font") != null)
                        {
                            ctrl.Font = defaultFont;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                // Log error if needed, but continue with other controls
                System.Diagnostics.Debug.WriteLine($"Error applying font to control {ctrl.Name}: {ex.Message}");
            }
        }

        /// <summary>
        /// Sets a specific font for controls with specific names
        /// </summary>
        /// <param name="form">The form containing the controls</param>
        /// <param name="controlNames">Array of control names to target</param>
        /// <param name="font">The font to apply</param>
        public static void SetFontForSpecificControls(Form form, string[] controlNames, Font font)
        {
            foreach (string controlName in controlNames)
            {
                Control[] controls = form.Controls.Find(controlName, true);
                foreach (Control ctrl in controls)
                {
                    ctrl.Font = font;
                }
            }
        }

        /// <summary>
        /// Disposes of the static fonts when application closes
        /// </summary>
        public static void DisposeStaticFonts()
        {
            DefaultFont?.Dispose();
            TitleFont?.Dispose();
            SmallFont?.Dispose();
            LargeFont?.Dispose();
        }
    }
}