namespace File_Explorer_System
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
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("Reports");
            TreeNode treeNode2 = new TreeNode("Notes");
            TreeNode treeNode3 = new TreeNode("Orders");
            TreeNode treeNode4 = new TreeNode("Documents", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Photos");
            TreeNode treeNode6 = new TreeNode("Screenshots");
            TreeNode treeNode7 = new TreeNode("Scans");
            TreeNode treeNode8 = new TreeNode("Images", new TreeNode[] { treeNode5, treeNode6, treeNode7 });
            TreeNode treeNode9 = new TreeNode("Movies");
            TreeNode treeNode10 = new TreeNode("Clips");
            TreeNode treeNode11 = new TreeNode("Recordings");
            TreeNode treeNode12 = new TreeNode("Videos", new TreeNode[] { treeNode9, treeNode10, treeNode11 });
            label1 = new Label();
            panel1 = new Panel();
            lbl_Progress = new Label();
            Tb_speed = new TrackBar();
            Nm_files = new NumericUpDown();
            Dm_filetype = new DomainUpDown();
            Prog_download = new ProgressBar();
            Btn_reset = new Button();
            Btn_start = new Button();
            label4 = new Label();
            Tree_folder = new TreeView();
            label3 = new Label();
            label2 = new Label();
            View_folder = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            Timer_download = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tb_speed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Nm_files).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(93, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 32);
            label1.TabIndex = 0;
            label1.Text = "FILE EXPLORER SYSTEM";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_Progress);
            panel1.Controls.Add(Tb_speed);
            panel1.Controls.Add(Nm_files);
            panel1.Controls.Add(Dm_filetype);
            panel1.Controls.Add(Prog_download);
            panel1.Controls.Add(Btn_reset);
            panel1.Controls.Add(Btn_start);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Tree_folder);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(View_folder);
            panel1.Location = new Point(12, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 457);
            panel1.TabIndex = 1;
            // 
            // lbl_Progress
            // 
            lbl_Progress.AutoSize = true;
            lbl_Progress.Location = new Point(25, 400);
            lbl_Progress.Name = "lbl_Progress";
            lbl_Progress.Size = new Size(20, 15);
            lbl_Progress.TabIndex = 12;
            lbl_Progress.Text = "lbl";
            // 
            // Tb_speed
            // 
            Tb_speed.LargeChange = 4;
            Tb_speed.Location = new Point(152, 312);
            Tb_speed.Minimum = 1;
            Tb_speed.Name = "Tb_speed";
            Tb_speed.Size = new Size(267, 45);
            Tb_speed.TabIndex = 11;
            Tb_speed.Value = 1;
            // 
            // Nm_files
            // 
            Nm_files.Location = new Point(152, 281);
            Nm_files.Name = "Nm_files";
            Nm_files.Size = new Size(267, 23);
            Nm_files.TabIndex = 10;
            // 
            // Dm_filetype
            // 
            Dm_filetype.Items.Add("<-- select -->");
            Dm_filetype.Items.Add("Image Files");
            Dm_filetype.Items.Add("Text Files");
            Dm_filetype.Items.Add("Video Files");
            Dm_filetype.Location = new Point(152, 250);
            Dm_filetype.Name = "Dm_filetype";
            Dm_filetype.ReadOnly = true;
            Dm_filetype.Size = new Size(267, 23);
            Dm_filetype.Sorted = true;
            Dm_filetype.TabIndex = 9;
            Dm_filetype.TextChanged += Dm_filetype_TextChanged;
            // 
            // Prog_download
            // 
            Prog_download.Location = new Point(25, 418);
            Prog_download.Name = "Prog_download";
            Prog_download.Size = new Size(394, 23);
            Prog_download.TabIndex = 8;
            // 
            // Btn_reset
            // 
            Btn_reset.Location = new Point(233, 364);
            Btn_reset.Name = "Btn_reset";
            Btn_reset.Size = new Size(130, 31);
            Btn_reset.TabIndex = 7;
            Btn_reset.Text = "RESET";
            Btn_reset.UseVisualStyleBackColor = true;
            // 
            // Btn_start
            // 
            Btn_start.Location = new Point(72, 364);
            Btn_start.Name = "Btn_start";
            Btn_start.Size = new Size(130, 31);
            Btn_start.TabIndex = 6;
            Btn_start.Text = "START";
            Btn_start.UseVisualStyleBackColor = true;
            Btn_start.Click += Btn_start_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 312);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 5;
            label4.Text = "Speed";
            // 
            // Tree_folder
            // 
            Tree_folder.Location = new Point(25, 13);
            Tree_folder.Name = "Tree_folder";
            treeNode1.Name = "Doc_report";
            treeNode1.Text = "Reports";
            treeNode2.Name = "Doc_notes";
            treeNode2.Text = "Notes";
            treeNode3.Name = "Doc_po";
            treeNode3.Text = "Orders";
            treeNode4.Name = "Node_doc";
            treeNode4.Text = "Documents";
            treeNode5.Name = "Image_photo";
            treeNode5.Text = "Photos";
            treeNode6.Name = "Image_screenshot";
            treeNode6.Text = "Screenshots";
            treeNode7.Name = "Image_scan";
            treeNode7.Text = "Scans";
            treeNode8.Name = "Node_image";
            treeNode8.Text = "Images";
            treeNode9.Name = "Video_movies";
            treeNode9.Text = "Movies";
            treeNode10.Name = "Video_clips";
            treeNode10.Text = "Clips";
            treeNode11.Name = "Video_records";
            treeNode11.Text = "Recordings";
            treeNode12.Name = "Node_videos";
            treeNode12.Text = "Videos";
            Tree_folder.Nodes.AddRange(new TreeNode[] { treeNode4, treeNode8, treeNode12 });
            Tree_folder.Size = new Size(121, 228);
            Tree_folder.TabIndex = 4;
            Tree_folder.AfterSelect += Tree_folder_AfterSelect;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 282);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 3;
            label3.Text = "Files";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 252);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "File Type";
            // 
            // View_folder
            // 
            View_folder.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            View_folder.Location = new Point(152, 13);
            View_folder.Name = "View_folder";
            View_folder.Size = new Size(267, 228);
            View_folder.TabIndex = 1;
            View_folder.UseCompatibleStateImageBehavior = false;
            View_folder.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "File Name";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "File Type";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "File Size";
            // 
            // Timer_download
            // 
            Timer_download.Tick += Timer_download_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 552);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FILE EXPLORER SYSTEM";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Tb_speed).EndInit();
            ((System.ComponentModel.ISupportInitialize)Nm_files).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ListView View_folder;
        private Label label3;
        private Label label2;
        private TreeView Tree_folder;
        private NumericUpDown Nm_files;
        private DomainUpDown Dm_filetype;
        private ProgressBar Prog_download;
        private Button Btn_reset;
        private Button Btn_start;
        private Label label4;
        private TrackBar Tb_speed;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label lbl_Progress;
        private System.Windows.Forms.Timer Timer_download;
    }
}
