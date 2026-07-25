namespace AssistenciaTec.View
{
    partial class FrmTecnicos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTecnicos));
            label6 = new Label();
            toolStripButtonEditar = new ToolStripButton();
            toolStripButtonExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            LblErroEndereco = new Label();
            LblErroTelefone = new Label();
            LblErroEmail = new Label();
            LblErroNome = new Label();
            TxtEndereco = new TextBox();
            label5 = new Label();
            TxtTelefone = new TextBox();
            label4 = new Label();
            TxtEmail = new TextBox();
            label2 = new Label();
            TxtNome = new TextBox();
            toolStripButtonCancelar = new ToolStripButton();
            toolStripButtonSalvar = new ToolStripButton();
            pictureBox1 = new PictureBox();
            toolStripButtonNovo = new ToolStripButton();
            errorProvider1 = new ErrorProvider(components);
            label3 = new Label();
            DatagridViewTecnicos = new DataGridView();
            btnBuscar = new Button();
            LabelId = new Label();
            label1 = new Label();
            label7 = new Label();
            toolStrip1 = new ToolStrip();
            groupBox1 = new GroupBox();
            TxtBuscarPorNome = new TextBox();
            GroupBoxDadosCliente = new GroupBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DatagridViewTecnicos).BeginInit();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            GroupBoxDadosCliente.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 31);
            label6.Name = "label6";
            label6.Size = new Size(152, 15);
            label6.TabIndex = 0;
            label6.Text = "Buscar Técnicos  por nome:";
            // 
            // toolStripButtonEditar
            // 
            toolStripButtonEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEditar.Image = (Image)resources.GetObject("toolStripButtonEditar.Image");
            toolStripButtonEditar.ImageTransparentColor = Color.Magenta;
            toolStripButtonEditar.Name = "toolStripButtonEditar";
            toolStripButtonEditar.Size = new Size(28, 32);
            toolStripButtonEditar.Text = "toolStripButton2";
            toolStripButtonEditar.ToolTipText = "Editar cliente selecioado";
            toolStripButtonEditar.Click += toolStripButtonEditar_Click;
            // 
            // toolStripButtonExcluir
            // 
            toolStripButtonExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonExcluir.Image = (Image)resources.GetObject("toolStripButtonExcluir.Image");
            toolStripButtonExcluir.ImageTransparentColor = Color.Magenta;
            toolStripButtonExcluir.Name = "toolStripButtonExcluir";
            toolStripButtonExcluir.Size = new Size(28, 32);
            toolStripButtonExcluir.Text = "toolStripButton3";
            toolStripButtonExcluir.ToolTipText = "Excluir cliente selecionado";
            toolStripButtonExcluir.Click += toolStripButtonExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 35);
            // 
            // LblErroEndereco
            // 
            LblErroEndereco.Font = new Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblErroEndereco.ForeColor = Color.Red;
            LblErroEndereco.Location = new Point(133, 436);
            LblErroEndereco.Name = "LblErroEndereco";
            LblErroEndereco.Size = new Size(156, 15);
            LblErroEndereco.TabIndex = 13;
            LblErroEndereco.Text = "Nome é obrigatório.";
            LblErroEndereco.TextAlign = ContentAlignment.MiddleRight;
            LblErroEndereco.Visible = false;
            // 
            // LblErroTelefone
            // 
            LblErroTelefone.Font = new Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblErroTelefone.ForeColor = Color.Red;
            LblErroTelefone.Location = new Point(30, 281);
            LblErroTelefone.Name = "LblErroTelefone";
            LblErroTelefone.Size = new Size(156, 15);
            LblErroTelefone.TabIndex = 12;
            LblErroTelefone.Text = "Nome é obrigatório.";
            LblErroTelefone.TextAlign = ContentAlignment.MiddleRight;
            LblErroTelefone.Visible = false;
            // 
            // LblErroEmail
            // 
            LblErroEmail.Font = new Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblErroEmail.ForeColor = Color.Red;
            LblErroEmail.Location = new Point(133, 214);
            LblErroEmail.Name = "LblErroEmail";
            LblErroEmail.Size = new Size(156, 15);
            LblErroEmail.TabIndex = 11;
            LblErroEmail.Text = "Nome é obrigatório.";
            LblErroEmail.TextAlign = ContentAlignment.MiddleRight;
            LblErroEmail.Visible = false;
            // 
            // LblErroNome
            // 
            LblErroNome.Font = new Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblErroNome.ForeColor = Color.Red;
            LblErroNome.Location = new Point(133, 150);
            LblErroNome.Name = "LblErroNome";
            LblErroNome.Size = new Size(156, 15);
            LblErroNome.TabIndex = 10;
            LblErroNome.Text = "Nome é obrigatório.";
            LblErroNome.TextAlign = ContentAlignment.MiddleRight;
            LblErroNome.Visible = false;
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(18, 314);
            TxtEndereco.Multiline = true;
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(271, 124);
            TxtEndereco.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 293);
            label5.Name = "label5";
            label5.Size = new Size(155, 15);
            label5.TabIndex = 8;
            label5.Text = "Especialidades do Técnicos :";
            // 
            // TxtTelefone
            // 
            TxtTelefone.Location = new Point(18, 253);
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.Size = new Size(168, 23);
            TxtTelefone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 232);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefone do Técnicos :";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(18, 186);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(271, 23);
            TxtEmail.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 165);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 4;
            label2.Text = "E-mail do Técnicos :";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(18, 122);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(271, 23);
            TxtNome.TabIndex = 3;
            TxtNome.TextChanged += TxtNome_TextChanged;
            // 
            // toolStripButtonCancelar
            // 
            toolStripButtonCancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonCancelar.Image = (Image)resources.GetObject("toolStripButtonCancelar.Image");
            toolStripButtonCancelar.ImageTransparentColor = Color.Magenta;
            toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            toolStripButtonCancelar.Size = new Size(28, 32);
            toolStripButtonCancelar.Text = "toolStripButton4";
            toolStripButtonCancelar.ToolTipText = "Cancelar operação";
            toolStripButtonCancelar.Click += toolStripButtonCancelar_Click;
            // 
            // toolStripButtonSalvar
            // 
            toolStripButtonSalvar.AutoSize = false;
            toolStripButtonSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSalvar.Image = (Image)resources.GetObject("toolStripButtonSalvar.Image");
            toolStripButtonSalvar.ImageTransparentColor = Color.Magenta;
            toolStripButtonSalvar.Name = "toolStripButtonSalvar";
            toolStripButtonSalvar.Size = new Size(32, 32);
            toolStripButtonSalvar.Text = "toolStripButton5";
            toolStripButtonSalvar.ToolTipText = "Gravar alterações";
            toolStripButtonSalvar.Click += toolStripButtonSalvar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // toolStripButtonNovo
            // 
            toolStripButtonNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNovo.Image = (Image)resources.GetObject("toolStripButtonNovo.Image");
            toolStripButtonNovo.ImageTransparentColor = Color.Magenta;
            toolStripButtonNovo.Name = "toolStripButtonNovo";
            toolStripButtonNovo.Size = new Size(28, 32);
            toolStripButtonNovo.Text = "toolStripButton1";
            toolStripButtonNovo.ToolTipText = "Novo Cliente";
            toolStripButtonNovo.Click += toolStripButtonNovo_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 101);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome do Técnicos :";
            // 
            // DatagridViewTecnicos
            // 
            DatagridViewTecnicos.AllowUserToResizeColumns = false;
            DatagridViewTecnicos.AllowUserToResizeRows = false;
            DatagridViewTecnicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatagridViewTecnicos.Location = new Point(15, 101);
            DatagridViewTecnicos.Name = "DatagridViewTecnicos";
            DatagridViewTecnicos.ReadOnly = true;
            DatagridViewTecnicos.Size = new Size(473, 337);
            DatagridViewTecnicos.TabIndex = 3;
            DatagridViewTecnicos.CellClick += DatagridViewTecnicos_CellClick;
            DatagridViewTecnicos.CellEnter += DatagridViewTecnicos_CellEnter;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(442, 43);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(46, 42);
            btnBuscar.TabIndex = 2;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // LabelId
            // 
            LabelId.BackColor = Color.Azure;
            LabelId.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelId.Location = new Point(156, 42);
            LabelId.Name = "LabelId";
            LabelId.Size = new Size(69, 36);
            LabelId.TabIndex = 1;
            LabelId.Text = "458";
            LabelId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 51);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "ID do Técnicos :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(75, 15);
            label7.Name = "label7";
            label7.Size = new Size(329, 32);
            label7.TabIndex = 0;
            label7.Text = "Cadastro de Técnicos ";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonNovo, toolStripButtonEditar, toolStripButtonExcluir, toolStripSeparator1, toolStripButtonCancelar, toolStripButtonSalvar });
            toolStrip1.Location = new Point(0, 543);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(854, 35);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DatagridViewTecnicos);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(TxtBuscarPorNome);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(334, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(508, 454);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de Técnicos cadastrados:";
            // 
            // TxtBuscarPorNome
            // 
            TxtBuscarPorNome.Location = new Point(15, 52);
            TxtBuscarPorNome.Name = "TxtBuscarPorNome";
            TxtBuscarPorNome.Size = new Size(421, 23);
            TxtBuscarPorNome.TabIndex = 1;
            // 
            // GroupBoxDadosCliente
            // 
            GroupBoxDadosCliente.Controls.Add(LblErroEndereco);
            GroupBoxDadosCliente.Controls.Add(LblErroTelefone);
            GroupBoxDadosCliente.Controls.Add(LblErroEmail);
            GroupBoxDadosCliente.Controls.Add(LblErroNome);
            GroupBoxDadosCliente.Controls.Add(TxtEndereco);
            GroupBoxDadosCliente.Controls.Add(label5);
            GroupBoxDadosCliente.Controls.Add(TxtTelefone);
            GroupBoxDadosCliente.Controls.Add(label4);
            GroupBoxDadosCliente.Controls.Add(TxtEmail);
            GroupBoxDadosCliente.Controls.Add(label2);
            GroupBoxDadosCliente.Controls.Add(TxtNome);
            GroupBoxDadosCliente.Controls.Add(label3);
            GroupBoxDadosCliente.Controls.Add(LabelId);
            GroupBoxDadosCliente.Controls.Add(label1);
            GroupBoxDadosCliente.Enabled = false;
            GroupBoxDadosCliente.Location = new Point(12, 76);
            GroupBoxDadosCliente.Name = "GroupBoxDadosCliente";
            GroupBoxDadosCliente.Size = new Size(316, 454);
            GroupBoxDadosCliente.TabIndex = 4;
            GroupBoxDadosCliente.TabStop = false;
            GroupBoxDadosCliente.Text = "Dados do Técnicos :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 61);
            panel1.TabIndex = 7;
            // 
            // FrmTecnicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 578);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox1);
            Controls.Add(GroupBoxDadosCliente);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FrmTecnicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTecnicos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DatagridViewTecnicos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            GroupBoxDadosCliente.ResumeLayout(false);
            GroupBoxDadosCliente.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ToolStripButton toolStripButtonEditar;
        private ToolStripButton toolStripButtonExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private Label LblErroEndereco;
        private Label LblErroTelefone;
        private Label LblErroEmail;
        private Label LblErroNome;
        private TextBox TxtEndereco;
        private Label label5;
        private TextBox TxtTelefone;
        private Label label4;
        private TextBox TxtEmail;
        private Label label2;
        private TextBox TxtNome;
        private ToolStripButton toolStripButtonCancelar;
        private ToolStripButton toolStripButtonSalvar;
        private PictureBox pictureBox1;
        private ToolStripButton toolStripButtonNovo;
        private ErrorProvider errorProvider1;
        private ToolStrip toolStrip1;
        private GroupBox groupBox1;
        private DataGridView DatagridViewTecnicos;
        private Button btnBuscar;
        private TextBox TxtBuscarPorNome;
        private GroupBox GroupBoxDadosCliente;
        private Label label3;
        private Label LabelId;
        private Label label1;
        private Panel panel1;
        private Label label7;
    }
}