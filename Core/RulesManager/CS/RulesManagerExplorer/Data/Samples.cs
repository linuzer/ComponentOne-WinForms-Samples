﻿using RulesManagerExplorer.Samples;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace RulesManagerExplorer.Samples
{
    /// <summary>
    /// The sample description
    /// </summary>
    public class SampleItem
    {
        #region ** fields

        private Type _sampleType;

        #endregion

        #region ** ctor
        public SampleItem() { }

        /// <summary>
        /// Sample item contructor
        /// </summary>
        /// <param name="name">The name of control</param>
        /// <param name="title">The title of control</param>
        /// <param name="desc">The description of control</param>
        /// <param name="sampleType">Type</param>
        public SampleItem(string name, string title, string desc, Type sampleType)
        {
            if (sampleType == null)
                throw new ArgumentException("sampleType can't be null");
            Name = name;
            Title = title;
            Description = desc;

            _sampleType = sampleType;
        }

        #endregion

        #region ** public fields
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Type SampleType { get => _sampleType; set => _sampleType = value; }
        public Control Sample
        {
            get
            {
                var control = Activator.CreateInstance(_sampleType) as Control;
                return control;
            }
        }

        #endregion
    }

    /// <summary>
    /// The data source of controls
    /// </summary>
    public static class SampleDataSource
    {
        private static List<SampleItem> _allItems;

        static SampleDataSource()
        {
            // The samples description creating
            _allItems = new List<SampleItem>()
            {
                new SampleItem()
                {
                    Description = "One of the most common chart requirements is to customize the appearance of the data points—the individual values that are plotted on the chart. The representation of data points (known as symbols) varies depending upon the chart type being used, so customizing a data point in a Column/Bar chart would imply customizing the appearance of the columns/bars. ",
                    Name = "Formatting in FlexChart",
                    Title = "Formatting in FlexChart",
                    SampleType = typeof(ChartConditionalFormatting)
                },
                new SampleItem()
                {
                    Description = "Conditional formatting enables users to highlight cells with a certain color, depending upon the cell's value. The FlexGrid control lets users apply conditional formatting to an individual cell or a range of cells to let them visualize data more clearly for analysis and comparison.",
                    Name = "Formatting in FlexGrid",
                    Title = "Formatting in FlexGrid",
                    SampleType = typeof(DataGridViewConditionalFormatting)
                }
            };
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
