namespace 陈登佳文件与项目管理系统
{
	partial class NewVersionForm
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
			this.btnNotSave = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblVersionName = new System.Windows.Forms.Label();
			this.tbVersionName = new System.Windows.Forms.TextBox();
			this.lblSubmitter = new System.Windows.Forms.Label();
			this.lblFaVersion = new System.Windows.Forms.Label();
			this.lblIntroduction = new System.Windows.Forms.Label();
			this.tbSubmitter = new System.Windows.Forms.TextBox();
			this.tbIntroduction = new System.Windows.Forms.TextBox();
			this.lblNowFaName = new System.Windows.Forms.Label();
			this.btnDeselectFa = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(38, 243);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(450, 300);
			this.treeView1.TabIndex = 0;
			// 
			// btnNotSave
			// 
			this.btnNotSave.Location = new System.Drawing.Point(413, 549);
			this.btnNotSave.Name = "btnNotSave";
			this.btnNotSave.Size = new System.Drawing.Size(75, 39);
			this.btnNotSave.TabIndex = 1;
			this.btnNotSave.Text = "取消";
			this.btnNotSave.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(311, 549);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 39);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "保存";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// lblVersionName
			// 
			this.lblVersionName.AutoSize = true;
			this.lblVersionName.Location = new System.Drawing.Point(38, 13);
			this.lblVersionName.Name = "lblVersionName";
			this.lblVersionName.Size = new System.Drawing.Size(67, 15);
			this.lblVersionName.TabIndex = 2;
			this.lblVersionName.Text = "版本名称";
			// 
			// tbVersionName
			// 
			this.tbVersionName.Location = new System.Drawing.Point(41, 47);
			this.tbVersionName.Name = "tbVersionName";
			this.tbVersionName.Size = new System.Drawing.Size(447, 25);
			this.tbVersionName.TabIndex = 3;
			// 
			// lblSubmitter
			// 
			this.lblSubmitter.AutoSize = true;
			this.lblSubmitter.Location = new System.Drawing.Point(38, 91);
			this.lblSubmitter.Name = "lblSubmitter";
			this.lblSubmitter.Size = new System.Drawing.Size(52, 15);
			this.lblSubmitter.TabIndex = 4;
			this.lblSubmitter.Text = "提交人";
			// 
			// lblFaVersion
			// 
			this.lblFaVersion.AutoSize = true;
			this.lblFaVersion.Location = new System.Drawing.Point(38, 202);
			this.lblFaVersion.Name = "lblFaVersion";
			this.lblFaVersion.Size = new System.Drawing.Size(52, 15);
			this.lblFaVersion.TabIndex = 5;
			this.lblFaVersion.Text = "父版本";
			// 
			// lblIntroduction
			// 
			this.lblIntroduction.AutoSize = true;
			this.lblIntroduction.Location = new System.Drawing.Point(253, 91);
			this.lblIntroduction.Name = "lblIntroduction";
			this.lblIntroduction.Size = new System.Drawing.Size(67, 15);
			this.lblIntroduction.TabIndex = 6;
			this.lblIntroduction.Text = "版本说明";
			// 
			// tbSubmitter
			// 
			this.tbSubmitter.Location = new System.Drawing.Point(41, 129);
			this.tbSubmitter.Name = "tbSubmitter";
			this.tbSubmitter.Size = new System.Drawing.Size(153, 25);
			this.tbSubmitter.TabIndex = 7;
			// 
			// tbIntroduction
			// 
			this.tbIntroduction.Location = new System.Drawing.Point(256, 122);
			this.tbIntroduction.Multiline = true;
			this.tbIntroduction.Name = "tbIntroduction";
			this.tbIntroduction.Size = new System.Drawing.Size(232, 107);
			this.tbIntroduction.TabIndex = 8;
			// 
			// lblNowFaName
			// 
			this.lblNowFaName.AutoEllipsis = true;
			this.lblNowFaName.Location = new System.Drawing.Point(19, 552);
			this.lblNowFaName.Name = "lblNowFaName";
			this.lblNowFaName.Size = new System.Drawing.Size(261, 39);
			this.lblNowFaName.TabIndex = 9;
			this.lblNowFaName.Text = "当前父版本：";
			// 
			// btnDeselectFa
			// 
			this.btnDeselectFa.Location = new System.Drawing.Point(119, 192);
			this.btnDeselectFa.Name = "btnDeselectFa";
			this.btnDeselectFa.Size = new System.Drawing.Size(75, 37);
			this.btnDeselectFa.TabIndex = 10;
			this.btnDeselectFa.Text = "取消选择";
			this.btnDeselectFa.UseVisualStyleBackColor = true;
			// 
			// NewVersionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 600);
			this.Controls.Add(this.btnDeselectFa);
			this.Controls.Add(this.lblNowFaName);
			this.Controls.Add(this.tbIntroduction);
			this.Controls.Add(this.tbSubmitter);
			this.Controls.Add(this.lblIntroduction);
			this.Controls.Add(this.lblFaVersion);
			this.Controls.Add(this.lblSubmitter);
			this.Controls.Add(this.tbVersionName);
			this.Controls.Add(this.lblVersionName);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnNotSave);
			this.Controls.Add(this.treeView1);
			this.Name = "NewVersionForm";
			this.Text = "新建版本";
			this.Load += new System.EventHandler(this.NewVersionForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Button btnNotSave;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblVersionName;
		private System.Windows.Forms.TextBox tbVersionName;
		private System.Windows.Forms.Label lblSubmitter;
		private System.Windows.Forms.Label lblFaVersion;
		private System.Windows.Forms.Label lblIntroduction;
		private System.Windows.Forms.TextBox tbSubmitter;
		private System.Windows.Forms.TextBox tbIntroduction;
		private System.Windows.Forms.Label lblNowFaName;
		private System.Windows.Forms.Button btnDeselectFa;
	}
}