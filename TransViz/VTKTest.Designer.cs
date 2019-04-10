using Kitware.VTK;

namespace TransViz {
				partial class VTKTest {
								/// <summary>
								/// Required designer variable.
								/// </summary>
								private System.ComponentModel.IContainer components = null;

								/// <summary>
								/// Clean up any resources being used.
								/// </summary>
								/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
								protected override void Dispose(bool disposing)
								{
												if (disposing && ( components != null )) {
																components.Dispose();
												}
												base.Dispose(disposing);
								}



								#region Windows Form Designer generated code

								/// <summary>
								/// Required method for Designer support - do not modify
								/// the contents of this method with the code editor.
								/// </summary>
								private void InitializeComponent()
								{
												this.renderWindowControl1 = new Kitware.VTK.RenderWindowControl();
												this.SuspendLayout();
												// 
												// renderWindowControl1
												// 
												this.renderWindowControl1.AddTestActors = false;
												this.renderWindowControl1.Dock = System.Windows.Forms.DockStyle.Fill;
												this.renderWindowControl1.Location = new System.Drawing.Point(0, 0);
												this.renderWindowControl1.Name = "renderWindowControl1";
												this.renderWindowControl1.Size = new System.Drawing.Size(800, 450);
												this.renderWindowControl1.TabIndex = 0;
												this.renderWindowControl1.TestText = null;
												this.renderWindowControl1.Load += new System.EventHandler(this.RenderWindowControl1_Load);
												// 
												// VTKTest
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(800, 450);
												this.Controls.Add(this.renderWindowControl1);
												this.Name = "VTKTest";
												this.Text = "VTKTest";
												this.ResumeLayout(false);

								}

								#endregion

								private RenderWindowControl renderWindowControl1;
				}
}