namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startForever = new System.Windows.Forms.Button();
            this.startSomeSecs = new System.Windows.Forms.Button();
            this.printfile = new System.Windows.Forms.Button();
            this.exitProcess = new System.Windows.Forms.Button();
            this.showRunning = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showRunning);
            this.groupBox1.Controls.Add(this.exitProcess);
            this.groupBox1.Controls.Add(this.printfile);
            this.groupBox1.Controls.Add(this.startSomeSecs);
            this.groupBox1.Controls.Add(this.startForever);
            this.groupBox1.Location = new System.Drawing.Point(248, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processes";
            // 
            // startForever
            // 
            this.startForever.Location = new System.Drawing.Point(70, 33);
            this.startForever.Name = "startForever";
            this.startForever.Size = new System.Drawing.Size(207, 23);
            this.startForever.TabIndex = 0;
            this.startForever.Text = "Start Process forever";
            this.startForever.UseVisualStyleBackColor = true;
            this.startForever.Click += new System.EventHandler(this.startForever_Click);
            // 
            // startSomeSecs
            // 
            this.startSomeSecs.Location = new System.Drawing.Point(70, 62);
            this.startSomeSecs.Name = "startSomeSecs";
            this.startSomeSecs.Size = new System.Drawing.Size(207, 23);
            this.startSomeSecs.TabIndex = 1;
            this.startSomeSecs.Text = "Start Processs some secs";
            this.startSomeSecs.UseVisualStyleBackColor = true;
            this.startSomeSecs.Click += new System.EventHandler(this.startSomeSecs_Click);
            // 
            // printfile
            // 
            this.printfile.Location = new System.Drawing.Point(70, 91);
            this.printfile.Name = "printfile";
            this.printfile.Size = new System.Drawing.Size(207, 23);
            this.printfile.TabIndex = 2;
            this.printfile.Text = "Print File";
            this.printfile.UseVisualStyleBackColor = true;
            this.printfile.Click += new System.EventHandler(this.printfile_Click);
            // 
            // exitProcess
            // 
            this.exitProcess.Location = new System.Drawing.Point(70, 120);
            this.exitProcess.Name = "exitProcess";
            this.exitProcess.Size = new System.Drawing.Size(207, 23);
            this.exitProcess.TabIndex = 3;
            this.exitProcess.Text = "Exit Process";
            this.exitProcess.UseVisualStyleBackColor = true;
            this.exitProcess.Click += new System.EventHandler(this.exitProcess_Click);
            // 
            // showRunning
            // 
            this.showRunning.Location = new System.Drawing.Point(70, 149);
            this.showRunning.Name = "showRunning";
            this.showRunning.Size = new System.Drawing.Size(207, 23);
            this.showRunning.TabIndex = 4;
            this.showRunning.Text = "Show running Process";
            this.showRunning.UseVisualStyleBackColor = true;
            this.showRunning.Click += new System.EventHandler(this.showRunning_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(248, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Threads";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 37);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(309, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button showRunning;
        private System.Windows.Forms.Button exitProcess;
        private System.Windows.Forms.Button printfile;
        private System.Windows.Forms.Button startSomeSecs;
        private System.Windows.Forms.Button startForever;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

