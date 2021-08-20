
namespace Baitap1
{
    partial class FrmNhapdaysovatinhtong
    {
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
            if (disposing && (components != null))
            {
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
            this.txtTongDay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDaySo = new System.Windows.Forms.TextBox();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.txtTongLe = new System.Windows.Forms.TextBox();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTongDay
            // 
            this.txtTongDay.Location = new System.Drawing.Point(234, 178);
            this.txtTongDay.Multiline = true;
            this.txtTongDay.Name = "txtTongDay";
            this.txtTongDay.Size = new System.Drawing.Size(114, 29);
            this.txtTongDay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập dãy số và tính tổng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dãy vừa nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng các phần tử trong dãy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng lẻ";
            // 
            // txtDaySo
            // 
            this.txtDaySo.Location = new System.Drawing.Point(157, 139);
            this.txtDaySo.Multiline = true;
            this.txtDaySo.Name = "txtDaySo";
            this.txtDaySo.Size = new System.Drawing.Size(191, 29);
            this.txtDaySo.TabIndex = 0;
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(121, 98);
            this.txtNhapSo.Multiline = true;
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(77, 32);
            this.txtNhapSo.TabIndex = 0;
            // 
            // txtTongLe
            // 
            this.txtTongLe.Location = new System.Drawing.Point(127, 255);
            this.txtTongLe.Multiline = true;
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.Size = new System.Drawing.Size(77, 29);
            this.txtTongLe.TabIndex = 0;
            // 
            // txtTongChan
            // 
            this.txtTongChan.Location = new System.Drawing.Point(127, 217);
            this.txtTongChan.Multiline = true;
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.Size = new System.Drawing.Size(77, 29);
            this.txtTongChan.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tổng chẵn";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(234, 98);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 32);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Location = new System.Drawing.Point(84, 318);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(75, 32);
            this.btnTiepTuc.TabIndex = 2;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(247, 318);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 32);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmNhapdaysovatinhtong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDaySo);
            this.Controls.Add(this.txtTongChan);
            this.Controls.Add(this.txtTongLe);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.txtTongDay);
            this.Name = "FrmNhapdaysovatinhtong";
            this.Text = "Nhập dãy số và tính tổng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTongDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDaySo;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.TextBox txtTongLe;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
    }
}

