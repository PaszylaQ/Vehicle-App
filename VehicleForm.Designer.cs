namespace VehicleApp
{
    partial class VehicleForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vehicleBrandTextBox = new System.Windows.Forms.TextBox();
            this.maxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vehicleDateOfProduction = new System.Windows.Forms.DateTimePicker();
            this.maxSpeedErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.brandErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.vehicleExistErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.vehicleTypeControl = new VehicleApp.VehicleTypeControl();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeedErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleExistErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeControl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date of production";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max speed";
            // 
            // vehicleBrandTextBox
            // 
            this.vehicleBrandTextBox.Location = new System.Drawing.Point(135, 20);
            this.vehicleBrandTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.vehicleBrandTextBox.Name = "vehicleBrandTextBox";
            this.vehicleBrandTextBox.Size = new System.Drawing.Size(99, 20);
            this.vehicleBrandTextBox.TabIndex = 4;
            this.vehicleBrandTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.vehicleBrandTextBox_Validating);
            this.vehicleBrandTextBox.Validated += new System.EventHandler(this.vehicleBrandTextBox_Validated);
            // 
            // maxSpeedTextBox
            // 
            this.maxSpeedTextBox.Location = new System.Drawing.Point(135, 49);
            this.maxSpeedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.maxSpeedTextBox.Name = "maxSpeedTextBox";
            this.maxSpeedTextBox.Size = new System.Drawing.Size(99, 20);
            this.maxSpeedTextBox.TabIndex = 5;
            this.maxSpeedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.maxSpeedTextBox_Validating);
            this.maxSpeedTextBox.Validated += new System.EventHandler(this.maxSpeedTextBox_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "km/h";
            // 
            // vehicleDateOfProduction
            // 
            this.vehicleDateOfProduction.CustomFormat = "yyyy";
            this.vehicleDateOfProduction.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.vehicleDateOfProduction.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vehicleDateOfProduction.Location = new System.Drawing.Point(135, 77);
            this.vehicleDateOfProduction.Margin = new System.Windows.Forms.Padding(2);
            this.vehicleDateOfProduction.MaxDate = new System.DateTime(2019, 11, 11, 0, 0, 0, 0);
            this.vehicleDateOfProduction.Name = "vehicleDateOfProduction";
            this.vehicleDateOfProduction.Size = new System.Drawing.Size(151, 20);
            this.vehicleDateOfProduction.TabIndex = 7;
            this.vehicleDateOfProduction.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // maxSpeedErrorProvider
            // 
            this.maxSpeedErrorProvider.ContainerControl = this;
            this.maxSpeedErrorProvider.RightToLeft = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(26, 221);
            this.okButton.Margin = new System.Windows.Forms.Padding(2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(79, 20);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.Location = new System.Drawing.Point(188, 221);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(79, 20);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // brandErrorProvider
            // 
            this.brandErrorProvider.ContainerControl = this;
            this.brandErrorProvider.RightToLeft = true;
            // 
            // vehicleExistErrorProvider
            // 
            this.vehicleExistErrorProvider.ContainerControl = this;
            // 
            // vehicleTypeControl
            // 
            this.vehicleTypeControl.CurrentType = VehicleApp.TypeOfVehicle.Car;
            this.vehicleTypeControl.Image = ((System.Drawing.Image)(resources.GetObject("vehicleTypeControl.Image")));
            this.vehicleTypeControl.Location = new System.Drawing.Point(135, 106);
            this.vehicleTypeControl.Margin = new System.Windows.Forms.Padding(2);
            this.vehicleTypeControl.Name = "vehicleTypeControl";
            this.vehicleTypeControl.Size = new System.Drawing.Size(98, 106);
            this.vehicleTypeControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vehicleTypeControl.TabIndex = 11;
            this.vehicleTypeControl.TabStop = false;
            this.vehicleTypeControl.Click += new System.EventHandler(this.vehicleTypeControl_Click);
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 294);
            this.ControlBox = false;
            this.Controls.Add(this.vehicleTypeControl);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.vehicleDateOfProduction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxSpeedTextBox);
            this.Controls.Add(this.vehicleBrandTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(349, 333);
            this.MinimumSize = new System.Drawing.Size(349, 333);
            this.Name = "VehicleForm";
            this.Text = "VehicleForm";
            this.Load += new System.EventHandler(this.VehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeedErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleExistErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vehicleBrandTextBox;
        private System.Windows.Forms.TextBox maxSpeedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker vehicleDateOfProduction;
        private System.Windows.Forms.ErrorProvider maxSpeedErrorProvider;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ErrorProvider brandErrorProvider;
        private System.Windows.Forms.ErrorProvider vehicleExistErrorProvider;
        private VehicleTypeControl vehicleTypeControl;
    }
}