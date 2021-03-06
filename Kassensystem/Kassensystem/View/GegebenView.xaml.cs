﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kassensystem.View
{
    /// <summary>
    /// Interaktionslogik für GegebenView.xaml
    /// </summary>
    public partial class GegebenView : UserControl
    {
        public GegebenView()
        {
            InitializeComponent();
        }
        private void ListBox_OnScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            scrollViewer.SelectedIndex = scrollViewer.Items.Count;
            scrollViewer.ScrollIntoView(scrollViewer.SelectedItem);
        }
    }
}
