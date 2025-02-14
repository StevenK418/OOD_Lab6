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

namespace OOD_Lab6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Create a new database connection
       // private Model1Container db = new Model1Container();
       private Model2Container db = new Model2Container();

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Triggered when the main window is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //Query the db for all bands
            var query = from a in db.Bands
                                    select a;

            //Assign the resulting list of bands as data source for 
            //The bands listbox
            LSTBX_Bands.ItemsSource = query.ToList();
        }

        /// <summary>
        /// Triggered when an band in the listbox is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LSTBX_Bands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //Get reference to the listbox that sent this event
            ListBox box = (ListBox) sender;
            //Get reference to the selected band
            Band band = (Band)box.SelectedItem;


            //If the band selected is not null
            if (band != null)
            {
                //Query the database for the boos matching the selected band
                var query = 
                                            from b in db.Albums
                                            where b.Band.Id == band.Id
                                            select b.Name;

                //Assign the query's result set as the data source for the albums listbox
                LSTBXAlbums.ItemsSource = query.ToList();
            }
        }
    }
}
