namespace POSeidon
{
    partial class AddSupplierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplierForm));
            this.addSupplierFormPanel = new System.Windows.Forms.Panel();
            this.addButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addressTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.emailTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.phoneTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.emailLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.addressLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.phoneLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.nameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.addSupplierFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addSupplierFormPanel
            // 
            this.addSupplierFormPanel.Controls.Add(this.addButton);
            this.addSupplierFormPanel.Controls.Add(this.addressTextBox);
            this.addSupplierFormPanel.Controls.Add(this.emailTextBox);
            this.addSupplierFormPanel.Controls.Add(this.phoneTextBox);
            this.addSupplierFormPanel.Controls.Add(this.nameTextBox);
            this.addSupplierFormPanel.Controls.Add(this.emailLabel);
            this.addSupplierFormPanel.Controls.Add(this.addressLabel);
            this.addSupplierFormPanel.Controls.Add(this.phoneLabel);
            this.addSupplierFormPanel.Controls.Add(this.nameLabel);
            resources.ApplyResources(this.addSupplierFormPanel, "addSupplierFormPanel");
            this.addSupplierFormPanel.Name = "addSupplierFormPanel";
            // 
            // addButton
            // 
            resources.ApplyResources(this.addButton, "addButton");
            this.addButton.Name = "addButton";
            this.addButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addButton.StateCommon.Border.Rounding = 5;
            this.addButton.Values.Text = resources.GetString("addButton.Values.Text");
            this.addButton.Click += new System.EventHandler(this.AddSupplierFormButton_Click);
            // 
            // addressTextBox
            // 
            resources.ApplyResources(this.addressTextBox, "addressTextBox");
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addressTextBox.StateCommon.Border.Rounding = 5;
            // 
            // emailTextBox
            // 
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.emailTextBox.StateCommon.Border.Rounding = 5;
            // 
            // phoneTextBox
            // 
            resources.ApplyResources(this.phoneTextBox, "phoneTextBox");
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.phoneTextBox.StateCommon.Border.Rounding = 5;
            // 
            // nameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nameTextBox.StateCommon.Border.Rounding = 5;
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Values.Text = resources.GetString("emailLabel.Values.Text");
            // 
            // addressLabel
            // 
            resources.ApplyResources(this.addressLabel, "addressLabel");
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Values.Text = resources.GetString("addressLabel.Values.Text");
            // 
            // phoneLabel
            // 
            resources.ApplyResources(this.phoneLabel, "phoneLabel");
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Values.Text = resources.GetString("phoneLabel.Values.Text");
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Values.Text = resources.GetString("nameLabel.Values.Text");
            // 
            // AddSupplierForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addSupplierFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddSupplierForm";
            this.addSupplierFormPanel.ResumeLayout(false);
            this.addSupplierFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addSupplierFormPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox addressTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox emailTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox phoneTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nameTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel emailLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel addressLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel phoneLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel nameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addButton;
    }
}