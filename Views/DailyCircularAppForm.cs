using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using daily_circular_desktop_application_system.Model;
using daily_circular_desktop_application_system.Service;

namespace daily_circular_desktop_application_system.Views
{
    public partial class DailyCircularAppForm : Form
    {
        private static int circularPanelWidth = 830;
        private static int circularPanelHeight = 245;
        private static Font circularTitleFont = new Font("Times New Roman", 16);

        private int selectionType;
        private Circular circular;
        private CircularService circularService;

        public DailyCircularAppForm()
        {
            InitializeComponent();
            this.allCircularPanel.Visible = true;
            this.myCircularPanel.Visible = false;
            this.createCircularPanel.Visible = false;

            this.userFullName.Text = Session.LoggedUser.Fullname;

            this.selectionType = 0;
            this.circular = new Circular();
            this.circularService = new CircularService();

            loadDailyCircularAppHome();
        }

        private void allCircularButton_Click(object sender, EventArgs e)
        {
            this.selectionType = 0;
            this.allCircularPanel.Visible = true;
            this.myCircularPanel.Visible = false;
            this.createCircularPanel.Visible = false;
        }

        private void myCircularButton_Click(object sender, EventArgs e)
        {
            this.selectionType = 1;
            this.allCircularPanel.Visible = false;
            this.myCircularPanel.Visible = true;
            this.createCircularPanel.Visible = false;
        }

        private void createCircularButton_Click(object sender, EventArgs e)
        {
            this.selectionType = 2;
            this.allCircularPanel.Visible = false;
            this.myCircularPanel.Visible = false;
            this.createCircularPanel.Visible = true;
        }

        private void loadDailyCircularAppHome()
        {
            this.allCircularFlowLayoutPanel.Controls.Clear();
            this.myCircularFlowLayoutPanel.Controls.Clear();
            foreach (Circular circular in this.circularService.getAllCirculars())
            {
                this.allCircularFlowLayoutPanel.Controls.Add(
                    createCircularPanelFromCircularObject(circular, 0)
                );
            }

            foreach (Circular circular in this.circularService.getAllCircularsByEmail(
                Session.LoggedUser.Email
            ))
            {
                this.myCircularFlowLayoutPanel.Controls.Add(
                    createCircularPanelFromCircularObject(circular, 1)
                );
            }
        }

        private Panel createCircularPanelFromCircularObject(Circular circular, int flg)
        {

            Panel circularPanel = new Panel();
            circularPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            circularPanel.Size = new Size(circularPanelWidth, circularPanelHeight);
            circularPanel.BackColor = System.Drawing.Color.White;

            // circular title text
            Label circularTitle = new Label();
            circularTitle.Size = new Size(circularPanelWidth, 30);
            circularTitle.Padding = new Padding(5);
            circularTitle.Font = circularTitleFont;
            circularTitle.Text = circular.Title;
            circularTitle.BackColor = System.Drawing.Color.Aqua;

            // circular Date
            Label circularPublishDate = new Label();
            circularPublishDate.Size = new Size(150, 30);
            circularPublishDate.Padding = new Padding(5);
            circularPublishDate.Font = new Font("Times New Roman", 9);
            circularPublishDate.Text = circular.CreatedAt.ToLongDateString();
            circularPublishDate.TextAlign = ContentAlignment.MiddleRight;
            circularPublishDate.BackColor = System.Drawing.Color.Coral;

            // posted by
            Label postedBy = new Label();
            postedBy.Size = new Size(circularPanelWidth, 20);
            postedBy.Font = new Font("Times New Roman", 8);
            postedBy.Text = "By: " + circular.CreatedBy.Fullname;
            postedBy.BackColor = System.Drawing.Color.DarkSeaGreen;
            postedBy.Padding = new Padding(8, 4, 5, 1);

            // circular body text
            Label circularBody = new Label();
            circularBody.Padding = new Padding(5, 10, 5, 5);
            circularBody.Font = new Font("Arial", 10);
            circularBody.Size = new Size(circularPanelWidth, 170);
            circularBody.Text = circular.Body;

            // menu bar
            /*---------------------------------------------------------------*/
            Panel circularMenuBar = new Panel();
            circularMenuBar.Size = new Size(circularPanelWidth, 25);
            // circularMenuBar.BackColor = System.Drawing.Color.LightGreen;

            Button viewButton = new Button();
            viewButton.Text = "View";
            circularMenuBar.Controls.Add(viewButton);

            if (flg == 1)
            {
                // update button
                Button updateButton = new Button();
                updateButton.Text = "Update";
                updateButton.Parent = viewButton;
                updateButton.Dock = DockStyle.Right;
                updateButton.BackColor = System.Drawing.Color.Green;
                updateButton.ForeColor = System.Drawing.Color.White;

                updateButton.Click += (obj, arg) =>
                {
                    const string message = "Are you sure?";
                    const string caption = "Update Circular";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        this.circular = circular;
                        this.textBox1.Text = this.circular.Title;
                        this.richTextBox1.Text = this.circular.Body;

                        this.allCircularPanel.Visible = false;
                        this.myCircularPanel.Visible = false;
                        this.createCircularPanel.Visible = true;
                    }
                };

                circularMenuBar.Controls.Add(updateButton);

                // delete button

                Button deleteButton = new Button();
                deleteButton.Text = "Delete";
                deleteButton.Parent = updateButton;
                deleteButton.Dock = DockStyle.Right;
                deleteButton.BackColor = System.Drawing.Color.Red;
                deleteButton.ForeColor = System.Drawing.Color.White;

                deleteButton.Click += (obj, eArgs) =>
                {
                    const string message = "Are you sure?";
                    const string caption = "Delete Circular";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            this.circularService.deleteCircularById(circular.CircularId);

                            MessageBox.Show("Circular deleted");
                            this.loadDailyCircularAppHome();
                            this.allCircularPanel.Visible = false;
                            this.myCircularPanel.Visible = true;
                            this.createCircularPanel.Visible = false;
                        }
                        catch (Exception excp)
                        {
                            MessageBox.Show("Circular delete failed!!!");
                        }
                    }
                };

                circularMenuBar.Controls.Add(deleteButton);
            }
            /*---------------------------------------------------------------*/

            // add to cicular panel
            circularPanel.Controls.Add(circularTitle);
            circularPanel.Controls.SetChildIndex(circularTitle, 0);

            circularPanel.Controls.Add(circularPublishDate);
            circularPanel.Controls.SetChildIndex(circularPublishDate, 1);

            circularPublishDate.Parent = circularTitle;
            circularPublishDate.Dock = DockStyle.Right;

            postedBy.Parent = circularTitle;
            postedBy.Dock = DockStyle.Bottom;

            circularPanel.Controls.Add(postedBy);
            circularPanel.Controls.SetChildIndex(postedBy, 2);

            circularBody.Parent = postedBy;
            circularBody.Dock = DockStyle.Bottom;

            circularPanel.Controls.Add(circularBody);
            circularPanel.Controls.SetChildIndex(circularBody, 3);

            circularMenuBar.Parent = circularBody;
            circularMenuBar.Dock = DockStyle.Bottom;

            circularPanel.Controls.Add(circularMenuBar);
            circularPanel.Controls.SetChildIndex(circularMenuBar, 4);

            return circularPanel;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to logout?";
            const string caption = "Logout";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.circular.Title = (sender as TextBox).Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.circular.Body = (sender as RichTextBox).Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isVaildCircular() == true)
            {
                if (this.circularService.createCircular(this.circular) == true)
                {
                    MessageBox.Show("Circular Posted");

                    this.textBox1.Clear();
                    this.richTextBox1.Clear();
                    this.circular = new Circular();

                    this.loadDailyCircularAppHome();
                    this.allCircularPanel.Visible = false;
                    this.myCircularPanel.Visible = true;
                    this.createCircularPanel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Failed to post the circular!");
                }
            }
        }

        private bool isVaildCircular()
        {
            if (string.IsNullOrEmpty(this.circular.Title))
            {
                MessageBox.Show("Title is required");
                return false;
            }
            if (string.IsNullOrEmpty(this.circular.Body))
            {
                MessageBox.Show("Write the circular");
                return false;
            }
            this.circular.CreatedAt = DateTime.Now;
            this.circular.CreatedBy = Session.LoggedUser;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.selectionType = 0;
            this.allCircularPanel.Visible = true;
            this.myCircularPanel.Visible = false;
            this.createCircularPanel.Visible = false;
        }
    }
}
