using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace tictactoe
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button but9;
		private System.Windows.Forms.Button but8;
		private System.Windows.Forms.Button but7;
		private System.Windows.Forms.Button but6;
		private System.Windows.Forms.Button but5;
		private System.Windows.Forms.Button but4;
		private System.Windows.Forms.Button but3;
		private System.Windows.Forms.Button but2;
		private System.Windows.Forms.Button but1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;


		private System.Windows.Forms.Button [] _buttonArray; 
		private bool _isX;			
		private bool _isGameOver;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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
			this.but9 = new System.Windows.Forms.Button();
			this.but8 = new System.Windows.Forms.Button();
			this.but7 = new System.Windows.Forms.Button();
			this.but6 = new System.Windows.Forms.Button();
			this.but5 = new System.Windows.Forms.Button();
			this.but4 = new System.Windows.Forms.Button();
			this.but3 = new System.Windows.Forms.Button();
			this.but2 = new System.Windows.Forms.Button();
			this.but1 = new System.Windows.Forms.Button();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// but9
			// 
			this.but9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.but9.Location = new System.Drawing.Point(104, 104);
			this.but9.Name = "but9";
			this.but9.Size = new System.Drawing.Size(50, 50);
			this.but9.TabIndex = 18;
			// 
			// but8
			// 
			this.but8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.but8.Location = new System.Drawing.Point(56, 104);
			this.but8.Name = "but8";
			this.but8.Size = new System.Drawing.Size(50, 50);
			this.but8.TabIndex = 17;
			// 
			// but7
			// 
			this.but7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.but7.Location = new System.Drawing.Point(8, 104);
			this.but7.Name = "but7";
			this.but7.Size = new System.Drawing.Size(50, 50);
			this.but7.TabIndex = 16;
			// 
			// but6
			// 
			this.but6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.but6.Location = new System.Drawing.Point(104, 56);
			this.but6.Name = "but6";
			this.but6.Size = new System.Drawing.Size(50, 50);
			this.but6.TabIndex = 15;
			// 
			// but5
			// 
			this.but5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.but5.Location = new System.Drawing.Point(56, 56);
			this.but5.Name = "but5";
			this.but5.Size = new System.Drawing.Size(50, 50);
			this.but5.TabIndex = 14;
			// 
			// but4
			// 
			this.but4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.but4.Location = new System.Drawing.Point(8, 56);
			this.but4.Name = "but4";
			this.but4.Size = new System.Drawing.Size(50, 50);
			this.but4.TabIndex = 13;
			// 
			// but3
			// 
			this.but3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.but3.Location = new System.Drawing.Point(104, 8);
			this.but3.Name = "but3";
			this.but3.Size = new System.Drawing.Size(50, 50);
			this.but3.TabIndex = 12;
			// 
			// but2
			// 
			this.but2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.but2.Location = new System.Drawing.Point(56, 8);
			this.but2.Name = "but2";
			this.but2.Size = new System.Drawing.Size(50, 50);
			this.but2.TabIndex = 11;
			// 
			// but1
			// 
			this.but1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.but1.Location = new System.Drawing.Point(8, 8);
			this.but1.Name = "but1";
			this.but1.Size = new System.Drawing.Size(50, 50);
			this.but1.TabIndex = 10;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2});
			this.menuItem1.Text = "File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "New";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(160, 161);
			this.Controls.Add(this.but9);
			this.Controls.Add(this.but8);
			this.Controls.Add(this.but7);
			this.Controls.Add(this.but6);
			this.Controls.Add(this.but5);
			this.Controls.Add(this.but4);
			this.Controls.Add(this.but3);
			this.Controls.Add(this.but2);
			this.Controls.Add(this.but1);
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
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
			_buttonArray = new Button[9] {but1, but2, but3, but4, but5, but6, but7, but8, but9};
			for(int i = 0; i < 9; i++)
				this._buttonArray[i].Click += new System.EventHandler(this.ClickHandler);
			InitTicTacToe(); 
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			InitTicTacToe();	
		}

		public void InitTicTacToe()
		{
			for(int i=0;i<9;i++)
			{
				_buttonArray[i].Text = "";
				_buttonArray[i].ForeColor = Color.Black;
				_buttonArray[i].BackColor = Color.LightGray;
				_buttonArray[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			}
			this._isX = true;
			this._isGameOver = false;
		}

		private void ClickHandler(object sender, System.EventArgs e)
		{
			Button tempButton = (Button)sender;
			if( this._isGameOver )
			{
				MessageBox.Show("please start new game!","Game End",MessageBoxButtons.OK);
				return;			
			}
			if( tempButton.Text != "" )	
			{
				return;
			}
			if( _isX )	
				tempButton.Text = "X";
			else
				tempButton.Text = "O";
			_isX = !_isX;	
			this._isGameOver = result.CheckWinner(_buttonArray );
		}
	}
	public class result
	{
		static private int [,] Winners = new int[,]
				   {
						{0,1,2},
						{3,4,5},
						{6,7,8},
						{0,3,6},
						{1,4,7},
						{2,5,8},
						{0,4,8},
						{2,4,6}
				   };
		static public bool CheckWinner( Button [] myControls )
		{
			bool gameOver = false;
			for(int i = 0; i < 8; i++)
			{
				int a = Winners[i,0],b=Winners[i,1],c=Winners[i,2];		
				Button b1=myControls[a], b2=myControls[b], b3=myControls[c];
				if(b1.Text == "" || b2.Text == "" || b3.Text == "" )	
					continue;											
				if(b1.Text == b2.Text && b2.Text == b3.Text )			
				{														
					b1.BackColor = b2.BackColor = b3.BackColor = Color.LightCoral;
					b1.Font = b2.Font = b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Italic & System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
					gameOver = true;
					MessageBox.Show(b1.Text + " .... Wins the game!","Game End",MessageBoxButtons.OK);
					break;  
				}
			}	
			return gameOver;
		}
	}
}
