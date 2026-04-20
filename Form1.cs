namespace File_Explorer_System
{
    public partial class Form1 : Form
    {
        int currentFile = 0;
        int NumberofFiles = 0;
        int speedDelay = 0;
        private readonly List<Document> documents = [];
        private readonly List<Images> images = [];
        private readonly List<Videos> videos = [];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddDocument();
            AddImages();
            AddVideos();
            Dm_filetype.SelectedIndex = 0;
            lbl_Progress.Text = "";
        }

        public void AddDocument()
        {
            documents.Add(new Document { Id = 1, Name = "Reports1", Type = "txt", Size = "1MB" });
            documents.Add(new Document { Id = 2, Name = "Reports2", Type = "txt", Size = "2MB" });
            documents.Add(new Document { Id = 3, Name = "Reports3", Type = "txt", Size = "3MB" });
            documents.Add(new Document { Id = 4, Name = "Notes1", Type = "docx", Size = "4MB" });
            documents.Add(new Document { Id = 5, Name = "Notes2", Type = "docx", Size = "5MB" });
            documents.Add(new Document { Id = 6, Name = "Notes3", Type = "docx", Size = "6MB" });
            documents.Add(new Document { Id = 7, Name = "Orders1", Type = "xlsx", Size = "7MB" });
            documents.Add(new Document { Id = 8, Name = "Orders2", Type = "xlsx", Size = "8MB" });
            documents.Add(new Document { Id = 9, Name = "Orders3", Type = "xlsx", Size = "9MB" });

        }

        private void AddImages()
        {
            images.Add(new Images { Id = 1, Name = "Photo", Type = "jpg", Size = "1MB" });
            images.Add(new Images { Id = 2, Name = "Photo2", Type = "jpg", Size = "2MB" });
            images.Add(new Images { Id = 3, Name = "Photo3", Type = "jpg", Size = "3MB" });
            images.Add(new Images { Id = 4, Name = "Screenshot4", Type = "png", Size = "4MB" });
            images.Add(new Images { Id = 5, Name = "Screenshot5", Type = "png", Size = "5MB" });
            images.Add(new Images { Id = 6, Name = "Screenshot6", Type = "png", Size = "6MB" });
            images.Add(new Images { Id = 7, Name = "Scans7", Type = "jpeg", Size = "7MB" });
            images.Add(new Images { Id = 8, Name = "Scans8", Type = "jpeg", Size = "8MB" });
            images.Add(new Images { Id = 9, Name = "Scans9", Type = "jpeg", Size = "9MB" });
        }

        private void AddVideos()
        {
            videos.Add(new Videos { Id = 1, Name = "Movies1", Type = "mp4", Size = "10MB" });
            videos.Add(new Videos { Id = 2, Name = "Movies2", Type = "mp4", Size = "20MB" });
            videos.Add(new Videos { Id = 3, Name = "Movies3", Type = "mp4", Size = "30MB" });
            videos.Add(new Videos { Id = 4, Name = "Clips4", Type = "avi", Size = "40MB" });
            videos.Add(new Videos { Id = 5, Name = "Clips5", Type = "avi", Size = "50MB" });
            videos.Add(new Videos { Id = 6, Name = "Clips6", Type = "avi", Size = "60MB" });
            videos.Add(new Videos { Id = 7, Name = "Recordings7", Type = "mkv", Size = "70MB" });
            videos.Add(new Videos { Id = 8, Name = "Recordings8", Type = "mkv", Size = "80MB" });
            videos.Add(new Videos { Id = 9, Name = "Recordings9", Type = "mkv", Size = "90MB" });
        }

        private void Tree_folder_AfterSelect(object sender, TreeViewEventArgs e)
        {

            View_folder.Items.Clear();
            if (e.Node != null)
            {
                switch (e.Node.Text)
                {
                    case "Documents":
                        foreach (var doc in documents)
                        {
                            ListViewItem item = new(doc.Name);
                            item.SubItems.Add(doc.Type);
                            item.SubItems.Add(doc.Size);
                            View_folder.Items.Add(item);
                        }
                        break;
                    case "Reports":
                        foreach (var doc in documents.Where(d => d.Name.StartsWith("Reports")))
                        {
                            ListViewItem item = new(doc.Name);
                            item.SubItems.Add(doc.Type);
                            item.SubItems.Add(doc.Size);
                            View_folder.Items.Add(item);
                        }
                        break;
                    case "Notes":
                        foreach (var doc in documents.Where(d => d.Name.StartsWith("Notes")))
                        {
                            ListViewItem item = new(doc.Name);
                            item.SubItems.Add(doc.Type);
                            item.SubItems.Add(doc.Size);
                            View_folder.Items.Add(item);
                        }
                        break;
                    case "Orders":
                        foreach (var doc in documents.Where(d => d.Name.StartsWith("Orders")))
                        {
                            ListViewItem item = new(doc.Name);
                            item.SubItems.Add(doc.Type);
                            item.SubItems.Add(doc.Size);
                            View_folder.Items.Add(item);
                        }
                        break;
                    case "Images":
                        foreach (var img in images)
                        {
                            ListViewItem item = new(img.Name);
                            item.SubItems.Add(img.Type);
                            item.SubItems.Add(img.Size);
                            View_folder.Items.Add(item);
                        }
                        break;
                    case "Photos":
                        foreach (var img in images.Where(i => i.Name.StartsWith("Photo")))
                        {
                            ListViewItem item = new(img.Name);
                            item.SubItems.Add(img.Type);
                            item.SubItems.Add(img.Size);
                            View_folder.Items.Add(item);
                        }
                        break;
                    case "Screenshots":
                        foreach (var img in images.Where(i => i.Name.StartsWith("Screenshot")))
                        {
                            ListViewItem item = new(img.Name);
                            item.SubItems.Add(img.Type);
                            item.SubItems.Add(img.Size);
                            View_folder.Items.Add(item);
                        }
                        break;
                    case "Scans":
                        foreach (var img in images.Where(i => i.Name.StartsWith("Scans")))
                        {
                            ListViewItem item = new(img.Name);
                            item.SubItems.Add(img.Type);
                            item.SubItems.Add(img.Size);
                            View_folder.Items.Add(item);
                        }
                        break;
                    case "Videos":
                        foreach (var vid in videos)
                        {
                            ListViewItem item = new(vid.Name);
                            item.SubItems.Add(vid.Type);
                            item.SubItems.Add(vid.Size);
                            View_folder.Items.Add(item);
                        }
                        break;
                    case "Movies":
                        foreach (var vid in videos.Where(v => v.Name.StartsWith("Movies")))
                        {
                            ListViewItem item = new(vid.Name);
                            item.SubItems.Add(vid.Type);
                            item.SubItems.Add(vid.Size);
                            View_folder.Items.Add(item);
                        }
                        break;
                    case "Clips":
                        foreach (var vid in videos.Where(v => v.Name.StartsWith("Clips")))
                        {
                            ListViewItem item = new(vid.Name);
                            item.SubItems.Add(vid.Type);
                            item.SubItems.Add(vid.Size);
                            View_folder.Items.Add(item);
                        }
                        break;
                    case "Recordings":
                        foreach (var vid in videos.Where(v => v.Name.StartsWith("Recordings")))
                        {
                            ListViewItem item = new(vid.Name);
                            item.SubItems.Add(vid.Type);
                            item.SubItems.Add(vid.Size);
                            View_folder.Items.Add(item);
                        }
                        break;
                }
            }
        }

        private void Dm_filetype_TextChanged(object sender, EventArgs e)
        {
            View_folder.Items.Clear();
            if (e != null)
            {
                switch (Dm_filetype.Text)
                {
                    case "Text Files":
                        foreach (var doc in documents)
                        {
                            ListViewItem item = new(doc.Name);
                            item.SubItems.Add(doc.Type);
                            item.SubItems.Add(doc.Size);
                            View_folder.Items.Add(item);
                        }
                        break;
                    case "Image Files":
                        foreach (var img in images)
                        {
                            ListViewItem item = new(img.Name);
                            item.SubItems.Add(img.Type);
                            item.SubItems.Add(img.Size);
                            View_folder.Items.Add(item);
                        }
                        break;
                    case "Video Files":
                        foreach (var vid in videos)
                        {
                            ListViewItem item = new(vid.Name);
                            item.SubItems.Add(vid.Type);
                            item.SubItems.Add(vid.Size);
                            View_folder.Items.Add(item);
                        }
                        break;
                    default:
                        return;
                }
            }
        }
        private void Btn_start_Click(object sender, EventArgs e)
        {
            if (Dm_filetype.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a file type to download.");
                return;
            }
            if (Nm_files.Value <= 0)
            {
                MessageBox.Show("Please select a valid number of files to download.");
                return;
            }
            Btn_start.Enabled = false;
            Tree_folder.Enabled = false;
            View_folder.Enabled = false;
            Nm_files.Enabled = false;
            Tb_speed.Enabled = false;
            lbl_Progress.Text = "";
            try
            {
                NumberofFiles = (int)Nm_files.Value;
                speedDelay = (int)Tb_speed.Value;
                int delayms = (11 - speedDelay) * 100;
                Timer_download.Interval = delayms;
                Prog_download.Maximum = NumberofFiles;
                Prog_download.Value = 0;
                currentFile = 0;
                Timer_download.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                Btn_start.Enabled = true;
                Tree_folder.Enabled = true;
                View_folder.Enabled = true;
                Nm_files.Enabled = true;
                Tb_speed.Enabled = true;
            }
        }

        private void Timer_download_Tick(object sender, EventArgs e)
        {

            if (currentFile < NumberofFiles)
            {
                currentFile++;
                Prog_download.Value = currentFile;
                int percentage = (int)((double)currentFile / NumberofFiles * 100);
                lbl_Progress.Text = $"Downloading file {currentFile} of {NumberofFiles} " + $"at speed {speedDelay} ({percentage}%)";
            }
            else
            {
                Timer_download.Stop();
                Btn_start.Enabled = true;
                Tree_folder.Enabled = true;
                View_folder.Enabled = true;
                Nm_files.Enabled = true;
                Tb_speed.Enabled = true;
                lbl_Progress.Text = "Download complete! (100%)";
                Prog_download.Value = Prog_download.Maximum;
            }
        }
        private class Document
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Type { get; set; } = string.Empty;
            public string Size { get; set; } = string.Empty;
        }

        private class Images
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Type { get; set; } = string.Empty;
            public string Size { get; set; } = string.Empty;
        }

        private class Videos
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Type { get; set; } = string.Empty;
            public string Size { get; set; } = string.Empty;
        }
    }
}
