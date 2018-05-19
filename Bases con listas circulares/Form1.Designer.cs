namespace Bases_con_listas_circulares
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
            this.txtRoute = new System.Windows.Forms.RichTextBox();
            this.numStartHour = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRouteName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numFinalHour = new System.Windows.Forms.NumericUpDown();
            this.numFinalMinute = new System.Windows.Forms.NumericUpDown();
            this.numStartMinute = new System.Windows.Forms.NumericUpDown();
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBaseName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numTimeToArrive = new System.Windows.Forms.NumericUpDown();
            this.btnAddBase = new System.Windows.Forms.Button();
            this.btnListRoute = new System.Windows.Forms.Button();
            this.txtCircularList = new System.Windows.Forms.RichTextBox();
            this.btnListBases = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.numInsert = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteByName = new System.Windows.Forms.Button();
            this.btnDeleteLast = new System.Windows.Forms.Button();
            this.btnDeleteFirst = new System.Windows.Forms.Button();
            this.lblStartHour = new System.Windows.Forms.Label();
            this.lblFinalHour = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinalHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinalMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeToArrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInsert)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRoute
            // 
            this.txtRoute.Location = new System.Drawing.Point(168, 31);
            this.txtRoute.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtRoute.Name = "txtRoute";
            this.txtRoute.Size = new System.Drawing.Size(212, 474);
            this.txtRoute.TabIndex = 66;
            this.txtRoute.Text = "";
            // 
            // numStartHour
            // 
            this.numStartHour.Location = new System.Drawing.Point(477, 48);
            this.numStartHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numStartHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numStartHour.Name = "numStartHour";
            this.numStartHour.Size = new System.Drawing.Size(81, 26);
            this.numStartHour.TabIndex = 80;
            this.numStartHour.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Hora inicio:";
            // 
            // txtRouteName
            // 
            this.txtRouteName.Location = new System.Drawing.Point(477, 141);
            this.txtRouteName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtRouteName.Name = "txtRouteName";
            this.txtRouteName.Size = new System.Drawing.Size(170, 26);
            this.txtRouteName.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Hora fin:";
            // 
            // numFinalHour
            // 
            this.numFinalHour.Location = new System.Drawing.Point(477, 88);
            this.numFinalHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numFinalHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numFinalHour.Name = "numFinalHour";
            this.numFinalHour.Size = new System.Drawing.Size(81, 26);
            this.numFinalHour.TabIndex = 82;
            this.numFinalHour.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // numFinalMinute
            // 
            this.numFinalMinute.Location = new System.Drawing.Point(566, 88);
            this.numFinalMinute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numFinalMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numFinalMinute.Name = "numFinalMinute";
            this.numFinalMinute.Size = new System.Drawing.Size(81, 26);
            this.numFinalMinute.TabIndex = 84;
            this.numFinalMinute.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numStartMinute
            // 
            this.numStartMinute.Location = new System.Drawing.Point(566, 48);
            this.numStartMinute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numStartMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numStartMinute.Name = "numStartMinute";
            this.numStartMinute.Size = new System.Drawing.Size(81, 26);
            this.numStartMinute.TabIndex = 83;
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.AutoSize = true;
            this.btnAddRoute.Location = new System.Drawing.Point(571, 187);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(76, 30);
            this.btnAddRoute.TabIndex = 85;
            this.btnAddRoute.Text = "Agregar";
            this.btnAddRoute.UseVisualStyleBackColor = true;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "Rutas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "Bases";
            // 
            // txtBaseName
            // 
            this.txtBaseName.Location = new System.Drawing.Point(477, 312);
            this.txtBaseName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtBaseName.Name = "txtBaseName";
            this.txtBaseName.Size = new System.Drawing.Size(170, 26);
            this.txtBaseName.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 315);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 89;
            this.label7.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 90;
            this.label6.Text = "Tiempo para llegar:";
            // 
            // numTimeToArrive
            // 
            this.numTimeToArrive.Location = new System.Drawing.Point(551, 263);
            this.numTimeToArrive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numTimeToArrive.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numTimeToArrive.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTimeToArrive.Name = "numTimeToArrive";
            this.numTimeToArrive.Size = new System.Drawing.Size(83, 26);
            this.numTimeToArrive.TabIndex = 91;
            this.numTimeToArrive.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnAddBase
            // 
            this.btnAddBase.AutoSize = true;
            this.btnAddBase.Location = new System.Drawing.Point(571, 360);
            this.btnAddBase.Name = "btnAddBase";
            this.btnAddBase.Size = new System.Drawing.Size(76, 30);
            this.btnAddBase.TabIndex = 92;
            this.btnAddBase.Text = "Agregar";
            this.btnAddBase.UseVisualStyleBackColor = true;
            this.btnAddBase.Click += new System.EventHandler(this.btnAddBase_Click);
            // 
            // btnListRoute
            // 
            this.btnListRoute.AutoSize = true;
            this.btnListRoute.Location = new System.Drawing.Point(571, 432);
            this.btnListRoute.Name = "btnListRoute";
            this.btnListRoute.Size = new System.Drawing.Size(110, 30);
            this.btnListRoute.TabIndex = 93;
            this.btnListRoute.Text = "Ver recorrido";
            this.btnListRoute.UseVisualStyleBackColor = true;
            this.btnListRoute.Click += new System.EventHandler(this.btnListRoute_Click);
            // 
            // txtCircularList
            // 
            this.txtCircularList.Location = new System.Drawing.Point(15, 31);
            this.txtCircularList.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtCircularList.Name = "txtCircularList";
            this.txtCircularList.Size = new System.Drawing.Size(141, 323);
            this.txtCircularList.TabIndex = 94;
            this.txtCircularList.Text = "";
            // 
            // btnListBases
            // 
            this.btnListBases.AutoSize = true;
            this.btnListBases.Location = new System.Drawing.Point(404, 360);
            this.btnListBases.Name = "btnListBases";
            this.btnListBases.Size = new System.Drawing.Size(110, 30);
            this.btnListBases.TabIndex = 95;
            this.btnListBases.Text = "Listar bases";
            this.btnListBases.UseVisualStyleBackColor = true;
            this.btnListBases.Click += new System.EventHandler(this.btnListBases_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.AutoSize = true;
            this.btnInsert.Location = new System.Drawing.Point(571, 396);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(76, 30);
            this.btnInsert.TabIndex = 96;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // numInsert
            // 
            this.numInsert.Location = new System.Drawing.Point(654, 396);
            this.numInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numInsert.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInsert.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInsert.Name = "numInsert";
            this.numInsert.Size = new System.Drawing.Size(83, 26);
            this.numInsert.TabIndex = 97;
            this.numInsert.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDeleteByName
            // 
            this.btnDeleteByName.AutoSize = true;
            this.btnDeleteByName.Location = new System.Drawing.Point(654, 312);
            this.btnDeleteByName.Name = "btnDeleteByName";
            this.btnDeleteByName.Size = new System.Drawing.Size(76, 30);
            this.btnDeleteByName.TabIndex = 98;
            this.btnDeleteByName.Text = "Borrar";
            this.btnDeleteByName.UseVisualStyleBackColor = true;
            this.btnDeleteByName.Click += new System.EventHandler(this.btnDeleteByName_Click);
            // 
            // btnDeleteLast
            // 
            this.btnDeleteLast.AutoSize = true;
            this.btnDeleteLast.Location = new System.Drawing.Point(404, 432);
            this.btnDeleteLast.Name = "btnDeleteLast";
            this.btnDeleteLast.Size = new System.Drawing.Size(109, 30);
            this.btnDeleteLast.TabIndex = 99;
            this.btnDeleteLast.Text = "Borrar último";
            this.btnDeleteLast.UseVisualStyleBackColor = true;
            this.btnDeleteLast.Click += new System.EventHandler(this.btnDeleteLast_Click);
            // 
            // btnDeleteFirst
            // 
            this.btnDeleteFirst.AutoSize = true;
            this.btnDeleteFirst.Location = new System.Drawing.Point(404, 396);
            this.btnDeleteFirst.Name = "btnDeleteFirst";
            this.btnDeleteFirst.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteFirst.TabIndex = 100;
            this.btnDeleteFirst.Text = "Borrar primero";
            this.btnDeleteFirst.UseVisualStyleBackColor = true;
            this.btnDeleteFirst.Click += new System.EventHandler(this.btnDeleteFirst_Click);
            // 
            // lblStartHour
            // 
            this.lblStartHour.AutoSize = true;
            this.lblStartHour.Location = new System.Drawing.Point(11, 394);
            this.lblStartHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartHour.Name = "lblStartHour";
            this.lblStartHour.Size = new System.Drawing.Size(87, 20);
            this.lblStartHour.TabIndex = 101;
            this.lblStartHour.Text = "Hora inicio:";
            // 
            // lblFinalHour
            // 
            this.lblFinalHour.AutoSize = true;
            this.lblFinalHour.Location = new System.Drawing.Point(11, 424);
            this.lblFinalHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalHour.Name = "lblFinalHour";
            this.lblFinalHour.Size = new System.Drawing.Size(69, 20);
            this.lblFinalHour.TabIndex = 102;
            this.lblFinalHour.Text = "Hora fin:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 103;
            this.label8.Text = "Bases";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 104;
            this.label9.Text = "Recorrido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 511);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblFinalHour);
            this.Controls.Add(this.lblStartHour);
            this.Controls.Add(this.btnDeleteFirst);
            this.Controls.Add(this.btnDeleteLast);
            this.Controls.Add(this.btnDeleteByName);
            this.Controls.Add(this.numInsert);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnListBases);
            this.Controls.Add(this.txtCircularList);
            this.Controls.Add(this.btnListRoute);
            this.Controls.Add(this.btnAddBase);
            this.Controls.Add(this.numTimeToArrive);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBaseName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddRoute);
            this.Controls.Add(this.numFinalMinute);
            this.Controls.Add(this.numStartMinute);
            this.Controls.Add(this.numFinalHour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numStartHour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRouteName);
            this.Controls.Add(this.txtRoute);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinalHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinalMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeToArrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInsert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtRoute;
        private System.Windows.Forms.NumericUpDown numStartHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRouteName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numFinalHour;
        private System.Windows.Forms.NumericUpDown numFinalMinute;
        private System.Windows.Forms.NumericUpDown numStartMinute;
        private System.Windows.Forms.Button btnAddRoute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBaseName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numTimeToArrive;
        private System.Windows.Forms.Button btnAddBase;
        private System.Windows.Forms.Button btnListRoute;
        private System.Windows.Forms.RichTextBox txtCircularList;
        private System.Windows.Forms.Button btnListBases;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.NumericUpDown numInsert;
        private System.Windows.Forms.Button btnDeleteByName;
        private System.Windows.Forms.Button btnDeleteLast;
        private System.Windows.Forms.Button btnDeleteFirst;
        private System.Windows.Forms.Label lblStartHour;
        private System.Windows.Forms.Label lblFinalHour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

