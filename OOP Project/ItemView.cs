﻿using OOP_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class ItemView : Form
    {
        public ItemView()
        {
            InitializeComponent();
        }

        private void ItemView_Load(object sender, EventArgs e)
        {
            foreach (Rentable item in AirBNE.list)
            {
                renderButton(item);
            }
        }
        private void renderButton(Rentable item)
        {
            Button button = new Button();
            switch (item.GetType().Name)
            {
                case "Apartment":
                    button.BackgroundImage = Properties.Resources.Apartment;
                    break;
                case "House":
                    button.BackgroundImage = Properties.Resources.House;
                    break;
                case "HotelRoom":
                    button.BackgroundImage = Properties.Resources.Hotel;
                    break;
            }
            button.BackgroundImageLayout = ImageLayout.Stretch;
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.TextImageRelation = TextImageRelation.TextBeforeImage;
            button.Name = Convert.ToString(item.Id);
            button.Size = new Size(225, 250);
            button.Text = item.getText();
            button.Click += new EventHandler(this.itemClick);
            flowLayoutPanel1.Controls.Add(button);
        }
        private void itemClick(object sender, EventArgs e)
        {
            foreach(Control control in flowLayoutPanel1.Controls)
            {
                if (sender.Equals(control))
                {
                    ItemInfo.itemID = Convert.ToInt32(control.Name);
                    break;
                }
            }
            ItemInfo form = new ItemInfo();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string name1 = "";
            string name2 = searchBox.Text.ToLower();
            foreach (Rentable item in AirBNE.list)
            {
                name1 = item.Address.ToLower();
                if (name1.Contains(name2))
                    renderButton(item);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Rentable item in AirBNE.list)
            {
                renderButton(item);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AirBNE form = new AirBNE();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (this.ClientRectangle.Width > 0 && this.ClientRectangle.Height > 0)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(234, 234, 234), Color.FromArgb(255, 94, 0), 65F))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
        }

        private void numericUpDownSearchValue_ValueChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            double tmp =Convert.ToDouble(numericUpDownSearchValue.Value);
            foreach(Rentable item in AirBNE.list)
            {
                if (item.Price < tmp)
                {
                    renderButton(item);
                }
            }
        }
    }
}
