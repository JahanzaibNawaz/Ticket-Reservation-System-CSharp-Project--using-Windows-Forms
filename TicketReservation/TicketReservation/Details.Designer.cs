namespace TicketReservation
{
    partial class Details
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
            this.formView = new System.Windows.Forms.DataGridView();
            this.btn_View = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.formView)).BeginInit();
            this.SuspendLayout();
            // 
            // formView
            // 
            this.formView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formView.Location = new System.Drawing.Point(12, 23);
            this.formView.Name = "formView";
            this.formView.Size = new System.Drawing.Size(824, 221);
            this.formView.TabIndex = 0;
            // 
            // btn_View
            // 
            this.btn_View.Location = new System.Drawing.Point(13, 271);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(75, 23);
            this.btn_View.TabIndex = 1;
            this.btn_View.Text = "Load Details";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 358);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.formView);
            this.Name = "Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Details_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.formView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView formView;
        private System.Windows.Forms.Button btn_View;
    }
}