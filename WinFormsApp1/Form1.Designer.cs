namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Jugadores = new TabControl();
            tabPage2 = new TabPage();
            buttonID = new Button();
            buttonReset = new Button();
            dgvInventory = new DataGridView();
            btnUpdatePlayer = new Button();
            btnDeletePlayer = new Button();
            btnAddPlayer = new Button();
            txtPlayerName = new TextBox();
            label1 = new Label();
            Block = new TabPage();
            ResultBlock = new DataGridView();
            IdBlock = new Button();
            ResetBlock = new Button();
            buttonModify = new Button();
            DeleteBlock = new Button();
            AddBlock = new Button();
            BlockEnter = new TextBox();
            Blockname = new Label();
            Inventario = new TabPage();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            Jugadores.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            Block.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ResultBlock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Jugadores
            // 
            Jugadores.Controls.Add(tabPage2);
            Jugadores.Controls.Add(Block);
            Jugadores.Controls.Add(Inventario);
            Jugadores.Location = new Point(12, 3);
            Jugadores.Name = "Jugadores";
            Jugadores.SelectedIndex = 0;
            Jugadores.Size = new Size(736, 423);
            Jugadores.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonID);
            tabPage2.Controls.Add(buttonReset);
            tabPage2.Controls.Add(dgvInventory);
            tabPage2.Controls.Add(btnUpdatePlayer);
            tabPage2.Controls.Add(btnDeletePlayer);
            tabPage2.Controls.Add(btnAddPlayer);
            tabPage2.Controls.Add(txtPlayerName);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(728, 390);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "JUGADORES";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // buttonID
            // 
            buttonID.Location = new Point(541, 288);
            buttonID.Name = "buttonID";
            buttonID.Size = new Size(124, 41);
            buttonID.TabIndex = 7;
            buttonID.Text = "ID";
            buttonID.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(541, 219);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(124, 41);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "Actualizar";
            buttonReset.UseVisualStyleBackColor = true;
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(66, 54);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new Size(455, 275);
            dgvInventory.TabIndex = 5;
            dgvInventory.CellContentClick += dgvInventory_CellContentClick;
            // 
            // btnUpdatePlayer
            // 
            btnUpdatePlayer.Location = new Point(541, 172);
            btnUpdatePlayer.Name = "btnUpdatePlayer";
            btnUpdatePlayer.Size = new Size(124, 41);
            btnUpdatePlayer.TabIndex = 4;
            btnUpdatePlayer.Text = "Modificar";
            btnUpdatePlayer.UseVisualStyleBackColor = true;
            // 
            // btnDeletePlayer
            // 
            btnDeletePlayer.Location = new Point(541, 116);
            btnDeletePlayer.Name = "btnDeletePlayer";
            btnDeletePlayer.Size = new Size(124, 41);
            btnDeletePlayer.TabIndex = 3;
            btnDeletePlayer.Text = "Eliminar";
            btnDeletePlayer.UseVisualStyleBackColor = true;
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.Location = new Point(541, 54);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(124, 41);
            btnAddPlayer.TabIndex = 2;
            btnAddPlayer.Text = "Agregar";
            btnAddPlayer.UseVisualStyleBackColor = true;
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(174, 9);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.PlaceholderText = "Nombre del Jugador";
            txtPlayerName.Size = new Size(303, 27);
            txtPlayerName.TabIndex = 1;
            txtPlayerName.TextChanged += txtPlayerName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 16);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "JUGADOR";
            // 
            // Block
            // 
            Block.Controls.Add(pictureBox1);
            Block.Controls.Add(ResultBlock);
            Block.Controls.Add(IdBlock);
            Block.Controls.Add(ResetBlock);
            Block.Controls.Add(buttonModify);
            Block.Controls.Add(DeleteBlock);
            Block.Controls.Add(AddBlock);
            Block.Controls.Add(BlockEnter);
            Block.Controls.Add(Blockname);
            Block.Location = new Point(4, 29);
            Block.Name = "Block";
            Block.Padding = new Padding(3);
            Block.Size = new Size(728, 390);
            Block.TabIndex = 2;
            Block.Text = "BLOQUES";
            Block.UseVisualStyleBackColor = true;
            // 
            // ResultBlock
            // 
            ResultBlock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultBlock.Location = new Point(58, 54);
            ResultBlock.Name = "ResultBlock";
            ResultBlock.ReadOnly = true;
            ResultBlock.RowHeadersWidth = 51;
            ResultBlock.Size = new Size(455, 253);
            ResultBlock.TabIndex = 9;
            ResultBlock.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IdBlock
            // 
            IdBlock.Location = new Point(558, 288);
            IdBlock.Name = "IdBlock";
            IdBlock.Size = new Size(124, 41);
            IdBlock.TabIndex = 8;
            IdBlock.Text = "ID";
            IdBlock.UseVisualStyleBackColor = true;
            IdBlock.Click += IdBlock_Click;
            // 
            // ResetBlock
            // 
            ResetBlock.Location = new Point(558, 227);
            ResetBlock.Name = "ResetBlock";
            ResetBlock.Size = new Size(124, 41);
            ResetBlock.TabIndex = 7;
            ResetBlock.Text = "Actualizar";
            ResetBlock.UseVisualStyleBackColor = true;
            ResetBlock.Click += ResetBlock_Click;
            // 
            // buttonModify
            // 
            buttonModify.Location = new Point(558, 168);
            buttonModify.Name = "buttonModify";
            buttonModify.Size = new Size(124, 41);
            buttonModify.TabIndex = 5;
            buttonModify.Text = "Modificar";
            buttonModify.UseVisualStyleBackColor = true;
            buttonModify.Click += buttonModify_Click;
            // 
            // DeleteBlock
            // 
            DeleteBlock.Location = new Point(558, 110);
            DeleteBlock.Name = "DeleteBlock";
            DeleteBlock.Size = new Size(124, 41);
            DeleteBlock.TabIndex = 4;
            DeleteBlock.Text = "Eliminar";
            DeleteBlock.UseVisualStyleBackColor = true;
            DeleteBlock.Click += button1_Click;
            // 
            // AddBlock
            // 
            AddBlock.Location = new Point(558, 54);
            AddBlock.Name = "AddBlock";
            AddBlock.Size = new Size(124, 41);
            AddBlock.TabIndex = 3;
            AddBlock.Text = "Agregar";
            AddBlock.UseVisualStyleBackColor = true;
            AddBlock.Click += AddBlock_Click;
            // 
            // BlockEnter
            // 
            BlockEnter.Location = new Point(118, 16);
            BlockEnter.Name = "BlockEnter";
            BlockEnter.PlaceholderText = "Nombre del Bloque";
            BlockEnter.Size = new Size(303, 27);
            BlockEnter.TabIndex = 2;
            BlockEnter.TextChanged += BlockEnter_TextChanged;
            // 
            // Blockname
            // 
            Blockname.AutoSize = true;
            Blockname.Location = new Point(28, 19);
            Blockname.Name = "Blockname";
            Blockname.Size = new Size(64, 20);
            Blockname.TabIndex = 1;
            Blockname.Text = "BLOQUE";
            Blockname.Click += Blockname_Click;
            // 
            // Inventario
            // 
            Inventario.Location = new Point(4, 29);
            Inventario.Name = "Inventario";
            Inventario.Padding = new Padding(3);
            Inventario.Size = new Size(728, 390);
            Inventario.TabIndex = 3;
            Inventario.Text = "INVENTARIO";
            Inventario.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(98, 313);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Jugadores);
            Name = "Form1";
            Text = "Form1";
            Jugadores.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            Block.ResumeLayout(false);
            Block.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ResultBlock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl Jugadores;
        private TabPage tabPage2;
        private TabPage Block;
        private TabPage Inventario;
        private Button btnUpdatePlayer;
        private Button btnDeletePlayer;
        private Button btnAddPlayer;
        private TextBox txtPlayerName;
        private Label label1;
        private Button buttonID;
        private Button buttonReset;
        private DataGridView dgvInventory;
        private Label Blockname;
        private TextBox BlockEnter;
        private Button DeleteBlock;
        private Button AddBlock;
        private Button buttonModify;
        private Button ResetBlock;
        private Button IdBlock;
        private DataGridView ResultBlock;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
    }
}
