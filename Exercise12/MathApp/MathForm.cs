using System;
using System.ComponentModel;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace MathApp
{
    public partial class MathForm : Form
    {
        private static Random random = new Random();

        private bool StressTestBool { get; set; }

        private double RandomNumber
        {
            get
            {
                double a = 1.0d;
                double b = 100.0d;
                return random.NextDouble() * (b - a) + a;
            }
        }

        public MathForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            double num1 = 0d;
            double num2 = 0d;
            try
            {
                switch (btn.Text)
                {
                    case "+":
                        if (AreTextFieldsEmpty())
                        {
                            MessageBox.Show("Numbers have to be entered in both textfields", "Important");
                        }
                        else
                        {
                            num1 = Double.Parse(textBox1.Text);
                            num2 = Double.Parse(textBox2.Text);
                            label1.Text = lib.Add(num1, num2).ToString("0.00");
                            listBox1.Items.Add(String.Format("{0} + {1} = {2}", num1, num2, label1.Text));
                        }
                        break;
                    case "-":
                        if (AreTextFieldsEmpty())
                        {
                            MessageBox.Show("Numbers have to be entered in both textfields", "Important");
                        }
                        else
                        {
                            num1 = Double.Parse(textBox1.Text);
                            num2 = Double.Parse(textBox2.Text);
                            label1.Text = lib.Subtract(num1, num2).ToString("0.00");
                            listBox1.Items.Add(String.Format("{0} - {1} = {2}", num1, num2, label1.Text));
                        }
                        break;
                    case "\\":
                        if (AreTextFieldsEmpty())
                        {
                            MessageBox.Show("Numbers have to be entered in both textfields", "Important");
                        }
                        else
                        {
                            num1 = Double.Parse(textBox1.Text);
                            num2 = Double.Parse(textBox2.Text);
                            label1.Text = lib.Div(num1, num2).ToString("0.00");
                            listBox1.Items.Add(String.Format("{0} \\ {1} = {2}", num1, num2, label1.Text));
                        }
                        break;
                    case "*":
                        if (AreTextFieldsEmpty())
                        {
                            MessageBox.Show("Numbers have to be entered in both textfields", "Important");
                        }
                        else
                        {
                            num1 = Double.Parse(textBox1.Text);
                            num2 = Double.Parse(textBox2.Text);
                            label1.Text = lib.Mult(num1, num2).ToString("0.00");
                            listBox1.Items.Add(String.Format("{0} * {1} = {2}", num1, num2, label1.Text));
                        }
                        break;
                    case "clear":
                        ClearFields();
                        break;
                    default:
                        break;
                }
            }
            catch (FormatException)
            {
                ToolTip toolTip1 = new ToolTip()
                {
                    UseFading = true,
                    ToolTipIcon = ToolTipIcon.Warning,
                    ToolTipTitle = "Error"
                };
                if (num1 == 0d || num2 == 0d)
                {
                    toolTip1.Show("Please enter a valid number", label1, 1500);
                    GC.Collect();
                }
            }
        }

        private bool AreTextFieldsEmpty()
        {
            return textBox1.Text.Equals("") || textBox2.Text.Equals("");
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            label1.Text = "0.00";
            listBox1.Items.Clear();
        }

        private void MenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "XML File|*.xml",
                Title = "Save an XML File",
                FileName = "Calculations"
            };
            DialogResult res = saveFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                int counter = 1;
                XmlDocument doc = new XmlDocument();
                XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(docNode);

                XmlNode expressionsNode = doc.CreateElement("expressions");
                doc.AppendChild(expressionsNode);
                foreach (var item in listBox1.Items)
                {
                    XmlNode calculationNode = doc.CreateElement("calculation");
                    XmlAttribute calculationAttribute = doc.CreateAttribute("id");
                    calculationAttribute.Value = counter++.ToString();
                    calculationNode.Attributes.Append(calculationAttribute);
                    expressionsNode.AppendChild(calculationNode);

                    XmlNode operationNode = doc.CreateElement("operation");
                    operationNode.AppendChild(doc.CreateTextNode(Regex.Split(item.ToString(), " = ")[0]));
                    calculationNode.AppendChild(operationNode);
                    XmlNode resultNode = doc.CreateElement("result");
                    resultNode.AppendChild(doc.CreateTextNode(Regex.Split(item.ToString(), " = ")[1]));
                    calculationNode.AppendChild(resultNode);
                }
                doc.Save(saveFileDialog.FileName);
            }
        }

        private void MenuItem2_Click(object sender, EventArgs e)
        {
            ClearFields();
            OpenFileDialog fd = new OpenFileDialog()
            {
                Title = "Read a File",
            };
            DialogResult res = fd.ShowDialog();

            if (res == DialogResult.OK)
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(fd.FileName);

                    XPathNavigator nav = doc.CreateNavigator();
                    XPathNodeIterator iterOps = nav.Select("/expressions/calculation/operation");
                    XPathNodeIterator iterResults = nav.Select("/expressions/calculation/result");

                    while (iterOps.MoveNext() && iterResults.MoveNext())
                    {
                        listBox1.Items.Add(iterOps.Current.Value + " = " + iterResults.Current.Value);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Unsuccessful reading!", "Error");
                }
            }
        }

        private void StressTest()
        {
            Random rnd = new Random();
            double op1 = Math.Round(RandomNumber, 2);
            textBox1.Text = op1.ToString();

            double op2 = Math.Round(RandomNumber, 2);
            textBox2.Text = op2.ToString();

            Type operations = Type.GetType("MathLibrary.MathLib");
            ConstructorInfo opConstr = operations.GetConstructor(Type.EmptyTypes);
            object mathOps = opConstr.Invoke(new object[] { });

            switch (rnd.Next(1, 5))
            {
                case 1:
                    MethodInfo Add = operations.GetMethod("Add", new Type[] { typeof(double), typeof(double) });
                    double addValue = (double)Add.Invoke(mathOps, new object[] { op1, op2 });
                    label1.Text = addValue.ToString("0.00");
                    listBox1.Items.Add(String.Format("{0} + {1} = {2}", op1, op2, label1.Text));
                    break;
                case 2:
                    MethodInfo Subtract = operations.GetMethod("Subtract", new Type[] { typeof(double), typeof(double) });
                    double subValue = (double)Subtract.Invoke(mathOps, new object[] { op1, op2 });
                    label1.Text = subValue.ToString("0.00");
                    listBox1.Items.Add(String.Format("{0} - {1} = {2}", op1, op2, label1.Text));
                    break;
                case 3:
                    MethodInfo Mult = operations.GetMethod("Mult", new Type[] { typeof(double), typeof(double) });
                    double multValue = (double)Mult.Invoke(mathOps, new object[] { op1, op2 });
                    label1.Text = multValue.ToString("0.00");
                    listBox1.Items.Add(String.Format("{0} * {1} = {2}", op1, op2, label1.Text));
                    break;
                case 4:
                    MethodInfo Div = operations.GetMethod("Div", new Type[] { typeof(double), typeof(double) });
                    double divValue = (double)Div.Invoke(mathOps, new object[] { op1, op2 });
                    label1.Text = divValue.ToString("0.00");
                    listBox1.Items.Add(String.Format("{0} \\ {1} = {2}", op1, op2, label1.Text));
                    break;
                default:
                    break;
            }
        }

        private void MenuItem3_Click(object sender, EventArgs e)
        {
            StressTestBool = true;
            if (backgroundWorker1.IsBusy)
            {
                return;
            }
            else
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void MenuItem4_Click(object sender, EventArgs e)
        {
            StressTestBool = false;
            progressBar1.Style = 0;
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1000);
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            StressTest();
            if (StressTestBool)
            {
                backgroundWorker1.RunWorkerAsync();
                progressBar1.Style = ProgressBarStyle.Marquee;
            }
        }

        //private void MenuItem3_Click(object sender, EventArgs e)
        //{
        // An alternative way to create the stress test feature using two threads
        //    CheckForIllegalCrossThreadCalls = false;

        //    StressTestBool = true;
        //    new Thread(() =>
        //    {
        //        while (StressTestBool)
        //        {
        //            new Thread(() => StressTest()).Start();
        //            Thread.Sleep(1000);
        //        }
        //    }).Start();
        //}
    }
}