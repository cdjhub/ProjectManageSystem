namespace 陈登佳文件与项目管理系统
{
	partial class ClassChooseForm
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
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnNotSave = new System.Windows.Forms.Button();
			this.btnNewClass = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.lblNowClass = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(10, 10);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(500, 350);
			this.treeView1.TabIndex = 0;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(324, 453);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 40);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "确定";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnNotSave
			// 
			this.btnNotSave.Location = new System.Drawing.Point(420, 453);
			this.btnNotSave.Name = "btnNotSave";
			this.btnNotSave.Size = new System.Drawing.Size(75, 40);
			this.btnNotSave.TabIndex = 2;
			this.btnNotSave.Text = "取消";
			this.btnNotSave.UseVisualStyleBackColor = true;
			// 
			// btnNewClass
			// 
			this.btnNewClass.Location = new System.Drawing.Point(54, 439);
			this.btnNewClass.Name = "btnNewClass";
			this.btnNewClass.Size = new System.Drawing.Size(121, 40);
			this.btnNewClass.TabIndex = 3;
			this.btnNewClass.Text = "新建分类";
			this.btnNewClass.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(29, 485);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(179, 19);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "使用选中分类为父分类";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// lblNowClass
			// 
			this.lblNowClass.AutoSize = true;
			this.lblNowClass.Location = new System.Drawing.Point(13, 382);
			this.lblNowClass.Name = "lblNowClass";
			this.lblNowClass.Size = new System.Drawing.Size(82, 15);
			this.lblNowClass.TabIndex = 5;
			this.lblNowClass.Text = "当前分类：";
			// 
			// ClassChooseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 520);
			this.Controls.Add(this.lblNowClass);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.btnNewClass);
			this.Controls.Add(this.btnNotSave);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.treeView1);
			this.Name = "ClassChooseForm";
			this.Text = "选择分类";
			this.Load += new System.EventHandler(this.ClassChooseForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnNotSave;
		private System.Windows.Forms.Button btnNewClass;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label lblNowClass;
	}
}