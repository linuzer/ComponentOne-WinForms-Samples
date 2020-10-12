using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DBImageField
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList _imgList;
		private System.Windows.Forms.DataGrid dataGrid1;
		private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this._imgList = new System.Windows.Forms.ImageList(this.components);
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// _imgList
			// 
			this._imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this._imgList.ImageSize = new System.Drawing.Size(16, 15);
			this._imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgList.ImageStream")));
			this._imgList.TransparentColor = System.Drawing.Color.Red;
			// 
			// dataGrid1
			// 
			this.dataGrid1.CaptionText = "MSDataGrid";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Left;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(240, 237);
			this.dataGrid1.TabIndex = 0;
			// 
			// c1FlexGrid1
			// 
			this.c1FlexGrid1.BackColor = System.Drawing.SystemColors.Window;
			this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:24;}\t";
			this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1FlexGrid1.Location = new System.Drawing.Point(240, 24);
			this.c1FlexGrid1.Name = "c1FlexGrid1";
			this.c1FlexGrid1.Size = new System.Drawing.Size(288, 213);
			this.c1FlexGrid1.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.c1FlexGrid1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Highlight;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(240, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(288, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = " C1FlexGrid";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(528, 237);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1FlexGrid1,
																		  this.label1,
																		  this.dataGrid1});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Binding to Image Fields";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("String", typeof(string));
			dt.Columns.Add("Int", typeof(int));
			dt.Columns.Add("Image", typeof(Image));

			object[] obj = new object[3];
			string[] str = "the|quick|brown|fox|jumped|over|the|lazy|yellow|dog".Split('|');
			for (int i = 0; i < 1000; i++)
			{
				obj[0] = str[i % 10];
				obj[1] = i;
				obj[2] = _imgList.Images[i % 10];
				dt.Rows.Add(obj);
			}

			dataGrid1.DataSource = dt;
			c1FlexGrid1.DataSource = dt;
		}
	}
}
