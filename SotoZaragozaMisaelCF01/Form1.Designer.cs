
namespace SotoZaragozamisaelA01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonPixel = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderID = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderX = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderY = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderRadio = new System.Windows.Forms.ColumnHeader();
            this.labelimageSelected = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.buttonCircleSize = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Selecciona Una Imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Location = new System.Drawing.Point(12, 46);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(394, 311);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagen.TabIndex = 1;
            this.pictureBoxImagen.TabStop = false;
          
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonPixel
            // 
            this.buttonPixel.Location = new System.Drawing.Point(422, 16);
            this.buttonPixel.Name = "buttonPixel";
            this.buttonPixel.Size = new System.Drawing.Size(309, 24);
            this.buttonPixel.TabIndex = 6;
            this.buttonPixel.Text = "Obtener Datos";
            this.buttonPixel.UseVisualStyleBackColor = true;
            this.buttonPixel.Click += new System.EventHandler(this.buttonPixel_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderX,
            this.columnHeaderY,
            this.columnHeaderRadio});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(422, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(309, 207);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID: ";
            // 
            // columnHeaderX
            // 
            this.columnHeaderX.Text = "X: ";
            // 
            // columnHeaderY
            // 
            this.columnHeaderY.Text = "Y: ";
            // 
            // columnHeaderRadio
            // 
            this.columnHeaderRadio.Text = "Radio: ";
            // 
            // labelimageSelected
            // 
            this.labelimageSelected.AutoSize = true;
            this.labelimageSelected.Location = new System.Drawing.Point(170, 363);
            this.labelimageSelected.Name = "labelimageSelected";
            this.labelimageSelected.Size = new System.Drawing.Size(119, 15);
            this.labelimageSelected.TabIndex = 8;
            this.labelimageSelected.Text = "Imagen Seleccionada";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(531, 256);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(95, 15);
            this.Data.TabIndex = 9;
            this.Data.Text = "Datos Obtenidos";
            // 
            // buttonCircleSize
            // 
            this.buttonCircleSize.Location = new System.Drawing.Point(422, 334);
            this.buttonCircleSize.Name = "buttonCircleSize";
            this.buttonCircleSize.Size = new System.Drawing.Size(309, 23);
            this.buttonCircleSize.TabIndex = 10;
            this.buttonCircleSize.Text = "Ordenar Por Tamaño";
            this.buttonCircleSize.UseVisualStyleBackColor = true;
            this.buttonCircleSize.Click += new System.EventHandler(this.buttonCircleSize_Click);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(422, 305);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(309, 23);
            this.buttonX.TabIndex = 11;
            this.buttonX.Text = "Ordenar en X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // buttonY
            // 
            this.buttonY.Location = new System.Drawing.Point(422, 276);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(309, 23);
            this.buttonY.TabIndex = 12;
            this.buttonY.Text = "Ordenar en Y";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.buttonY_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 407);
            this.Controls.Add(this.buttonY);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonCircleSize);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.labelimageSelected);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonPixel);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonPixel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderX;
        private System.Windows.Forms.ColumnHeader columnHeaderY;
        private System.Windows.Forms.ColumnHeader columnHeaderRadio;
        private System.Windows.Forms.Label labelimageSelected;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Button buttonCircleSize;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonY;
    }
}

