﻿using Dioboy.ManagerBase;
using System;
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

namespace Dioboy
{
	/// <summary>
	/// MainWindow.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class MainWindow : Window
	{
		private DioboyMainTrigger _Trigger = new DioboyMainTrigger();

		public MainWindow()
		{
			InitializeComponent();

			Loaded += MainWindow_Loaded;
			_Trigger.Run();
		}

		void MainWindow_Loaded(object sender, RoutedEventArgs e)
		{
			_Trigger.Stop();
		}
	}
}