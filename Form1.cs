using System;
using System.Drawing;
using System.Windows.Forms;
using OrderedNotes.Properties;
using System.Collections.Generic;

namespace OrderedNotes
{
    public partial class MainForm : Form
    {
        private List<Note> notes = new List<Note>();

        public MainForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            new ToolTip().SetToolTip(this.btnTopmost, "Toggle topmost property of this window");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Location = Settings.Default.MainPos;
            this.TopMost = Settings.Default.TopMost;
            this.inSens.Value = Settings.Default.Sensitivity;

            if (this.TopMost)
                this.btnTopmost.Image = Resources.pin_on;
            else
                this.btnTopmost.Image = Resources.pin_off;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.MainPos = this.Location;
            Settings.Default.TopMost = this.TopMost;
            Settings.Default.Sensitivity = (int) this.inSens.Value;

            Settings.Default.Save();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Note note = new Note(notes.Count + 1);

            note.Visible = true;

            notes.Add(note);
            this.Focus();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            notes.RemoveAll(s => s.Visible == false);

            if (notes.Count == 0)
                return;

            notes.Sort(delegate (Note a, Note b) {
                var aCoords = a.getCoords();
                var bCoords = b.getCoords();

                var playRoom = this.inSens.Value;

                var yDiff = bCoords[0] - aCoords[0];
                var xDiff = bCoords[1] - aCoords[1];

                if (yDiff > playRoom)
                    return -1; // prefer first
                else if (yDiff < -playRoom)
                    return 1; // prefer second
                else if (xDiff > playRoom)
                    return -1; // prefer first
                else
                    return 1; // prefer other
            });

            string result = "";

            foreach(Note note in notes)
            {
                result += note.getText() + "\n\n";
                Console.WriteLine(note.Text + ": " + note.getCoords()[0] + " " + note.getCoords()[1]);
            }

            result = result.Trim();

            new Note(result).Show();
        }

        private void btnTopmost_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;

            if (this.TopMost)
                this.btnTopmost.Image = Resources.pin_on;
            else
                this.btnTopmost.Image = Resources.pin_off;
        }
    }

    public class Note : Form
    {
        private RichTextBox tbNote = new RichTextBox();

        public Note(int number)
        {
            this.Text = "Note #" + number;

            this.tbNote.Top = 0;
            this.tbNote.Left = 0;
            this.tbNote.Width = this.Width - 13;
            this.tbNote.Height = this.Height - 38;
            this.tbNote.Font = new Font("Arial", 18, FontStyle.Regular);

            this.Controls.Add(tbNote);
            this.Resize += OnResizeEvent;
        }

        public Note(string result)
        {
            this.Text = "Export";

            this.tbNote.Top = 0;
            this.tbNote.Left = 0;
            this.tbNote.Width = this.Width - 13;
            this.tbNote.Height = this.Height - 38;
            this.tbNote.Font = new Font("Arial", 18, FontStyle.Regular);

            this.Controls.Add(tbNote);
            this.Resize += OnResizeEvent;

            this.tbNote.Text = result;
            this.tbNote.ReadOnly = true;
        }

        public void OnResizeEvent(object sender, EventArgs e)
        {
            this.tbNote.Width = this.Width - 13;
            this.tbNote.Height = this.Height - 38;
        }

        public string getText()
        {
            return this.tbNote.Text;
        }

        public int[] getCoords()
        {
            int[] coords = { this.Top, this.Left };

            return coords;
        }
    }
}
