﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Illusion.Product.ViewModel;

namespace Illusion.Product.View
{
    /// <summary>
    /// Interaction logic for ProductAssemblyView.xaml
    /// </summary>
    public partial class ProductAssemblyView : UserControl
    {
        public ProductAssemblyView(ProductAssemblyViewModel model)
        {
            InitializeComponent();
            DataContext = model;
        }
    }
}
