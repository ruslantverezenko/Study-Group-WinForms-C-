
namespace MyApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myDatabaseDataSet = new MyApp.MyDatabaseDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new MyApp.MyDatabaseDataSetTableAdapters.StudentsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.parentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parentsTableAdapter = new MyApp.MyDatabaseDataSetTableAdapters.ParentsTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.parentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.gradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradesTableAdapter = new MyApp.MyDatabaseDataSetTableAdapters.GradesTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.номерстуденческогобилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адреспроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонстудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонродителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерзачётнойкнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонродителяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кемявляетсястудентуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоработыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерзачётнойкнигиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.математикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.русскийЯзыкDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.физикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.информатикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.parentsStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsStudentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерстуденческогобилетаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn,
            this.датарожденияDataGridViewTextBoxColumn,
            this.адреспроживанияDataGridViewTextBoxColumn,
            this.телефонстудентаDataGridViewTextBoxColumn,
            this.телефонродителяDataGridViewTextBoxColumn,
            this.номерзачётнойкнигиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1149, 125);
            this.dataGridView1.TabIndex = 0;
            // 
            // myDatabaseDataSet
            // 
            this.myDatabaseDataSet.DataSetName = "MyDatabaseDataSet";
            this.myDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.myDatabaseDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Укажите номер студенческого билета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Укажите новый адрес студента";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(16, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(16, 404);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(16, 460);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(199, 22);
            this.textBox3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Удалить студента";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(13, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Изменить адрес";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1171, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 70);
            this.button3.TabIndex = 9;
            this.button3.Text = "Добавить студента";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1171, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 56);
            this.button4.TabIndex = 10;
            this.button4.Text = "Обновить таблицу";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Укажите номер студенческого билета";
            // 
            // parentsBindingSource
            // 
            this.parentsBindingSource.DataMember = "Parents";
            this.parentsBindingSource.DataSource = this.myDatabaseDataSet;
            // 
            // parentsTableAdapter
            // 
            this.parentsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.телефонродителяDataGridViewTextBoxColumn1,
            this.фИОDataGridViewTextBoxColumn1,
            this.кемявляетсястудентуDataGridViewTextBoxColumn,
            this.местоработыDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.parentsBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(498, 217);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(667, 150);
            this.dataGridView2.TabIndex = 12;
            // 
            // parentsBindingSource1
            // 
            this.parentsBindingSource1.DataMember = "Parents";
            this.parentsBindingSource1.DataSource = this.myDatabaseDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(754, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Таблица родителей";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gold;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(1171, 217);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 95);
            this.button5.TabIndex = 14;
            this.button5.Text = "Добавить родителя";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерзачётнойкнигиDataGridViewTextBoxColumn1,
            this.математикаDataGridViewTextBoxColumn,
            this.русскийЯзыкDataGridViewTextBoxColumn,
            this.физикаDataGridViewTextBoxColumn,
            this.информатикаDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.gradesBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(490, 408);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(675, 150);
            this.dataGridView3.TabIndex = 15;
            // 
            // gradesBindingSource
            // 
            this.gradesBindingSource.DataMember = "Grades";
            this.gradesBindingSource.DataSource = this.myDatabaseDataSet;
            // 
            // gradesTableAdapter
            // 
            this.gradesTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gold;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(1171, 408);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 99);
            this.button6.TabIndex = 16;
            this.button6.Text = "Добавить оценки";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(785, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Таблица оценок";
            // 
            // номерстуденческогобилетаDataGridViewTextBoxColumn
            // 
            this.номерстуденческогобилетаDataGridViewTextBoxColumn.DataPropertyName = "Номер_студенческого_билета";
            this.номерстуденческогобилетаDataGridViewTextBoxColumn.HeaderText = "Номер_студенческого_билета";
            this.номерстуденческогобилетаDataGridViewTextBoxColumn.Name = "номерстуденческогобилетаDataGridViewTextBoxColumn";
            this.номерстуденческогобилетаDataGridViewTextBoxColumn.Width = 170;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.Width = 175;
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            // 
            // датарожденияDataGridViewTextBoxColumn
            // 
            this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.HeaderText = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
            // 
            // адреспроживанияDataGridViewTextBoxColumn
            // 
            this.адреспроживанияDataGridViewTextBoxColumn.DataPropertyName = "Адрес_проживания";
            this.адреспроживанияDataGridViewTextBoxColumn.HeaderText = "Адрес_проживания";
            this.адреспроживанияDataGridViewTextBoxColumn.Name = "адреспроживанияDataGridViewTextBoxColumn";
            this.адреспроживанияDataGridViewTextBoxColumn.Width = 120;
            // 
            // телефонстудентаDataGridViewTextBoxColumn
            // 
            this.телефонстудентаDataGridViewTextBoxColumn.DataPropertyName = "Телефон_студента";
            this.телефонстудентаDataGridViewTextBoxColumn.HeaderText = "Телефон_студента";
            this.телефонстудентаDataGridViewTextBoxColumn.Name = "телефонстудентаDataGridViewTextBoxColumn";
            this.телефонстудентаDataGridViewTextBoxColumn.Width = 120;
            // 
            // телефонродителяDataGridViewTextBoxColumn
            // 
            this.телефонродителяDataGridViewTextBoxColumn.DataPropertyName = "Телефон_родителя";
            this.телефонродителяDataGridViewTextBoxColumn.HeaderText = "Телефон_родителя";
            this.телефонродителяDataGridViewTextBoxColumn.Name = "телефонродителяDataGridViewTextBoxColumn";
            this.телефонродителяDataGridViewTextBoxColumn.Width = 120;
            // 
            // номерзачётнойкнигиDataGridViewTextBoxColumn
            // 
            this.номерзачётнойкнигиDataGridViewTextBoxColumn.DataPropertyName = "Номер_зачётной_книги";
            this.номерзачётнойкнигиDataGridViewTextBoxColumn.HeaderText = "Номер_зачётной_книги";
            this.номерзачётнойкнигиDataGridViewTextBoxColumn.Name = "номерзачётнойкнигиDataGridViewTextBoxColumn";
            this.номерзачётнойкнигиDataGridViewTextBoxColumn.Width = 200;
            // 
            // телефонродителяDataGridViewTextBoxColumn1
            // 
            this.телефонродителяDataGridViewTextBoxColumn1.DataPropertyName = "Телефон_родителя";
            this.телефонродителяDataGridViewTextBoxColumn1.HeaderText = "Телефон_родителя";
            this.телефонродителяDataGridViewTextBoxColumn1.Name = "телефонродителяDataGridViewTextBoxColumn1";
            this.телефонродителяDataGridViewTextBoxColumn1.Width = 120;
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            this.фИОDataGridViewTextBoxColumn1.Width = 200;
            // 
            // кемявляетсястудентуDataGridViewTextBoxColumn
            // 
            this.кемявляетсястудентуDataGridViewTextBoxColumn.DataPropertyName = "Кем_является_студенту";
            this.кемявляетсястудентуDataGridViewTextBoxColumn.HeaderText = "Кем_является_студенту";
            this.кемявляетсястудентуDataGridViewTextBoxColumn.Name = "кемявляетсястудентуDataGridViewTextBoxColumn";
            this.кемявляетсястудентуDataGridViewTextBoxColumn.Width = 150;
            // 
            // местоработыDataGridViewTextBoxColumn
            // 
            this.местоработыDataGridViewTextBoxColumn.DataPropertyName = "Место_работы";
            this.местоработыDataGridViewTextBoxColumn.HeaderText = "Место_работы";
            this.местоработыDataGridViewTextBoxColumn.Name = "местоработыDataGridViewTextBoxColumn";
            this.местоработыDataGridViewTextBoxColumn.Width = 150;
            // 
            // номерзачётнойкнигиDataGridViewTextBoxColumn1
            // 
            this.номерзачётнойкнигиDataGridViewTextBoxColumn1.DataPropertyName = "Номер_зачётной_книги";
            this.номерзачётнойкнигиDataGridViewTextBoxColumn1.HeaderText = "Номер_зачётной_книги";
            this.номерзачётнойкнигиDataGridViewTextBoxColumn1.Name = "номерзачётнойкнигиDataGridViewTextBoxColumn1";
            this.номерзачётнойкнигиDataGridViewTextBoxColumn1.Width = 200;
            // 
            // математикаDataGridViewTextBoxColumn
            // 
            this.математикаDataGridViewTextBoxColumn.DataPropertyName = "Математика";
            this.математикаDataGridViewTextBoxColumn.HeaderText = "Математика";
            this.математикаDataGridViewTextBoxColumn.Name = "математикаDataGridViewTextBoxColumn";
            // 
            // русскийЯзыкDataGridViewTextBoxColumn
            // 
            this.русскийЯзыкDataGridViewTextBoxColumn.DataPropertyName = "Русский язык";
            this.русскийЯзыкDataGridViewTextBoxColumn.HeaderText = "Русский язык";
            this.русскийЯзыкDataGridViewTextBoxColumn.Name = "русскийЯзыкDataGridViewTextBoxColumn";
            this.русскийЯзыкDataGridViewTextBoxColumn.Width = 125;
            // 
            // физикаDataGridViewTextBoxColumn
            // 
            this.физикаDataGridViewTextBoxColumn.DataPropertyName = "Физика";
            this.физикаDataGridViewTextBoxColumn.HeaderText = "Физика";
            this.физикаDataGridViewTextBoxColumn.Name = "физикаDataGridViewTextBoxColumn";
            // 
            // информатикаDataGridViewTextBoxColumn
            // 
            this.информатикаDataGridViewTextBoxColumn.DataPropertyName = "Информатика";
            this.информатикаDataGridViewTextBoxColumn.HeaderText = "Информатика";
            this.информатикаDataGridViewTextBoxColumn.Name = "информатикаDataGridViewTextBoxColumn";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gold;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(1171, 310);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 57);
            this.button7.TabIndex = 18;
            this.button7.Text = "Обновить таблицу";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gold;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(1171, 504);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 54);
            this.button8.TabIndex = 19;
            this.button8.Text = "Обновить таблицу";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // parentsStudentsBindingSource
            // 
            this.parentsStudentsBindingSource.DataMember = "ParentsStudents";
            this.parentsStudentsBindingSource.DataSource = this.parentsBindingSource;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(544, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Таблица студентов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1272, 602);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учебная группа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsStudentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MyDatabaseDataSet myDatabaseDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private MyDatabaseDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource parentsBindingSource;
        private MyDatabaseDataSetTableAdapters.ParentsTableAdapter parentsTableAdapter;
        private System.Windows.Forms.BindingSource parentsStudentsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource parentsBindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource gradesBindingSource;
        private MyDatabaseDataSetTableAdapters.GradesTableAdapter gradesTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерстуденческогобилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адреспроживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонстудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонродителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзачётнойкнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонродителяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кемявляетсястудентуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоработыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзачётнойкнигиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn математикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn русскийЯзыкDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn физикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn информатикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label6;
    }
}

