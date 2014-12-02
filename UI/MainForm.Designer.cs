namespace UI
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tagPreproccess = new System.Windows.Forms.TabPage();
            this.tagClassify = new System.Windows.Forms.TabPage();
            this.tabCluster = new System.Windows.Forms.TabPage();
            this.tabAssociate = new System.Windows.Forms.TabPage();
            this.tabSelectAttributes = new System.Windows.Forms.TabPage();
            this.tabVisualize = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnOpenURL = new System.Windows.Forms.Button();
            this.btnOpenDB = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gboxFilter = new System.Windows.Forms.GroupBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtChoose = new System.Windows.Forms.TextBox();
            this.gboxCurrent = new System.Windows.Forms.GroupBox();
            this.txtRelation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRelationContent = new System.Windows.Forms.Label();
            this.txtInstances = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAttributes = new System.Windows.Forms.Label();
            this.gboxAttribute = new System.Windows.Forms.GroupBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tagPreproccess.SuspendLayout();
            this.tagClassify.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gboxFilter.SuspendLayout();
            this.gboxCurrent.SuspendLayout();
            this.gboxAttribute.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tagPreproccess);
            this.tabControl1.Controls.Add(this.tagClassify);
            this.tabControl1.Controls.Add(this.tabCluster);
            this.tabControl1.Controls.Add(this.tabAssociate);
            this.tabControl1.Controls.Add(this.tabSelectAttributes);
            this.tabControl1.Controls.Add(this.tabVisualize);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 519);
            this.tabControl1.TabIndex = 0;
            // 
            // tagPreproccess
            // 
            this.tagPreproccess.Controls.Add(this.panel1);
            this.tagPreproccess.Location = new System.Drawing.Point(4, 22);
            this.tagPreproccess.Name = "tagPreproccess";
            this.tagPreproccess.Padding = new System.Windows.Forms.Padding(3);
            this.tagPreproccess.Size = new System.Drawing.Size(859, 493);
            this.tagPreproccess.TabIndex = 0;
            this.tagPreproccess.Text = "Preproccess";
            this.tagPreproccess.UseVisualStyleBackColor = true;
            // 
            // tagClassify
            // 
            this.tagClassify.Controls.Add(this.panel2);
            this.tagClassify.Location = new System.Drawing.Point(4, 22);
            this.tagClassify.Name = "tagClassify";
            this.tagClassify.Padding = new System.Windows.Forms.Padding(3);
            this.tagClassify.Size = new System.Drawing.Size(859, 493);
            this.tagClassify.TabIndex = 1;
            this.tagClassify.Text = "Classify";
            this.tagClassify.UseVisualStyleBackColor = true;
            // 
            // tabCluster
            // 
            this.tabCluster.Location = new System.Drawing.Point(4, 22);
            this.tabCluster.Name = "tabCluster";
            this.tabCluster.Padding = new System.Windows.Forms.Padding(3);
            this.tabCluster.Size = new System.Drawing.Size(859, 493);
            this.tabCluster.TabIndex = 2;
            this.tabCluster.Text = "Cluster";
            this.tabCluster.UseVisualStyleBackColor = true;
            // 
            // tabAssociate
            // 
            this.tabAssociate.Location = new System.Drawing.Point(4, 22);
            this.tabAssociate.Name = "tabAssociate";
            this.tabAssociate.Padding = new System.Windows.Forms.Padding(3);
            this.tabAssociate.Size = new System.Drawing.Size(859, 432);
            this.tabAssociate.TabIndex = 3;
            this.tabAssociate.Text = "Associate";
            this.tabAssociate.UseVisualStyleBackColor = true;
            // 
            // tabSelectAttributes
            // 
            this.tabSelectAttributes.Location = new System.Drawing.Point(4, 22);
            this.tabSelectAttributes.Name = "tabSelectAttributes";
            this.tabSelectAttributes.Padding = new System.Windows.Forms.Padding(3);
            this.tabSelectAttributes.Size = new System.Drawing.Size(859, 432);
            this.tabSelectAttributes.TabIndex = 4;
            this.tabSelectAttributes.Text = "Select Attributes";
            this.tabSelectAttributes.UseVisualStyleBackColor = true;
            // 
            // tabVisualize
            // 
            this.tabVisualize.Location = new System.Drawing.Point(4, 22);
            this.tabVisualize.Name = "tabVisualize";
            this.tabVisualize.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisualize.Size = new System.Drawing.Size(859, 493);
            this.tabVisualize.TabIndex = 5;
            this.tabVisualize.Text = "Visualize";
            this.tabVisualize.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.gboxAttribute);
            this.panel1.Controls.Add(this.gboxCurrent);
            this.panel1.Controls.Add(this.gboxFilter);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnUndo);
            this.panel1.Controls.Add(this.btnOpenDB);
            this.panel1.Controls.Add(this.btnOpenURL);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 493);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(6, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 490);
            this.panel2.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(11, 18);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(126, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open file...";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnOpenURL
            // 
            this.btnOpenURL.Location = new System.Drawing.Point(157, 18);
            this.btnOpenURL.Name = "btnOpenURL";
            this.btnOpenURL.Size = new System.Drawing.Size(126, 23);
            this.btnOpenURL.TabIndex = 0;
            this.btnOpenURL.Text = "Open URL...";
            this.btnOpenURL.UseVisualStyleBackColor = true;
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.Location = new System.Drawing.Point(298, 18);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.Size = new System.Drawing.Size(126, 23);
            this.btnOpenDB.TabIndex = 0;
            this.btnOpenDB.Text = "Open DB...";
            this.btnOpenDB.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(444, 18);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(126, 23);
            this.btnUndo.TabIndex = 0;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(587, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(126, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit...";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(726, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save...";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // gboxFilter
            // 
            this.gboxFilter.Controls.Add(this.txtChoose);
            this.gboxFilter.Controls.Add(this.btnApply);
            this.gboxFilter.Controls.Add(this.btnChoose);
            this.gboxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxFilter.Location = new System.Drawing.Point(12, 49);
            this.gboxFilter.Name = "gboxFilter";
            this.gboxFilter.Size = new System.Drawing.Size(840, 49);
            this.gboxFilter.TabIndex = 1;
            this.gboxFilter.TabStop = false;
            this.gboxFilter.Text = "Filter";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(6, 19);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(92, 23);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(764, 17);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(70, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // txtChoose
            // 
            this.txtChoose.Location = new System.Drawing.Point(104, 20);
            this.txtChoose.Name = "txtChoose";
            this.txtChoose.Size = new System.Drawing.Size(635, 22);
            this.txtChoose.TabIndex = 2;
            // 
            // gboxCurrent
            // 
            this.gboxCurrent.Controls.Add(this.label2);
            this.gboxCurrent.Controls.Add(this.label1);
            this.gboxCurrent.Controls.Add(this.txtAttributes);
            this.gboxCurrent.Controls.Add(this.txtInstances);
            this.gboxCurrent.Controls.Add(this.txtRelationContent);
            this.gboxCurrent.Controls.Add(this.txtRelation);
            this.gboxCurrent.Location = new System.Drawing.Point(10, 104);
            this.gboxCurrent.Name = "gboxCurrent";
            this.gboxCurrent.Size = new System.Drawing.Size(434, 60);
            this.gboxCurrent.TabIndex = 2;
            this.gboxCurrent.TabStop = false;
            this.gboxCurrent.Text = "Current relation";
            // 
            // txtRelation
            // 
            this.txtRelation.AutoSize = true;
            this.txtRelation.Location = new System.Drawing.Point(38, 20);
            this.txtRelation.Name = "txtRelation";
            this.txtRelation.Size = new System.Drawing.Size(49, 13);
            this.txtRelation.TabIndex = 0;
            this.txtRelation.Text = "Relation:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instances:";
            // 
            // txtRelationContent
            // 
            this.txtRelationContent.AutoSize = true;
            this.txtRelationContent.Location = new System.Drawing.Point(93, 20);
            this.txtRelationContent.Name = "txtRelationContent";
            this.txtRelationContent.Size = new System.Drawing.Size(33, 13);
            this.txtRelationContent.TabIndex = 0;
            this.txtRelationContent.Text = "None";
            // 
            // txtInstances
            // 
            this.txtInstances.AutoSize = true;
            this.txtInstances.Location = new System.Drawing.Point(94, 40);
            this.txtInstances.Name = "txtInstances";
            this.txtInstances.Size = new System.Drawing.Size(33, 13);
            this.txtInstances.TabIndex = 0;
            this.txtInstances.Text = "None";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Attributes:";
            // 
            // txtAttributes
            // 
            this.txtAttributes.AutoSize = true;
            this.txtAttributes.Location = new System.Drawing.Point(350, 40);
            this.txtAttributes.Name = "txtAttributes";
            this.txtAttributes.Size = new System.Drawing.Size(33, 13);
            this.txtAttributes.TabIndex = 0;
            this.txtAttributes.Text = "None";
            // 
            // gboxAttribute
            // 
            this.gboxAttribute.Controls.Add(this.btnRemove);
            this.gboxAttribute.Controls.Add(this.btnInvert);
            this.gboxAttribute.Controls.Add(this.btnNone);
            this.gboxAttribute.Controls.Add(this.btnAll);
            this.gboxAttribute.Location = new System.Drawing.Point(12, 170);
            this.gboxAttribute.Name = "gboxAttribute";
            this.gboxAttribute.Size = new System.Drawing.Size(432, 317);
            this.gboxAttribute.TabIndex = 3;
            this.gboxAttribute.TabStop = false;
            this.gboxAttribute.Text = "Attributes";
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(39, 20);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(105, 23);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(166, 20);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(105, 23);
            this.btnNone.TabIndex = 0;
            this.btnNone.Text = "None";
            this.btnNone.UseVisualStyleBackColor = true;
            // 
            // btnInvert
            // 
            this.btnInvert.Location = new System.Drawing.Point(307, 20);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(105, 23);
            this.btnInvert.TabIndex = 0;
            this.btnInvert.Text = "Invert";
            this.btnInvert.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(9, 279);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(417, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 531);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Weka Explorer";
            this.tabControl1.ResumeLayout(false);
            this.tagPreproccess.ResumeLayout(false);
            this.tagClassify.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gboxFilter.ResumeLayout(false);
            this.gboxFilter.PerformLayout();
            this.gboxCurrent.ResumeLayout(false);
            this.gboxCurrent.PerformLayout();
            this.gboxAttribute.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tagPreproccess;
        private System.Windows.Forms.TabPage tagClassify;
        private System.Windows.Forms.TabPage tabCluster;
        private System.Windows.Forms.TabPage tabAssociate;
        private System.Windows.Forms.TabPage tabSelectAttributes;
        private System.Windows.Forms.TabPage tabVisualize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnOpenDB;
        private System.Windows.Forms.Button btnOpenURL;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gboxFilter;
        private System.Windows.Forms.TextBox txtChoose;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.GroupBox gboxCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtInstances;
        private System.Windows.Forms.Label txtRelationContent;
        private System.Windows.Forms.Label txtRelation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtAttributes;
        private System.Windows.Forms.GroupBox gboxAttribute;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnAll;
    }
}

