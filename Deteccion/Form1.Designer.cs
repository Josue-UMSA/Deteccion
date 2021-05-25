
namespace Deteccion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cargar = new System.Windows.Forms.Button();
            this.seccion = new System.Windows.Forms.ComboBox();
            this.seccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seccionDataSet = new Deteccion.seccionDataSet();
            this.seccionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seccionTableAdapter = new Deteccion.seccionDataSetTableAdapters.seccionTableAdapter();
            this.clasificar = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorTableAdapter = new Deteccion.seccionDataSetTableAdapters.colorTableAdapter();
            this.tableAdapterManager = new Deteccion.seccionDataSetTableAdapters.TableAdapterManager();
            this.original = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.seccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.original)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(12, 12);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(148, 23);
            this.cargar.TabIndex = 0;
            this.cargar.Text = "Cargar Imagen";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // seccion
            // 
            this.seccion.DataSource = this.seccionBindingSource;
            this.seccion.DisplayMember = "Seccion";
            this.seccion.Enabled = false;
            this.seccion.FormattingEnabled = true;
            this.seccion.Location = new System.Drawing.Point(12, 41);
            this.seccion.Name = "seccion";
            this.seccion.Size = new System.Drawing.Size(148, 21);
            this.seccion.TabIndex = 1;
            this.seccion.ValueMember = "Id";
            // 
            // seccionBindingSource
            // 
            this.seccionBindingSource.DataMember = "seccion";
            this.seccionBindingSource.DataSource = this.seccionDataSet;
            // 
            // seccionDataSet
            // 
            this.seccionDataSet.DataSetName = "seccionDataSet";
            this.seccionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seccionDataSetBindingSource
            // 
            this.seccionDataSetBindingSource.DataSource = this.seccionDataSet;
            this.seccionDataSetBindingSource.Position = 0;
            // 
            // seccionTableAdapter
            // 
            this.seccionTableAdapter.ClearBeforeFill = true;
            // 
            // clasificar
            // 
            this.clasificar.Enabled = false;
            this.clasificar.Location = new System.Drawing.Point(54, 68);
            this.clasificar.Name = "clasificar";
            this.clasificar.Size = new System.Drawing.Size(75, 23);
            this.clasificar.TabIndex = 2;
            this.clasificar.Text = "Clasificar";
            this.clasificar.UseVisualStyleBackColor = true;
            this.clasificar.Click += new System.EventHandler(this.clasificar_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(946, 547);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataMember = "color";
            this.colorBindingSource.DataSource = this.seccionDataSet;
            // 
            // colorTableAdapter
            // 
            this.colorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.colorTableAdapter = this.colorTableAdapter;
            this.tableAdapterManager.seccionTableAdapter = this.seccionTableAdapter;
            this.tableAdapterManager.UpdateOrder = Deteccion.seccionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // original
            // 
            this.original.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.original.Location = new System.Drawing.Point(30, 106);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(112, 93);
            this.original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.original.TabIndex = 4;
            this.original.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(166, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1086, 624);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(66, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(67, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 656);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1231, 39);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 707);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.original);
            this.Controls.Add(this.clasificar);
            this.Controls.Add(this.seccion);
            this.Controls.Add(this.cargar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.original)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.ComboBox seccion;
        private System.Windows.Forms.BindingSource seccionDataSetBindingSource;
        private seccionDataSet seccionDataSet;
        private System.Windows.Forms.BindingSource seccionBindingSource;
        private seccionDataSetTableAdapters.seccionTableAdapter seccionTableAdapter;
        private System.Windows.Forms.Button clasificar;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private seccionDataSetTableAdapters.colorTableAdapter colorTableAdapter;
        private seccionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox original;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

